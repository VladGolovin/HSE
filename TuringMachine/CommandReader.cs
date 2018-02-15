using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine
{
    public class CommandReader
    {
        private string filePath { get; set; }
        private BinaryFormatter formatter = new BinaryFormatter();

        public CommandReader(string filePath)
        {
            this.filePath = filePath;
        }

        public Dictionary<char, Dictionary<string, Command>> ReadAll()
        {
            Dictionary<char, Dictionary<string, Command>> commands = new Dictionary<char, Dictionary<string, Command>>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    Command command = new Command();

                    string[] constituents = line.Split('/');
                    char key1 = Char.Parse(constituents[0]);
                    string key2 = constituents[1];

                    command.NewSimbol = Char.Parse(constituents[2]);
                    command.NewState = constituents[3];
                    char direct = Char.Parse(constituents[4]);

                    switch (direct)
                    {
                        case 'R':
                            command.Direction = Direction.Right;
                            break;
                        case 'L':
                            command.Direction = Direction.Left;
                            break;
                        default:
                            break;
                    }

                    commands[key1][key2] = command;
                }
            }

            return commands;
        }
    }
}
