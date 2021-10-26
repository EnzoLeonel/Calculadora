using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    static class MVC
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Modelo modelo = new Modelo();
            Vista vista = new Vista();
            Controlador controlador = new Controlador(vista, modelo);
            vista.setControlador(controlador);
            Application.EnableVisualStyles();
            Application.Run(vista);
        }
    }
}
