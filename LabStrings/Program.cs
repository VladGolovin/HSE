namespace LabStrings
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using TaskRunner;
    using TaskRunner.Helpers;

    public class Program
    {
        static void Main(string[] args)
        {
            TaskRunner taskRunner = new TaskRunner(new Dictionary<int, Action>()
            {
                {1, () => RunTask1() },
                {2, () => RunTask2() },
                {3, () => RunTask3() }
            });

            taskRunner.Start();
        }

        /// <summary>
        /// Метод разворачивает строку.
        /// </summary>
        /// <param name="sourceString">Исходная строка.</param>
        /// <returns></returns>
        private static string ReverseString(string sourceString)
        {
            char[] invertedString = new char[sourceString.Length];

            int i = 0,
                j = sourceString.Length - 1;

            while (i <= j)
            {
                invertedString[i] = sourceString[j];
                invertedString[j] = sourceString[i];
                i++; j--;
            }

            return new string(invertedString);
        }

        /// <summary>
        /// Перевернуть каждое четное слово.
        /// </summary>
        public static void RunTask1()
        {
            string sourceString = string.Empty;

            IOHelper.ReadValueSafely(ref sourceString, "исходную строку");

            string[] words = sourceString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 1; i < words.Length; i+=2)
            {
                words[i] = ReverseString(words[i]);
            }

            Console.WriteLine($"Исходная строка: {sourceString}");

            sourceString = String.Join(" ", words);

            Console.WriteLine($"Перевёрнутая строка: {sourceString}");
        }

        /// <summary>
        /// Удалить все слова в строке, которые начинаются с цифры.
        /// </summary>
        public static void RunTask2()
        {
            string sourceString = string.Empty,
                   result = string.Empty;

            IOHelper.ReadValueSafely(ref sourceString, "исходную строку");

            string[] words = sourceString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (!Char.IsDigit(words[i][0]))
                {
                    result = $"{result} {words[i]}";
                }                
            }

            sourceString = result;

            Console.WriteLine(result);
        }

        /// <summary>
        /// Перевернуть каждое  слово, номер которого совпадает с его длиной.
        /// </summary>
        public static void RunTask3()
        {
            string sourceString = string.Empty;

            IOHelper.ReadValueSafely(ref sourceString, "исходную строку");

            string[] words = sourceString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if (i + 1 == words[i].Length)
                {
                    words[i] = ReverseString(words[i]);
                }
            }

            Console.WriteLine($"Исходная строка: {sourceString}");

            sourceString = String.Join(" ", words);

            Console.WriteLine($"Перевёрнутая строка: {sourceString}");
        }
    }
}
