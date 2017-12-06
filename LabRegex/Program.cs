namespace LabRegex
{
    using System;
    using System.Text.RegularExpressions;
    using System.Collections.Generic;

    using TaskRunner;
    using TaskRunner.Helpers;

    /// <summary>
    /// Лабораторная по регулярным выражениям.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            TaskRunner tr = new TaskRunner(new Dictionary<int, Action>()
            {
                { 1, () => RunTask1() },
                { 2, () => RunTask1() },
                { 3, () => RunTask3() },
                { 4, () => RunTask4() }
            });

            tr.Start();
        }

        /// <summary>
        /// Проверяет введённое пользователем выражение на соответствие указанному патерну.
        /// </summary>
        /// <param name="pattern">Паттерн регулярного выражения.</param>
        private static void CheckExpression(string pattern)
        {
            Regex regex = new Regex(pattern);

            string number = string.Empty;

            IOHelper.ReadValueSafely(ref number, "число");

            string result = regex.Match(number).Success
                ? "Значение подходит под шаблон."
                : "Значение не подходит под шаблон.";

            Console.WriteLine(result);
        }

        /// <summary>
        /// Проверить является ли заданная строка шестизначным числом, записанным в десятичной системе счисления без нулей в старших разрядах.
        /// </summary>
        protected static void RunTask1()
        {
            string pattern = @"^[1-9][0-9]{5}$";

            Console.WriteLine("6 значное число, без нулей в старших разрядах.");

            CheckExpression(pattern);
        }

        /// <summary>
        /// Написать регулярное выражение, определяющее является ли заданная строка правильным MAC-адресом.
        /// </summary>
        protected static void RunTask2()
        {
            string pattern = @"^[0-9A-Fa-f][0-9A-Fa-f](\:[0-9A-Fa-f][0-9A-Fa-f]){5}$";

            Console.WriteLine("Строка должна соответствовать маске MAC-адреса \"00:00:00:00:00:00\".");

            CheckExpression(pattern);
        }

        /// <summary>
        /// Вводимая строка должна соответствовать идентификатору цвета, например "#F01000".
        /// </summary>
        protected static void RunTask3()
        {
            string pattern = @"^#[a-fA-F0-9]{6}$";

            Console.WriteLine("Вводимая строка должна соответствовать идентификатору цвета, например \"#F01000\".");

            CheckExpression(pattern);
        }

        /// <summary>
        /// "Сложный пароль"
        /// </summary>
        protected  static void RunTask4()
        {
            string pattern = @"^(?=.*[a-z])(?=.*[0-9])(?=.*[A-Z])([A-Za-z0-9]|_){8,}$";

            Console.WriteLine("Придумайте сложный пароль (требования: не менее 8 символов, 1 Заглавная буква, 1 цифра.");

            CheckExpression(pattern);
        }
    }
}
