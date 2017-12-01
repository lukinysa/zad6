using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gitara siema");
            int num01 = 3;
            int num02 = 5;
            for(int i = 1; i < 100; i++)
            {
                Console.WriteLine(i);
                if(i % num01 == 0)
                {
                    Console.WriteLine(i +"Fizz");
                }
                if(i % num02 == 0)
                {
                    Console.WriteLine(i + "Buzz");
                }
                if(i % num01 == 0 && i % num02 == 0)
                {
                    Console.WriteLine(i + "FizzBuzz");
                }
            }
            Console.ReadKey();
        }
    }
}