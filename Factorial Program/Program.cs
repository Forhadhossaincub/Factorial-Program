using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial Program.");

            Console.Write("Enter a number between 1 to 10 : ");
            int num = int.Parse(Console.ReadLine());

            if (num < 1 || num > 10)
            {
                Console.WriteLine("Plese input 1 to 10");
                Console.ReadKey();
                Console.ReadLine();
                return;
            }

            long facto = Factorial(num);
            Console.WriteLine($"{num}! Factorial is : {facto}");


            long facto2 = Factorial2(num);
            Console.WriteLine($"{num}! Factorial is : {facto2}");


            Console.ReadKey();

        }//Main

        public static long Factorial(int num)
        {
            long f = 1;
            for (int i = num; i > 0; i--)
            {
                f = f * i;
            }
            return f;
        }

        public static long Factorial2(int num)
        {
            if (num == 1) return 1;

            return num * Factorial2(num - 1);
        }
    }//Class
}//Namespace
