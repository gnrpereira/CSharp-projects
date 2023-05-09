using System;
using Calculos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraSimples;
using Calculadora;
using System.Security.Policy;

namespace Menu
{
    public class Screen
    {
        public static void SelectTheOperation()
        {
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("======== Hello, welcome to Menu ========");
                Console.WriteLine("What'd you want today?");
                Console.WriteLine("\n\t1 Simple calculator\n\t2 Arithmetic Avarage of 4 numbers\n\t3 IMC calculator\n\t4 Table\n\t5 Exit");
                int op = int.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        Calculator.ChooseOperations();
                        break;
                    case 2:
                        Avarage.ArithmeticAvarage();
                        break;
                    case 3:
                        IMC.IMCCalculator();
                        break;
                    case 4:
                        /*
                         Table
                         */
                        break;
                    case 5:
                        Console.WriteLine("Bye!");
                        exit= false;
                        break;
                }
            }
        }
    }
}
