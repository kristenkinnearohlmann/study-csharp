using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);
            Console.ReadLine();
        }
    }
}
