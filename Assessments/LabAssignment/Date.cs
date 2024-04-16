using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.LabAssignment
{
    public class Date
    {
        private int date;
        private string month;
        private int year;

        public Date()
        {
            date = 1;
            month = "Jan";
            year = 2020;
        }
        public Date(int date, string month, int year)
        {
            this.date = date;
            this.year = year;
            this.month = month;
        }
        public string Display()
        {
            return $"Date={date}-{month}-{year}";
        }
    }
}
