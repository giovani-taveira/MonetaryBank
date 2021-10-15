
namespace ProjetoMonetaryBank.Principal
{
    partial class Frm_Principal
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
            this.Lbl_SeuSaldo = new System.Windows.Forms.Label();
            this.Lbl_Operacoes = new System.Windows.Forms.Label();
            this.Pcb_Imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_NomeUsuario
            // 
            this.Lbl_NomeUsuario.AutoSize = true;
            this.Lbl_NomeUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_NomeUsuario.Location = new System.Drawing.Point(130, 45);
            this.Lbl_NomeUsuario.Name = "Lbl_NomeUsuario";
            this.Lbl_NomeUsuario.Size = new System.Drawing.Size(63, 25);
            this.Lbl_NomeUsuario.TabIndex = 0;
            this.Lbl_NomeUsuario.Text = "label1";
            // 
            // Btn_Sacar
            // 
            this.Btn_Sacar.Location = new System.Drawing.Point(46, 287);
            this.Btn_Sacar.Name = "Btn_Sacar";
            this.Btn_Sacar.Size = new System.Drawing.Size(133, 65);
            this.Btn_Sacar.TabIndex = 1;
            this.Btn_Sacar.Text = "button1";
            this.Btn_Sacar.UseVisualStyleBackColor = true;
            // 
            // Btn_Depositar
            // 
            this.Btn_Depositar.Location = new System.Drawing.Point(46, 358);
            this.Btn_Depositar.Name = "Btn_Depositar";
            this.Btn_Depositar.Size = new System.Drawing.Size(133, 66);
            this.Btn_Depositar.TabIndex = 2;
            this.Btn_Depositar.Text = "button2";
            this.Btn_Depositar.UseVisualStyleBackColor = true;
            // 
            // Btn_Transferencia
            // 
            this.Btn_Transferencia.Location = new System.Drawing.Point(202, 287);
            this.Btn_Transferencia.Name = "Btn_Transferencia";
            this.Btn_Transferencia.Size = new System.Drawing.Size(135, 65);
            this.Btn_Transferencia.TabIndex = 3;
            this.Btn_Transferencia.Text = "button3";
            this.Btn_Transferencia.UseVisualStyleBackColor = true;
            // 
            // Btn_Historico
            // 
            this.Btn_Historico.Location = new System.Drawing.Point(202, 358);
            this.Btn_Historico.Name = "Btn_Historico";
            this.Btn_Historico.Size = new System.Drawing.Size(135, 66);
            this.Btn_Historico.TabIndex = 4;
            this.Btn_Historico.Text = "button4";
            this.Btn_Historico.UseVisualStyleBackColor = true;
            // 
            // Lbl_SeuSaldo
            // 
            this.Lbl_SeuSaldo.AutoSize = true;
            this.Lbl_SeuSaldo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_SeuSaldo.Location = new System.Drawing.Point(12, 160);
            this.Lbl_SeuSaldo.Name = "Lbl_SeuSaldo";
            this.Lbl_SeuSaldo.Size = new System.Drawing.Size(63, 25);
            this.Lbl_SeuSaldo.TabIndex = 5;
            this.Lbl_SeuSaldo.Text = "label1";
            // 
            // Lbl_Operacoes
            // 
            this.Lbl_Operacoes.AutoSize = true;
            this.Lbl_Operacoes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Operacoes.Location = new System.Drawing.Point(12, 250);
            this.Lbl_Operacoes.Name = "Lbl_Operacoes";
            this.Lbl_Operacoes.Size = new System.Drawing.Size(63, 25);
            this.Lbl_Operacoes.TabIndex = 6;
            this.Lbl_Operacoes.Text = "label1";
            // 
            // Pcb_Imagem
            // 
            this.Pcb_Imagem.Location = new System.Drawing.Point(12, 12);
            this.Pcb_Imagem.Name = "Pcb_Imagem";
            this.Pcb_Imagem.Size = new System.Drawing.Size(110, 110);
            this.Pcb_Imagem.TabIndex = 7;
            this.Pcb_Imagem.TabStop = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.Pcb_Imagem);
            this.Controls.Add(this.Lbl_Operacoes);
            this.Controls.Add(this.Lbl_SeuSaldo);
            this.Controls.Add(this.Btn_Historico);
            this.Controls.Add(this.Btn_Transferencia);
            this.Controls.Add(this.Btn_Depositar);
            this.Controls.Add(this.Btn_Sacar);
            this.Controls.Add(this.Lbl_NomeUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Principal";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_NomeUsuario;
        private System.Windows.Forms.Button Btn_Sacar;
        private System.Windows.Forms.Button Btn_Depositar;
        private System.Windows.Forms.Button Btn_Transferencia;
        private System.Windows.Forms.Button Btn_Historico;
        private System.Windows.Forms.Label Lbl_SeuSaldo;
        private System.Windows.Forms.Label Lbl_Operacoes;
        private System.Windows.Forms.PictureBox Pcb_Imagem;
    }
}