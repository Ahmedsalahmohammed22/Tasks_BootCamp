using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Delegate
{
    internal class Socialensurance
    {
        public string InsuranceNumber { get; set; }
        public string Provider { get; set; }
        public DateTime StartDate { get; set; }


        public Socialensurance(string insuranceNumber, string provider, DateTime startDate)
        {
            InsuranceNumber = insuranceNumber;
            Provider = provider;
            StartDate = startDate;
        }

        public override string ToString()
        {
            return $"Insurance Number: {InsuranceNumber}, Provider: {Provider}, Start Date: {StartDate:yyyy-MM-dd}";
        }
        public void BeginSocialensurance(Employee employee)
        {
            Console.WriteLine($"{employee.Name} has Social Insurance on {InsuranceNumber} by {Provider} starting from {StartDate:yyyy-MM-dd}");
        }
    }
}
