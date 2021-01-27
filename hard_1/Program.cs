using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hard_1
{
     class Employee
    {
        static void Main(string[] args)
        {
            int choice, opt;
            Employee emp = new Employee();
            do
            {
                Console.WriteLine("Please enter the option\n1.Add an employee\n2.Modify an employee detail\n3.Print all employee's details\n4.Print an employee detail\n5.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        emp.Insert_emply_details();
                        break;
                    case 2:
                        emp.modify_employee_details();
                        break;
                    case 3:
                        emp.Print_All_Employee();
                        break;
                    case 4:
                        emp.Print_Employee();
                        break;
                    default:
                        break;                        

                }

            } while (choice<=4);
           
              Console.ReadKey();
        }
    }
}
