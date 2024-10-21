using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day6
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public List<string> History { get; set; }

        public void DisplayPatientInfo()
        {
            Console.WriteLine($"Name: {Name}\nAddress: {Address}\nAge: {Age}\nGender: {Gender}");
        }
        public void AddToHistory(string history)
        {
            History.Add(history);
            Console.WriteLine($"Added to history: {history}");
        }
    }
}
