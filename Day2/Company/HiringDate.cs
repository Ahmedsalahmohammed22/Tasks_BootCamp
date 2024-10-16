using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal struct HiringDate
    {
        public int year;
        public int month;
        public int day;
        public HiringDate(int day , int month , int year)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public bool Earlierthan(HiringDate hiring)
        {
            if (year < hiring.year)
                return true;
            if(year ==  hiring.year && month < hiring.month)
                return true;
            if(year == hiring.year && month == hiring.month && day < hiring.day)
                return true;
            return false;
        }
        public string DisplayHiringDate()
        {
            return $"{day:D2}/{month:D2}/{year}";
        }

    }
}
