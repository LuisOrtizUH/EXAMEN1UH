using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Clases
{
    internal class Vendedores
    {

        public Vendedores()
        {
        }
        public void ListadodelosVendedores()
        {

            Dictionary<string, string> Vendedores = new Dictionary<string, string>();
            Vendedores.Add("2223", "Luis Ortiz");
            Vendedores.Add("1718", "Carlos Ortiz");

            foreach (var ven in Vendedores)
            {
                Console.WriteLine($"Llave: {ven.Key} Nombre:{ven.Value}");
            }
            Console.Read();

        }

    }


}
