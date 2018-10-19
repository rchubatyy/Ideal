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
    public partial class fCriarIdeia : Form
    {
        private static IList<Categoria> categoriaLista = new List<Categoria>(); 
        public fCriarIdeia()
        {
            InitializeComponent();
            InserirCatComboBox();
        }

        private void InserirCatComboBox()
        {
            //Defenir os parametros da combobox
            cmbcategoria.Items.Add("Selecionar");
            cmbcategoria.SelectedItem = "Selecionar";

            // Buscar a lista de categorias a base de dados
            string sql = "select * from Categoria";
            SB_DB buscarCategorias = new SB_DB(sql, 2, "select");
            buscarCategorias.Run();
 
            //Preencher a combobox Consoante o resulta da busca
            for (int i = 0; i < buscarCategorias.List.Count; i++)
            {
                i++;
                cmbcategoria.Items.Add(buscarCategorias.List[i]);
                var cat = new Categoria(Convert.ToInt32(buscarCategorias.List[i - 1]), buscarCategorias.List[i]);
                categoriaLista.Add(cat);
            }
        }

        private void btcriarIdeia_Click(object sender, EventArgs e)
        {
            IList<String> setofdata = new List<string>();
            setofdata.Add(txttitulo.Text);
            setofdata.Add(txttag.Text);
            setofdata.Add(cmbcategoria.SelectedItem.ToString());
            setofdata.Add(rtbmensagem.Text);
            IValidation validarIdeia = CriarIdeiaValidation.Singleton();

            //Validação dos Campos
            if (validarIdeia.Validar(setofdata))
            {
                var categoria = new Categoria("");

                //buscar a categoria selecionada na combobox na lista de categorias
                foreach (var cat in categoriaLista)
                {
                    if (cat.Tipo == cmbcategoria.SelectedItem.ToString())
                    {
                        categoria.Id = cat.Id;
                        categoria.Tipo = cat.Tipo;
                    }
                }

                //Inserir a ideia da ideia na base de dados
                string sql = "insert into Ideia (Titulo,Mensagem,Estado,Data,idGrupo,idCategoria,idConta) values ('" + txttitulo.Text + "','" + rtbmensagem.Text + "','Aberto','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',NULL,'" + categoria.Id + "','" + Program.IdContaActiva + "')";
                SB_DB inseriSessao = new SB_DB(sql, 1, "insert");
                inseriSessao.Run();

                //Ver se a ideia vem com Tag preenchida
                if (!txttag.Text.Equals(""))
                {
                    //Buscar o Id da novoa ideia Criada
                    string sql2 = "select MAX(Ideia.idIdeia)from Ideia";
                    SB_DB novaIdIdeia = new SB_DB(sql2, 1, "select");
                    novaIdIdeia.Run();

                    //Verificar se tem a Tag na base de dados
                    string sql1 = "select idTag from Tag where Nome = '" + txttag.Text + "'";
                    SB_DB verificaTag = new SB_DB(sql1, 1, "select");
                    verificaTag.Run();

                    int idIdeiaNova = Convert.ToInt32(novaIdIdeia.List[0]);

                    if (verificaTag.List.Count > 0)
                    {
                        //Inserir a ideia na Tag ja existente - Tabela Ideia_Tag
                        sql1 = "insert into Ideia_Tag (idIdeia,idTag) values ('" + idIdeiaNova + "','" + Convert.ToInt32(verificaTag.List[0]) + "')";
                        SB_DB inseriTagIdeia = new SB_DB(sql1, 1, "insert");
                        inseriTagIdeia.Run();
                    }
                    else
                    {
                        //Inserir a nova Tag na Base de dados
                        sql1 = "insert into Tag (Nome,Data) values ('" + txttitulo.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                        SB_DB inseriTag = new SB_DB(sql1, 1, "insert");
                        inseriTag.Run();

                        //Buscar o Id da nova Tag Criada
                        sql1 = "select MAX(Tag.idTag)from Tag";
                        SB_DB novaTag = new SB_DB(sql1, 1, "select");
                        novaTag.Run();

                        //Inserir a ideia na Tag ja existente - Tabela Ideia_Tag
                        sql1 = "insert into Ideia_Tag (idIdeia,idTag) values ('" + idIdeiaNova + "','" + Convert.ToInt32(novaTag.List[0]) + "')";
                        SB_DB inseriTagIdeia = new SB_DB(sql1, 1, "insert");
                        inseriTagIdeia.Run();
                    }
                }

                //Mostrar uma mensagem de sucesso
                MessageBox.Show("Inserção com sucesso da ideia: \n" 
                    + "Titulo: " + txttitulo.Text + "\n"
                    + "Categoria: " + categoria.Tipo + " Tag: "+ txttag.Text + "\n"
                    + "Pelo utilizador: " + Program.IdSessao + "\n"
                    + "Data de Inserção: "+ DateTime.Now.ToString());

                //Voltar para Pagina Principal
                fPaginaPrincipal voltarPaginaPrincipal = new fPaginaPrincipal();
                this.Hide();
                voltarPaginaPrincipal.Show();
            }
        }

        private void btvoltar_Click(object sender, EventArgs e)
        {
            fPaginaPrincipal voltarPaginaPrincipal = new fPaginaPrincipal();
            this.Hide();
            voltarPaginaPrincipal.Show();
        }
    }
}
