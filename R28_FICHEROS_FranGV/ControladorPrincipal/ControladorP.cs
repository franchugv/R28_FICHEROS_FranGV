using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R28_FICHEROS_FranGV.ControladorPrincipal
{
    public enum OpcionesPrincipal : byte { Salir, Añadir, Consultar }
    public static class ControladorP
    {
        
        public static void ControladorPrincipal()
        {
            // Recursos
            bool esValido;
            OpcionesPrincipal opcion = OpcionesPrincipal.Salir;
            string mError = "";

            do
            {
                esValido = true;
                try
                {

                }
                catch (Exception error)
                {
                    esValido = false;
                    mError = error.Message;
                }
                finally
                {
                    if(!esValido) 
                }

            } while (!esValido || opcion != OpcionesPrincipal.Salir);

            
        }
    }
}
