using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Question
    {
            public string Questionbody { get; set; }
            public int Mark { get; set; }
            public Question(string questionbody, int mark)
            {
                Questionbody = questionbody;
                Mark = mark;
            }
            public override string ToString()
            {
                return $"Question : {Questionbody} ( {Mark} mark) ";
            }
    }
}
