using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cow
{
    public class Cow
    {
        public string CowCounter(int count)
        {
            int lastTwoDigits = count % 100;

            if (11 <= lastTwoDigits &&
                lastTwoDigits <= 19)
                return "коров";

            int digit = count % 10;

            if (digit == 1)
                return "корова";
            else if (digit >= 2 && digit <= 4)
                return "коровы";
            return "коров";
        }
    }
}
