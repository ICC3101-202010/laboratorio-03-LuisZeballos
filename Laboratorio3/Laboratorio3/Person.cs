using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Person
    {
        protected string FirstName;
        protected string LastName;
        protected string Pais;
        protected string Birthday;
        protected int Rut;


        public Person(string FirstName, string LastName,string Pais,int Rut,string Birthday) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Pais = Pais;
            this.Birthday = Birthday;
            this.Rut = Rut;

        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public string GetPais()
        {
            return Pais;
        }
        public int GetRut()
        {
            return Rut;
        }
        public string GetBirth()
        {
            return Birthday;
        }
    }
}
