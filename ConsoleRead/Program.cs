using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            int a = int.Parse(line1);
            int b = int.Parse(line2);
            int result = a + b;

            Console.WriteLine(result);
        }
    }
}
