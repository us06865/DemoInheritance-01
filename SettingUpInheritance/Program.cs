using System;

namespace SettingUpInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee e0 = new Employee();
            DisplayEmployeeInfo(e0);
            //Console.WriteLine("\nEmployee #0: " +
            //    "\n\tFirst Name: {0}, " +
            //    "\n\tLast Name: {1}," +
            //    "\n\tEmployee ID: {2}",
            //    e0.FirstName, e0.LastName, e0.EmpId);
          ;


            Employee e1 = new Employee("John","Doe", 52);
            DisplayEmployeeInfo(e1);
            //Console.WriteLine("\nEmployee #0: " +
            //"\n\tFirst Name: {0}, " +
            //"\n\tLast Name: {1}," +
            //"\n\tEmployee ID: {2}",
            //e1.FirstName, e1.LastName, e1.EmpId);
            Console.ReadLine();

            static void DisplayEmployeeInfo(Employee e)
            {
                Console.WriteLine("\nEmployee # {3}: " +
                "\n\tFirst Name: {0}, " +
                "\n\tLast Name: {1}," +
                "\n\tEmployee ID: {2}",
                e.FirstName, e.LastName, e.EmpId,Employee.NumberOfEmployees);
            }

        }
    }
}
