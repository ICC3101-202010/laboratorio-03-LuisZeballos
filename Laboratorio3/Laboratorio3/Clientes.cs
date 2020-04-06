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
        public List<string> Carrito;
        public Clientes(string FirstName, string LastName, string Pais, int Rut, string Birthday, int Money, List<string> Carrito) : base(FirstName, LastName, Pais, Rut, Birthday)
        {
            this.Money = Money;
            this.Carrito = Carrito;
        }
        public int Getmoney()
        {
            return Money;
        }
        public List<string> GetCarrito()
        {
            return Carrito;
        }
        public void AddCarrito(string pro)
        {
            Carrito.Add(pro);
        }
    }
}
