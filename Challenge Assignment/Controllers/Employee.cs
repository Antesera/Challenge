using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge_Assignment.Controllers
{
    class Eventhandler
    {
        class Employee
        {
            public DateTime HiringDate { get; set; }
        }
        static void Main()
        {
           //Write the current date and time
            DateTime now = DateTime.Now;
            Console.WriteLine("NOW:" + now);

            //store a DteTime in a class.
            Employee employee = new Employee() { HiringDate = now };
            Console.WriteLine("HIRING DATE: " + employee.HiringDate);
        }
    }
}