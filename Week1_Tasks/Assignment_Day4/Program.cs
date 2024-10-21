namespace Assignment_Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            Movie movie = new Movie(101, "Inception",2001,"action" , "mark" , true , 10);
            Rental rental = new Rental(1, movie, 123, DateTime.Now, DateTime.Now.AddDays(5));

            decimal rentalCost = rental.CalculateRental((rental.ReturnDate - rental.RentalDate).Days, movie);
            Console.WriteLine(rentalCost);

 
            Payment payment = new Payment(1, rental.RentalId, rentalCost, "Credit Card");


            payment.ProcessPayment();

            payment.DisplayPaymentDetails();
        }
    }
}
