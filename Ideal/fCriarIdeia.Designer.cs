namespace Ideal
{
    partial class fCriarIdeia
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
            this.btcriarIdeia = new System.Windows.Forms.Button();
            this.rtbmensagem = new System.Windows.Forms.RichTextBox();
            this.txttag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbcategoria = new System.Windows.Forms.ComboBox();
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btvoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btvoltar);
            this.groupBox1.Controls.Add(this.btcriarIdeia);
            this.groupBox1.Controls.Add(this.rtbmensagem);
            this.groupBox1.Controls.Add(this.txttag);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbcategoria);
            this.groupBox1.Controls.Add(this.txttitulo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // btcriarIdeia
            // 
            this.btcriarIdeia.Location = new System.Drawing.Point(166, 228);
            this.btcriarIdeia.Name = "btcriarIdeia";
            this.btcriarIdeia.Size = new System.Drawing.Size(91, 29);
            this.btcriarIdeia.TabIndex = 8;
            this.btcriarIdeia.Text = "Criar Ideia";
            this.btcriarIdeia.UseVisualStyleBackColor = true;
            this.btcriarIdeia.Click += new System.EventHandler(this.btcriarIdeia_Click);
            // 
            // rtbmensagem
            // 
            this.rtbmensagem.Location = new System.Drawing.Point(84, 126);
            this.rtbmensagem.Name = "rtbmensagem";
            this.rtbmensagem.Size = new System.Drawing.Size(173, 96);
            this.rtbmensagem.TabIndex = 7;
            this.rtbmensagem.Text = "";
            // 
            // txttag
            // 
            this.txttag.Location = new System.Drawing.Point(84, 91);
            this.txttag.Name = "txttag";
            this.txttag.Size = new System.Drawing.Size(100, 20);
            this.txttag.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tag";
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcategoria.FormattingEnabled = true;
            this.cmbcategoria.Location = new System.Drawing.Point(84, 57);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(100, 21);
            this.cmbcategoria.TabIndex = 4;
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(84, 26);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(100, 20);
            this.txttitulo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mensagem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Título";
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(9, 229);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(86, 27);
            this.btvoltar.TabIndex = 9;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // fCriarIdeia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 281);
            this.Controls.Add(this.groupBox1);
            this.Name = "fCriarIdeia";
            this.Text = "Criar Ideia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.RichTextBox rtbmensagem;
        private System.Windows.Forms.TextBox txttag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbcategoria;
        private System.Windows.Forms.Button btcriarIdeia;
        private System.Windows.Forms.Button btvoltar;
    }
}