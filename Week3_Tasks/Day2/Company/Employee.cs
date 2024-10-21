using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public char Gender { get; set;}

        public Employee(int id , string name , double salary , HiringDate hiringDate , char gender)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.Gender = gender;
            this.HireDate = hiringDate;
        }
        public string DisplayEmployee()
        {
            return $"ID: {Id}, Salary: {Salary:C}, Hire Date: {HireDate.DisplayHiringDate()}, Gender: {Gender}";
        }
    }
}
