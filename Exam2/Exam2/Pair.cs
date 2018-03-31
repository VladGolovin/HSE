using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    public class Pair
    {
        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }

        public int First { get; set; }

        public int Second { get; set; }

        public override string ToString()
        {
            return $"first: {First}, second: {Second}";
        }
    }
}
