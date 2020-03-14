using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeNutri_Registros.Controllers;
using MeNutri_Registros.Views;

namespace MeNutri_Registros
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Condicao que nao permite mais de uma instância do software aberto por vez
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("A aplicação já está rodando, apenas uma instância é permitida.", "Execução bloqueada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Application.Run(new TelaLogin());
        }
    }
}
