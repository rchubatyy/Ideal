namespace Ideal
{
    partial class fVerSubscricao
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datagvsubscricao = new System.Windows.Forms.DataGridView();
            this.btapagar = new System.Windows.Forms.Button();
            this.btvoltar = new System.Windows.Forms.Button();
            this.subscricaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagvsubscricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscricaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datagvsubscricao);
            this.groupBox1.Controls.Add(this.btapagar);
            this.groupBox1.Controls.Add(this.btvoltar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subscrições";
            // 
            // datagvsubscricao
            // 
            this.datagvsubscricao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvsubscricao.Location = new System.Drawing.Point(6, 19);
            this.datagvsubscricao.Name = "datagvsubscricao";
            this.datagvsubscricao.ReadOnly = true;
            this.datagvsubscricao.Size = new System.Drawing.Size(364, 248);
            this.datagvsubscricao.TabIndex = 6;
            this.datagvsubscricao.CellDoubleClick += datagvsubscricao_CellDoubleClick;
            this.datagvsubscricao.CellClick += datagvsubscricao_CellClick;
            // 
            // btapagar
            // 
            this.btapagar.Location = new System.Drawing.Point(6, 273);
            this.btapagar.Name = "btapagar";
            this.btapagar.Size = new System.Drawing.Size(86, 23);
            this.btapagar.TabIndex = 5;
            this.btapagar.Text = "Apagar";
            this.btapagar.UseVisualStyleBackColor = true;
            this.btapagar.Click += new System.EventHandler(this.btapagar_Click);
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(284, 273);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(86, 23);
            this.btvoltar.TabIndex = 1;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // subscricaoBindingSource
            // 
            this.subscricaoBindingSource.DataSource = typeof(Ideal.Classes.Subscricao);
            // 
            // fVerSubscricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(400, 327);
            this.Controls.Add(this.groupBox1);
            this.Name = "fVerSubscricao";
            this.Text = "Ver Subscrições";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagvsubscricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subscricaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.BindingSource subscricaoBindingSource;
        private System.Windows.Forms.Button btapagar;
        private System.Windows.Forms.DataGridView datagvsubscricao;
    }
}