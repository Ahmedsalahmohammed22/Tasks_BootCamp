using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_LINQ
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject[] Subjects { get; set; }

        public Student(int id  , string fname , string lname , Subject[] subject)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
            Subjects = subject;   
        }
        public Student()
        {
            
        }
        public override string ToString()
        {
            string txt = $"ID: {Id}, Name: {FirstName} {LastName}, ";
            foreach (Subject subject in Subjects)
            {
                txt += subject.ToString() ;
            }
            return txt;
        }

    }
}
