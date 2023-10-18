using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9_Oct18
{
    class Program
    {
        static void Main()
        {
            try
            {
                Employee emp = new Employee();

                Console.Write("Enter Employee Number: ");
                emp.EmpNo = int.Parse(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                emp.EName = Console.ReadLine();

                Console.Write("Enter Salary: ");
                emp.Salary = double.Parse(Console.ReadLine());

                Console.Write("Enter Department Number: ");
                emp.DeptNo = int.Parse(Console.ReadLine());

                Console.WriteLine($"Employee Number: {emp.EmpNo}");
                Console.WriteLine($"Employee Name: {emp.EName}");
                Console.WriteLine($"Salary: {emp.Salary}");
                Console.WriteLine($"Department Number: {emp.DeptNo}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            Console.ReadLine();

            //==========================================================================================================

            // Create a movie and customer
            Movie movie1 = new Movie { MovieId = 1, MovieName = "Movie 1", Language = "English" };
            Customer customer1 = new Customer { CustId = 1, BorrowDate = DateTime.Now, MovieId = 1 };

            // Issue the movie CD
            customer1.Borrow(movie1);

            // Check for overdue movies
            if (Customer.OverdueMovies.Count > 0)
            {
                Console.WriteLine("Overdue movies:");
                foreach (var overdueMovie in Customer.OverdueMovies)
                {
                    Console.WriteLine($"Movie ID: {overdueMovie.MovieId}, Name: {overdueMovie.MovieName}");
                }
                
            }
            Console.ReadLine();
        }
    }
}
