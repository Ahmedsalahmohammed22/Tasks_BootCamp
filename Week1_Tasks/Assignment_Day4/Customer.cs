using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day4
{
    internal class Customer
    {
        public int CustomerID { get; set; }
        public string name {  get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string membershipType { get; set; }

        public Rental? rentMovie(Movie movie , DateTime rentalDate , Employee employee , DateTime returnDate , int rentalId)
        {
            if (movie.checkAvailability())
            {
                Rental rental = new Rental(rentalId, movie, CustomerID, rentalDate, returnDate);
                Console.WriteLine($"Movie {movie.title} rented by {this.name}.");
                return rental;
            }
            else
            {
                Console.WriteLine($"Movie {movie.title} is not available.");
                return null;
            }

        }
        public void ReturnMovie(Movie movie)
        {   
            Console.WriteLine($"Movie {movie.title} returned by {this.name}.");
        }
    }
}
