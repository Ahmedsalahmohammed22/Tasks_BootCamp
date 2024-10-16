using StudentLibrary;
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
        public Duration(int hours = 0 , int minutes = 0 , int seconds = 0)
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
        public override string ToString()
        {
            return $"{Hours:D2}H:{Minutes:D2}M:{Seconds:D2}S";
        }

        public override bool Equals(object? obj)
        {

            Duration d = obj as Duration;
            if (d == null) return false;
            else return (Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds);

        }
        public static Duration operator +(Duration d1, Duration d2)
        {
            Duration d3 = new Duration();
            d3.Hours = d1.Hours + d2.Hours;
            d3.Minutes = d1.Minutes + d2.Minutes;
            d3.Seconds = d1.Seconds + d2.Seconds;
            return d3;
        }

        public static Duration operator +(Duration d3 , int seconds)
        {
            d3.Hours = d3.Hours + (seconds / 3600);
            d3.Minutes = d3.Minutes + ((seconds % 3600) / 60);
            d3.Seconds = d3.Seconds + (seconds % 60);
            return d3;
        }
        public static Duration operator ++(Duration d1)
        {
            Duration d3 = new Duration();
            d3.Minutes = d1.Minutes ++;
            return d3;
        }
        public static Duration operator --(Duration d1)
        {
            Duration d3 = new Duration();
            d3.Minutes = --d1.Minutes;
            return d3;
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            int totalsecondD1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalsecondD2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return totalsecondD1 <= totalsecondD2;

        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            int totalsecondD1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalsecondD2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
            return totalsecondD1 >= totalsecondD2;

        }
    }
}
