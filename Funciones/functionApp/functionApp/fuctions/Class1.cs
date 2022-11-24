using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace functions
{
    //public: indica que la clase es de acceso público
    //static: permite utilizar los métodos de esta clase
    // sin necesidad de crear una insancia de la misma
    /// <summary>
    /// Calcula o devuelve una tabla de multiplicar.
    /// </summary>
    public static class Varias
    {
        public static string tablaMultiplicar(int tabla)
        {
            string aux = "";
            for (int k = 1; k <= 12; k++)
            {
                aux += $"{tabla} x {k} = {k * tabla}\r\n";
            }
            return aux;
        }
        public static bool validaUsuario(string usuario, string clave)
        {
            usuario = "devin";
            clave = "devin";
            return (usuario == "devin" && clave == "devin") ? true : false;
        }
    }
}

