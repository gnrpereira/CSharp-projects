using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora
{
    public static class Avarage
    {
        public static void ArrayAvarage()
        {
            decimal[] numbers = new decimal[4];
            decimal sum = 0;
            decimal media;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Insert the {i}° number:");
                decimal tempo = decimal.Parse(Console.ReadLine());
                numbers[i] += tempo;

                sum += numbers[i];
            }

            media = sum / numbers.Length;

            Console.WriteLine($"The current avarage is: {media}");
        }
        public static void ArithmeticAvarage()
        {
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("======= ARITHMETIC AVARAGE =======");
                Console.WriteLine("\nSelect the option");
                Console.WriteLine("\n1 Avarage\n2 Exit");
                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    ArrayAvarage();
                }
                else if (op == 2)
                {
                    exit = false;
                }
                else 
                {
                    Console.WriteLine("Wrong option, try again");
                }
            }
        }
    }
}
