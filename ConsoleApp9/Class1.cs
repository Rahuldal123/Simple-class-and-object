using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Date
    {
        int day, year;
        string month;

        public void Assignvalue()
        {
            day = 13;
            month = "sept";
            year = 2022;


        }
        public string Displayvalue()
        {
           return $"{day} {month} {year}";
        }
    }

}
