using System;

namespace The_Tech_Academy_Basic_C_Sharp_Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt for package weight and convert input to a float
            Console.Write("Please enter the package weight: ");
            var packageWeight = float.Parse(Console.ReadLine() ?? string.Empty);

            // Check if the weight is greater than 50
            if (packageWeight > 50)
            {
                // Display error message if package is too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                // Prompt for package width and convert input to a float
                Console.Write("Please enter the package width: ");
                var packageWidth = float.Parse(Console.ReadLine() ?? string.Empty);

                // Prompt for package height and convert input to a float
                Console.Write("Please enter the package height: ");
                var packageHeight = float.Parse(Console.ReadLine() ?? string.Empty);

                // Prompt for package length and convert input to a float
                Console.Write("Please enter the package length: ");
                var packageLength = float.Parse(Console.ReadLine() ?? string.Empty);

                // Calculate the total of the dimensions (width + height + length)
                var dimensionTotal = packageWidth + packageHeight + packageLength;

                // Check if the total dimensions exceed 50
                if (dimensionTotal > 50)
                {
                    // Display error message if the package is too large
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    // Calculate the shipping cost: (width * height * length * weight) / 100
                    var shippingCost = (packageWidth * packageHeight * packageLength * packageWeight) / 100;

                    // Display the calculated shipping cost as a dollar amount
                    Console.WriteLine($"Your estimated total for shipping this package is: ${shippingCost:F2}");
                    Console.WriteLine("Thank you!");
                }
            }
        }
    }
}
