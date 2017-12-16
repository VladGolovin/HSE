using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class TriangleArray
    {
        private Triangle[] tArray;

        public Triangle this[int i]
        {
            get { return tArray[i]; }
            set { tArray[i] = value; }
        }

        /// <summary>
        /// Возвращает индекс минимального элемента.
        /// </summary>
        public int MinValueIndex
        {
            get
            {
                if (tArray.Length == 0)
                    throw new Exception("Массив не содержит элементов");

                Triangle minValue = tArray[0];
                int minIndex = 0;

                for (int i = 1; i < tArray.Length; i++)
                {
                    if (tArray[i] < minValue)
                    {
                        minValue = tArray[i];
                        minIndex = i;
                    }
                }

                return minIndex;
            }
        }
        /// <summary>
        /// Создаёт пустой массив.
        /// </summary>
        public TriangleArray()
        {
            tArray = new Triangle[0];
        }

        /// <summary>
        /// Заполняет массив треугольниками со случайными сторонами.
        /// </summary>
        /// <param name="size">Длина массива.</param>
        public TriangleArray(int size)
        {
            tArray = new Triangle[size];

            Random r = new Random();

            for (int i = 0; i < size; i++)
            {
                double x = r.Next(1, 15);
                double y = r.Next(1, 15);
                double c = Math.Sqrt(x * x + y * y);
                tArray[i] = new Triangle(x, y, c);
            }
        }

        /// <summary>
        /// Выводит элементы массива в консоль
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < tArray.Length; i++)
            {
                Triangle t = tArray[i];
                Console.WriteLine(@"
                        TraingleArray[{0}]=({1}; {2}; {3})", i, t.X, t.Y, t.C);
            }
        }
    }
}
