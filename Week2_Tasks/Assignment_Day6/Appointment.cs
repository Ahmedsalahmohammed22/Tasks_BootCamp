using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day6
{
    internal class Appointment
    {
        public DateTime Date { get; set; }
        public TimeOnly Time { get; set; }
        public Customer Customer { get; set; } = new Customer();
        public Assistant Assistant { get; set; } = new Assistant();
        public Doctor Doctor { get; set; } = new Doctor();
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }



        public bool AppointmentDoctorAvailability(DateTime date, TimeOnly time)
        {
            DayOfWeek day = Date.DayOfWeek;
            if(Doctor.GetSchedule().Contains((WorkingDays)day))
            {
                Console.WriteLine("Doctor is available on this date.");
                return true;
            }
            else
            {
                Console.WriteLine("Doctor is not available on this date.");
                return false;
            }
        }

        public bool TimeUntaked(DateTime date , TimeOnly time ) {
            string key = $"{date:yyyy-MM-dd}_{time:HH:mm}";
            if (DataBase.AppList.ContainsKey(key))
            {
                var existingAppointment = DataBase.AppList[key];

                if (existingAppointment.Doctor == this.Doctor)
                {
                    Console.WriteLine("This time is taken");
                    return false; 
                }
            }
            return true;

        }
    }
}
