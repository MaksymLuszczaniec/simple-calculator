using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Calculator---------");
            Console.WriteLine("Enter the selection you want to do");

            while(true)
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
                                result = PerformOperation("addition");
                                break;
                            case "2":
                                result = PerformOperation("subtraction");
                                break;
                            case "3":
                                result = PerformOperation("multiplication");
                                break;
                            case "4":
                                result = PerformOperation("division");
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

        static double PerformOperation(string operation)
        {
            Console.WriteLine($"first {operation}:");
            double operand1 = double.Parse(Console.ReadLine());

            Console.WriteLine($"second {operation}:");
            double operand2 = double.Parse(Console.ReadLine());

            switch (operation)
            {
                case "addition":
                    return operand1 + operand2;
                case "subtraction":
                    return operand1 - operand2;
                case "multiplication":
                    return operand1 * operand2;
                case "division":
                    if (operand2 == 0)
                    {
                        throw new Exception("You cant by zero!");
                    }
                    return operand1 / operand2;
                default:
                    throw new Exception("Error");
            }
        }
    }
}
        
    
