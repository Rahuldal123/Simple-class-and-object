using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
  public class Employee
    {
        string Name, Qualification, Department ,month;
        int day, year;
        double salary ;

        public void Assignvalue()
        {
            Name = "Mahesh Deokar";
            Qualification = "B.E.Mechanical";
            Department = "Production";
            day = 18;
            month = "sept";
            year = 2021;
            salary = 45000;


        }

        public string Displayvalue()
        {
            return $" Name = {Name} Qualiication={Qualification} dept= {Department} join date={day} {month} {year}  salary={salary}";
        }







    }
}
