using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace simpleCalculator
{
    internal class Program
    {
        static void startMessage()
        {
            //Adds all of the into messages
            Console.WriteLine("|===========================================|");
            Console.WriteLine("What type of calculation would you like to do?");
            Console.WriteLine("                 Version 1.1");
            Console.WriteLine("|===========================================|");

            Console.WriteLine("-> Addition (+)");
            Console.WriteLine("-> Subtraction (-)");
            Console.WriteLine("-> Multiplication (*)");
            Console.WriteLine("-> Division (/)");
            Console.WriteLine("-> Remainder (%)");
        }

        static void storyStart() //Short story with a secret char
        {
            for (int i = 0; i < 3; i++) 
            {
                Thread.Sleep(1000); //Sleeps 1000 miliseconds then adds
                Console.Write(".");
            }
            Console.WriteLine();
            Thread.Sleep(2000);

            Console.WriteLine("           o     |                             '                 \r\n       +       - o -                               +        '   o\r\n           |_    |                  |    .         . .           \r\n           |         .            --o--                   +.   ' \r\n     '                              |                            \r\n                +                         . *    .               \r\n                                                                 \r\n                      |                     |   +                \r\n       + *       .   -o-  '               - o -   ' .            \r\n           '       .  |              o      |                  . \r\n           o                                         '           \r\n .     |                       *                         +       \r\n      -+-                                . *        . .     .o   \r\n       |                       +                 '               \r\n       ..                   .  *+                                ");

            for (int i = 0; i < 65; i++)
            {
                Thread.Sleep(50); 
                Console.Write("-");
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }

            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine("7 Stars are born every year");

            Console.WriteLine();
            char[] writeLife = { 'L', 'i', 'f', 'e' , ' ' , 'I' , 's' , ' ' , 'E', 'v', 'e', 'r' , ' ', 'E', 'x', 'p', 'a', 'n', 'd', 'i', 'n', 'g'}; //Array for witing life
            int[] lifeDelay = { 1000, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100}; //Array for the delays
            for (int i = 0; i < writeLife.Length; i++) 
            { 
                Thread.Sleep(lifeDelay[i]);
                Console.Write(writeLife[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }

            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("No matter how much hope is lost");
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }

            Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("There is always some hope somewhere out there");
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }

            Thread.Sleep(1000);
            Console.WriteLine();
            startMessage();
            mathCalc();
            

        }

        static void mathCalc() //Calculates the inputted value
        {
            string op = Console.ReadLine(); //Takes in the operator

            while (op != "s")
            {
                double num3 = 0; //Initializes the variable to change later
                
                char operation = Convert.ToChar(op); //Switches it to a char for easy access

                if (op == "" || op == " ")
                {
                    Console.WriteLine("Try again");
                    mathCalc();
                }

                Console.WriteLine("Enter your first number: ");
                Console.WriteLine("");
                string number1 = Console.ReadLine(); //Takes the first number in and converts it to a double
                double num1 = Convert.ToDouble(number1);

                Console.WriteLine("Enter your second number: ");
                Console.WriteLine("");
                string number2 = Console.ReadLine(); //Does above but for num2
                double num2 = Convert.ToDouble(number2);
                
                Console.WriteLine("|==================|");
                Console.WriteLine(num1 + " " + operation + " " + num2); //Simple declaration

                switch (operation) //Manages which operation is set and creates the proper case
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
                

                //Asks for a restart
                Console.WriteLine("");
                Console.WriteLine("Would you like another calculation?: (Yes/ No)"); 

                string restart = Console.ReadLine();
                restart = restart.ToLower();

                switch (restart) //Cases for restart back to mathcalc
                {
                    //yes to reset
                    case "yes":
                        Console.WriteLine("");
                        Console.WriteLine("");
                        startMessage();
                        mathCalc();
                        break;
                    case "ye":
                        Console.WriteLine("");
                        Console.WriteLine("");
                        startMessage();
                        mathCalc();
                        break;
                    case "y":
                        Console.WriteLine("");
                        Console.WriteLine("");
                        startMessage();
                        mathCalc();
                        break;
                    //Here for no 
                    case "no":
                        Environment.Exit(0);
                        break;
                    case "n":
                        Environment.Exit(0);
                        break;
                    //In case someone just wants to say yes faster
                    default:
                        mathCalc();
                        break;
                }
            }

            if (op == "s")
            {
                storyStart();
            }

        }

        static void Main(string[] args)
        {
            startMessage();

            mathCalc();
        }
    }
}
