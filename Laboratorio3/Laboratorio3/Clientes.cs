using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Clientes : Person
    {
        private int Money;
        public Clientes(string FirstName, string LastName, string Pais, int Rut, string Birthday, int Money) : base(FirstName, LastName, Pais, Rut, Birthday)
        {
            this.Money = Money;
        }
        public int Getmoney()
        {
            return Money;
        }
    }
}
