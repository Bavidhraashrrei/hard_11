using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hard_1
{
    class Employee
    {
        IDictionary<int, Tuple<string, int, double>> employe = new Dictionary<int, Tuple<string, int, double>>();
        int id, age;
        string name;
        double salary;
        int opt;

        public Employee()
        {

        }

        public Employee(int id, int age, string name, double salary)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.salary = salary;
        }
        public void Get_emplydetails()
        {
            Console.WriteLine("Please enter the employee ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary");
            salary = Convert.ToDouble(Console.ReadLine());
        }


        public void Insert_emply_details()
        {
            do
            {
                Get_emplydetails();
                employe.Add(id, Tuple.Create(name, age, salary));
                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                opt = Convert.ToInt32(Console.ReadLine());
            } while (opt == 1);
        }
        public void modify_employee_details()
        {
            int id1, age1;
            double salary1;
            string name1;
            Console.WriteLine("Please enter the employee ID");
            id1 = Convert.ToInt32(Console.ReadLine());
            foreach (var obj in employe)
            {
                if (obj.Key == id1)
                {
                    Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", obj.Key, obj.Value.Item1, obj.Value.Item2, obj.Value.Item3);

                    continue;
                }
            }
            Console.WriteLine("Please enter the updated employee details");
            Console.WriteLine("Please enter the employee name");
            name1 = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary");
            salary1 = Convert.ToDouble(Console.ReadLine());
            foreach (var obj in employe)
            {
                if (obj.Key == id1)
                {
                     obj.Value.Item1=name1;
                     obj.Value.Item2=age1;
                     obj.Value.Item3=salary1;

                    break;
                }
            }

        }
        public void Print_All_Employee()
        {
            foreach (var obj in employe)
            {
                                
                    Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", obj.Key, obj.Value.Item1, obj.Value.Item2, obj.Value.Item3);

                
            }
        }
        public void Print_Employee()
        {
            int id1;
            Console.WriteLine("Please enter the employee ID");
            id1 = Convert.ToInt32(Console.ReadLine());
            foreach (var obj in employe)
            {
                if (obj.Key == id1)
                {
                    Console.WriteLine("Employee ID:{0}\nName:{1}\nAge:{2}\nSalary:{3}", obj.Key, obj.Value.Item1, obj.Value.Item2, obj.Value.Item3);

                }
            }
        }
       /* public void Exit()
        {
            
                System.Environment.Exit(0);
            
        }
    }