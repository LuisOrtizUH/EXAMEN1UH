using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{

  
        internal class Vehiculos : Tipo


        {
            static int[] Codigos = new int[5];
            static String[] Marcas = new string[5];
            static int[] Costos = new int[5];
            static String[] Modelos = new string[5];
            static int Valor = 1;

            

            public Vehiculos()
            {

            }

            public Vehiculos(string codigo, string marca, string costo, string modelo)
            {


            }
            public  void Agrega(string v)//Agrega cosas

            {

                Console.WriteLine("Ingrese el codigo del vehiculo"); Codigos[Valor] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la marca del vehiculo"); Marcas[Valor] = Console.ReadLine();
                Console.WriteLine("Ingrese el año del vehiculo"); Modelos[Valor] = Console.ReadLine();
                Console.WriteLine("Ingrese el costo del del vehiculo"); Costos[Valor] = int.Parse(Console.ReadLine());
                Valor++;
            }

            public  void Mostrar()//Me muestra cosas
            {

                int Valor;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Marca:{Marcas[i]}");
                    Console.WriteLine($"Modelo:{Modelos[i]}");
                    Console.WriteLine($"costo:{Costos[i]}");
                }

            }

            public void ModificaVehiculo(string c)//Modificar Cosas
            {

                int Valor;
                Boolean Existe = false;
                Console.WriteLine("Digite el codigo del vehiculo que desea modificar"); Valor = int.Parse(Console.ReadLine());
                for (int i = 0; i < 5; i++)
                {
                    if (Valor == Codigos[i])
                    {

                        Console.WriteLine("Ingrese la marca del vehiculo"); Marcas[Valor] = Console.ReadLine();
                        Console.WriteLine("Ingrese el año del vehiculo"); Modelos[Valor] = Console.ReadLine();
                        Console.WriteLine("Ingrese el costo del vehiculo"); Costos[Valor] = int.Parse(Console.ReadLine());
                        Existe = true;
                    }
                }
                if (!Existe) Console.WriteLine("El vehiculo ingresado no lo encontramos");

            }

            public void ConsultaVehiculo(string c)
            {

                int Valor;
                Boolean Existe = false;
                Console.WriteLine("Ingrese el codigo del vehiculo que desea buscar"); Valor = int.Parse(Console.ReadLine());
                for (int i = 0; i < 5; i++)
                {
                    if (Valor == Codigos[i])
                    {
                        Console.WriteLine($"Marca:{Marcas[i]}");
                        Console.WriteLine($"Modelo:{Modelos[i]}");
                        Console.WriteLine($"costo:{Costos[i]}");
                        Existe = true;
                    }
                }
                if (!Existe) Console.WriteLine("El vehiculo que ingresaste no existe o no lo encontramos");
            }

            public void VentasCorrectas(string v)
            {

                int Valor;
                Boolean Existe = false;
                Console.WriteLine("Ingrese el codigo del vehiculo que desea buscar"); Valor = int.Parse(Console.ReadLine());
                for (int i = 0; i < 5; i++)
                {
                    if (Valor == Codigos[i])
                    {
                        Console.WriteLine($"Marca:{Marcas[i]}");
                        Console.WriteLine($"Modelo:{Modelos[i]}");
                        Console.WriteLine($"costo:{Costos[i]}");
                        Existe = true;
                    }
                }
                if (!Existe) Console.WriteLine("El vehiculo que ingresaste no existe o no lo encontramos");
                {

                }




            }


        }
    }

    
   

    
