using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Calculator---------");
            Console.WriteLine("Enter the selection you want to do");

            Calc calculator = new Calc();

            while (true)
            {
                Console.WriteLine("\nEnter an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("9. Exit");

                string input = Console.ReadLine();

                if (input == "9")
                {
                    Console.WriteLine("See you!");
                    break;
                }

                try
                {
                    double result = 0;

                    switch (input)
                    {
                        case "1":
                            result = calculator.PerformOperation("addition");
                            break;
                        case "2":
                            result = calculator.PerformOperation("subtraction");
                            break;
                        case "3":
                            result = calculator.PerformOperation("multiplication");
                            break;
                        case "4":
                            result = calculator.PerformOperation("division");
                            break;
                        default:
                            Console.WriteLine("bad operation!");
                            break;
                    }

                    if (input != "9")
                    {
                        Console.WriteLine($"Result: {result}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }

    public class Calc
    {
        public double PerformOperation(string operation)
        {
            Console.WriteLine($"Enter first number for {operation}:");
            double operand1 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter second number for {operation}:");
            double operand2 = double.Parse(Console.ReadLine());

            switch (operation)
            {
                case "addition":
                    return Addition(operand1, operand2);
                case "subtraction":
                    return Subtraction(operand1, operand2);
                case "multiplication":
                    return Multiplication(operand1, operand2);
                case "division":
                    return Division(operand1, operand2);
                default:
                    throw new Exception("Invalid operation");
            }
        }

        public double Addition(double a, double b)
        {
            return a + b;
        }

        public double Subtraction(double a, double b)
        {
            return a - b;
        }

        public double Multiplication(double a, double b)
        {
            return a * b;
        }

        public double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero!");
            }
            return a / b;
        }
    }
}
