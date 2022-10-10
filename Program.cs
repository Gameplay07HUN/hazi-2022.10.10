using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vasmegye
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvasoscucc = File.ReadAllLines("vas.txt");
            Console.WriteLine(beolvasoscucc.Length);

            Console.ReadKey();
        }
    }
}
