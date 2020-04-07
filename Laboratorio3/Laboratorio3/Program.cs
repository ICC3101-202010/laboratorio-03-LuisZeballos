using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Program
    {
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
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
            Console.WriteLine("Desea realizar más acciones? 1 para si y 2 para no");
            int s = Convert.ToInt32(Console.ReadLine());
            while (s == 1)
            {
                Console.WriteLine("1. Realizar compras");
                Console.WriteLine("2. Cambiar puestos, hrs de trabajo o salario de los trabajadores");
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
                            Console.WriteLine("Desea ver los datos de la compra?Si/No");
                            string u = Console.ReadLine();
                            if (u == "si")
                            {
                                for (int co = 0;co < clientes[f].GetCarrito().Count();co++)
                                {
                                    Console.WriteLine(clientes[f].GetCarrito()[co] );
                                }
                                Random random = new Random();
                                int num = random.Next(0, empleados.Count());
                                Console.WriteLine("Total de la compra: $" + total);
                                Console.WriteLine("Fue atendido por: " + empleados[num].GetFirstName() + empleados[num].GetLastName() + "  Fecha y hora " + DateTime.Now);
                            }
                        }
                    }


                }
                if (r == "2")
                {
                    Console.WriteLine("Desea cambiar puesto, hrs de trabajo o sueldo?(Puesto/Horas/Sueldo) ");
                    string rt = Console.ReadLine();
                    if (rt == "Puesto")
                    {
                        Console.WriteLine("A quien quiere cambiar de puesto?(Empleado,Jefe,Supervisor,Auxiliar)");
                        string u = Console.ReadLine();
                        if (u == "Empleado")
                        {
                            Console.WriteLine("Cual es el nombre?(Primer nombre)");
                            string h = Console.ReadLine();
                            for (int m = 0; m < empleados.Count(); m++)
                            {
                                if (h == empleados[m].GetFirstName())
                                {
                                    Console.WriteLine("Cual es la nuevo trabajo de " + h + "?(Jefe, Supervisor, Auxiliar)");
                                    string j = Console.ReadLine();
                                    empleados[m].Changejob(j);
                                    if (j == "Jefe")
                                    {
                                        Jefes person = new Jefes(empleados[m].GetFirstName(), empleados[m].GetLastName(), empleados[m].GetPais(), empleados[m].GetRut(), empleados[m].GetBirth(), empleados[m].GetSalary(), empleados[m].Gethrs(), "Jefe");
                                        jefes.Add(person);
                                        empleados.RemoveAt(m);
                                    }
                                    else if (j == "Supervisor")
                                    {
                                        Supervisores person = new Supervisores(empleados[m].GetFirstName(), empleados[m].GetLastName(), empleados[m].GetPais(), empleados[m].GetRut(), empleados[m].GetBirth(), empleados[m].GetSalary(), empleados[m].Gethrs(), "Supervisor");
                                        supervisores.Add(person);
                                        empleados.RemoveAt(m);
                                    }
                                    else if (j == "Auxiliar")
                                    {
                                        Auxiliares person = new Auxiliares(empleados[m].GetFirstName(), empleados[m].GetLastName(), empleados[m].GetPais(), empleados[m].GetRut(), empleados[m].GetBirth(), empleados[m].GetSalary(), empleados[m].Gethrs(), "Auxiliar");
                                        auxiliares.Add(person);
                                        empleados.RemoveAt(m);
                                    }
                                    Console.WriteLine(h + " ahora trabaja como " + j);
                                }
                            }
                        }
                        else if (u == "Jefe")
                        {
                            Console.WriteLine("Cual es el nombre?(Primer nombre)");
                            string h = Console.ReadLine();
                            for (int m = 0; m < jefes.Count(); m++)
                            {
                                if (h == jefes[m].GetFirstName())
                                {
                                    Console.WriteLine("Cual es la nuevo trabajo de " + h + "?(Empleado, Supervisor, Auxiliar)");
                                    string j = Console.ReadLine();
                                    jefes[m].Changejob(j);
                                    if (j == "Empleado")
                                    {
                                        Empleados person = new Empleados(jefes[m].GetFirstName(), jefes[m].GetLastName(), jefes[m].GetPais(), jefes[m].GetRut(), jefes[m].GetBirth(), jefes[m].GetSalary(), jefes[m].Gethrs(), "Empleado");
                                        empleados.Add(person);
                                        jefes.RemoveAt(m);
                                    }
                                    else if (j == "Supervisor")
                                    {
                                        Supervisores person = new Supervisores(jefes[m].GetFirstName(), jefes[m].GetLastName(), jefes[m].GetPais(), jefes[m].GetRut(), jefes[m].GetBirth(), jefes[m].GetSalary(), jefes[m].Gethrs(), "Supervisor");
                                        supervisores.Add(person);
                                        jefes.RemoveAt(m);
                                    }
                                    else if (j == "Auxiliar")
                                    {
                                        Auxiliares person = new Auxiliares(jefes[m].GetFirstName(), jefes[m].GetLastName(), jefes[m].GetPais(), jefes[m].GetRut(), jefes[m].GetBirth(), jefes[m].GetSalary(), jefes[m].Gethrs(), "Auxiliar");
                                        auxiliares.Add(person);
                                        jefes.RemoveAt(m);
                                    }
                                    Console.WriteLine(h + " ahora trabaja como " + j);
                                }
                            }
                        }
                        else if (u == "Supervisor")
                        {
                            Console.WriteLine("Cual es el nombre?(Primer nombre)");
                            string h = Console.ReadLine();
                            for (int m = 0; m < supervisores.Count(); m++)
                            {
                                if (h == supervisores[m].GetFirstName())
                                {
                                    Console.WriteLine("Cual es la nuevo trabajo de " + h + "?(Empleado, Jefe, Auxiliar)");
                                    string j = Console.ReadLine();
                                    supervisores[m].Changejob(j);
                                    if (j == "Empleado")
                                    {
                                        Empleados person = new Empleados(supervisores[m].GetFirstName(), supervisores[m].GetLastName(), supervisores[m].GetPais(), supervisores[m].GetRut(),supervisores[m].GetBirth(), supervisores[m].GetSalary(), supervisores[m].Gethrs(), "Empleado");
                                        empleados.Add(person);
                                        supervisores.RemoveAt(m);
                                    }
                                    else if (j == "Jefes")
                                    {
                                        Jefes person = new Jefes(supervisores[m].GetFirstName(), supervisores[m].GetLastName(), supervisores[m].GetPais(), supervisores[m].GetRut(), supervisores[m].GetBirth(), supervisores[m].GetSalary(), supervisores[m].Gethrs(), "Jefe");
                                        jefes.Add(person);
                                        supervisores.RemoveAt(m);
                                    }
                                    else if (j == "Auxiliar")
                                    {
                                        Auxiliares person = new Auxiliares(supervisores[m].GetFirstName(), supervisores[m].GetLastName(), supervisores[m].GetPais(), supervisores[m].GetRut(), supervisores[m].GetBirth(), supervisores[m].GetSalary(), supervisores[m].Gethrs(), "Auxiliar");
                                        auxiliares.Add(person);
                                        supervisores.RemoveAt(m);
                                    }
                                    Console.WriteLine(h + " ahora trabaja como " + j);
                                }
                            }
                        }
                        else if (u == "Auxiliar")
                        {
                            Console.WriteLine("Cual es el nombre?(Primer nombre)");
                            string h = Console.ReadLine();
                            for (int m = 0; m < auxiliares.Count(); m++)
                            {
                                if (h == auxiliares[m].GetFirstName())
                                {
                                    Console.WriteLine("Cual es la nuevo trabajo de " + h + "?(Empleado, Jefe, Auxiliar)");
                                    string j = Console.ReadLine();
                                    auxiliares[m].Changejob(j);
                                    if (j == "Empleado")
                                    {
                                        Empleados person = new Empleados(auxiliares[m].GetFirstName(), auxiliares[m].GetLastName(), auxiliares[m].GetPais(), auxiliares[m].GetRut(), auxiliares[m].GetBirth(), auxiliares[m].GetSalary(), auxiliares[m].Gethrs(), "Empleado");
                                        empleados.Add(person);
                                        auxiliares.RemoveAt(m);
                                    }
                                    else if (j == "Jefes")
                                    {
                                        Jefes person = new Jefes(auxiliares[m].GetFirstName(), auxiliares[m].GetLastName(), auxiliares[m].GetPais(), auxiliares[m].GetRut(), auxiliares[m].GetBirth(), auxiliares[m].GetSalary(), auxiliares[m].Gethrs(), "Jefe");
                                        jefes.Add(person);
                                        auxiliares.RemoveAt(m);
                                    }
                                    else if (j == "Auxiliar")
                                    {
                                        Supervisores person = new Supervisores(auxiliares[m].GetFirstName(), auxiliares[m].GetLastName(), auxiliares[m].GetPais(), auxiliares[m].GetRut(), auxiliares[m].GetBirth(), auxiliares[m].GetSalary(), auxiliares[m].Gethrs(), "Supervisor");
                                        supervisores.Add(person);
                                        auxiliares.RemoveAt(m);
                                        Console.WriteLine(h + " ahora trabaja como " + j);
                                    }
                                }
                            }
                        }
                    }
                    if (rt == "Horas")
                    {
                        Console.WriteLine("A quien quiere ajustarle las horas de trabajo?(Empleado,Jefe,Supervisor,Auxiliar)");
                        string u = Console.ReadLine();
                        if (u == "Empleado")
                        {
                            Console.WriteLine("Cual es el nombre?(Primer nombre)");
                            string h = Console.ReadLine();
                            for (int m = 0; m < empleados.Count(); m++)
                            {
                                if (h == empleados[m].GetFirstName())
                                {
                                    Console.WriteLine("Cual es la nueva cantidad de horas de trabajo de " + h);
                                    int j = Convert.ToInt32(Console.ReadLine());
                                    empleados[m].ChangeHrs(j);
                                    Console.WriteLine("La nueva cantidad de horas de trabajo de " + h + " ahora es de " + j + "hrs");
                                }

                            }
                        }
                        else if (u == "Jefe")
                        {
                            Console.WriteLine("Cual es el nombre?(Primer nombre)");
                            string h = Console.ReadLine();
                            for (int m = 0; m < jefes.Count(); m++)
                            {
                                if (h == jefes[m].GetFirstName())
                                {
                                    Console.WriteLine("Cual es la nueva cantidad de horas de trabajo de " + h);
                                    int j = Convert.ToInt32(Console.ReadLine());
                                    jefes[m].ChangeHrs(j);
                                    Console.WriteLine("La nueva cantidad de horas de trabajo de " + h + " ahora es de " + j + "hrs");
                                }
                            }
                        }
                        else if (u == "Supervisor")
                        {
                            Console.WriteLine("Cual es el nombre?(Primer nombre)");
                            string h = Console.ReadLine();
                            for (int m = 0; m < supervisores.Count(); m++)
                            {
                                if (h == supervisores[m].GetFirstName())
                                {
                                    Console.WriteLine("Cual es la nueva cantidad de horas de trabajo de " + h);
                                    int j = Convert.ToInt32(Console.ReadLine());
                                    supervisores[m].ChangeHrs(j);
                                    Console.WriteLine("La nueva cantidad de horas de trabajo de " + h + " ahora es de " + j + "hrs");
                                }
                            }
                        }
                        else if (u == "Auxiliar")
                        {
                            Console.WriteLine("Cual es el nombre?(Primer nombre)");
                            string h = Console.ReadLine();
                            for (int m = 0; m < auxiliares.Count(); m++)
                            {
                                if (h == auxiliares[m].GetFirstName())
                                {
                                    Console.WriteLine("Cual es la nueva cantidad de horas de trabajo de " + h);
                                    int j = Convert.ToInt32(Console.ReadLine());
                                    auxiliares[m].ChangeHrs(j);
                                    Console.WriteLine("La nueva cantidad de horas de trabajo de " + h + " ahora es de " + j + "hrs");
                                }
                            }
                        }
                    }
                    if (rt == "Sueldo")
                    {
                        Console.WriteLine("A quien quiere ajustarle el sueldo?(Empleado,Jefe,Supervisor,Auxiliar)");
                        string u = Console.ReadLine();
                        if (u == "Empleado")
                        {
                            Console.WriteLine("Cual es el nombre?(Primer nombre)");
                            string h = Console.ReadLine();
                            for (int m = 0;m < empleados.Count(); m++)
                            {
                                if (h == empleados[m].GetFirstName())
                                {
                                    Console.WriteLine("Cual es el nuevo sueldo de" + h);
                                    int j = Convert.ToInt32(Console.ReadLine());
                                    empleados[m].ChangeSalary(j);
                                    Console.WriteLine("El sueldo de " + h + " ahora es de $" + j);
                                }
                            }
                        }
                        else if (u == "Jefe")
                        {
                            Console.WriteLine("Cual es el nombre?(Primer nombre)");
                            string h = Console.ReadLine();
                            for (int m = 0; m < jefes.Count(); m++)
                            {
                                if (h == jefes[m].GetFirstName())
                                {
                                    Console.WriteLine("Cual es el nuevo sueldo de" + h);
                                    int j = Convert.ToInt32(Console.ReadLine());
                                    jefes[m].ChangeSalary(j);
                                    Console.WriteLine("El sueldo de " + h + " ahora es de $" + j);
                                }
                            }
                        }
                        else if (u == "Supervisor")
                        {
                            Console.WriteLine("Cual es el nombre?(Primer nombre)");
                            string h = Console.ReadLine();
                            for (int m = 0; m < supervisores.Count(); m++)
                            {
                                if (h == supervisores[m].GetFirstName())
                                {
                                    Console.WriteLine("Cual es el nuevo sueldo de" + h);
                                    int j = Convert.ToInt32(Console.ReadLine());
                                    supervisores[m].ChangeSalary(j);
                                    Console.WriteLine("El sueldo de " + h + " ahora es de $" + j);
                                }
                            }
                        }
                        else if (u == "Auxiliar")
                        {
                            Console.WriteLine("Cual es el nombre?(Primer nombre)");
                            string h = Console.ReadLine();
                            for (int m = 0; m < auxiliares.Count(); m++)
                            {
                                if (h == auxiliares[m].GetFirstName())
                                {
                                    Console.WriteLine("Cual es el nuevo sueldo de" + h);
                                    int j = Convert.ToInt32(Console.ReadLine());
                                    auxiliares[m].ChangeSalary(j);
                                    Console.WriteLine("El sueldo de " + h + " ahora es de $" + j);
                                }
                            }
                        }
                    }
                }
                if (r == "3")
                {

                }

                Console.WriteLine("Desea realizar otra accion? si/no");
                string g = Console.ReadLine();
                if (g == "no")
                {
                    s++;
                }
            }

            


            Console.ReadLine();
        }

    }
}
