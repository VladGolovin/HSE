namespace Exam1.ConsoleApplication
{
    using System;
    using Exam1;

    class Program
    {
        static void Main(string[] args)
        {
            #region Часть 1

            #endregion
            Triangle t1 = new Triangle(3, 4, 5);
            Console.WriteLine(
                @"
                    Часть 1
                    Треугольник 1:
                        Cтороны: {0}, {1}, {2}
                        Площадь (методом): {3}
                        Площадь (статической функцией): {4}",
                t1.X, t1.Y, t1.C, t1.S(), Triangle.S(3, 4, 5));

            #region Часть 2
            Triangle t2 = new Triangle(5, 12, 13);
            Triangle t3 = new Triangle(7, 24, 25);

            double t2Double = t2;
            bool t2Bool = (bool)t2;


            bool loe = t2 <= t3;
            bool goe = t2 >= t3;

            Console.WriteLine(
                @"
                    Часть 2
                        Треугольник 1: x={0}, y={1}, c={2}
                        Треугольник 2: x={3}, y={4}, c={5}",
                t2.X, t2.Y, t2.C,
                t3.X, t3.Y, t3.C);
            t2--;
            t3++;
            Console.WriteLine(
                @"
                        Треугольник1++ = x={0}, y={1}, c={2}
                        Треугольник2-- = x={3}, y={4}, c={5}

                        Треугольник 1 к типу double (явно) = {6}
                        Треугольник 1 к типу bool (неявное) = {7}

                        Треугольник 1 <= Треугольник 2 = {8}
                        Треугольник 2 >= Треугольник 3 = {9}",
                t2.X, t2.Y, t2.C,
                t3.X, t3.Y, t3.C,
                t2Double,
                t2Bool,
                loe,
                goe);
            #endregion

            #region Часть 3
            Console.WriteLine(@"
                    Часть 3");
            TriangleArray tArray = new TriangleArray(10);
            tArray.Print();

            Console.WriteLine(@"
                        Индекс треугольника с минимальной площадью: {0}", tArray.MinValueIndex);
            #endregion

            Console.ReadLine();
        }
    }
}
