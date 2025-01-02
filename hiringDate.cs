using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class hiringDate
    {
        public int year {  set; get; }
        public int month {  set; get; }
        public int day {  set; get; }

        public hiringDate(int year, int month, int day)
        {
            if (day < 1 || day > 31 || month < 1 || month > 12 || year < 1930)
                throw new AggregateException("not True Date");
            this.year = year;             
            this.month = month;
            this.day = day;
        }
    }
}
