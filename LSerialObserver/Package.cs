using System;
using System.Collections.Generic;

namespace LSerialObserver
{
    // Разобранный пакет 
    public class Package
    {
        // Поля структуры
        public Dictionary<string, object> Objects { get; set; } = new();

        // Время формирования
        public DateTime Time { get; set; }
    }
}
