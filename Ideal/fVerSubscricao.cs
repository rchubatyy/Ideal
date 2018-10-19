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

namespace Ideal
{
    public partial class fVerSubscricao : Form
    {
        private static int idIdeia_activa;

        public fVerSubscricao()
        {
            //Buscar a lista subscricao da conta
            InitializeComponent();

            datagvsubscricao.AllowUserToAddRows = false;

            //Preencher as colunas da dataGridView
            datagvsubscricao.Columns.Add("idIdeia", "idIdeia");
            datagvsubscricao.Columns.Add("Titulo", "Título");
            datagvsubscricao.Columns.Add("Data", "Data de Subscrição");

            //Buscar as subscrições da conta
            string sql = "select Subscricao.idIdeia, Ideia.Titulo, Subscricao.Data from Subscricao Inner join Conta ON Subscricao.idConta = Conta.idConta inner join Ideia ON Subscricao.idIdeia = Ideia.idIdeia Where Conta.idConta = '"+ Program.IdContaActiva +"'";
            SB_DB buscarSub = new SB_DB(sql, 3, "select");
            buscarSub.Run();

            //Preencher a datagridView com Subscriçoes
            for (int i = 2; i < buscarSub.List.Count; i=i+3)
            {
                datagvsubscricao.Rows.Add(buscarSub.List[i-2], buscarSub.List[i-1], buscarSub.List[i]);
            }
        }

        private void datagvsubscricao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = datagvsubscricao.Rows[e.RowIndex];
                idIdeia_activa = Convert.ToInt32(row.Cells["idIdeia"].Value.ToString());
            }
        }

        private void datagvsubscricao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                fIdeia verIdeia = new fIdeia(idIdeia_activa);
                this.Hide();
                verIdeia.Show();
            }
        }

        private void btapagar_Click(object sender, EventArgs e)
        {
           foreach (DataGridViewCell oneCell in datagvsubscricao.SelectedCells)
           {
                if (oneCell.Selected)
                {
                    //Eliminar na base de dados a subscrição dessa ideia do utilizador acitvo
                    string sql = "delete from Subscricao where idConta = '" + Program.IdContaActiva + "' and idIdeia = '" + idIdeia_activa + "'";
                    SB_DB eliminarSub = new SB_DB(sql, 1, "insert");
                    eliminarSub.Run();
                    datagvsubscricao.Rows.RemoveAt(oneCell.RowIndex);
                }
            }
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            //Voltar a pagina Principal
            fPaginaPrincipal voltarPaginaPrincipal = new fPaginaPrincipal();
            this.Hide();
            voltarPaginaPrincipal.Show();
        }
    }
}
