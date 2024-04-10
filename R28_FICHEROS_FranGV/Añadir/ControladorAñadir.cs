using R28_FICHEROS_FranGV.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R28_FICHEROS_FranGV.Añadir
{
    public static class ControladorAñadir
    {
        public static void ControladorA()
        {
            bool esValido;
            string mError = "";
            string cadena = "";

            do
            {
                esValido = true;
                UIAñadir.MenuAñadir();
                try
                {
                    cadena = Metodos.Metodos.CaptarCadena();
                    // Verificar que no se repita
                    if (APIFichero.APIFichero.VerificarRepeticion(cadena) == false) throw new InvalidDataException("Nombre repetido");

                    APIFichero.APIFichero.EscribirFichero(cadena); // Añadir cadena al fichero.

                    UIAñadir.FinEjecucionA();
                }
                catch(Exception Error)
                {
                    esValido = false;
                    mError = Error.Message;
                }
                finally
                {
                    if (!esValido) Metodos.Metodos.MostrarError(mError);
                }



            } while (!esValido);
        }
    }
}
