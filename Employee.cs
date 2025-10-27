using System;

namespace EmployeeComparison
{
    // This class represents an Employee with an Id, FirstName, and LastName.
    public class Employee
    {
        // Unique identifier for the employee
        public int Id { get; set; }

        // Employee's first name
        public string FirstName { get; set; }

        // Employee's last name
        public string LastName { get; set; }

        // Overload the "==" operator to compare Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are null — they are equal in that case
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one is null and the other isn't, they are not equal
            if ((object)emp1 == null || (object)emp2 == null)
                return false;

            // Compare the Id properties
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator, which is required when "==" is overloaded
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals to ensure proper comparison behavior in collections, etc.
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Employee other = (Employee)obj;
            return Id == other.Id;
        }

        // Override GetHashCode when Equals is overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
