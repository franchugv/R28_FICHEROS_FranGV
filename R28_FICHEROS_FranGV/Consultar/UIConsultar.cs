using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R28_FICHEROS_FranGV.Consultar
{
    public static class UIConsultar
    {
        public static void MostrarDatos()
        {
            Console.Clear();
            Console.WriteLine($"\n{APIFichero.APIFichero.ConsultarFichero()}");

            Metodos.Metodos.Pausa();

        }
    }
}
