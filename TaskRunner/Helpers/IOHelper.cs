namespace TaskRunner.Helpers
{
    using System;

    /// <summary>
    /// Класс для упращённого ввода/вывода значений пользователя.
    /// </summary>
    public static class IOHelper
    {       
        /// <summary>
        /// Метод для безопасного получения от пользователя переменной заданного типа.
        /// </summary>
        /// <typeparam name="T">Тип переменной.</typeparam>
        /// <param name="value">Переменная, в которую будет записано значение, полученное от пользователя.</param>
        /// <param name="valueName">Название переменной, требуемой от пользователя.</param>
        public static void ReadValueSafely<T>(ref T value, string valueName)
        {
            bool isValid = false;
            do
            {
                Console.Write($"Введите {valueName}:");

                try
                {
                    value = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
                    isValid = true;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Ожидается значение типа {typeof(T).Name}.");
                }
            } while (!isValid);
        }
    }
}
