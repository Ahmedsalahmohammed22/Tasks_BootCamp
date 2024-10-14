using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace University
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration(int hours , int minutes , int seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public Duration(int totalSeconds)
        {
            this.Hours = totalSeconds / 3600;
            this.Minutes = (totalSeconds % 3600) / 60 ;
            this.Seconds = totalSeconds % 60;
        }
        public string getstring()
        {
            return $"Hours: {Hours} Minutes: {Minutes} Seconds: {Seconds}";

        }
    }
}
