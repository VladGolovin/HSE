using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            var collection = new List<Pair>();

            collection.Add(new Pair(rnd.Next(0, 100), rnd.Next(0, 100)));

            collection.Add(new Money(rnd.Next(0, 100), rnd.Next(0, 100)));

            collection.Add(new Money(rnd.Next(0, 100), rnd.Next(0, 100)));

            PrintCollection(collection);

            var moneys = collection.Where(pair => pair.GetType() == typeof(Money)).Select(pair => (Money)pair).ToList();

            Console.WriteLine($"Среднее арифмитическое: {Avarage(moneys)}");

            Console.ReadKey();
        }

        public static void PrintCollection(List<Pair> collection)
        {
            foreach (var pair in collection)
            {
                Console.WriteLine(pair);
            }
        }

        public static double Avarage(List<Money> moneys)
        {
            double sum = 0;

            foreach (var money in moneys)
            {
                sum += money.ToDouble();
            }

            return sum / moneys.Count();
        }
    }
}
