using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Event_Delegate
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public Dictionary<string, string> Dependents { get; set; }
        public event Action<Employee> addemployee;
        public Employee(int id , string name , decimal salary , string gender , DateTime hireDate , Dictionary<string , string> dependents)
        {
            Id = id;
            Name = name;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
            Dependents = dependents;
        }
        public void Onaddemployee()
        {
            addemployee.Invoke(this);
        }
        public override string ToString()
        {
            string txt = $"ID: {Id}, Salary: {Salary:C}, Gender: {Gender} , Hire Date: {HireDate:yyyy-MM-dd}";
            if(Dependents.Count > 0)
            {
                txt += ", Dependents: \n";
                foreach (KeyValuePair<string , string > depend in Dependents)
                {
                    txt += $"{depend.Key}  ({depend.Value})\n";
                }

            }
            else
            {
                txt += " , No dependents listed";
            }
            return txt ;
        }


    }
}
