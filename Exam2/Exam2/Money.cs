using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    public class Money: Pair
    {
        public Money(int rubls, int pennies): base(rubls, pennies)
        {

        }

        public override string ToString()
        {
            return $"Рубли: {First}, Копейки: {Second}";
        }

        public double ToDouble()
        {
            return First + (double)Second / 100;
        }
    }
}
