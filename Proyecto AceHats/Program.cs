﻿using Proyecto_AceHats.Forms;
using Proyecto_AceHats.Forms.RegularForms;
using Proyecto_AceHats.Forms.AdminForms;
using Proyecto_AceHats.Forms.RegularForms.subForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_AceHats
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formInv(null));
        }
    }
}
