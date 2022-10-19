using Baseline.ImTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    internal class Tipo
    {
        public Tipo()

        {

        }

        List<String> Tipos = new List<string>() { "Motocicleta", "Automovil", "Dron" };
        int x = 0;


        public Boolean IndicarLista(string valor)
        {

            Boolean existe = Tipos.Contains(valor);

            return existe;

        }

        public void Lista()
        {

            for (int i = 0; i < Tipos.Count; i++)
            {

                Console.WriteLine(Tipos[i]);

            }
            Console.ReadLine();

        }
    }


}

