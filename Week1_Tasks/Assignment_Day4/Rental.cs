using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day4
{
    internal class Rental
    {
        public int RentalId {  get; set; }
        public int MovieId { get; set; }
        public int CustomerId { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime RentalDate { get; set; }
        public decimal RentalPrice { get; set; }
        public Rental(int rentalId , Movie movie , int customerId , DateTime rentalDate , DateTime returnDate )
        {
            RentalId = rentalId;
            MovieId = movie.movieId;
            CustomerId = customerId;
            ReturnDate = returnDate;
            RentalDate = rentalDate;
            RentalPrice = CalculateRental((returnDate - rentalDate).Days, movie);
        }

        public decimal CalculateRental(int day , Movie movie)
        {
            RentalPrice = day * movie.pricePerDay;
            return RentalPrice;
        }
        public void DisplayRentalDetails()
        {
            Console.WriteLine($"Rental ID: {RentalId}\nMovie ID: {MovieId}\nCustomer ID: {CustomerId}\nRental Date: {RentalDate.ToShortDateString()}\nReturn Date: {ReturnDate.ToShortDateString()}\nRental Price: {RentalPrice:C}");
        }
    }
}
