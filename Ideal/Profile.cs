using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ideal.Classes;
using Ideal.Classes.Factory;
using Ideal.Classes.Template_Method;
using Ideal.Classes.Validacao;

namespace Ideal
{
    public partial class Profile : Form
    {
        private static int idIdeia_activa;

        public Profile()
        {
            InitializeComponent();

            //buscar o info do Utilizador
            string sql = "select Nome,Apelido,Email,DataNascimento,Tipo from Conta INNER JOIN Perfil ON Conta.idConta = Perfil.idConta where Conta.idConta = '" + Program.IdContaActiva + "'";
            SB_DB buscarInfoConta = new SB_DB(sql, 5, "select");
            buscarInfoConta.Run();

            //Corrigir o label da data de nascimento
            string[] datanascimento = buscarInfoConta.List[3].Split(' ');

            //Preencher os labels consoante o info do Utilizador
            lbnome.Text = buscarInfoConta.List[0];
            lbapelido.Text = buscarInfoConta.List[1];
            lbemail.Text = buscarInfoConta.List[2];
            lbdatanascimento.Text = datanascimento[0];
            lbtipoconta.Text = buscarInfoConta.List[4];

            dgvminhasideias.AllowUserToAddRows = false;

            //Preencher as colunas da datagridview
            dgvminhasideias.Columns.Add("idIdeia", "idIdeia");
            dgvminhasideias.Columns.Add("Titulo", "Título");
            dgvminhasideias.Columns.Add("Data", "Data");

            //Buscar as ideias criadas pelo Utilizador Por
            sql = "select Ideia.idIdeia, Ideia.Titulo,Data from Ideia INNER JOIN Conta ON Ideia.idConta = Conta.idConta where Conta.idConta = '" + Program.IdContaActiva + "'";
            SB_DB buscarMinhasIdeias = new SB_DB(sql, 3, "select");
            buscarMinhasIdeias.Run();

            //Popular a datagridview
            for (int i = 2; i < buscarMinhasIdeias.List.Count; i = i + 3)
            {
                dgvminhasideias.Rows.Add(buscarMinhasIdeias.List[i - 2], buscarMinhasIdeias.List[i - 1], buscarMinhasIdeias.List[i]);
            }
        }

        private void dgvminhasideias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvminhasideias.Rows[e.RowIndex];
                idIdeia_activa = Convert.ToInt32(row.Cells["idIdeia"].Value.ToString());
            }
        }

        private void dgvminhasideias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                fIdeia verIdeia = new fIdeia(idIdeia_activa);
                this.Hide();
                verIdeia.Show();
            }
        }

        private void writeidea_Click(object sender, EventArgs e)
        {
            fCriarIdeia criarIdeia = new fCriarIdeia();
            this.Hide();
            criarIdeia.Show();
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            fPaginaPrincipal verPaginaPrincipal = new fPaginaPrincipal();
            this.Hide();
            verPaginaPrincipal.Show();
        }
    }
}
