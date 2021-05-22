using System.Text.Json;
using System.Text.Json.Serialization;

namespace LSerialObserver
{
    // Утилиты облегщающие сериализацию в JSON с общими параметрами
    public static class Json
    {
        private static readonly JsonSerializerOptions Options = new()
        {
            WriteIndented = true,
            Converters = {new JsonStringEnumConverter()}
        };

        public static string Serialize(object obj)
        {
            return JsonSerializer.Serialize(obj, Options);
        }

        public static T Deserialize<T>(string str)
        {
            return JsonSerializer.Deserialize<T>(str, Options);
        }
    }
}
