﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject.Entities
{
    internal class Employee
    {
        public string Name {  get; protected set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee(string name, int hours, double valuePerHour) 
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;

        }

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }





    }
}
