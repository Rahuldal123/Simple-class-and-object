using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Student
    {
        string name, address, stream;
        int rollnum;


        public void Assignvalue()
        {
            name = "rahul";
            address = "pune,maharashtra";
            stream = "mechanical";
            rollnum = 20;
        }
        public string Displayvalue()
        {
            return $"{name} {address} {stream} {rollnum}"; 
            
        }

        
       

        


    }
}
