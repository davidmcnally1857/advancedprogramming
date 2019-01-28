using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProj
{

    public class Calculator
    {
       
               
        public Calculator()
        {  }

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


        public static void Main(string[] args) {

            Calculator calculator = new Calculator();

            Console.WriteLine("######################");
            Console.WriteLine("Scientific Calculator");
            Console.WriteLine("######################\n\n");
            bool isNumber;
            Console.WriteLine("Please enter a number");
            string number = Console.ReadLine();
            double x = 0;
            isNumber = double.TryParse(number, out x);
            if (isNumber == false)
            {
                x = 0;
                Console.WriteLine(x);
            }
           
                Console.WriteLine("Please enter an operation");
                Console.WriteLine("Press 1 to add\nPress 2 to subtract\nPress 3 to multiply\nPress 4 to divide\nPress 5 for Modulo\nPress6 for square\nPress 7 for cube\n" +
                    "Press 8 for sin\nPress 9 for cos\nPress 10 for tan");
            try
            {
                int operation = int.Parse(Console.ReadLine());
                 double y = 0;
                if (operation >= 1 && operation <= 5)
                {

                    Console.WriteLine("Please enter a number");
                    number = Console.ReadLine();
                    
                    isNumber = double.TryParse(number, out y);

                    if (isNumber == false)
                    {
                        y = 0;
                        Console.WriteLine(0);
                    }

                }
                    switch (operation)
                    {
                        case 1:
                            Console.WriteLine("The answer is: " + calculator.Add(x, y));
                            break;
                        case 2:
                            Console.WriteLine("The answer is: " + calculator.Subtract(x, y));
                            break;
                        case 3:
                            Console.WriteLine("The answer is: " + calculator.Multiply(x, y));
                            break;
                        case 4:
                            Console.WriteLine("The answer is: " + calculator.Divide(x, y));
                            break;
                        case 5:
                            Console.WriteLine("The answer is: " + calculator.Modulo(x, y));
                            break;            
                        case 6:
                            Console.WriteLine("The answer is: " + calculator.Squared(x));
                            break;
                        case 7:
                            Console.WriteLine("The answer is: " + calculator.Cubed(x));
                            break;
                        case 8:
                            Console.WriteLine("The answer is: " + calculator.Sin(x));
                            break;
                        case 9:
                            Console.WriteLine("The answer is: " + calculator.Cos(x));
                            break;
                        case 10:
                            Console.WriteLine("The answer is: " + calculator.Tan(x));
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


            Console.ReadLine();

        }
        
            
           
        }
    }

