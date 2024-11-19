using System;

namespace EmployeeComparisonPolymorphismApp
{
    public class Employee : IQuittable
    {
        protected bool Equals(Employee other)
        {
            return Id == other.Id && FirstName == other.FirstName && LastName == other.LastName;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((Employee)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Id;
                hashCode = (hashCode * 397) ^ (FirstName != null ? FirstName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (LastName != null ? LastName.GetHashCode() : 0);
                return hashCode;
            }
        }

        // Properties to store employee information.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the "==" operator to compare two Employee objects by their Id.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1 != null && emp2 != null && emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator as well, as it must be paired with "==".
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp2 != null && emp1 != null && emp1.Id != emp2.Id;
        }

        // Implement the Quit() method from the IQuittable interface.
        public void Quit()
        {
            // Output a message indicating the employee has quit.
            Console.WriteLine($"{FirstName} {LastName} has quit.");
        }
    }

}
