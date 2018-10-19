using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ideal.Classes.Template_Method;

namespace Ideal
{
    public partial class fPesquisarIdeia : Form
    {
        private static int idIdeia_activa;

        public fPesquisarIdeia()
        {
            InitializeComponent();

            dgvpesquisaideias.AllowUserToAddRows = false;

            //Preencher as colunas da dataGridView
            dgvpesquisaideias.Columns.Add("idIdeia", "idIdeia");
            dgvpesquisaideias.Columns.Add("Titulo", "Título");
            dgvpesquisaideias.Columns.Add("Data", "Data");
            dgvpesquisaideias.Columns.Add("Username", "Criado Por");
        }

        private void dgvpesquisaideias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvpesquisaideias.Rows[e.RowIndex];
                idIdeia_activa = Convert.ToInt32(row.Cells["idIdeia"].Value.ToString());
            }
        }

        private void dgvpesquisaideias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                fIdeia verIdeia = new fIdeia(idIdeia_activa);
                this.Hide();
                verIdeia.Show();
            }
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            //Voltar a pagina Principal
            fPaginaPrincipal voltarPaginaPrincipal = new fPaginaPrincipal();
            this.Hide();
            voltarPaginaPrincipal.Show();
        }

        private void btpesquisa_Click(object sender, EventArgs e)
        {
            //Limpar a datagridview
            dgvpesquisaideias.Rows.Clear();

            //Buscar as ideias por ordem descrecente da data
            string sql = "select distinct Ideia.idIdeia, Ideia.Titulo,Ideia.Data, Username " +
                         "from Tag,Ideia " +
                         "INNER JOIN Conta ON Ideia.idConta = Conta.idConta " +
                         "INNER JOIN Categoria ON Ideia.idCategoria = Categoria.idCategoria" +
                         " where Ideia.Estado LIKE '%"+ txtpesquisa.Text + "%' " +
                         "OR Ideia.Mensagem LIKE '%" + txtpesquisa.Text + "%' " +
                         "OR Ideia.Titulo LIKE '%" + txtpesquisa.Text + "%' " +
                         "OR Conta.Username LIKE '%" + txtpesquisa.Text + "%'" +
                         " OR Categoria.Tipo LIKE '%" + txtpesquisa.Text + "%' " +
                         "OR Tag.Nome LIKE '%" + txtpesquisa.Text + "%'";
            SB_DB buscarIdeiasRecentes = new SB_DB(sql, 4, "select");
            buscarIdeiasRecentes.Run();

            //Preencher a datagridView com Subscriçoes
            for (int i = 3; i < buscarIdeiasRecentes.List.Count; i = i + 4)
            {
                dgvpesquisaideias.Rows.Add(buscarIdeiasRecentes.List[i - 3], buscarIdeiasRecentes.List[i - 2], buscarIdeiasRecentes.List[i - 1], buscarIdeiasRecentes.List[i]);
            }

            //Limpar a textBox da pesquisa
            txtpesquisa.Text = "";
        }
    }
}
