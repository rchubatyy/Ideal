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
using Ideal.Classes.Template_Method;

namespace Ideal
{
    public partial class fPaginaPrincipal : Form
    {
        private static int idIdeia_activa;

        public fPaginaPrincipal()
        {
            //buscar ultimo login
            string sql = "select TOP 1 Data from Sessao,Conta where Sessao.idConta = Conta.idConta and Conta.idConta = '"+ Program.IdContaActiva +"' Order BY Data DESC";
            SB_DB buscarUltimeLogin = new SB_DB(sql, 1, "select");
            buscarUltimeLogin.Run();

            InitializeComponent();
            btgrupos.Hide();

            //Preencher os labels
            lbusername.Text = Program.IdSessao;
            lbultimologin.Text = buscarUltimeLogin.List[0];

            dgvideiasrecentes.AllowUserToAddRows = false;

            //Preencher as colunas da datagridview
            dgvideiasrecentes.Columns.Add("idIdeia", "idIdeia");
            dgvideiasrecentes.Columns.Add("Titulo", "Título");
            dgvideiasrecentes.Columns.Add("Criado", "Criado Por");

            //Buscar as ideias por ordem descrecente da data
            sql = "select Ideia.idIdeia, Ideia.Titulo, Username from Ideia INNER JOIN Conta ON Ideia.idConta = Conta.idConta ORDER BY Data DESC";
            SB_DB buscarIdeiasRecentes = new SB_DB(sql, 3, "select");
            buscarIdeiasRecentes.Run();

            //Preencher a datagridView com Subscriçoes
            for (int i = 2; i < buscarIdeiasRecentes.List.Count; i = i + 3)
            {
                dgvideiasrecentes.Rows.Add(buscarIdeiasRecentes.List[i - 2], buscarIdeiasRecentes.List[i - 1], buscarIdeiasRecentes.List[i]);
            }
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            //Inserir uma Sessao associada a conta
            string dataUltimoLogin = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string sql = "insert into Sessao (Data,idConta) values ('" + dataUltimoLogin + "','" + Program.IdContaActiva + "')";
            SB_DB inseriSessao = new SB_DB(sql, 1, "insert");
            inseriSessao.Run();
            MessageBox.Show("Volte Sempre!");

            var formLogin = new Welcome();
            this.Hide();
            formLogin.Show();
        }

        private void dgvideiasrecentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvideiasrecentes.Rows[e.RowIndex];
                idIdeia_activa = Convert.ToInt32(row.Cells["idIdeia"].Value.ToString());
            }
        }

        private void dgvideiasrecentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                fIdeia verIdeia = new fIdeia(idIdeia_activa);
                this.Hide();
                verIdeia.Show();
            }
        }

        private void btpesquisaideias_Click(object sender, EventArgs e)
        {
            fPesquisarIdeia pesquisar = new fPesquisarIdeia();
            this.Hide();
            pesquisar.Show();
        }

        private void btversubscricao_Click(object sender, EventArgs e)
        {
            fVerSubscricao versubscricao = new fVerSubscricao();
            this.Hide();
            versubscricao.Show();
        }

        private void btcriarideia_Click(object sender, EventArgs e)
        {
            fCriarIdeia criarIdeia = new fCriarIdeia();
            this.Hide();
            criarIdeia.Show();
        }

        private void btgrupos_Click(object sender, EventArgs e)
        {

        }

        private void btmeuperfil_Click(object sender, EventArgs e)
        {
            Profile verProfile = new Profile();
            this.Hide();
            verProfile.Show();
        }
    }
}
