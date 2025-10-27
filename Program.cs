using System;

namespace EmployeeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first Employee object
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.FirstName = "John";
            emp1.LastName = "Doe";

            // Create second Employee object
            Employee emp2 = new Employee();
            emp2.Id = 1; // Same Id as emp1
            emp2.FirstName = "Jane";
            emp2.LastName = "Smith";

            // Compare the two Employee objects using the overloaded "==" operator
            if (emp1 == emp2)
            {
                Console.WriteLine("emp1 and emp2 are the same employee (same Id).");
            }
            else
            {
                Console.WriteLine("emp1 and emp2 are different employees (different Ids).");
            }

            // Pause the console so user can read the result
            Console.ReadLine();
        }
    }
}
