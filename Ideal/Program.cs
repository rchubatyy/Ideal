using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIS_Ideial;
using Ideal.Classes;
using Ideal.Classes.Factory;

namespace Ideal
{
    static class Program
    {
        private static string idSessao;
        private static int idConta_activa;

        public static string IdSessao
        {
            get { return idSessao; }
            set { idSessao = value; }
        }

        public static int IdContaActiva
        {
            get { return idConta_activa; }
            set { idConta_activa = value; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Welcome());
        }
    }
}
