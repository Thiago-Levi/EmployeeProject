using EmployeeProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EmployeeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employess = new List<Employee>();

            Console.WriteLine("Enter the number of employees");
            int numberOfEmployees = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numberOfEmployees; i++)
            {
                Console.Write("Outsourced (y/n)? ");
                char option = Convert.ToChar(Console.ReadLine());
                string name = ""; 
                int hours = 0;
                double valuePerHour = 0.0;
                double additionalCharge = 0.0;
               

                switch (option)
                {
                    case 'y':
                        Console.Write("Name: ");
                        name = Convert.ToString(Console.ReadLine());

                        Console.Write("Hours: ");
                        hours = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Value Per hour: ");
                        valuePerHour = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Addtional charge: ");
                        additionalCharge = Convert.ToDouble(Console.ReadLine());

                        Employee outsourceEmployee = 
                            new OutsourceEmployee(name, hours, valuePerHour, additionalCharge);
                            employess.Add(outsourceEmployee);
                        break;

                    case 'n':
                        Console.WriteLine("Name: ");
                        name = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Hours: ");
                        hours = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Value Per hour: ");
                        valuePerHour = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Employee employee = new Employee(name, hours, valuePerHour);
                        employess.Add(employee);
                        break;
                     
                    default: Console.WriteLine("Opção inválida!");
                    break;
                }

              



            }

            foreach (var employee in employess)
            {
                Console.WriteLine($"{employee.Name} - {employee.Payment():C}");
            }

            Console.ReadLine();

        }

    }
}
