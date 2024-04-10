using R28_FICHEROS_FranGV.Consultar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R28_FICHEROS_FranGV.ControladorPrincipal
{
    public enum OpcionesPrincipal : byte { Salir, Añadir, Consultar, Verificar }

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
                UIPrincipal.UIPrincipal.UIP();

                esValido = true;
                try
                {
                    opcion = (OpcionesPrincipal)Metodos.Metodos.CaptarOpcionEnum((byte)Enum.GetValues<OpcionesPrincipal>().Length);


                    switch (opcion)
                    {
                        case OpcionesPrincipal.Salir:
                            break;
                        case OpcionesPrincipal.Añadir:
                            Añadir.ControladorAñadir.ControladorA();
                            break;
                        case OpcionesPrincipal.Consultar:
                            UIConsultar.MostrarDatos();
                            break;
                        case OpcionesPrincipal.Verificar:
                            break;
                    }

                }
                catch (Exception error)
                {
                    esValido = false;
                    mError = error.Message;
                }
                finally
                {
                    if(!esValido) Metodos.Metodos.MostrarError(mError);
                }

            } while (!esValido || opcion != OpcionesPrincipal.Salir);

            
        }
    }
}
