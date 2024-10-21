using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day6
{
    internal class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Shift { get; set; }
        public bool IsOnline { get; set; }
        public DateTime LastLoggedIn { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool Login(string username, string password)
        {
            if (username == null || password == null) return false;
            if (username == Username && password == Password)
            {
                IsOnline = true;
                LastLoggedIn = DateTime.Now;
                return true;
            }
            else
            {
                Console.WriteLine("Invalid Login");
                return false;
            }
        }
        public bool Logout()
        {
            if (IsOnline)
            {
                IsOnline = false;
                Console.WriteLine($"{Name} has logged out");
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} has not logged out");
                return false;
            }
        }
        public void UpdateAccountDetails(string newPhone , string newShift)
        {
            this.Phone = newPhone;
            this.Shift = newShift;
            Console.WriteLine($"Account for {Name} updated");
        }
        public bool CheckOnlineStatus()
        {
            return IsOnline;
        }
    }
}
