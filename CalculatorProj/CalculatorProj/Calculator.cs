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

            return Math.Sin(x);
           
        }

        public double Cos(double x)
        {
            return Math.Cos(x);
        }

        public double Tan(double x)
        {
            return Math.Tan(x);
        }


        public static void Main(string[] args) {

            Calculator calculator = new Calculator();
            Console.WriteLine("Please enter a number");
            double x = double.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("Please enter an operation");
            string operation = Console.ReadLine();
            if (operation == "s" || operation == "c" || operation == "sq" || operation == "sin" || operation == "cos" || operation == "tan")
            {

                if (operation == "s")
                {
                    Console.WriteLine(calculator.Squared(x));
                }
                else if (operation == "c")
                {
                   Console.WriteLine(calculator.Cubed(x));
                }
                else if(operation == "sq")
                {
                    Console.WriteLine(calculator.SquareRoot(x));
                }

                else if(operation == "sin")
                {
                    Console.WriteLine(calculator.Sin(x));
                }

                else if(operation == "cos")
                {
                    Console.WriteLine(calculator.Cos(x));
                }

                else if(operation == "tan")
                {
                    Console.WriteLine(calculator.Tan(x));
                }

            }
            else {

                Console.WriteLine("Please enter a number");
                double y = int.Parse(Console.ReadLine().ToLower());
                switch (operation)
                {
                    case "+":
                        Console.WriteLine(calculator.Add(x, y));
                        break;
                    case "-":
                        Console.WriteLine(calculator.Subtract(x, y));
                        break;
                    case "*":
                        Console.WriteLine(calculator.Multiply(x, y));
                        break;
                    case "/":
                        Console.WriteLine(calculator.Divide(x, y));
                        break;
                    case "%":
                        Console.WriteLine(calculator.Modulo(x, y));
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            }
            Console.ReadLine();

        }
        
            
           
        }
    }

