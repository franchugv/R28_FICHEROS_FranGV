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

        // MÉTODOS

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


            // Verifica que exista el fichero, si no es así, lo creará automáticamente, aunque no estoy
            // Seguro de si AppendAllText lo hace también...
            VerificarExsistenciaFichero();

            File.AppendAllText(RUTA, $"{nombre}\n");





        }


        public static string ConsultarFichero()
        {
            // Recursos
            StreamReader Lector;
            string cadena = "";

            VerificarExsistenciaFichero();

            Lector = File.OpenText(RUTA);

            cadena = Lector.ReadToEnd(); // Este Método lee de inicio a fin

            Lector.Close();

            return cadena;
        }

        //public static bool VerificarRepeticion(string busqueda) MAL
        //{
        //    bool esCorrecto = true;


        //    char[] Nombres = new char[ConsultarFichero().Length];


        //    Nombres = ConsultarFichero().ToCharArray();

        //    for (int indice = 0; indice < ConsultarFichero().Length; indice++)
        //    {
        //        if (Nombres[indice].ToString().Contains(busqueda)) esCorrecto = false;

        //    }


        //    return esCorrecto;
        //}

        public static bool VerificarRepeticion(string busqueda)
        {
            bool esCorrecto = true;

            string fichero;

            fichero = ConsultarFichero().Replace("\n", "");

            if (busqueda.Contains(fichero)) esCorrecto = false; // Quitar Espacios


            return esCorrecto;
        }

        public static void VerificarExsistenciaFichero()
        {
            if (!File.Exists(RUTA)) CrearFichero();
        }

    }
}
