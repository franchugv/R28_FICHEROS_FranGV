using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R28_FICHEROS_FranGV.APIFichero
{
    public static class APIFichero
    {

        // RECURSOS

        private const string RUTA = "Nombres.txt";

        public static void CrearFichero()
        {
            // Recursos

            StreamWriter Escritor;

            Escritor = File.CreateText(RUTA);

            Escritor.Close();
        }

        public static void EscribirFichero(string nombre)
        {
            // Recursos

            StreamWriter Escritor;
           
            
            if (!File.Exists(RUTA)) CrearFichero();

            File.AppendAllText(RUTA, $"{nombre}\ns");



        }
    }
}
