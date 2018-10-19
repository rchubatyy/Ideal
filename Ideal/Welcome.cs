using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DIS_Ideial;
using Ideal.Classes;
using Ideal.Classes.Factory;
using Ideal.Classes.Template_Method;
using Ideal.Classes.Validacao;

namespace Ideal
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            txtpassword.PasswordChar = '*';
        }


        private void loginbutton_Click(object sender, EventArgs e)
        {
            //Verificar se o Login está correcto
            string sql = "select idConta,Username , Password from Conta where Username = '"+ txtusername.Text +"' And Password = '"+ txtpassword.Text +"'";
            SB_DB buscarLogin = new SB_DB(sql,3,"select");
            buscarLogin.Run();

            IList<String> resultado = buscarLogin.List;

            if (resultado.Count == 0)
            {
                MessageBox.Show("Username ou Password Erradas");
            }
            else
            {
                MessageBox.Show("Login com Sucesso.");

                //Defenir o id da sessão
                Program.IdSessao = txtusername.Text;
                Program.IdContaActiva = Convert.ToInt32(buscarLogin.List[0]);

                //Mostrar a Página principal
                fPaginaPrincipal verPaginaPricinpal = new fPaginaPrincipal();
                this.Hide();
                verPaginaPricinpal.Show();
            }
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            fCriarUtilizador formCriarUtilizadorcriar = new fCriarUtilizador();
            this.Hide();
            formCriarUtilizadorcriar.Show();
        }
    }
}
