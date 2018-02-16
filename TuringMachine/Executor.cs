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

        Dictionary<char, Dictionary<string, Command>> commands = new Dictionary<char, Dictionary<string, Command>>();

        int pos;

        public Executor(Dictionary<char, Dictionary<string, Command>> commands)
        {
            clearTape();
            this.commands = commands;
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
                
                while (index < Tape.Length || !Tape[index].Equals('_'))
                {
                    sb.Append(Tape[index]);
                    index++;
                }

                return sb.ToString();
            }
            set
            {
                clearTape();

                int _carriagePostion = pos;

                for (int i = 0; i < value.Length; i++)
                {
                    Tape[pos] = value[i];
                    pos++;
                }

                pos = _carriagePostion;
            }
        }

        public void Run()
        {
            string state = commands[Tape[pos]].FirstOrDefault().Key;

            while (state != "q0")
            {
                var command = commands[Tape[pos]][state];

                Tape[pos] = command.NewSimbol;

                switch (command.Direction)
                {
                    case Direction.Left:
                        pos--;
                        break;
                    case Direction.Right:
                        pos--;
                        break;
                    default:
                        break;
                }

                state = command.NewState;
            }
        }

        private void clearTape()
        {
            for (int i = 0; i < Tape.Length; i++)
            {
                Tape[i] = '_';
            }

            pos = 40;
        }
    }
}
