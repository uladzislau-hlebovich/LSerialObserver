using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static LSerialObserver.BinaryUtils;

namespace LSerialObserver
{
    // Порядок байт
    public enum EndiannessType
    {
        Little, // От младшего к старшему
        Big // От старшего к младшему
    }

    // Тип поля
    public enum FieldType
    {
        AsciiChar,
        Byte,
        SByte,
        Short,
        UShort,
        Int,
        UInt,
        Long,
        ULong,
        Float,
        Double,
        AsciiString
    }

    // Поле структуры
    public class StructField
    {
        // Тип поля
        public FieldType Type { get; set; }

        // Количество элементов массива
        public int Count { get; set; }
    }

    // Разбор бинарных данных в определённую структуру
    public class StructParser
    {
        // Буффер данных
        private readonly List<byte> _buffer = new();

        // Последовательность байт
        public EndiannessType Endianness { get; set; } = EndiannessType.Little;

        // Поля структуры
        public Dictionary<string, StructField> Fields { get; set; } = new();

        // Событие получения новых данных
        private event Action BytesReceived;

        // Извлечь из буффера несколько байт
        // (Вызовет ошибку, если байт в буфере недостаточно)
        private List<byte> PopBytes(int count)
        {
            var bytes = _buffer.GetRange(0, count);
            _buffer.RemoveRange(0, count);
            return bytes;
        }

        // Асинхронно извлечь из буффера count байт
        // (Если байт в буфере недостаточно, подписаться на событие и вернуть, когда байты появятся)
        private Task<List<byte>> PopBytesAsync(int count)
        {
            var tcs = new TaskCompletionSource<List<byte>>();

            if (_buffer.Count >= count)
            {
                tcs.TrySetResult(PopBytes(count));
            }
            else
            {
                void ResolveIfHasEnoughBytes()
                {
                    if (_buffer.Count >= count)
                    {
                        BytesReceived -= ResolveIfHasEnoughBytes;
                        tcs.TrySetResult(PopBytes(count));
                    }
                }

                BytesReceived += ResolveIfHasEnoughBytes;
            }

            return tcs.Task;
        }

        // Извлекать побайтово из буффера, пока не будет достигнута терминирующая последовательность байт
        private async Task<List<byte>> PopUntilAsync(byte terminator)
        {
            // Внутренний буффер
            List<byte> buffer = new();

            while (true)
            {
                // Дождаться получения байта
                var b = (await PopBytesAsync(1))[0];

                // Если байт равен терминирующей последовательности ...
                if (b == terminator)
                    break; // выйти из цикла

                // Иначе добавить байт в внутрений буффер
                buffer.Add(b);
            }

            return buffer;
        }

        // Разобрать следующий пакет
        public async Task<Package> ParseNext()
        {
            var package = new Package();

            // Цикл по каждому полю в структуре
            foreach (var (name, field) in Fields)
            {
                // Массив значений
                var values = new List<object>();

                // Цикл для каждого элемента в массива
                for (var i = 0; i < field.Count; i++)
                {
                    // внутренний буффер
                    var bytes = new List<byte>();

                    // Тип имеет пременный размер?
                    if (IsVariableLength(field.Type))
                        // Извлечь из буффера до терминирующей последовательности
                        bytes = await PopUntilAsync(VariableLengthTypeTerminator(field.Type));
                    else
                        // Извлечь из буффера ровно нужное для типа количество
                        bytes = await PopBytesAsync(GetTypeLength(field.Type));

                    // Если тип является многобайтовым и последовательность байт структуре
                    // не совпадает с последовательностью байт системы
                    if (IsMultibyte(field.Type) && !IsNativeEndianness(Endianness))
                        // Развернуть буффер
                        bytes.Reverse();

                    // Разобрать в определённый тип
                    var value = ParseToType(field.Type, bytes.ToArray());
                    // Добавить в массив
                    values.Add(value);
                }

                // Добавить массив в пакет
                package.Objects.Add(name, values);
            }

            return package;
        }

        // Обработчик получения данных
        public void HandleDataReceived(byte[] data)
        {
            // Добавить данные в буффер
            _buffer.AddRange(data);
            // Вызвать событие получения данных
            BytesReceived?.Invoke();
        }
    }
}
