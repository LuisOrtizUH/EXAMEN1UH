using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases
{
    internal class Menu
    {

        static Menu() { }

        public static void MenuPrincipal()

        {
            Vendedores Vende = new Vendedores();
            byte Valor = 1;
            Tipo tipo = new Tipo();
           Vehiculos vehi = new Vehiculos();


            do
            {


                Console.Write("1* ");

                Console.WriteLine("Vehiculos");

                Console.Write("2* ");

                Console.WriteLine("Ventas");

                Console.Write("3* ");

                Console.WriteLine("Reportes");

                Console.Write("4* ");

                Console.WriteLine("Salir");

                Console.Write("Digite la opcion a elegir: ");
                Valor = byte.Parse(Console.ReadLine());
                Console.Clear();
                Tipo t = new Tipo();
                switch (Valor)
                {
                    case 1: SubMenuVentas(); break;
                    case 3: Vende.ListadodelosVendedores(); tipo.Lista(); vehi.Mostrar(); break;
                    case 4:
                        Console.WriteLine("Muy amable,  Hasta Luego");
                        break;
                    default:
                        break;
                }
            } while (Valor != 4);

        }

        public static void SubMenuVentas()
        {
            Vehiculos vehi = new Vehiculos();
            byte Valor = 1;
            do
            {

                Console.WriteLine("Elegiste la opcion Vehiculos");

                Console.Write("1* ");
                Console.WriteLine("Agregar");
                Console.Write("2* ");
                Console.WriteLine("Modificar");
                Console.Write("3* ");
                Console.WriteLine("Consultar");

                Console.Write("4-*");
                Console.WriteLine("Salir");
                Console.WriteLine("-------------------------");
                Console.Write("Digite la opcion a elegir: ");
                Valor = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (Valor)
                {
                    case 1: vehi.Agrega("1"); break;
                    case 2:vehi.ModificaVehiculo ("2"); break;
                    case 3: vehi.ModificaVehiculo("3"); break;
                    case 4:
                        Menu.MenuPrincipal(); break;


                }
            } while (Valor != 5);

        }

    }

}

