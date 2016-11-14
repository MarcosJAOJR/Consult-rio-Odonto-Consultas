using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaSistemaConsultorio
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmPrincipal());
            }
            catch (Exception excecao)
            {
                MessageBox.Show("Não foi possível iniciar o sistema! Mensagem:" + excecao.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
