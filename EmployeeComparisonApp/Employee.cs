namespace EmployeeComparisonApp
{
    public class Employee
    {
        // Define properties for Id, FirstName, and LastName
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the "==" operator to compare two Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are null, or if one is null
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare the Id property of both Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator to provide the opposite behavior of the "==" operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals method to ensure it behaves consistently with the "==" operator
        public override bool Equals(object obj)
        {
            if (obj is Employee otherEmployee)
            {
                return this.Id == otherEmployee.Id;
            }
            return false;
        }

        // Override GetHashCode method to ensure consistency when using collections like dictionaries
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
