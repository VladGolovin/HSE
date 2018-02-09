using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine
{
    public class Executor
    {
        char[] Tape = new char[100];

        int carriagePosition;

        public Executor()
        {
            clearTape();
        }

        public string Value
        {
            get
            {
                int index = 0;

                while (Tape[index].Equals('_') && index < Tape.Length) index++;

                if (index == (Tape.Length - 1))
                {
                    return string.Empty;
                }
                
                StringBuilder sb = new StringBuilder();
                
                while (!Tape[index].Equals('_') || index < Tape.Length)
                {
                    sb.Append(Tape[index]);
                    index++;
                }

                return sb.ToString();
            }
            set
            {
                clearTape();

                int _carriagePostion = carriagePosition;

                for (int i = 0; i < value.Length; i++)
                {
                    Tape[carriagePosition] = value[i];
                    carriagePosition++;
                }

                carriagePosition = _carriagePostion;
            }
        }


        private void clearTape()
        {
            for (int i = 0; i < Tape.Length; i++)
            {
                Tape[i] = '_';
            }

            carriagePosition = 40;
        }
    }
}
