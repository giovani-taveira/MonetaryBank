
namespace ProjetoMonetaryBank.Inicializacao
{
    partial class Frm_CriaSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CriaSenha));
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_SenhaConfirma = new System.Windows.Forms.Label();
            this.Txt_SenhaConfirma = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Finalizar = new System.Windows.Forms.Button();
            this.Btn_Voltar = new System.Windows.Forms.Button();
            this.Msk_CPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Location = new System.Drawing.Point(179, 81);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Senha.TabIndex = 1;
            this.Lbl_Senha.Text = "label1";
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_CPF.Location = new System.Drawing.Point(179, 28);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(38, 15);
            this.Lbl_CPF.TabIndex = 2;
            this.Lbl_CPF.Text = "label2";
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(179, 99);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.Size = new System.Drawing.Size(246, 23);
            this.Txt_Senha.TabIndex = 1;
            // 
            // Lbl_SenhaConfirma
            // 
            this.Lbl_SenhaConfirma.AutoSize = true;
            this.Lbl_SenhaConfirma.Location = new System.Drawing.Point(179, 134);
            this.Lbl_SenhaConfirma.Name = "Lbl_SenhaConfirma";
            this.Lbl_SenhaConfirma.Size = new System.Drawing.Size(38, 15);
            this.Lbl_SenhaConfirma.TabIndex = 4;
            this.Lbl_SenhaConfirma.Text = "label3";
            this.Lbl_SenhaConfirma.Click += new System.EventHandler(this.Lbl_SenhaConfirma_Click);
            // 
            // Txt_SenhaConfirma
            // 
            this.Txt_SenhaConfirma.Location = new System.Drawing.Point(179, 152);
            this.Txt_SenhaConfirma.Name = "Txt_SenhaConfirma";
            this.Txt_SenhaConfirma.Size = new System.Drawing.Size(246, 23);
            this.Txt_SenhaConfirma.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forms.Properties.Resources.img_senha;
            this.pictureBox1.Location = new System.Drawing.Point(33, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Finalizar
            // 
            this.Btn_Finalizar.Location = new System.Drawing.Point(325, 203);
            this.Btn_Finalizar.Name = "Btn_Finalizar";
            this.Btn_Finalizar.Size = new System.Drawing.Size(99, 35);
            this.Btn_Finalizar.TabIndex = 3;
            this.Btn_Finalizar.Text = "button1";
            this.Btn_Finalizar.UseVisualStyleBackColor = true;
            this.Btn_Finalizar.Click += new System.EventHandler(this.Btn_Finalizar_Click);
            // 
            // Btn_Voltar
            // 
            this.Btn_Voltar.Location = new System.Drawing.Point(33, 203);
            this.Btn_Voltar.Name = "Btn_Voltar";
            this.Btn_Voltar.Size = new System.Drawing.Size(99, 35);
            this.Btn_Voltar.TabIndex = 4;
            this.Btn_Voltar.Text = "button2";
            this.Btn_Voltar.UseVisualStyleBackColor = true;
            this.Btn_Voltar.Click += new System.EventHandler(this.Btn_Voltar_Click);
            // 
            // Msk_CPF
            // 
            this.Msk_CPF.Location = new System.Drawing.Point(179, 46);
            this.Msk_CPF.Mask = "000,000,000-00";
            this.Msk_CPF.Name = "Msk_CPF";
            this.Msk_CPF.Size = new System.Drawing.Size(245, 23);
            this.Msk_CPF.TabIndex = 8;
            // 
            // Frm_CriaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 262);
            this.Controls.Add(this.Msk_CPF);
            this.Controls.Add(this.Btn_Voltar);
            this.Controls.Add(this.Btn_Finalizar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txt_SenhaConfirma);
            this.Controls.Add(this.Lbl_SenhaConfirma);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Lbl_CPF);
            this.Controls.Add(this.Lbl_Senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_CriaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CriaSenhacs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Label Lbl_SenhaConfirma;
        private System.Windows.Forms.TextBox Txt_SenhaConfirma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Finalizar;
        private System.Windows.Forms.Button Btn_Voltar;
        private System.Windows.Forms.MaskedTextBox Msk_CPF;
    }
}