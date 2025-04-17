using System;

namespace ArrayProcessingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new ArrayProcessor();

            // Подгрузка файла из корневой директории проекта
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "input.txt");

            // Считать тестовые наборы
            processor.ProcessFile(filePath);
        }
    }
}