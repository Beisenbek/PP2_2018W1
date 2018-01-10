using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRead2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] values = line.Split(' ');
            int n = values.Length;
            int s = 0;
            for (int i = 0; i < n; ++i)
            {
                s = s + int.Parse(values[i]);
            }

            Console.WriteLine(s);
        }
    }
}
