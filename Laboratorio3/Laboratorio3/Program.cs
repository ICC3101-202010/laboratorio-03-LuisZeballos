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
            List<Clientes> clientes = new List<Clientes>();
            List<Empleados> empleados = new List<Empleados>();
            List<Jefes> jefes = new List<Jefes>();
            List<Supervisores> supervisores = new List<Supervisores>();
            List<Auxiliares> auxiliares = new List<Auxiliares>();
            List<Producto> products = new List<Producto>();
            Console.WriteLine("Cuantas personas desea agregar?");
            int i = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (count < i)
            {
                Console.WriteLine("Que tipo de persona es?(Cliente,Empleado,Jefe,Supervisor,Auxiliar)");
                string res = Console.ReadLine();
                if (res == "Cliente" || res == "cliente")
                {
                    List<string> carrito = new List<string>();
                    Console.WriteLine("Cual es el nombre?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Cual es el apellido?");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("De qué país es?");
                    string pais = Console.ReadLine();
                    Console.WriteLine("Cual es su fecha de naciemiento?(XX/YY/ZZ)");
                    string birthday = Console.ReadLine();
                    Console.WriteLine("Cual es el Rut?(sin puntos ni guión)");
                    int rut = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cuanto dinero posee?");
                    int money = Convert.ToInt32(Console.ReadLine());

                    Clientes person = new Clientes(name, apellido, pais, rut, birthday, money ,carrito);

                    clientes.Add(person);
                    count++;
                    if (i > 1)
                    {
                        Console.WriteLine("Siguiente Persona: ");
                    }
                }
                else if (res == "Empleado" || res == "empleado")
                {
                    Console.WriteLine("Cual es el nombre?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Cual es el apellido?");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("De qué país es?");
                    string pais = Console.ReadLine();
                    Console.WriteLine("Cual es su fecha de naciemiento?(XX/YY/ZZ)");
                    string birthday = Console.ReadLine();
                    Console.WriteLine("Cual es el Rut?(sin puntos ni guión)");
                    int rut = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cuanto dinero gana?");
                    int salary = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cuantas hrs trabaja?");
                    int hrs = Convert.ToInt32(Console.ReadLine());

                    Empleados person = new Empleados(name, apellido, pais, rut, birthday, salary, hrs, res);

                    empleados.Add(person);
                    count++;
                    if (i > 1)
                    {
                        Console.WriteLine("Siguiente Persona: ");
                    }
                }
                else if (res == "Jefe" || res == "jefe")
                {
                    Console.WriteLine("Cual es el nombre?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Cual es el apellido?");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("De qué país es?");
                    string pais = Console.ReadLine();
                    Console.WriteLine("Cual es su fecha de naciemiento?(XX/YY/ZZ)");
                    string birthday = Console.ReadLine();
                    Console.WriteLine("Cual es el Rut?(sin puntos ni guión)");
                    int rut = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cuanto dinero gana?");
                    int salary = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cuantas hrs trabaja?");
                    int hrs = Convert.ToInt32(Console.ReadLine());

                    Jefes person = new Jefes(name, apellido, pais, rut, birthday, salary,hrs,res);

                    jefes.Add(person);
                    count++;
                    if (i > 1)
                    {
                        Console.WriteLine("Siguiente Persona: ");
                    }
                }
                else if (res == "Supervisor" || res == "supervisor")
                {
                    Console.WriteLine("Cual es el nombre?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Cual es el apellido?");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("De qué país es?");
                    string pais = Console.ReadLine();
                    Console.WriteLine("Cual es su fecha de naciemiento?(XX/YY/ZZ)");
                    string birthday = Console.ReadLine();
                    Console.WriteLine("Cual es el Rut?(sin puntos ni guión)");
                    int rut = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cuanto dinero gana?");
                    int salary = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cuantas hrs trabaja?");
                    int hrs = Convert.ToInt32(Console.ReadLine());

                    Supervisores person = new Supervisores(name, apellido, pais, rut, birthday, salary, hrs, res);

                    supervisores.Add(person);
                    count++;
                    if (i > 1)
                    {
                        Console.WriteLine("Siguiente Persona: ");
                    }
                }
                else if (res == "Auxiliar" || res == "auxiliar")
                {
                    Console.WriteLine("Cual es el nombre?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Cual es el apellido?");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("De qué país es?");
                    string pais = Console.ReadLine();
                    Console.WriteLine("Cual es su fecha de naciemiento?(XX/YY/ZZ)");
                    string birthday = Console.ReadLine();
                    Console.WriteLine("Cual es el Rut?(sin puntos ni guión)");
                    int rut = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cuanto dinero gana?");
                    int salary = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cuantas hrs trabaja?");
                    int hrs = Convert.ToInt32(Console.ReadLine());

                    Auxiliares person = new Auxiliares(name, apellido, pais, rut, birthday, salary, hrs, res);

                    auxiliares.Add(person);
                    count++;
                    if (i > 1)
                    {
                        Console.WriteLine("Siguiente Persona: ");
                    }
                }

            }
            Console.WriteLine("Desea agregar productos? Si/No");
            string a = Console.ReadLine();
            if (a == "Si" || a == "si")
            {
                Console.WriteLine("Cuantos productos desea agregar?");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = 0;
                while (c < b)
                {
                    Console.WriteLine("Cual es el nombre del producto?");
                    string name = Console.ReadLine();
                    Console.WriteLine("Cual es la marca del producto?");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Cual es el precio del producto?");
                    int price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Cual es el stock del producto?");
                    int stock = Convert.ToInt32(Console.ReadLine());

                    Producto producto = new Producto(name, marca, price, stock);

                    products.Add(producto);

                    c++;
                    if (b > 1 && b != c)
                    {
                        Console.WriteLine("Siguiente Producto: ");
                    }

                 
                }
            }
            Console.WriteLine("Desea realizar más acciones? 1 para si y 2 para no");
            int s = Convert.ToInt32(Console.ReadLine());
            while (s == 1)
            {
                Console.WriteLine("1. Realizar compras");
                Console.WriteLine("2. Cambiar puestos o salario de los trabajadores");
                Console.WriteLine("3. Ralizar simulacion random supermercado");

                string r = Console.ReadLine();
                if (r == "1")
                {
                    Console.WriteLine("Con que cliente quiere comprar(Primer nombre)");
                    string cli = Console.ReadLine();
                    for (int f = 0; f < clientes.Count();f++)
                    {
                        if (cli == clientes[f].GetFirstName())
                        {
                            int saldo = clientes[f].Getmoney();
                            Console.WriteLine("Cuantos productos desea agregar al carrito?");
                            int y = Convert.ToInt32(Console.ReadLine());
                            int total = 0;
                            for (int l = 0; l < y;l++)
                            {
                                Console.WriteLine("Que producto desea agregar?(Nombre)");
                                string q = Console.ReadLine();
                                for (int k = 0; k < products.Count(); k++)
                                {
                                    if (q == products[k].GetName())
                                    {
                                        if (products[k].GetStock() == 0)
                                        {
                                            Console.WriteLine("Producto agotado");
                                            break;
                                        }
                                        if (saldo < products[k].GetPrice())
                                        {
                                            Console.WriteLine("No tiene saldo suficiente");

                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Añadido al carrito");
                                            clientes[f].AddCarrito(products[k].GetName());
                                            saldo -= products[k].GetPrice();
                                            products[k].Compra();
                                            total += products[k].GetPrice();
                                        }
                                    }
                                }


                            }
                            Console.WriteLine("Desea ver los datos de la compra de" + clientes[f] + "?Si/No");
                            string u = Console.ReadLine();
                            if (u == "si")
                            {
                                for (int co = 0;co < clientes[f].GetCarrito().Count();co++)
                                {
                                    Console.WriteLine(clientes[f].GetCarrito()[co] );
                                }
                                Console.WriteLine("Total gastado: $" + total);
                            }
                        }
                    }


                }
                if (r == "2")
                {

                }
                if (r == "3")
                {

                }

                Console.WriteLine("Desea realizar otra accion? si/no");
                string b = Console.ReadLine();
                if (b == "no")
                {
                    s++;
                }
            }

            


            Console.ReadLine();
        }

    }
}
