
namespace Forms.Formularios.Operacoes
{
    partial class Frm_Tranferencia
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
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.Lbl_NomeOperacao = new System.Windows.Forms.Label();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.Txt_ValidaSenha = new System.Windows.Forms.TextBox();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Lbl_ValidaSenha = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Lbl_CpfRecebedor = new System.Windows.Forms.Label();
            this.Msk_CpfRecebedor = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.Location = new System.Drawing.Point(217, 246);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(108, 42);
            this.Btn_Confirmar.TabIndex = 0;
            this.Btn_Confirmar.Text = "button1";
            this.Btn_Confirmar.UseVisualStyleBackColor = true;
            this.Btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            this.Btn_Confirmar.MouseEnter += new System.EventHandler(this.Btn_Confirmar_MouseEnter_1);
            this.Btn_Confirmar.MouseLeave += new System.EventHandler(this.Btn_Confirmar_MouseLeave_1);
            // 
            // Lbl_NomeOperacao
            // 
            this.Lbl_NomeOperacao.AutoSize = true;
            this.Lbl_NomeOperacao.Location = new System.Drawing.Point(32, 25);
            this.Lbl_NomeOperacao.Name = "Lbl_NomeOperacao";
            this.Lbl_NomeOperacao.Size = new System.Drawing.Size(38, 15);
            this.Lbl_NomeOperacao.TabIndex = 1;
            this.Lbl_NomeOperacao.Text = "label1";
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Location = new System.Drawing.Point(32, 142);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(293, 23);
            this.Txt_Valor.TabIndex = 2;
            // 
            // Txt_ValidaSenha
            // 
            this.Txt_ValidaSenha.Location = new System.Drawing.Point(32, 195);
            this.Txt_ValidaSenha.Name = "Txt_ValidaSenha";
            this.Txt_ValidaSenha.Size = new System.Drawing.Size(293, 23);
            this.Txt_ValidaSenha.TabIndex = 3;
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Location = new System.Drawing.Point(32, 124);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Valor.TabIndex = 4;
            this.Lbl_Valor.Text = "label2";
            // 
            // Lbl_ValidaSenha
            // 
            this.Lbl_ValidaSenha.AutoSize = true;
            this.Lbl_ValidaSenha.Location = new System.Drawing.Point(32, 177);
            this.Lbl_ValidaSenha.Name = "Lbl_ValidaSenha";
            this.Lbl_ValidaSenha.Size = new System.Drawing.Size(38, 15);
            this.Lbl_ValidaSenha.TabIndex = 5;
            this.Lbl_ValidaSenha.Text = "label3";
            this.Lbl_ValidaSenha.Click += new System.EventHandler(this.Lbl_ValidaSenha_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(32, 246);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(108, 42);
            this.Btn_Cancelar.TabIndex = 6;
            this.Btn_Cancelar.Text = "button2";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            this.Btn_Cancelar.MouseEnter += new System.EventHandler(this.Btn_Cancelar_MouseEnter_1);
            this.Btn_Cancelar.MouseLeave += new System.EventHandler(this.Btn_Cancelar_MouseLeave_1);
            // 
            // Lbl_CpfRecebedor
            // 
            this.Lbl_CpfRecebedor.AutoSize = true;
            this.Lbl_CpfRecebedor.Location = new System.Drawing.Point(32, 70);
            this.Lbl_CpfRecebedor.Name = "Lbl_CpfRecebedor";
            this.Lbl_CpfRecebedor.Size = new System.Drawing.Size(38, 15);
            this.Lbl_CpfRecebedor.TabIndex = 8;
            this.Lbl_CpfRecebedor.Text = "label2";
            // 
            // Msk_CpfRecebedor
            // 
            this.Msk_CpfRecebedor.Location = new System.Drawing.Point(32, 88);
            this.Msk_CpfRecebedor.Mask = "000,000,000-00";
            this.Msk_CpfRecebedor.Name = "Msk_CpfRecebedor";
            this.Msk_CpfRecebedor.Size = new System.Drawing.Size(293, 23);
            this.Msk_CpfRecebedor.TabIndex = 9;
            // 
            // Frm_Tranferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 313);
            this.Controls.Add(this.Msk_CpfRecebedor);
            this.Controls.Add(this.Lbl_CpfRecebedor);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Lbl_ValidaSenha);
            this.Controls.Add(this.Lbl_Valor);
            this.Controls.Add(this.Txt_ValidaSenha);
            this.Controls.Add(this.Txt_Valor);
            this.Controls.Add(this.Lbl_NomeOperacao);
            this.Controls.Add(this.Btn_Confirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "Frm_Tranferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Saque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Confirmar;
        private System.Windows.Forms.Label Lbl_NomeOperacao;
        private System.Windows.Forms.TextBox Txt_Valor;
        private System.Windows.Forms.TextBox Txt_ValidaSenha;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.Label Lbl_ValidaSenha;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label Lbl_CpfRecebedor;
        private System.Windows.Forms.MaskedTextBox Msk_CpfRecebedor;
    }
}