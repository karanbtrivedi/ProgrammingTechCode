using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyaramid_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            int numberOfLines = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int a = numberOfLines - 1; a >= i; a--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
