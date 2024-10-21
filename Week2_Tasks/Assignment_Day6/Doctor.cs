using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day6
{
    public enum WorkingDays
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    internal class Doctor : Account
    {
        public string Department {  get; set; }
        public bool FullAuth { get; set; } = true;
        public List<WorkingDays> WorkingDays { get; set; }

        public List<WorkingDays> GetSchedule()
        {
            Console.WriteLine($"{Name} works on : {string.Join(", ", WorkingDays)}");
            return WorkingDays;
        }

    }
}
