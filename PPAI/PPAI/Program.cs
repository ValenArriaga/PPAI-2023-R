using PPAI.Services;
using PPAI.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PantallaRegistrarRespuesta pantalla = new PantallaRegistrarRespuesta();
            List<string> v = new List<string>();
            v.Add("v1");
            v.Add("v2");
            v.Add("v3");
            v.Add("v4");
            v.Add("v5");
            pantalla.MostrarValidaciones(v);
            pantalla.MostrarDatosLlamada("Valentin", "Cat", "opc", "subOp");
            Application.Run(pantalla);
        }
    }
}
