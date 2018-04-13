using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarFlows
{
    class Program
    {
        public static Random rnd = new Random();

        int random(int n0, int n1)
        {

            if (n0 == 0 && n1 == 1) return rand() % 2;

            return rand() % (n1 - n0) + n0;

        }

        static void Main(string[] args)
        {
        }
    }
}
