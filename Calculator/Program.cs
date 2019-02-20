using System;

namespace Calculator
{
    public static class Program
    {
        public static void Main()
        {
           

            // Create a simple calculator that asks the user to input two different numbers 
            Console.WriteLine("Give me the first number: ");
            string numberOneInput = Console.ReadLine();
            int numberOne = int.Parse(numberOneInput);

            Console.WriteLine("Give me the second number: ");
            string numberTwoInput = Console.ReadLine();
            int numberTwo = int.Parse(numberTwoInput);

            Console.WriteLine("Would you like to add, subtract, multiply, or divide them?");
            string math = Console.ReadLine();

            if (math == "add")
            {
                int result = numberOne + numberTwo;
                Console.WriteLine($"Total = {result}");
                Console.ReadLine();
                return;
               
            }

            if (math == "subtract")
            {
                int result = numberOne - numberTwo;
                Console.WriteLine($"Total = {result}");
                Console.ReadLine();
                return;
            }

            if (math == "multiply")
            {
                int result = numberOne * numberTwo;
                Console.WriteLine($"Total = {result}");
                Console.ReadLine();
                return;
            }

            if (math == "divide")
            {
                int result = numberOne / numberTwo;
                Console.WriteLine($"Total = {result}");
                Console.ReadLine();
                return;
            }

            // and whether they want to add, subtract, multiply or divide them. 

            

            Console.ReadLine();
        }
    }
}
