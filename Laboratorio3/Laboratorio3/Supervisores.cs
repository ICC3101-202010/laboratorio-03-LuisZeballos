using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Supervisores : Person
    {
        private int Salary;
        public Supervisores(string FirstName, string LastName, string Pais, int Rut, string Birthday, int Salary) : base(FirstName, LastName, Pais, Rut, Birthday)
        {
            this.Salary = Salary;

        }
        public int GetSalary()
        {
            return Salary;
        }
    }
}
