using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProj
{

    /* This program is a calculator that 
     * performs 11 operations. These are 
     * listed 1 to 11 and an explanation
     * is give to what they do
     */
    public class Calculator
    {


        public Calculator()
        { }

        public double Add(double x, double y) {
            return x + y;
        }

        public double Subtract(double x, double y) {
            return x - y;
        }

        public double Multiply(double x, double y) {
            return x * y;
        }

        public double Divide(double x, double y) {
            if (y != 0) {
                return x / y;
            }

            else {

                Console.WriteLine("Cannot divide by 0");
                return -1;
            }
        }

        public double Modulo(double x, double y) {
            return x % y;
        }

        public double Squared(double x) {
            return Math.Pow(x, 2);
            

        }

        public double Cubed(double x) {
            return Math.Pow(x, 3);
        }

        public double SquareRoot(double x)
        {

            return Math.Sqrt(x);

        }

        public double Sin(double x)
        {


            return Math.Round(Math.Sin(x), 11);
        }

        public double Cos(double x)
        {
            return Math.Round(Math.Cos(x), 11);
        }

        public double Tan(double x)
        {
            return Math.Round(Math.Tan(x), 11);
        }

        public string PrintMessage()
        {
            return "The answer is ";
        }
    }

    public class Program { 

        public static void Main(string[] args) {

            Calculator calculator = new Calculator();
                     
            bool hasStarted = true;
         
            string reply;
            
            while (hasStarted)
            {

                Console.WriteLine("######################");
                Console.WriteLine("Basic Calculator");
                Console.WriteLine("######################\n\n");


                Console.WriteLine("Please enter a number");
               
                double x = 0;
                if (!double.TryParse(Console.ReadLine(), out x))
                {

                    Console.WriteLine("Invalid input");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

               

              //  Console.WriteLine("Please enter an operation");
                Console.WriteLine("\nPress 1 to add\nPress 2 to subtract\nPress 3 to multiply\nPress 4 to divide\nPress 5 for Modulo\nPress 6 for square\nPress 7 for cube\n" +
                    "Press 8 for square root\nPress 9 for sin\nPress 10 for cos\nPress 11 for tan");
                try
                {
                    int operation = int.Parse(Console.ReadLine());
                    double y = 0;

                    // The first 5 options require a second number to perform their functions
                    if (operation >= 1 && operation <= 5)
                    {

                        Console.WriteLine("Please enter a number");

                        if (!double.TryParse(Console.ReadLine(), out y))
                        {

                            Console.WriteLine("Invalid input");
                            Console.ReadLine();
                            Console.Clear();
                            continue;

                        }
                    }
                        //Gives the user the option to select operation
                        switch (operation) 
                        {
                            case 1:
                                Console.WriteLine(calculator.PrintMessage() + (calculator.Add(x, y)));
                                break;
                            case 2:
                                Console.WriteLine(calculator.PrintMessage() + calculator.Subtract(x, y));
                                break;
                            case 3:
                                Console.WriteLine(calculator.PrintMessage() + calculator.Multiply(x, y));
                                break;
                            case 4:
                                Console.WriteLine(calculator.PrintMessage() + calculator.Divide(x, y));
                                break;
                            case 5:
                                Console.WriteLine(calculator.PrintMessage() + calculator.Modulo(x, y));
                                break;
                            case 6:
                                Console.WriteLine(calculator.PrintMessage() + calculator.Squared(x));
                                break;
                            case 7:
                                Console.WriteLine(calculator.PrintMessage() + calculator.Cubed(x));
                                break;
                            case 8:
                                Console.WriteLine(calculator.PrintMessage() + calculator.SquareRoot(x));
                                break;
                            case 9:
                                Console.WriteLine(calculator.PrintMessage() + calculator.Sin(x));
                                break;
                            case 10:
                                Console.WriteLine(calculator.PrintMessage() + calculator.Cos(x));
                                break;
                            case 11:
                                Console.WriteLine(calculator.PrintMessage() + calculator.Tan(x));
                                break;
                            default:
                                Console.WriteLine("Invalid input");
                                break;
                        }

                    }
   
                
                catch (FormatException)
                {
                    Console.WriteLine("Operator has no value");
                }

                // Gives the user the option to perform a new calculation 
                Console.WriteLine("Would you like to perform more calculations?");
                reply = Console.ReadLine().ToLower();

                // If answer is no or invalid then the program ends
                if (reply == "n" || reply == "no")
                {
                    hasStarted = false;
                }
                else if (reply == "y" || reply == "yes")
                {
                    Console.Clear();
                }


                else
                {
                    Console.WriteLine("Invalid input");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                
            }
        }
        
        
           
        }
    }

