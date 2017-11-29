using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CAPA_USUARIO
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

            frmInicio form1 = new frmInicio();    //Creates the form
            Application.Run(form1);       //Runs the form. Program.cs will continue after the form closes



            //Get rid of form1 if you choose
            form1.Dispose();
            Application.Run(new Login());
            
        }
    }
}
