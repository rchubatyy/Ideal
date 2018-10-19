namespace Ideal
{
    partial class comentario
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtcusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcdata = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbccomentario = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // txtcusername
            // 
            this.txtcusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcusername.Location = new System.Drawing.Point(57, 9);
            this.txtcusername.Name = "txtcusername";
            this.txtcusername.ReadOnly = true;
            this.txtcusername.Size = new System.Drawing.Size(81, 13);
            this.txtcusername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data:";
            // 
            // txtcdata
            // 
            this.txtcdata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcdata.Location = new System.Drawing.Point(173, 9);
            this.txtcdata.Name = "txtcdata";
            this.txtcdata.ReadOnly = true;
            this.txtcdata.Size = new System.Drawing.Size(123, 13);
            this.txtcdata.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cometário:";
            // 
            // rtbccomentario
            // 
            this.rtbccomentario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbccomentario.Location = new System.Drawing.Point(69, 38);
            this.rtbccomentario.Name = "rtbccomentario";
            this.rtbccomentario.ReadOnly = true;
            this.rtbccomentario.Size = new System.Drawing.Size(199, 46);
            this.rtbccomentario.TabIndex = 5;
            this.rtbccomentario.Text = "";
            // 
            // comentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbccomentario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcdata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcusername);
            this.Controls.Add(this.label1);
            this.Name = "comentario";
            this.Size = new System.Drawing.Size(299, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcdata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbccomentario;
    }
}
