using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    internal class Program
    {
        static void startMessage()
        {
            Console.WriteLine("|===========================================|");
            Console.WriteLine("What type of calculation would you like to do?");
            Console.WriteLine("                 Version 1.0");
            Console.WriteLine("|===========================================|");

            Console.WriteLine("-> Addition (+)");
            Console.WriteLine("-> Subtraction (-)");
            Console.WriteLine("-> Multiplication (*)");
            Console.WriteLine("-> Division (/)");
            Console.WriteLine("-> Remainder (%)");
        }

        static void mathCalc()
        {
            double num3 = 0;

            string op = Console.ReadLine();
            char operation = Convert.ToChar(op);

            Console.WriteLine("Enter your first number: ");
            Console.WriteLine("");
            string number1 = Console.ReadLine();
            double num1 = Convert.ToDouble(number1);
            
            Console.WriteLine("Enter your second number: ");
            Console.WriteLine("");
            string number2 = Console.ReadLine();
            double num2 = Convert.ToDouble(number2);

            Console.WriteLine(num1 + " " + operation + " " + num2);

            switch (operation) 
            {
                case '+':
                    num3 = num1 + num2;
                    Console.WriteLine("Your answer is: " + num3);
                    break;
                case '-':
                    num3 = num1 - num2;
                    Console.WriteLine("Your answer is: " + num3);
                    break;
                case '*':
                    num3 = num1 * num2;
                    Console.WriteLine("Your answer is: " + num3);
                    break;
                case '/':
                    num3 = num1 / num2;
                    Console.WriteLine("Your answer is: " + num3);
                    break;
                case '%':
                    num3 = num1 % num2;
                    Console.WriteLine("Your answer is: " + num3);
                    break;
            }


        }


        static void Main(string[] args)
        {
            startMessage();

            mathCalc();
        }
    }
}
