using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class Triangle
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="x">Сторона 1.</param>
        /// <param name="y">Сторона 2.</param>
        /// <param name="c">Сторона 3.</param>
        public Triangle(double x, double y, double c)
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }

        #region Атрибуты
        /// <summary>
        /// Сторона 1.
        /// </summary>
        private double x { get; set; }

        /// <summary>
        /// Сторона 2.
        /// </summary>
        private double y { get; set; }

        /// <summary>
        /// Сторона 3.
        /// </summary>
        private double c { get; set; }
        #endregion

        #region Методы
        /// <summary>
        /// Проверяет существует ли треугольник с указанными сторонами.
        /// </summary>
        /// <param name="x">Сторона 1.</param>
        /// <param name="y">Сторона 2.</param>
        /// <param name="c">Сторона 3.</param>
        /// <returns>Возвращает true если такой треугольник существует.</returns>
        public static bool IsExists(double x, double y, double c)
        {
            return (x + y) > c && (y + c) > x && (x + c) > y;
        }

        /// <summary>
        /// Полупериметр.
        /// </summary>
        public static double P(double x, double y, double c)
        {
            return (x + y + c) / 2;
        }

        /// <summary>
        /// Площадь треугольника по 3-ём сторонам.
        /// </summary>
        /// <param name="x">Сторона 1.</param>
        /// <param name="y">Сторона 2.</param>
        /// <param name="c">Сторона 3.</param>
        /// <returns>Площадь треугольника.</returns>
        private static double s(double x, double y, double c)
        {
            double p = P(x, y, c);
            return Math.Sqrt(p * (p - x) * (p - y) * (p - c));
        }

        /// <summary>
        /// Площадь (метод класса).
        /// </summary>
        /// <returns></returns>
        public double S()
        {
            return s(x, y, c);
        }

        /// <summary>
        /// Площадь (статическая функция).
        /// </summary>
        /// <param name="x">Сторона 1.</param>
        /// <param name="y">Сторона 2.</param>
        /// <param name="c">Сторона 3.</param>
        /// <returns>Площадь треугольника с указанными сторонами.</returns>
        public static double S(double x, double y, double c)
        {
            return IsExists(x, y, c) ? s(x, y, c) : -1;
        }
        #endregion

        #region Унарные операторы
        /// <summary>
        /// Увеличивает все стороны треугольника на 1.
        /// </summary>
        /// <param name="t">Треугольник.</param>
        /// <returns>Треугольник с увеличенными на 1 единицу сторонами.</returns>
        public static Triangle operator ++(Triangle t)
        {
            t.x++;
            t.y++;
            t.c++;

            return t;
        }

        /// <summary>
        /// Уменьшает все стороны треугольника на 1.
        /// </summary>
        /// <param name="t">Треугольник.</param>
        /// <returns>Треугольник с уменьшенными на 1 единицу сторонами.</returns>
        public static Triangle operator --(Triangle t)
        {
            if (--t.x <= 0 || --t.y <= 0 || --t.c <= 0)
                throw new Exception("Стороны треугольника не могут быть <= 0");

            return t;
        }
        #endregion

        #region Операторы сравнения
        public static bool operator ==(Triangle t1, Triangle t2)
        {
            return t1.x == t2.x && t1.y == t2.y && t1.c == t2.c;
        }

        public static bool operator !=(Triangle t1, Triangle t2)
        {
            return t1.x != t2.x || t1.y != t2.y || t1.c != t2.c; 
        }

        public static bool operator <(Triangle t1, Triangle t2)
        {
            return t1.S() < t2.S();
        }

        public static bool operator >(Triangle t1, Triangle t2)
        {
            return t1.S() > t2.S();
        }

        public static bool operator <=(Triangle t1, Triangle t2)
        {
            return t1.S() <= t2.S();
        }

        public static bool operator >=(Triangle t1, Triangle t2)
        {
            return t1.S() >= t2.S();
        }

        public override bool Equals(object obj)
        {
            return this == (Triangle)obj;
        }
        #endregion

        #region Преобразования к типам
        public static implicit operator double(Triangle t)
        {
            return Triangle.S(t.x, t.y, t.c);
        }

        public static explicit operator bool(Triangle t)
        {
            return IsExists(t.x, t.y, t.c);
        }
        #endregion
    }
}
