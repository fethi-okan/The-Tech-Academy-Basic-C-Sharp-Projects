
using System;

namespace EmployeeComparisonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects and assign values to their properties
            var employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            var employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

            // Compare the two Employee objects using the overloaded "==" operator
            var areEqual = employee1 == employee2;

            // Display the result of the comparison
            Console.WriteLine($"Are Employee 1 and Employee 2 equal? {areEqual}");

            // Change the Id of employee2 to match employee1's Id
            employee2.Id = 1;

            // Compare the two Employee objects again using the overloaded "==" operator
            areEqual = employee1 == employee2;

            // Display the result of the second comparison
            Console.WriteLine($"Are Employee 1 and Employee 2 equal after changing the Id? {areEqual}");

            // Keep the console window open to see the results
            Console.ReadLine();
        }
    }
}
