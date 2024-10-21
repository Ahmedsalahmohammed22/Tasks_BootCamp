using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Answer
    {
        public int Num { get; set; }
        public string Choosetxt { get; set; }
        public Answer(int num , string choose)
        {
            Num = num;
            Choosetxt = choose;
        }
        public override string ToString()
        {
            return $"{Num} - {Choosetxt}";
        }
    }
}
