using System;

namespace EmployeeComparisonPolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee class and assign values to its properties.
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };

            // Create another instance of the Employee class with different property values.
            Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

            // Use the overloaded "==" operator to compare the two employees and display the result.
            Console.WriteLine("Are the two employees equal? " + (employee1 == employee2));

            // Use polymorphism to create an object of type IQuittable.
            IQuittable quittable = employee1;

            // Call the Quit() method on the IQuittable object.
            quittable.Quit();

            // Wait for user input before closing the console.
            Console.ReadLine();
        }
    }
}
