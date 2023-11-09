using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8___OOP_Generic_Collections
{

    internal class EmpList : List<Employee>
    //Class Emplist to store our method for our list, Inheritance from Employee clas
    {
        public void PrintAllEmployees()
        {
            foreach (var employee in this)
            {
                employee.PrintInfo();             
            }
        }
        public bool ContainsEmployee(string employeeId)
        {
            return this.Exists(employee => employee.Id == employeeId);
        }   
        public void FindEmployee()
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
        public void FindALlEmployees()
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
