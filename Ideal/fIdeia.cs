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
    public partial class fIdeia : Form
    {
        private static int idIdeia_activa;
        private static int rating_ideia_Conta;
        private static IList<Comentario> comentarios;

        public fIdeia(int idIdeia)
        {
            idIdeia_activa = idIdeia;
            InitializeComponent();
            InserirVotarComboBox();

            //Buscar o Info da Ideia
            string sql = "select * from Ideia where idIdeia = '" + idIdeia + "'";
            SB_DB buscarIdeia = new SB_DB(sql, 8, "select");
            buscarIdeia.Run();
       
            //Preenchar as variaveis da ideia q vao preencher os Labels da form
            string titulo = buscarIdeia.List[1];
            string mensagem = buscarIdeia.List[2];
            string estado = buscarIdeia.List[3];
            int idContaDaIdeia = Convert.ToInt32(buscarIdeia.List[7]);

            //Buscar o Info A tag associada a Ideia
            sql = "select Tag.Nome from Ideia_Tag INNER JOIN Tag ON Ideia_Tag.idTag = Tag.idTag where idIdeia = '" + idIdeia + "'";
            SB_DB buscarTag = new SB_DB(sql, 1, "select");
            buscarTag.Run();

            //Buscar a categoria associada a Ideia
            sql = "select Categoria.Tipo from Categoria INNER JOIN Ideia ON Categoria.idCategoria= Ideia.idCategoria where idIdeia = '" + idIdeia + "'";
            SB_DB buscarCategoria = new SB_DB(sql, 1, "select");
            buscarCategoria.Run();

            //Buscar o criador da ideia
            sql = "select Username from Conta where idConta = '" + idContaDaIdeia + "'";
            SB_DB buscarUsername = new SB_DB(sql, 1, "select");
            buscarUsername.Run();

            GetRatingLabel();

            //Definir o groupBox da ideia
            txttitulo.Text = titulo;
            txtcategoria.Text = buscarCategoria.List[0];
            txtusername.Text = buscarUsername.List[0];
            rtbmensagem.Text = mensagem;
            lbestado.Text = estado;


            //Verifica se tem Tags
            if (buscarTag.List.Count > 0)
                txttag.Text = buscarTag.List[0];
            else
                txttag.Text = "Sem Tags Associada";

            //Botão subescrever/não subscrever
            VerificaSubscricao();

            //Buscar os comentários da Ideia
            sql = "select idComentario,Mensagem,Data,idIdeia,Username,Comentario.idConta from Comentario, Conta where idIdeia = '" + idIdeia_activa + "'and Comentario.idConta = Conta.idConta";
            SB_DB buscarComentario = new SB_DB(sql, 5, "select");
            buscarComentario.Run();

            List<List<string>> cometario = Split(buscarComentario.List,5);

            //Criar os comentarios e inserir na lista dos cometários
            comentarios = new List<Comentario>();

            //buscar objeto do comentário
            //Comentario coment = new Comentario(cometario[row+0][row], Convert.ToDateTime(cometario[row + 1][row]), cometario[row + 3][row]);

            for (int col = 0; col < cometario.Count; col++)
            {
                //Buscar o Username da criador do Comentario
                sql = "select Username from Comentario, Conta where Comentario.idConta = Conta.idConta and idComentario = '" + cometario[col][0] + "'";
                SB_DB buscarCriadorComentario = new SB_DB(sql, 1, "select");
                buscarCriadorComentario.Run();


                comentario userComentario = new comentario();
                userComentario.setTxtUsername(buscarCriadorComentario.List[0]);
                userComentario.setTxtmensagem(cometario[col][1]);
                userComentario.setTxtdata(cometario[col][2]);
                flowLayoutPanel1.Controls.Add(userComentario);
                }
        }

        private void GetRatingLabel()
        {
            string sql;

            //Buscar o Rating da Ideia
            sql = "select Valor from Rating, ideia where Rating.idIdeia = '" + idIdeia_activa + "' and Ideia.idIdeia = '" +
                  idIdeia_activa + "'";
            SB_DB buscarRating = new SB_DB(sql, 1, "select");
            buscarRating.Run();

            int rating = 0;

            for (int i = 0; i < buscarRating.List.Count; i++)
            {
                rating = rating + Convert.ToInt32(buscarRating.List[i]);
            }

            if (buscarRating.List.Count > 0)
            {
                rating = rating/Convert.ToInt32(buscarRating.List.Count);
            }

            lbrating.Text = rating.ToString();
        }

        private void InserirVotarComboBox()
        {
            cmbvotar.Items.Add(" ");
            cmbvotar.SelectedItem = " ";
            cmbvotar.Items.Add("1");
            cmbvotar.Items.Add("2");
            cmbvotar.Items.Add("3");
            cmbvotar.Items.Add("4");
            cmbvotar.Items.Add("5");

            //Qual é o botão a mostar
            VerificarVotacao();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //buscar Conta
            //Criar novo comentário
            // var novoComentario = new Comentario(rtbcomentario.Text, DateTime.Now, myConta2);

            comentario userComentario = new comentario();
            userComentario.setTxtUsername(Program.IdSessao);
            userComentario.setTxtmensagem(rtbcomentario.Text);
            userComentario.setTxtdata(DateTime.Now.ToString());
            flowLayoutPanel1.Controls.Add(userComentario);

            //Inserir a ideia na base de dados
            string sql = "insert into Comentario (Mensagem,Data,idIdeia,idConta) values ('" + rtbcomentario.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + idIdeia_activa + "','" + Program.IdContaActiva + "')";
            AbstractDB inserirComentario = new SB_DB(sql, 1, "insert");
            inserirComentario.Run();

            //limpar o rtb do comentario
            rtbcomentario.Text = "";
        }

        private void btsubscrever_Click(object sender, EventArgs e)
        {
            //Inserir na base de dados a subscrição
            string sql = "insert into Subscricao (Data,idIdeia,idConta) values ('" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + idIdeia_activa + "','" + Program.IdContaActiva + "')";
            AbstractDB inserirComentario = new SB_DB(sql, 1, "insert");
            inserirComentario.Run();


            //Actualizar o botão
            VerificaSubscricao();
        }

        private void btnsubscrever_Click(object sender, EventArgs e)
        {
            //Eliminar na base de dados a subscrição dessa ideia do utilizador acitvo
            string sql = "delete from Subscricao where idConta = '" + Program.IdContaActiva + "' and idIdeia = '" + idIdeia_activa + "'";
            SB_DB eliminarSub = new SB_DB(sql, 1, "insert");
            eliminarSub.Run();


            //Actualizar o botão
            VerificaSubscricao();
        }


        private void VerificaSubscricao()
        {
            var sub = false;

            //Buscar as subscrições do utilizador e verificar já fez a subscrição dessa Ideia
            string sql = "select idSubscricao from Subscricao, Conta where Subscricao.idConta = '" + Program.IdContaActiva + "' and idIdeia = '" + idIdeia_activa + "'";
            SB_DB buscarIdeia = new SB_DB(sql, 1, "select");
            buscarIdeia.Run();

            //verifica está subscrito
            if (buscarIdeia.List.Count > 0)
                sub = true;

            if (!sub)
            {
                btsubscrever.Show();
                btnsubscrever.Hide();
            }
            else
            {
                btsubscrever.Hide();
                btnsubscrever.Show();
            }
        }

        private void VerificarVotacao()
        {
            var sub = false;

            //Buscar as subscrições do utilizador e verificar já fez a subscrição dessa Ideia
            string sql = "select Rating.Valor from Rating " +
                         "INNER JOIN Conta ON Rating.idConta = Conta.idConta " +
                         "INNER JOIN Ideia ON Rating.idIdeia = Ideia.idIdeia " +
                         "Where Rating.idConta = '" + Program.IdContaActiva + "' " +
                         "and Rating.idIdeia = '" + idIdeia_activa + "'";
            SB_DB buscarVotar = new SB_DB(sql, 1, "select");
            buscarVotar.Run();

            //Se a conta tiver já uma votação a ideia definir o rating_ideia_Conta
            if (buscarVotar.List.Count >0)
                rating_ideia_Conta = Convert.ToInt32(buscarVotar.List[0]);

            //verifica se realizou a votação
            if (buscarVotar.List.Count > 0)
                sub = true;

            if (!sub)
            {
                btvotar.Show();
                btalterarvotaçao.Hide();
            }
            else
            {
                btvotar.Hide();
                btalterarvotaçao.Show();
            }
        }

        //Criar uma Matriz a partir de uma Lista
        public static List<List<string>> Split(List<string> source, int colunas)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / colunas)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            fPaginaPrincipal verPaginaPrincipal = new fPaginaPrincipal();
            this.Hide();
            verPaginaPrincipal.Show();
        }

        private void btalterarvotaçao_Click(object sender, EventArgs e)
        {
            if (!cmbvotar.SelectedItem.ToString().Equals(" "))
            {
                //Update do Rating consoante a ideia e a Conta
                string sql = "UPDATE Rating SET Valor = '"+ Convert.ToInt32(cmbvotar.SelectedItem.ToString()) + "' WHERE Rating.idIdeia = '" + idIdeia_activa + "' and Rating.idConta = '" + Program.IdContaActiva + "'";
                SB_DB buscarIdeia = new SB_DB(sql, 1, "select");
                buscarIdeia.Run();

                MessageBox.Show("O Rating foi Alterado para esta Ideia.");

                GetRatingLabel();
            }
            else
            MessageBox.Show("Escolha um Rating.");
        }

        private void btvotar_Click(object sender, EventArgs e)
        {
            //Verifica se tem valores na comboBox de votar
            if (!cmbvotar.SelectedItem.ToString().Equals(" "))
            {
                //Inserção do Rating consoante a ideia e a Conta
                string sql = "insert into Rating (Valor,Data,idIdeia,idConta) values ('" + cmbvotar.SelectedItem.ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + idIdeia_activa + "','" + Program.IdContaActiva + "')";
                SB_DB buscarIdeia = new SB_DB(sql, 1, "select");
                buscarIdeia.Run();

                //Verificar a comboBox do rating
                VerificarVotacao();

                GetRatingLabel();
            }
        }
    }
}
