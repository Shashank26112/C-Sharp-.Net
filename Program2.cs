using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("enter the two number1:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enerthe number2:");
            n2 = Convert.ToInt32(Console.ReadLine());
            int result;
            result = n1 + n2;
            Console.WriteLine("Sum of the two numbers:" + result.ToString());
            Console.ReadLine();
        }
    }
}
