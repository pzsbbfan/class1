using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date.Runtest();
            Console.ReadLine();
        }

    }

    class Date
    { 
        private int year;
        private int month;
        private int day;

        public Date(int day = 9, int month = 5, int year = 2022)
        { 
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void Add(int days)
        {
            day += days;
        }

        public void Add(int days, int months)
        {
            day += days;
            month += months;
            
        }

        public void Add(Date other)
        {
            day += other.day;
            month += other.month;
            year += other.year;
        }

        public string monthName()
        {
            string monthName = "";
            switch (month)
            {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "Febuary";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "Auguest";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
                default:
                    break;
            }
            return monthName;
        }

        public int monthDays()
        {
            int monthDays = 0;
            if (month == 4 || month == 9 || month == 6 || month == 11)
            {
                monthDays = 30;
            }
            else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8
                || month == 10 || month == 12)
            {
                monthDays = 31;
            }
            else if (month == 2)
            {
                if (year % 4 == 0)
                {
                    monthDays = 29;
                }
                else
                {
                    monthDays = 28;
                }
            }
            return monthDays;
        }

        private void Normalize()
        {
            if (day > monthDays())
            {
                day -= monthDays();
                month++;
            }

            if (month > 12)
            {
                month -= 12;
                year++;
            }
        }

        public override string ToString()
        {
            return $"year: {year} month: {monthName()} day: {day}";
        }

        public static void Runtest()
        { 
            Date date1 = new Date(20,1,2012);
            date1.Normalize();
            Console.WriteLine(date1);

            date1.Add(20);
            date1.Normalize();
            Console.WriteLine(date1);

            date1.Add(20, 1);
            date1.Normalize();
            Console.WriteLine(date1);

            Date date2 = new Date(20, 3, 2012);
            date1.Add(date2);
            date1.Normalize();
            Console.WriteLine(date1);

        }
    }
}
