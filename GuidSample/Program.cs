using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(Guid.NewGuid().ToString());
        }
    }
}
