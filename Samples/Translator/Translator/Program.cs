using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class Program
    {
        /// <summary>
        /// Строка с выраженем.
        /// </summary>
        static string expr;

        /// <summary>
        /// Индекс следующего
        /// </summary>
        static int nextIndex = 0;

        /// <summary>
        /// Текущий символ
        /// </summary>
        static char symbol;

        static void Main(string[] args)
        {
            expr = "a+225";
            NextSymbol();
            Expression();
        }

        static void NextSymbol()
        {
            if (nextIndex < expr.Length)
            {
                symbol = expr[nextIndex];
                nextIndex++;
            }
            else
            {
                symbol = '\0';
            }
        }

        static void Expression()
        {
            Addend();
            while (symbol == '+' || symbol == '-')
            {
                NextSymbol();
                Addend();
            }
        }

        private static void Addend()
        {
            Factor();
            while (symbol == '+' || symbol == '-')
            {
                NextSymbol();
                Factor();
            }
        }

        private static void Factor()
        {
            if (char.IsLetter(symbol))
                NextSymbol();
            else if (char.IsDigit(symbol))
                Number();
            else if (symbol == '(')
            {
                NextSymbol();
                Expression();
                NextSymbol();
            }
        }

        private static void Number()
        {
            if (char.IsDigit(symbol))
                NextSymbol();
        }
    }
}
