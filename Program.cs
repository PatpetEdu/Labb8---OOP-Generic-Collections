using System.Collections;

namespace Labb8___OOP_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Information about our employess
            Employee E1 = new Employee()
            {
                Id ="101",
                Name = "Lisa",
                Gender = "Female",
                Salary = 25500
            };
            Employee E2 = new Employee()
            {
                Id = "102",
                Name = "Patrik",
                Gender = "Male",
                Salary = 27000
            };
            Employee E3 = new Employee()
            {
                Id = "103",
                Name = "Amanda",
                Gender = "Female",
                Salary = 26500
            };
            Employee E4 = new Employee()
            {
                Id = "104",
                Name = "Erik",
                Gender = "Male",
                Salary = 27500
            };
            Employee E5 = new Employee()
            {
                Id = "105",
                Name = "Elsa",
                Gender = "Female",
                Salary = 28300
            };

            //Creating stack and using Push to implement them to the list
            Stack<Employee> empStack = new Stack<Employee>();

            empStack.Push(E1);
            empStack.Push(E2);
            empStack.Push(E3);
            empStack.Push(E4);
            empStack.Push(E5);
           
            foreach (var Employees in empStack)
            {
                Console.WriteLine("Items left in the stack " + empStack.Count());
                Employees.PrintInfo();
                
            }
            Console.WriteLine("*************************************");

            //Adding objects to the stack using Pop
            while (empStack.Count > 0)
            {
                Employee employee = empStack.Pop();
                employee.PrintInfo();
                Console.WriteLine("Items left in the stack " + empStack.Count());
                
            }
            Console.WriteLine("*************************************");
           
            //Adding objects to the stack again using Push because they are currently 0
            empStack.Push(E1);
            empStack.Push(E2);
            empStack.Push(E3);
            empStack.Push(E4);
            empStack.Push(E5);      
            Console.WriteLine("-Stack refilled count- = " + empStack.Count());
            Console.WriteLine("*************************************");

            //checking if an object in the stack exist using Peeok method
            Console.WriteLine("-Retrive using Peek method-");
            if (empStack.Count > 0)
            {
                Employee empPeek1 = empStack.Peek();             
                empPeek1.PrintInfo();
                Console.WriteLine("Items left in the stack " + empStack.Count());
            }
            if (empStack.Count > 1)
            {
                empStack.Pop(); //tar bort det översta i stacken för att kunna kolla på ett annat objekt
                Employee empPeek2 = empStack.Peek();             
                empPeek2.PrintInfo();
                Console.WriteLine("Items left in the stack " + empStack.Count());
                Console.WriteLine("*************************************");
            }
            //Inehåller
            bool employeeE3 = false;
            foreach(var employee in empStack)
             if (employee.Id == "103")
                {
                    employeeE3 = true;
                    break;
                }

            if (employeeE3)
            {
                Console.WriteLine("Employee 3 is in the stack");
                Console.WriteLine("*************************************");
            }
            else
            {
                Console.WriteLine("Employee is not in the stack");
                Console.WriteLine("*************************************");
            }

            //List for Employess 
            EmpList empList = new EmpList()
            {
                new Employee { Id = "101", Name = "Lisa", Gender = "Female", Salary = 25500 },
                new Employee { Id = "102", Name = "Patrik", Gender = "Male", Salary = 27000 },
                new Employee { Id = "103",Name = "Amanda",Gender = "Female",Salary = 26500},
                new Employee { Id = "104",Name = "Erik",Gender = "Male",Salary = 27500},
                new Employee { Id = "105",Name = "Elsa",Gender = "Female",Salary = 28300},

            };
            //Method to print employess from the list
            empList.PrintAllEmployees(); 
            Console.WriteLine("*************************************");
            //using bool and contains to see if specific employee is in the list
            bool containsEmployeeE1 = empList.ContainsEmployee("103");
            if (containsEmployeeE1)
            {
                Console.WriteLine("Employee1 object exists in the list");
                Console.WriteLine("*************************************");
            }
            else
            {
                Console.WriteLine("Employee1 object does not exist in the list");
                Console.WriteLine("*************************************");
            }

            Console.WriteLine();
            empList.FindEmployee();
            Console.WriteLine("*************************************");

            Console.WriteLine();
            empList.FindALlEmployees();
            


        }

    }
}