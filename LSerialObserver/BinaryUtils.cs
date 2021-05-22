using System;
using System.Text;

namespace LSerialObserver
{
    // Утилиты облегчающие разбор бинарных структур
    public class BinaryUtils
    {
        // Длинна типа в байтах
        public static int GetTypeLength(FieldType type)
        {
            return type switch
            {
                FieldType.AsciiChar => 1,
                FieldType.Byte => 1,
                FieldType.SByte => 1,
                FieldType.Short => 2,
                FieldType.UShort => 2,
                FieldType.Int => 4,
                FieldType.UInt => 4,
                FieldType.Float => 4,
                FieldType.Long => 8,
                FieldType.ULong => 8,
                FieldType.Double => 8,
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }

        // Являятся ли последовательность байт нативной для данной системы
        public static bool IsNativeEndianness(EndiannessType type)
        {
            return BitConverter.IsLittleEndian && type == EndiannessType.Little ||
                   !BitConverter.IsLittleEndian && type == EndiannessType.Big;
        }

        // Тип состоит из нескольких байт
        public static bool IsMultibyte(FieldType type)
        {
            return type switch
            {
                FieldType.AsciiChar or FieldType.AsciiString
                    or FieldType.Byte or FieldType.SByte => false,
                _ => true
            };
        }

        // Преобразование массива байт в данный тип
        public static object ParseToType(FieldType type, byte[] b)
        {
            return type switch
            {
                FieldType.AsciiChar => Encoding.ASCII.GetString(b)[0],
                FieldType.Byte => BitConverter.ToString(b),
                FieldType.SByte => (sbyte) b[0],
                FieldType.Short => BitConverter.ToInt16(b),
                FieldType.UShort => BitConverter.ToUInt16(b),
                FieldType.Int => BitConverter.ToInt32(b),
                FieldType.UInt => BitConverter.ToUInt32(b),
                FieldType.Long => BitConverter.ToInt64(b),
                FieldType.ULong => BitConverter.ToUInt64(b),
                FieldType.Float => BitConverter.ToSingle(b),
                FieldType.Double => BitConverter.ToDouble(b),
                FieldType.AsciiString => Encoding.ASCII.GetString(b),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }

        // Тип имеет переменный размер
        public static bool IsVariableLength(FieldType type)
        {
            return type switch
            {
                FieldType.AsciiString => true,
                _ => false
            };
        }

        // Терминирующая последовательность байт для типа перменного размера
        public static byte VariableLengthTypeTerminator(FieldType type)
        {
            return type switch
            {
                FieldType.AsciiString => 0x00,
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }
    }
}
