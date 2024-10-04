using System;

namespace CalculatorApp2
{
    class CalcApp
    {
        public void Calculate(double num1, double num2, string arithOperator) 
        {
            double result = 0;
            if (arithOperator != null)
            {
                switch (arithOperator)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        break;
                    default:
                        Console.WriteLine("Please pick a valid option");
                        break;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.Write("Enter First number: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine(" + : Add");
                Console.WriteLine(" - : Subtract");
                Console.WriteLine(" * : Multiply");
                Console.WriteLine(" / : Divide");

                Console.Write("\nEnter an option: ");
                CalcApp calcApp = new CalcApp();
                string arithOperator = Console.ReadLine();
                calcApp.Calculate(num1, num2, arithOperator);

                Console.WriteLine("Would you like to do another calculation? (y/n)");

            } while (Console.ReadLine() == "y");

            Console.WriteLine("Ok, bye!");
            Console.ReadKey();

        }
    }
}