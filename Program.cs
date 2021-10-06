using SimpleCalculator.ClassOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        public static object Application { get; private set; }

        static void Main(string[] args)
        {
            //initialize class
            MyOperations opr = new MyOperations();

            int doAgain = 1;
            int value1, value2;

            for (int resetCounter = 0; resetCounter < doAgain; resetCounter++)
            {
                //input for value 1
                Console.Write($"Enter first value: ");
                //int value1 = Convert.ToInt32(Console.ReadLine());
                value1 = int.Parse(Console.ReadLine());

                //input for value 2
                Console.Write($"Enter second value: ");
                //int value2 = Convert.ToInt32(Console.ReadLine());
                value2 = int.Parse(Console.ReadLine());

                Console.WriteLine(Environment.NewLine);

                //array of operation to choose from
                string[] operation = { "Add", "Subtract", "Multiply", "Divide", "Modulus" };



                //foreach  (var item in operation)
                //{
                //    Console.WriteLine($"{ item.ToString() }");
                //}
                Console.WriteLine("Available operations: ");
                Console.WriteLine(Environment.NewLine);

                for (int itr = 0; itr < operation.Length; itr++)
                {
                    Console.WriteLine($"{itr.ToString()} : { operation.GetValue(itr) }");
                }
                Console.WriteLine(Environment.NewLine);

                Console.Write("Depending on the number, select operation to use: ");
                string select = Console.ReadLine();
                Console.WriteLine(Environment.NewLine);

                selectOperation(select);
                Console.WriteLine(Environment.NewLine);

                Console.Write("Do you want to try again? [Y/N]: ");
                string option = Console.ReadLine();
                Console.WriteLine(Environment.NewLine);

                if (option.Equals("Y") || option.Equals("y"))
                {
                    Console.Clear();
                    doAgain++;
                }
                if (option.Equals("N") || option.Equals("n"))
                {
                    doAgain = 0;
                }
            }
            
            void selectOperation(string oprtr)
            {
                switch (oprtr)
                {
                    case "0":
                        Console.WriteLine("You've selected the 'Add' operation! ");
                        Console.WriteLine($"The answer is: { opr.Add(value1, value2) }");
                        break;

                    case "1":
                        Console.WriteLine("You've selected the 'Subtract' operation! ");
                        Console.WriteLine($"The answer is: { opr.Subtract(value1, value2) }");
                        break;

                    case "2":
                        Console.WriteLine("You've selected the 'Multiply' operation! ");
                        Console.WriteLine($"The answer is: { opr.Multiply(value1, value2) }");
                        break;

                    case "3":
                        Console.WriteLine("You've selected the 'Divide' operation! ");
                        Console.WriteLine($"The answer is: { opr.Divide(value1, value2) }");
                        break;

                    case "4":
                        Console.WriteLine("You've selected the 'Divide' operation! ");
                        Console.WriteLine($"The answer is: { opr.Modulus(value1, value2) }");
                        break;

                    default:
                        Console.WriteLine("Invalid operation!");
                        break;
                }
            }
            
        }
    }
}
