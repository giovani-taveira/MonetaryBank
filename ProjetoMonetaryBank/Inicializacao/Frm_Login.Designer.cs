
namespace ProjetoMonetaryBank.Inicializacao
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Txt_CPF = new System.Windows.Forms.TextBox();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Btn_Continuar = new System.Windows.Forms.Button();
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Lbl_Cadastro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoMonetaryBank.Properties.Resources.Logo_Finalizado;
            this.pictureBox1.Location = new System.Drawing.Point(33, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 264);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Txt_CPF
            // 
            this.Txt_CPF.Location = new System.Drawing.Point(33, 274);
            this.Txt_CPF.Name = "Txt_CPF";
            this.Txt_CPF.Size = new System.Drawing.Size(298, 23);
            this.Txt_CPF.TabIndex = 1;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(33, 328);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.Size = new System.Drawing.Size(298, 23);
            this.Txt_Senha.TabIndex = 2;
            // 
            // Btn_Continuar
            // 
            this.Btn_Continuar.Location = new System.Drawing.Point(84, 398);
            this.Btn_Continuar.Name = "Btn_Continuar";
            this.Btn_Continuar.Size = new System.Drawing.Size(200, 40);
            this.Btn_Continuar.TabIndex = 4;
            this.Btn_Continuar.Text = "button1";
            this.Btn_Continuar.UseVisualStyleBackColor = true;
            this.Btn_Continuar.Click += new System.EventHandler(this.Btn_Continuar_Click);
            this.Btn_Continuar.MouseLeave += new System.EventHandler(this.Btn_Continuar_MouseLeave);
            this.Btn_Continuar.MouseHover += new System.EventHandler(this.Btn_Continuar_MouseHover);
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Location = new System.Drawing.Point(33, 256);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(38, 15);
            this.Lbl_CPF.TabIndex = 4;
            this.Lbl_CPF.Text = "label1";
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Location = new System.Drawing.Point(33, 310);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Senha.TabIndex = 5;
            this.Lbl_Senha.Text = "label2";
            // 
            // Lbl_Cadastro
            // 
            this.Lbl_Cadastro.AutoSize = true;
            this.Lbl_Cadastro.Location = new System.Drawing.Point(33, 354);
            this.Lbl_Cadastro.Name = "Lbl_Cadastro";
            this.Lbl_Cadastro.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Cadastro.TabIndex = 3;
            this.Lbl_Cadastro.Text = "label3";
            this.Lbl_Cadastro.Click += new System.EventHandler(this.Lbl_Cadastro_Click);
            this.Lbl_Cadastro.MouseLeave += new System.EventHandler(this.Lbl_Cadastro_MouseLeave);
            this.Lbl_Cadastro.MouseHover += new System.EventHandler(this.Lbl_Cadastro_MouseHover);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.Lbl_Cadastro);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Lbl_CPF);
            this.Controls.Add(this.Btn_Continuar);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Txt_CPF);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txt_CPF;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Button Btn_Continuar;
        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.Label Lbl_Cadastro;
    }
}