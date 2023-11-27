using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    internal class Birthdate
    {
        public int year;
        public int month;
        public int day;

        public Birthdate(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
    }
}
