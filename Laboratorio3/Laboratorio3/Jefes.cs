﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Jefes : Person
    {
        private int Salary;
        private int hrs;
        private string job;
        public Jefes(string FirstName, string LastName, string Pais, int Rut, string Birthday, int Salary, int hrs, string job) : base(FirstName, LastName, Pais, Rut, Birthday)
        {
            this.Salary = Salary;
            this.hrs = hrs;
            this.job = job;

        }
        public int GetSalary()
        {
            return Salary;
        }
        public int Gethrs()
        {
            return hrs;
        }
        public string Getjob()
        {
            return job;
        }
        public void Changejob(string newjob)
        {
            job = newjob;
        }
        public void ChangeSalary(int newsalary)
        {
            Salary = newsalary;
        }
        public void ChangeHrs(int newHrs)
        {
            hrs = newHrs;
        }
    }
}
