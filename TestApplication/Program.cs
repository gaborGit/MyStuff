using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            System.Console.WriteLine("Hello world");

            Console.WriteLine("Please enter a number: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}*{1}={2}", i, i, i * i);

        }
    }
}
