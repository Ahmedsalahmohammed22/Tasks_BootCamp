using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_LINQ
{
    internal class Subject
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public Subject(int code , string name)
        {
            Code = code;
            Name = name;
        }
        public Subject()
        {
            
        }
        public override string ToString()=> $"Code: {Code}, Name: {Name}";
        
    }
}
