using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_Day6
{
    internal class Assistant : Account
    {
        public bool FullAuth { get; set; } = false;
        public List<Customer> WaitingList { get; set; }

        public Assistant()
        {
            WaitingList = new List<Customer>();
        }

        public Customer addNewCustomer(string name , string address , int age , string gender)
        {
            var customer = new Customer()
            {
                Name = name,
                Address = address,
                Age = age,
                Gender = gender
            };
            Console.WriteLine("New customer added");
            return customer;
        }
        public bool AddToWaiting(Customer customer)
        {
            this.WaitingList.Add(customer);
            Console.WriteLine($"{customer.Name} is waiting");
            return true;
        }
        public void AddAppointment(DateTime date, Customer customer , Doctor doctor , string shift)
        {
            decimal totalPrice = 100.00m;
            string status = "Scheduled";
            var appointment = new Appointment()
            {
                Date = date,
                Time = TimeOnly.FromDateTime(date),
                Customer = customer,
                Doctor = doctor,
                Assistant = this,
                TotalPrice = totalPrice,
                Status = status,
            };
            if (DataBase.Insert(DataBase.Table.Appointment, appointment))
            {
                Console.WriteLine($"Appointment scheduled for {customer.Name} with {doctor.Name} on {date.ToShortDateString()} during {shift} shift.");
            }
            else
            {
                Console.WriteLine("Failed to schedule appointment.");
            }
        }
        public void DeleteAppointment(DateTime date, TimeOnly time)
        {

            string key = $"{date:yyyy-MM-dd}_{time:HH:mm}";
            if (DataBase.AppList.ContainsKey(key))
            {
                var appointment = DataBase.AppList[key];
                if (DataBase.Delete(DataBase.Table.Appointment, appointment))
                {
                    Console.WriteLine($"Appointment on {date.ToShortDateString()} at {time} has been successfully deleted.");
                }
                else
                {
                    Console.WriteLine("Failed to delete the appointment.");
                }

            }

        }
        public void ChangeAppointment(DateTime date , TimeOnly time , DateTime newDate , TimeOnly newTime )
        {
            string key = $"{date:yyyy-MM-dd}_{time:HH:mm}";
            if (DataBase.AppList.ContainsKey(key))
            {
                var appointment = DataBase.AppList[key];
                if (!appointment.TimeUntaked(newDate, newTime))
                {
                    Console.WriteLine("The new time is already taken. Please choose another time.");
                    return;
                }
                appointment.Date = newDate;
                appointment.Time = newTime;
                if (DataBase.Update(DataBase.Table.Appointment, appointment ,key))
                {
                    Console.WriteLine($"Appointment Date changed to {date.ToShortDateString()}.");
                }
                else
                {
                    Console.WriteLine("Appointment not found.");
                }

            }
        }
        public void ChangeAppointment(DateTime date , TimeOnly time , string status)
        {
            string key = $"{date:yyyy-MM-dd}_{time:HH:mm}";
            if (DataBase.AppList.ContainsKey(key))
            {
                var appointment = DataBase.AppList[key];
                appointment.Status = status; 
                if (DataBase.Update(DataBase.Table.Appointment, appointment , key))
                {
                    Console.WriteLine($"Appointment on {date.ToShortDateString()} at {time} has been successfully updated to status '{status}'.");
                }
                else
                {
                    Console.WriteLine("Failed to update the appointment.");
                }

            }
            else
            {
                Console.WriteLine("No appointment found at the specified date and time.");
            }
        }
    }
}
