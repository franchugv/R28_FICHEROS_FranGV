using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R28_FICHEROS_FranGV.Verificar
{
    public static class ControladorVerificar
    {
        public static void ControladorV()
        {
            // RECURSOS 

            string cadena = "";
            string aux = "";
            bool esValido = true;

            UIVerificar.MenuVerificar();

            cadena = Metodos.Metodos.CaptarCadena();

            esValido = APIFichero.APIFichero.VerificarRepeticion(cadena);

            if (esValido) Metodos.Metodos.MostrarDato("No se repite. ");
            else Metodos.Metodos.MostrarDato("Se repite. ");
        }
    }
}
