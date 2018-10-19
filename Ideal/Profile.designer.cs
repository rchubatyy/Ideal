namespace Ideal
{
    partial class Profile
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
            this.name = new System.Windows.Forms.Label();
            this.lastlogin = new System.Windows.Forms.Label();
            this.novisits = new System.Windows.Forms.Label();
            this.writeidea = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbtipoconta = new System.Windows.Forms.Label();
            this.lbdatanascimento = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbapelido = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvminhasideias = new System.Windows.Forms.DataGridView();
            this.btvoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvminhasideias)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(68, 23);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 13);
            this.name.TabIndex = 0;
            // 
            // lastlogin
            // 
            this.lastlogin.AutoSize = true;
            this.lastlogin.Location = new System.Drawing.Point(348, 23);
            this.lastlogin.Name = "lastlogin";
            this.lastlogin.Size = new System.Drawing.Size(0, 13);
            this.lastlogin.TabIndex = 0;
            // 
            // novisits
            // 
            this.novisits.AutoSize = true;
            this.novisits.Location = new System.Drawing.Point(555, 23);
            this.novisits.Name = "novisits";
            this.novisits.Size = new System.Drawing.Size(0, 13);
            this.novisits.TabIndex = 0;
            // 
            // writeidea
            // 
            this.writeidea.Location = new System.Drawing.Point(261, 301);
            this.writeidea.Name = "writeidea";
            this.writeidea.Size = new System.Drawing.Size(128, 29);
            this.writeidea.TabIndex = 3;
            this.writeidea.Text = "Criar Ideia";
            this.writeidea.UseVisualStyleBackColor = true;
            this.writeidea.Click += new System.EventHandler(this.writeidea_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbtipoconta);
            this.groupBox1.Controls.Add(this.lbdatanascimento);
            this.groupBox1.Controls.Add(this.lbemail);
            this.groupBox1.Controls.Add(this.lbapelido);
            this.groupBox1.Controls.Add(this.lbnome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 295);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meu Perfil";
            // 
            // lbtipoconta
            // 
            this.lbtipoconta.AutoSize = true;
            this.lbtipoconta.Location = new System.Drawing.Point(90, 268);
            this.lbtipoconta.Name = "lbtipoconta";
            this.lbtipoconta.Size = new System.Drawing.Size(41, 13);
            this.lbtipoconta.TabIndex = 9;
            this.lbtipoconta.Text = "label10";
            // 
            // lbdatanascimento
            // 
            this.lbdatanascimento.AutoSize = true;
            this.lbdatanascimento.Location = new System.Drawing.Point(104, 86);
            this.lbdatanascimento.Name = "lbdatanascimento";
            this.lbdatanascimento.Size = new System.Drawing.Size(35, 13);
            this.lbdatanascimento.TabIndex = 8;
            this.lbdatanascimento.Text = "label9";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(47, 64);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(35, 13);
            this.lbemail.TabIndex = 7;
            this.lbemail.Text = "label8";
            // 
            // lbapelido
            // 
            this.lbapelido.AutoSize = true;
            this.lbapelido.Location = new System.Drawing.Point(57, 42);
            this.lbapelido.Name = "lbapelido";
            this.lbapelido.Size = new System.Drawing.Size(35, 13);
            this.lbapelido.TabIndex = 6;
            this.lbapelido.Text = "label7";
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(52, 19);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(35, 13);
            this.lbnome.TabIndex = 5;
            this.lbnome.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Conta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apelido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvminhasideias);
            this.groupBox2.Controls.Add(this.writeidea);
            this.groupBox2.Location = new System.Drawing.Point(235, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 338);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Minhas Ideias";
            // 
            // dgvminhasideias
            // 
            this.dgvminhasideias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvminhasideias.Location = new System.Drawing.Point(6, 19);
            this.dgvminhasideias.Name = "dgvminhasideias";
            this.dgvminhasideias.Size = new System.Drawing.Size(383, 276);
            this.dgvminhasideias.TabIndex = 4;
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(62, 314);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(74, 28);
            this.btvoltar.TabIndex = 5;
            this.btvoltar.Text = "Voltar";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 354);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.novisits);
            this.Controls.Add(this.lastlogin);
            this.Controls.Add(this.name);
            this.Name = "Profile";
            this.Text = "Profile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvminhasideias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label lastlogin;
        private System.Windows.Forms.Label novisits;
        private System.Windows.Forms.Button writeidea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvminhasideias;
        private System.Windows.Forms.Label lbtipoconta;
        private System.Windows.Forms.Label lbdatanascimento;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbapelido;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btvoltar;
    }
}