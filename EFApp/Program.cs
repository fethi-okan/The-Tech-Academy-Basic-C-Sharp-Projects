using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EFDataModel())
            {
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe"
                };
                context.Students.Add(student);
                context.SaveChanges();

                var students = context.Students.ToList();
                foreach (var studentItem in students)
                {
                    Console.WriteLine($"Id: {studentItem.Id}, First Name: {studentItem.FirstName}, Last Name: {studentItem.LastName}");
                }
            }

            Console.ReadLine();
        }
    }
}
