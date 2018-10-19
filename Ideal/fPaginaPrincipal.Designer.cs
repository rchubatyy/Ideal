namespace Ideal
{
    partial class fPaginaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.lbultimologin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btsair = new System.Windows.Forms.Button();
            this.lbusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvideiasrecentes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btmeuperfil = new System.Windows.Forms.Button();
            this.btpesquisaideias = new System.Windows.Forms.Button();
            this.btgrupos = new System.Windows.Forms.Button();
            this.btcriarideia = new System.Windows.Forms.Button();
            this.btversubscricao = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvideiasrecentes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.lbultimologin);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.btsair);
            this.gb1.Controls.Add(this.lbusername);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(529, 39);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "Sessão";
            // 
            // lbultimologin
            // 
            this.lbultimologin.AutoSize = true;
            this.lbultimologin.Location = new System.Drawing.Point(221, 16);
            this.lbultimologin.Name = "lbultimologin";
            this.lbultimologin.Size = new System.Drawing.Size(35, 13);
            this.lbultimologin.TabIndex = 4;
            this.lbultimologin.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ultimo Login:";
            // 
            // btsair
            // 
            this.btsair.Location = new System.Drawing.Point(448, 10);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(75, 23);
            this.btsair.TabIndex = 2;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(65, 16);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(35, 13);
            this.lbusername.TabIndex = 1;
            this.lbusername.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizador:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvideiasrecentes);
            this.groupBox1.Location = new System.Drawing.Point(182, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 294);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ideias Mais Recentes";
            // 
            // dgvideiasrecentes
            // 
            this.dgvideiasrecentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvideiasrecentes.Location = new System.Drawing.Point(6, 19);
            this.dgvideiasrecentes.Name = "dgvideiasrecentes";
            this.dgvideiasrecentes.ReadOnly = true;
            this.dgvideiasrecentes.Size = new System.Drawing.Size(353, 269);
            this.dgvideiasrecentes.TabIndex = 0;
            this.dgvideiasrecentes.CellDoubleClick += dgvideiasrecentes_CellDoubleClick;
            this.dgvideiasrecentes.CellClick += dgvideiasrecentes_CellClick;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btmeuperfil);
            this.groupBox2.Controls.Add(this.btpesquisaideias);
            this.groupBox2.Controls.Add(this.btgrupos);
            this.groupBox2.Controls.Add(this.btcriarideia);
            this.groupBox2.Controls.Add(this.btversubscricao);
            this.groupBox2.Location = new System.Drawing.Point(12, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 294);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // btmeuperfil
            // 
            this.btmeuperfil.Location = new System.Drawing.Point(6, 265);
            this.btmeuperfil.Name = "btmeuperfil";
            this.btmeuperfil.Size = new System.Drawing.Size(152, 23);
            this.btmeuperfil.TabIndex = 4;
            this.btmeuperfil.Text = "Meu Perfil";
            this.btmeuperfil.UseVisualStyleBackColor = true;
            this.btmeuperfil.Click += new System.EventHandler(this.btmeuperfil_Click);
            // 
            // btpesquisaideias
            // 
            this.btpesquisaideias.Location = new System.Drawing.Point(6, 34);
            this.btpesquisaideias.Name = "btpesquisaideias";
            this.btpesquisaideias.Size = new System.Drawing.Size(152, 23);
            this.btpesquisaideias.TabIndex = 3;
            this.btpesquisaideias.Text = "Pesquisar Ideias";
            this.btpesquisaideias.UseVisualStyleBackColor = true;
            this.btpesquisaideias.Click += new System.EventHandler(this.btpesquisaideias_Click);
            // 
            // btgrupos
            // 
            this.btgrupos.Location = new System.Drawing.Point(6, 236);
            this.btgrupos.Name = "btgrupos";
            this.btgrupos.Size = new System.Drawing.Size(152, 23);
            this.btgrupos.TabIndex = 2;
            this.btgrupos.Text = "Ver Grupos";
            this.btgrupos.UseVisualStyleBackColor = true;
            this.btgrupos.Click += new System.EventHandler(this.btgrupos_Click);
            // 
            // btcriarideia
            // 
            this.btcriarideia.Location = new System.Drawing.Point(6, 63);
            this.btcriarideia.Name = "btcriarideia";
            this.btcriarideia.Size = new System.Drawing.Size(152, 23);
            this.btcriarideia.TabIndex = 1;
            this.btcriarideia.Text = "Criar Ideias";
            this.btcriarideia.UseVisualStyleBackColor = true;
            this.btcriarideia.Click += new System.EventHandler(this.btcriarideia_Click);
            // 
            // btversubscricao
            // 
            this.btversubscricao.Location = new System.Drawing.Point(6, 207);
            this.btversubscricao.Name = "btversubscricao";
            this.btversubscricao.Size = new System.Drawing.Size(152, 23);
            this.btversubscricao.TabIndex = 0;
            this.btversubscricao.Text = "Minhas Subscrições";
            this.btversubscricao.UseVisualStyleBackColor = true;
            this.btversubscricao.Click += new System.EventHandler(this.btversubscricao_Click);
            // 
            // fPaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 363);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb1);
            this.Name = "fPaginaPrincipal";
            this.Text = "Página Principal";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvideiasrecentes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvideiasrecentes;
        private System.Windows.Forms.Label lbultimologin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btmeuperfil;
        private System.Windows.Forms.Button btpesquisaideias;
        private System.Windows.Forms.Button btgrupos;
        private System.Windows.Forms.Button btcriarideia;
        private System.Windows.Forms.Button btversubscricao;
    }
}