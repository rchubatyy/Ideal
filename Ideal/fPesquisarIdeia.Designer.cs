namespace Ideal
{
    partial class fPesquisarIdeia
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvpesquisaideias = new System.Windows.Forms.DataGridView();
            this.btpesquisa = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.btvoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesquisaideias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvpesquisaideias);
            this.groupBox1.Controls.Add(this.btpesquisa);
            this.groupBox1.Controls.Add(this.txtpesquisa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa de Ideias";
            // 
            // dgvpesquisaideias
            // 
            this.dgvpesquisaideias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpesquisaideias.Location = new System.Drawing.Point(6, 45);
            this.dgvpesquisaideias.Name = "dgvpesquisaideias";
            this.dgvpesquisaideias.ReadOnly = true;
            this.dgvpesquisaideias.Size = new System.Drawing.Size(447, 234);
            this.dgvpesquisaideias.TabIndex = 2;
            this.dgvpesquisaideias.CellDoubleClick += dgvpesquisaideias_CellDoubleClick;
            this.dgvpesquisaideias.CellClick += dgvpesquisaideias_CellClick;
            // 
            // btpesquisa
            // 
            this.btpesquisa.Location = new System.Drawing.Point(345, 16);
            this.btpesquisa.Name = "btpesquisa";
            this.btpesquisa.Size = new System.Drawing.Size(108, 23);
            this.btpesquisa.TabIndex = 1;
            this.btpesquisa.Text = "Pesquisar";
            this.btpesquisa.UseVisualStyleBackColor = true;
            this.btpesquisa.Click += new System.EventHandler(this.btpesquisa_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Location = new System.Drawing.Point(6, 19);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(333, 20);
            this.txtpesquisa.TabIndex = 0;
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(390, 297);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(75, 23);
            this.btvoltar.TabIndex = 1;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // fPesquisarIdeia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 326);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.groupBox1);
            this.Name = "fPesquisarIdeia";
            this.Text = "Pesquisar Ideias";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpesquisaideias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvpesquisaideias;
        private System.Windows.Forms.Button btpesquisa;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Button btvoltar;
    }
}