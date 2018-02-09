using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine
{
    public class Command
    {
        public char NewSimbol { get; set; }

        public char NewState { get; set; }

        public Direction Direction { get; set; }
    }
}
