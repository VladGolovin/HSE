using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPairs
{
    class Program
    {
        static bool[,] a;
        static int n;
        static int[] m;
        static bool[] visited;

        static bool TryAdd(int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[x,i] && !visited[i])
                {
                    if (m[i] == -1)
                    {
                        m[i] = x;
                        return true;
                    }
                    else
                    {
                        visited[i] = true;
                        if (TryAdd(m[i]))
                        {
                            m[i] = x;
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            var inp = new StreamReader("input.txt");
            int n = Int32.Parse(inp.ReadLine());
            a = new bool[n, n];
            m = new int[n];
            visited = new bool[n];
            for (int i = 0; i < n; i++) m[i] = -1;
            for (int i = 0; i < n; i++) visited[i] = false;
            for (int i = 0; i < n; i++)
            {
                var input = inp.ReadLine().Split(' ');
                for (int j = 0; j < input.Length; j++)
                {
                    a[i, Int32.Parse(input[j])] = true;
                }
            }

            for (int i = 0; i < n; i++)
                TryAdd(i);

            for (int i = 0; i < n; i++)
                if (m[i] != -1)
                    Console.WriteLine("{0} - {1}", m[i], i);

            Console.ReadKey();
        }
    }
}
