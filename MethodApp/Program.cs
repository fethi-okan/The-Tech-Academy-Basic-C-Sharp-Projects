using System;

namespace MethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            var mathOperations = new MathOperations();

            // Call the PerformOperation method, passing in two numbers
            mathOperations.PerformOperation(2, 3);

            // Call the PerformOperation method again, specifying the parameters by name
            mathOperations.PerformOperation(num1: 3, num2: 5);

            // Keep the console window open to see the results
            Console.ReadLine();
        }
    }
}
