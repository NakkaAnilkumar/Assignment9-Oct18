using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9_Oct18
{
    class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Language { get; set; }
    }

    class Customer
    {
        public int CustId { get; set; }
        public DateTime BorrowDate { get; set; }
        public int MovieId { get; set; }
        public DateTime? ReturnDate { get; set; }

        public static List<Movie> OverdueMovies = new List<Movie>();

        public void Borrow(Movie movie)
        {
            if (movie == null)
            {
                throw new ArgumentNullException("Movie cannot be null.");
            }

            if (BorrowDate == default)
            {
                throw new InvalidOperationException("BorrowDate cannot be null.");
            }

            if (ReturnDate == null)
            {
                // Calculate the return date by adding 10 days to the borrow date
                ReturnDate = BorrowDate.AddDays(10);

                // Check if the return date is overdue
                if (ReturnDate < DateTime.Now)
                {
                    OverdueMovies.Add(movie);
                }
            }
        }
    }
}
