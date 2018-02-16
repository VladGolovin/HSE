using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine
{
    public class Program
    {
        public Program()
        {

        }

        static void Main(string[] args)
        {
            CommandReader reader = new CommandReader("Commands.txt");
            Executor executor = new Executor(reader.ReadAll());

            Console.WriteLine("Введите исходное число:");
            string sourceNumber = Console.ReadLine();

            executor.Value = sourceNumber;
            executor.Run();
            Console.WriteLine($"x+1 для введённого числа: {executor.Value}");

            Console.ReadKey();            
        }
    }
}
