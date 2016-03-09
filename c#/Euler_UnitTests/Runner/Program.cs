using Euler.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = Factorial.Generate(100);


            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }
    }
}
