using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class IMC
    {
        public static void IMCCalculator()
        {
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("======= IMC Calculator =======");
                Console.WriteLine("Insert your weight");
                decimal weight = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Insert your height");
                decimal height = decimal.Parse(Console.ReadLine());

                decimal imc = weight / (height * height);

                Console.WriteLine($"Your current IMC is: {imc}");

                Console.WriteLine("Do you want to continue? y/n");
                string op = Console.ReadLine();

                if(op == "y" || op == "Y")
                {
                    exit = true;
                } else
                {
                    exit = false;
                }
            }
        }
    }
}
