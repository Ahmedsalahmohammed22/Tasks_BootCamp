using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day4
{
    internal class Payment
    {
        public int PaymentId {  get; set; }
        public int RentalId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool IsPaid { get; set; }
        public Payment(int paymentId , int rentalId , decimal amount , string paymentMethod )
        {
            PaymentId = paymentId;
            RentalId = rentalId;
            Amount = amount;
            PaymentMethod = paymentMethod;
            IsPaid = false;

        }
        public void ProcessPayment()
        {
            if( !IsPaid )
            {
                IsPaid = true;
                PaymentDate = DateTime.Now;
                Console.WriteLine($"Payment of {Amount:C} has been processed using {PaymentMethod} on {PaymentDate}.");
            }
            else
            {
                Console.WriteLine("Payment has already been made.");
            }
        }
        public void DisplayPaymentDetails()
        {
            string paymentStatus = IsPaid ? "Paid" : "Pending";
            Console.WriteLine($"Payment ID: {PaymentId}\nRental ID: {RentalId}\nAmount: {Amount:C}\nMethod: {PaymentMethod}\nStatus: {paymentStatus}\nPayment Date: {PaymentDate}");
        }
    }
}
