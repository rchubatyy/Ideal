using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ideal;
using Ideal.Classes;
using Ideal.Classes.Factory;
using Ideal.Classes.Template_Method;
using Ideal.Classes.Validacao;

namespace DIS_Ideial
{
    public partial class fCriarUtilizador : Form
    {
        public fCriarUtilizador()
        {
            InitializeComponent();
            txtpassword.PasswordChar = '*';
            txtpasswordr.PasswordChar = '*';
        }

        private void btncriarutilizador_Click(object sender, EventArgs e)
        {

            VerificaUtilizador();

        }

        private void VerificaUtilizador()
        {
            IList<String> setofdata= new List<string>();

            setofdata.Add(txtnome.Text);
            setofdata.Add(txtapelido.Text);
            setofdata.Add(txtemail.Text);
            setofdata.Add(dtpdatadenascimento.Value.ToString());
            setofdata.Add(txtusername.Text);
            setofdata.Add(txtpassword.Text);
            setofdata.Add(txtpasswordr.Text);

            //Valida os Campos
            IValidation validarRegisto = RegistoValidation.Singleton();

            if (validarRegisto.Validar(setofdata))
            {
                MessageBox.Show("Inserção com sucesso: \n" +
                                "Username: " + txtusername.Text + "\n"+
                                "Password: " + txtpassword.Text + "\n" +
                                "Pode fazer o Login!");
                InserirConta();

                var formLogin = new Welcome();
                this.Hide();
                formLogin.Show();
            } 
        }

        private void InserirConta()
        {
            //Criar o Objeto
            Perfil p = new Perfil(txtnome.Text, txtapelido.Text, txtemail.Text, dtpdatadenascimento.Value);
            DateTime dataActual = DateTime.Now;

            var factory = new UtilizadorFactory();
            var myConta2 = factory.CreateConta(txtusername.Text, txtpassword.Text, 0, dataActual, p);

            //Insere na base de dados a Conta
            string sql = "insert into Conta (Username,Password,Tipo) values ('" + myConta2.Username + "','" + myConta2.Password + "','Utilizador')";
            AbstractDB inserirConta = new SB_DB(sql,1,"insert");
            inserirConta.Run();

            //Pesquisar o id da conta Inserida
            sql = "Select idConta from Conta where username = '"+myConta2.Username+"'";
            SB_DB procurarIdConta = new SB_DB(sql,1,"select");
            procurarIdConta.Run();
            int idConta =Convert.ToInt32(procurarIdConta.List[0]);

            //Inserir o Perfil consoante a conta
            string dataNascimento = myConta2.Perfil.DataNascimento.ToString("yyyy-MM-dd HH:mm:ss");
            sql = "insert into Perfil (Nome,Apelido,Email,DataNascimento,idConta) values ('" + myConta2.Perfil.PrimeiroNome + "','" + myConta2.Perfil.UltimoNome + "','" + myConta2.Perfil.Email + "','" + dataNascimento + "','" + idConta + "')";
            SB_DB inseriPerfil= new SB_DB(sql,1,"insert");
            inseriPerfil.Run();

            //Inserir o Perfil consoante a conta
            string dataUltimoLogin = myConta2.UltimeLogin.ToString("yyyy-MM-dd HH:mm:ss");
            sql = "insert into Sessao (Data,idConta) values ('" + dataUltimoLogin + "','" + idConta + "')";
            SB_DB inseriSessao = new SB_DB(sql,1,"insert");
            inseriSessao.Run();
        }

        private void btvlogin_Click(object sender, EventArgs e)
        {
            var formLogin = new Welcome();
            this.Hide();
            formLogin.Show();
        }
    }
}
