using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            List < Person > people= new List<Person>();
            List <Producto> product = new List<Producto>();
            Console.WriteLine("Listo para comenzar?,Desea agregar una Persona o un Producto?");
            string respuesta = Console.ReadLine();
            if (respuesta == "Persona" || respuesta == "persona" )
            {
                Console.WriteLine("Cuantas personas desea agregar?");
                int i = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                while (count < i)
                {
                    Console.WriteLine("Que tipo de persona es?(Cliente,Empleado,Jefe,Supervisor,Auxiliar)");
                    string res = Console.ReadLine();
                    if (res == "Cliente" || res == "cliente")
                    {
                        Console.WriteLine("Cual es el nombre?");
                        string name = Console.ReadLine();
                        Console.WriteLine("Cual es el apellido?");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("De qué país es?");
                        string pais = Console.ReadLine();
                        Console.WriteLine("Cual es su fecha de naciemiento?");
                        string birthday = Console.ReadLine();
                        Console.WriteLine("Cual es el Rut?(sin puntos ni guión)");
                        int rut = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cuanto dinero posee?");
                        int money = Convert.ToInt32(Console.ReadLine());

                        Clientes person = new Clientes(name, apellido, pais, rut, birthday, money);

                        people.Add(person);
                        count++;
                    }                  
                    else if (res == "Empleado" || res == "empleado")
                    {
                        Console.WriteLine("Cual es el nombre?");
                        string name = Console.ReadLine();
                        Console.WriteLine("Cual es el apellido?");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("De qué país es?");
                        string pais = Console.ReadLine();
                        Console.WriteLine("Cual es su fecha de naciemiento?(XX/YY//ZZ)");
                        string birthday = Console.ReadLine();
                        Console.WriteLine("Cual es el Rut?(sin puntos ni guión)");
                        int rut = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cuanto dinero gana?");
                        int salary = Convert.ToInt32(Console.ReadLine());

                        Empleados person = new Empleados(name, apellido, pais, rut, birthday, salary);

                        people.Add(person);
                        count++;
                    }
                    else if (res == "Jefe" || res == "jefe")
                    {
                        Console.WriteLine("Cual es el nombre?");
                        string name = Console.ReadLine();
                        Console.WriteLine("Cual es el apellido?");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("De qué país es?");
                        string pais = Console.ReadLine();
                        Console.WriteLine("Cual es su fecha de naciemiento?(XX/YY//ZZ)");
                        string birthday = Console.ReadLine();
                        Console.WriteLine("Cual es el Rut?(sin puntos ni guión)");
                        int rut = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cuanto dinero gana?");
                        int salary = Convert.ToInt32(Console.ReadLine());

                        Jefes person = new Jefes(name, apellido, pais, rut, birthday, salary);

                        people.Add(person);
                        count++;
                    }
                    else if (res == "Supervisor" || res == "supervisor")
                    {
                        Console.WriteLine("Cual es el nombre?");
                        string name = Console.ReadLine();
                        Console.WriteLine("Cual es el apellido?");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("De qué país es?");
                        string pais = Console.ReadLine();
                        Console.WriteLine("Cual es su fecha de naciemiento?(XX/YY//ZZ)");
                        string birthday = Console.ReadLine();
                        Console.WriteLine("Cual es el Rut?(sin puntos ni guión)");
                        int rut = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cuanto dinero gana?");
                        int salary = Convert.ToInt32(Console.ReadLine());

                        Supervisores person = new Supervisores(name, apellido, pais, rut, birthday, salary);

                        people.Add(person);
                        count++;
                    }
                    else if (res == "Auxiliar" || res == "auxiliar")
                    {
                        Console.WriteLine("Cual es el nombre?");
                        string name = Console.ReadLine();
                        Console.WriteLine("Cual es el apellido?");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("De qué país es?");
                        string pais = Console.ReadLine();
                        Console.WriteLine("Cual es su fecha de naciemiento?(XX/YY//ZZ)");
                        string birthday = Console.ReadLine();
                        Console.WriteLine("Cual es el Rut?(sin puntos ni guión)");
                        int rut = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Cuanto dinero gana?");
                        int salary = Convert.ToInt32(Console.ReadLine());

                        Auxiliares person = new Auxiliares(name, apellido, pais, rut, birthday, salary);

                        people.Add(person);
                        count++;
                    }

                }

            }
            else if (respuesta == "Producto" || respuesta == "producto")
            {
                Console.WriteLine("Cuantos productos desea agregar?");
                int i = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                while ( count < i)
                {
                    Console.WriteLine("Cual es el nombre del producto?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Cual es la marca del producto?");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Cual es el precio del producto?");
                    int price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cual es el stock del producto?");
                    int stock = Convert.ToInt32(Console.ReadLine());

                    Producto producto = new Producto(name,marca,price,stock);

                    product.Add(producto);

                    count++;
                }
                int count2 = 0;
                while (count2 < i)
                {
                    Console.WriteLine(product[count2].GetName());
                    count2++;

                }
            }else
            {
                Console.WriteLine("No existe esa Clase");
            }
            Console.ReadLine();
        }
    }
}
