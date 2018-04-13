using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine
{
    public class Command
    {
        public char NewSimbol { get; set; }

        public string NewState { get; set; }

        public Direction Direction { get; set; }
    }
}
