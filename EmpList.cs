using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8___OOP_Generic_Collections
{

    internal class EmpList : List<Employee>
    //Class Emplist to store our method for our list, Inheritance from Employee class
    {
        public void PrintAllEmployees() //Method to print employees with attributes from Printinfo
        {
            foreach (var employee in this)
            {
                employee.PrintInfo();             
            }
        }
        public bool ContainsEmployee(string employeeId) //Method to look if a specific id exist 
        {
            return this.Exists(employee => employee.Id == employeeId);
        }   
        public void FindEmployee() //Method to find specific employee based on gender and prints the first one
        {
            Employee findMale = this.Find(Employee => Employee.Gender == "Male");
            
            if (findMale != null)
            {
                Console.WriteLine("First male in the list:");
                findMale.PrintInfo();
            }
            else
            {
                Console.WriteLine("No male found in the list.");
            }            
        }
        public void FindALlEmployees() //Method to find specific employees based on gender, and prints everyone of that gender
        {
            List<Employee> males = this.FindAll(Employee => Employee.Gender == "Male");
            
            if (males.Count > 0)
            {
                Console.WriteLine("All males in the list");
                foreach (var male in males)
                {
                    male.PrintInfo();
                }
            }
            else
            {
                Console.WriteLine("No males found in the list");
            }
        }
     
     
    }
}
