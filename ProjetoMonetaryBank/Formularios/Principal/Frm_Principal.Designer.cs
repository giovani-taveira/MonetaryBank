
namespace ProjetoMonetaryBank.Principal
{
    public partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Lbl_NomeUsuario = new System.Windows.Forms.Label();
            this.Btn_Sacar = new System.Windows.Forms.Button();
            this.Btn_Depositar = new System.Windows.Forms.Button();
            this.Btn_Transferencia = new System.Windows.Forms.Button();
            this.Btn_Historico = new System.Windows.Forms.Button();
            this.Lbl_Saldo = new System.Windows.Forms.Label();
            this.Lbl_Operacoes = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Tsm_Conta = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_ApagarConta = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_AlterarDados = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsm_AlterarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_NomeUsuario
            // 
            this.Lbl_NomeUsuario.AutoSize = true;
            this.Lbl_NomeUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_NomeUsuario.Location = new System.Drawing.Point(12, 53);
            this.Lbl_NomeUsuario.Name = "Lbl_NomeUsuario";
            this.Lbl_NomeUsuario.Size = new System.Drawing.Size(63, 25);
            this.Lbl_NomeUsuario.TabIndex = 0;
            this.Lbl_NomeUsuario.Text = "label1";
            // 
            // Btn_Sacar
            // 
            this.Btn_Sacar.Location = new System.Drawing.Point(47, 220);
            this.Btn_Sacar.Name = "Btn_Sacar";
            this.Btn_Sacar.Size = new System.Drawing.Size(133, 65);
            this.Btn_Sacar.TabIndex = 1;
            this.Btn_Sacar.Text = "button1";
            this.Btn_Sacar.UseVisualStyleBackColor = true;
            this.Btn_Sacar.Click += new System.EventHandler(this.Btn_Sacar_Click);
            this.Btn_Sacar.MouseEnter += new System.EventHandler(this.Btn_Sacar_MouseEnter);
            this.Btn_Sacar.MouseLeave += new System.EventHandler(this.Btn_Sacar_MouseLeave);
            // 
            // Btn_Depositar
            // 
            this.Btn_Depositar.Location = new System.Drawing.Point(47, 291);
            this.Btn_Depositar.Name = "Btn_Depositar";
            this.Btn_Depositar.Size = new System.Drawing.Size(133, 66);
            this.Btn_Depositar.TabIndex = 3;
            this.Btn_Depositar.Text = "button2";
            this.Btn_Depositar.UseVisualStyleBackColor = true;
            this.Btn_Depositar.Click += new System.EventHandler(this.Btn_Depositar_Click);
            this.Btn_Depositar.MouseEnter += new System.EventHandler(this.Btn_Depositar_MouseEnter);
            this.Btn_Depositar.MouseLeave += new System.EventHandler(this.Btn_Depositar_MouseLeave);
            // 
            // Btn_Transferencia
            // 
            this.Btn_Transferencia.Location = new System.Drawing.Point(203, 220);
            this.Btn_Transferencia.Name = "Btn_Transferencia";
            this.Btn_Transferencia.Size = new System.Drawing.Size(135, 65);
            this.Btn_Transferencia.TabIndex = 2;
            this.Btn_Transferencia.Text = "button3";
            this.Btn_Transferencia.UseVisualStyleBackColor = true;
            this.Btn_Transferencia.Click += new System.EventHandler(this.Btn_Transferencia_Click);
            this.Btn_Transferencia.MouseEnter += new System.EventHandler(this.Btn_Transferencia_MouseEnter);
            this.Btn_Transferencia.MouseLeave += new System.EventHandler(this.Btn_Transferencia_MouseLeave);
            // 
            // Btn_Historico
            // 
            this.Btn_Historico.Location = new System.Drawing.Point(203, 291);
            this.Btn_Historico.Name = "Btn_Historico";
            this.Btn_Historico.Size = new System.Drawing.Size(135, 66);
            this.Btn_Historico.TabIndex = 4;
            this.Btn_Historico.Text = "button4";
            this.Btn_Historico.UseVisualStyleBackColor = true;
            this.Btn_Historico.Click += new System.EventHandler(this.Btn_Historico_Click);
            this.Btn_Historico.MouseEnter += new System.EventHandler(this.Btn_Historico_MouseEnter);
            this.Btn_Historico.MouseLeave += new System.EventHandler(this.Btn_Historico_MouseLeave);
            // 
            // Lbl_Saldo
            // 
            this.Lbl_Saldo.AutoSize = true;
            this.Lbl_Saldo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Saldo.Location = new System.Drawing.Point(12, 110);
            this.Lbl_Saldo.Name = "Lbl_Saldo";
            this.Lbl_Saldo.Size = new System.Drawing.Size(63, 25);
            this.Lbl_Saldo.TabIndex = 5;
            this.Lbl_Saldo.Text = "label1";
            // 
            // Lbl_Operacoes
            // 
            this.Lbl_Operacoes.AutoSize = true;
            this.Lbl_Operacoes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Operacoes.Location = new System.Drawing.Point(12, 176);
            this.Lbl_Operacoes.Name = "Lbl_Operacoes";
            this.Lbl_Operacoes.Size = new System.Drawing.Size(63, 25);
            this.Lbl_Operacoes.TabIndex = 6;
            this.Lbl_Operacoes.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_Conta,
            this.Tsm_Sair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Tsm_Conta
            // 
            this.Tsm_Conta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsm_ApagarConta,
            this.Tsm_AlterarDados,
            this.Tsm_AlterarSenha});
            this.Tsm_Conta.Name = "Tsm_Conta";
            this.Tsm_Conta.Size = new System.Drawing.Size(125, 20);
            this.Tsm_Conta.Text = "toolStripMenuItem1";
            // 
            // Tsm_ApagarConta
            // 
            this.Tsm_ApagarConta.Name = "Tsm_ApagarConta";
            this.Tsm_ApagarConta.Size = new System.Drawing.Size(180, 22);
            this.Tsm_ApagarConta.Text = "toolStripMenuItem2";
            this.Tsm_ApagarConta.Click += new System.EventHandler(this.Tsm_ApagarConta_Click);
            // 
            // Tsm_AlterarDados
            // 
            this.Tsm_AlterarDados.Name = "Tsm_AlterarDados";
            this.Tsm_AlterarDados.Size = new System.Drawing.Size(180, 22);
            this.Tsm_AlterarDados.Text = "toolStripMenuItem4";
            this.Tsm_AlterarDados.Click += new System.EventHandler(this.Tsm_AlterarDados_Click);
            // 
            // Tsm_Sair
            // 
            this.Tsm_Sair.Name = "Tsm_Sair";
            this.Tsm_Sair.Size = new System.Drawing.Size(125, 20);
            this.Tsm_Sair.Text = "toolStripMenuItem3";
            this.Tsm_Sair.Click += new System.EventHandler(this.Tsm_Sair_Click);
            // 
            // Tsm_AlterarSenha
            // 
            this.Tsm_AlterarSenha.Name = "Tsm_AlterarSenha";
            this.Tsm_AlterarSenha.Size = new System.Drawing.Size(180, 22);
            this.Tsm_AlterarSenha.Text = "toolStripMenuItem1";
            this.Tsm_AlterarSenha.Click += new System.EventHandler(this.Tsm_AlterarSenha_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 388);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Lbl_Operacoes);
            this.Controls.Add(this.Lbl_Saldo);
            this.Controls.Add(this.Btn_Historico);
            this.Controls.Add(this.Btn_Transferencia);
            this.Controls.Add(this.Btn_Depositar);
            this.Controls.Add(this.Btn_Sacar);
            this.Controls.Add(this.Lbl_NomeUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Principal";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Sacar;
        private System.Windows.Forms.Button Btn_Depositar;
        private System.Windows.Forms.Button Btn_Transferencia;
        private System.Windows.Forms.Button Btn_Historico;
        private System.Windows.Forms.Label Lbl_Operacoes;
        private System.Windows.Forms.Label Lbl_NomeUsuario;
        private System.Windows.Forms.Label Lbl_Saldo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Conta;
        private System.Windows.Forms.ToolStripMenuItem Tsm_ApagarConta;
        private System.Windows.Forms.ToolStripMenuItem Tsm_AlterarDados;
        private System.Windows.Forms.ToolStripMenuItem Tsm_Sair;
        private System.Windows.Forms.ToolStripMenuItem Tsm_AlterarSenha;
    }
}