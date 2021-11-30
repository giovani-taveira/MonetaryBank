
namespace Forms.Formularios.Operacoes
{
    partial class Frm_Saque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Saque));
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.Lbl_NomeOperacao = new System.Windows.Forms.Label();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.Txt_ValidaSenha = new System.Windows.Forms.TextBox();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Lbl_ValidaSenha = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Senha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.Location = new System.Drawing.Point(217, 214);
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
            this.Lbl_NomeOperacao.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_NomeOperacao.Location = new System.Drawing.Point(32, 25);
            this.Lbl_NomeOperacao.Name = "Lbl_NomeOperacao";
            this.Lbl_NomeOperacao.Size = new System.Drawing.Size(63, 25);
            this.Lbl_NomeOperacao.TabIndex = 1;
            this.Lbl_NomeOperacao.Text = "label1";
            this.Lbl_NomeOperacao.Click += new System.EventHandler(this.Lbl_NomeOperacao_Click);
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Location = new System.Drawing.Point(32, 89);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(293, 23);
            this.Txt_Valor.TabIndex = 2;
            this.Txt_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Valor_KeyPress);
            // 
            // Txt_ValidaSenha
            // 
            this.Txt_ValidaSenha.Location = new System.Drawing.Point(32, 164);
            this.Txt_ValidaSenha.Name = "Txt_ValidaSenha";
            this.Txt_ValidaSenha.PasswordChar = '*';
            this.Txt_ValidaSenha.Size = new System.Drawing.Size(212, 23);
            this.Txt_ValidaSenha.TabIndex = 3;
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.Location = new System.Drawing.Point(32, 68);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Valor.TabIndex = 4;
            this.Lbl_Valor.Text = "label2";
            // 
            // Lbl_ValidaSenha
            // 
            this.Lbl_ValidaSenha.AutoSize = true;
            this.Lbl_ValidaSenha.Location = new System.Drawing.Point(32, 143);
            this.Lbl_ValidaSenha.Name = "Lbl_ValidaSenha";
            this.Lbl_ValidaSenha.Size = new System.Drawing.Size(38, 15);
            this.Lbl_ValidaSenha.TabIndex = 5;
            this.Lbl_ValidaSenha.Text = "label3";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(32, 214);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(108, 42);
            this.Btn_Cancelar.TabIndex = 6;
            this.Btn_Cancelar.Text = "button2";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            this.Btn_Cancelar.MouseEnter += new System.EventHandler(this.Btn_Cancelar_MouseEnter_1);
            this.Btn_Cancelar.MouseLeave += new System.EventHandler(this.Btn_Cancelar_MouseLeave_1);
            // 
            // Btn_Senha
            // 
            this.Btn_Senha.Location = new System.Drawing.Point(250, 164);
            this.Btn_Senha.Name = "Btn_Senha";
            this.Btn_Senha.Size = new System.Drawing.Size(75, 24);
            this.Btn_Senha.TabIndex = 7;
            this.Btn_Senha.Text = "button1";
            this.Btn_Senha.UseVisualStyleBackColor = true;
            this.Btn_Senha.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_Saque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 287);
            this.Controls.Add(this.Btn_Senha);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Lbl_ValidaSenha);
            this.Controls.Add(this.Lbl_Valor);
            this.Controls.Add(this.Txt_ValidaSenha);
            this.Controls.Add(this.Txt_Valor);
            this.Controls.Add(this.Lbl_NomeOperacao);
            this.Controls.Add(this.Btn_Confirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Frm_Saque";
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
        private System.Windows.Forms.Button Btn_Senha;
    }
}