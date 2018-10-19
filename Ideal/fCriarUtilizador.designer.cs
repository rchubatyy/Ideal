namespace DIS_Ideial
{
    partial class fCriarUtilizador
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtapelido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btncriarutilizador = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpasswordr = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpdatadenascimento = new System.Windows.Forms.DateTimePicker();
            this.btvlogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(114, 25);
            this.txtnome.Margin = new System.Windows.Forms.Padding(2);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(109, 20);
            this.txtnome.TabIndex = 0;
            // 
            // txtapelido
            // 
            this.txtapelido.Location = new System.Drawing.Point(114, 48);
            this.txtapelido.Margin = new System.Windows.Forms.Padding(2);
            this.txtapelido.Name = "txtapelido";
            this.txtapelido.Size = new System.Drawing.Size(109, 20);
            this.txtapelido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apelido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de Nascimento";
            // 
            // btncriarutilizador
            // 
            this.btncriarutilizador.Location = new System.Drawing.Point(226, 269);
            this.btncriarutilizador.Margin = new System.Windows.Forms.Padding(2);
            this.btncriarutilizador.Name = "btncriarutilizador";
            this.btncriarutilizador.Size = new System.Drawing.Size(66, 22);
            this.btncriarutilizador.TabIndex = 6;
            this.btncriarutilizador.Text = "Criar";
            this.btncriarutilizador.UseVisualStyleBackColor = true;
            this.btncriarutilizador.Click += new System.EventHandler(this.btncriarutilizador_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(115, 101);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(150, 20);
            this.txtemail.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpasswordr);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpdatadenascimento);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtapelido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Location = new System.Drawing.Point(27, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(272, 242);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // txtpasswordr
            // 
            this.txtpasswordr.Location = new System.Drawing.Point(141, 200);
            this.txtpasswordr.Margin = new System.Windows.Forms.Padding(2);
            this.txtpasswordr.Name = "txtpasswordr";
            this.txtpasswordr.Size = new System.Drawing.Size(109, 20);
            this.txtpasswordr.TabIndex = 18;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(141, 176);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(109, 20);
            this.txtpassword.TabIndex = 17;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(141, 154);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(109, 20);
            this.txtusername.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 207);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Reintroduza a Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 183);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 157);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Username";
            // 
            // dtpdatadenascimento
            // 
            this.dtpdatadenascimento.Location = new System.Drawing.Point(114, 72);
            this.dtpdatadenascimento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpdatadenascimento.Name = "dtpdatadenascimento";
            this.dtpdatadenascimento.Size = new System.Drawing.Size(151, 20);
            this.dtpdatadenascimento.TabIndex = 12;
            // 
            // btvlogin
            // 
            this.btvlogin.Location = new System.Drawing.Point(27, 269);
            this.btvlogin.Margin = new System.Windows.Forms.Padding(2);
            this.btvlogin.Name = "btvlogin";
            this.btvlogin.Size = new System.Drawing.Size(63, 22);
            this.btvlogin.TabIndex = 13;
            this.btvlogin.Text = "Login";
            this.btvlogin.UseVisualStyleBackColor = true;
            this.btvlogin.Click += new System.EventHandler(this.btvlogin_Click);
            // 
            // fCriarUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 299);
            this.Controls.Add(this.btvlogin);
            this.Controls.Add(this.btncriarutilizador);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fCriarUtilizador";
            this.Text = "Criar Utilizador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtapelido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncriarutilizador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpdatadenascimento;
        private System.Windows.Forms.TextBox txtpasswordr;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btvlogin;
    }
}