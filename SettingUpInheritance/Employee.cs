using System;
using System.Collections.Generic;
using System.Text;

namespace SettingUpInheritance
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private int empId;
        private static int numberOfEmployees;

        public string FirstName 
        {
            get { return firstName; } 
            protected set { firstName = value; }///protected is like private for this class and every sub class
        }
        public string LastName
        {
            get { return lastName; }
            protected set { lastName = value; }
        }
        public int EmpId
        {
            get { return empId; }
            protected set 
            { if (value < 0)
                {
                    //throw new FormatException("Invalid Employee ID");
                    Console.WriteLine("Invalid Employee ID Detected");
                    return;
                }
                else { empId = value; }
            }
        }
        public static int NumberOfEmployees
        {
            get { return numberOfEmployees; }
            protected set { numberOfEmployees = value; }
        }
        public Employee (string fn, string ln, int id)
        {
            FirstName = fn;
            LastName = ln;
            EmpId = id;
            NumberOfEmployees++;
        }
        public Employee () : this ("unknown","Unknown",0)////always crate a default constructor 
        {

        }
        //internal string GetFirstName(string n)
       // {

       // }
    }
}
