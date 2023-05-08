using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimples
{
    public static class Calculator
    {
        public static void Sum()
        {
            Console.WriteLine("======= SUM =======");
            Console.WriteLine("Insert the first number:");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insert the second number:");
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal sum = num1 + num2;
            Console.WriteLine($"The sum of the {num1} and {num2} is: {sum}");
        }
        public static void Subtraction()
        {
            Console.WriteLine("======= SUBTRACTION =======");
            Console.WriteLine("Insert the first number:");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insert the second number:");
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal sum = num1 - num2;
            Console.WriteLine($"The difference of the {num1} and {num2} is: {sum}");
        }
        public static void Multiplication()
        {
            Console.WriteLine("======= MULTIPLICATION =======");
            Console.WriteLine("Insert the first number:");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insert the second number:");
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal sum = num1 * num2;
            Console.WriteLine($"The product of the {num1} and {num2} is: {sum}");
        }
        public static void Division()
        {
            Console.WriteLine("======= DIVISION =======");
            Console.WriteLine("Insert the first number:");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Insert the second number:");
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal sum = num1 / num2;
            Console.WriteLine($"The division of the {num1} and {num2} is: {sum}");
        }

        public static void ChooseOperations()
        {
            bool exit = true;
            while(exit)
            {
                Console.WriteLine("======== SIMPLE CALCULATOR ========");
                Console.WriteLine("\n\t1 Addition\n\t2 Subtraction\n\t3 Multiplication\n\t4 Division\n\t5 Exit");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Sum();
                        break;
                    case 2:
                        Subtraction();
                        break;
                    case 3:
                        Multiplication();
                        break;
                    case 4:
                        Division();
                        break;
                    case 5:
                        exit = false;
                        break;
                }

            }
        }
        
    }
}
