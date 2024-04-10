using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R28_FICHEROS_FranGV.Añadir
{
    public static class UIAñadir
    {
        public static void MenuAñadir()
        {
            Console.Clear();
            Console.Write("Escriba el nombre que desea añadir: ");
        }

        public static void FinEjecucionA()
        {
            Console.WriteLine("¡Fichero añadido de forma exitosa!");
            Metodos.Metodos.Pausa();
        }
    }
}
