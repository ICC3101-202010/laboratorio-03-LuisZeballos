using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Producto
    {
        private string Name;
        private string Marca;
        private int Price;
        private int Stock;

        public Producto(string Name,string Marca,int Price, int Stock)
        {
            this.Name = Name;
            this.Marca = Marca;
            this.Price = Price;
            this.Stock = Stock;

        }
        public string GetName()
        {
            return Name;
        }
        public string GetMarca()
        {
            return Marca;
        }
        public int GetPrice()
        {
            return Price;
        }
        public int GetStock()
        {
            return Stock;
        }
    }
}
