
namespace ProjetoMonetaryBank
{
    partial class Frm_Carregamento
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Carregamento));
            this.Lbl_Mensagem = new System.Windows.Forms.Label();
            this.Pcb_Logo = new System.Windows.Forms.PictureBox();
            this.Prb_Progress = new System.Windows.Forms.ProgressBar();
            this.Trm_Carregamento = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Mensagem
            // 
            this.Lbl_Mensagem.AutoSize = true;
            this.Lbl_Mensagem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Mensagem.Location = new System.Drawing.Point(111, 311);
            this.Lbl_Mensagem.Name = "Lbl_Mensagem";
            this.Lbl_Mensagem.Size = new System.Drawing.Size(149, 25);
            this.Lbl_Mensagem.TabIndex = 0;
            this.Lbl_Mensagem.Text = "Seja Bem Vindo!";
            this.Lbl_Mensagem.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pcb_Logo
            // 
            this.Pcb_Logo.Image = global::ProjetoMonetaryBank.Properties.Resources.Logo_Finalizado;
            this.Pcb_Logo.Location = new System.Drawing.Point(38, 12);
            this.Pcb_Logo.Name = "Pcb_Logo";
            this.Pcb_Logo.Size = new System.Drawing.Size(300, 275);
            this.Pcb_Logo.TabIndex = 1;
            this.Pcb_Logo.TabStop = false;
            // 
            // Prb_Progress
            // 
            this.Prb_Progress.Location = new System.Drawing.Point(38, 399);
            this.Prb_Progress.Name = "Prb_Progress";
            this.Prb_Progress.Size = new System.Drawing.Size(300, 23);
            this.Prb_Progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Prb_Progress.TabIndex = 2;
            // 
            // Trm_Carregamento
            // 
            this.Trm_Carregamento.Enabled = true;
            this.Trm_Carregamento.Interval = 1000;
            this.Trm_Carregamento.Tick += new System.EventHandler(this.Trm_Carregamento_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aguarde um instante...";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Frm_Carregamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Prb_Progress);
            this.Controls.Add(this.Pcb_Logo);
            this.Controls.Add(this.Lbl_Mensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Carregamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Carregamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pcb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Mensagem;
        private System.Windows.Forms.PictureBox Pcb_Logo;
        private System.Windows.Forms.ProgressBar Prb_Progress;
        private System.Windows.Forms.Timer Trm_Carregamento;
        private System.Windows.Forms.Label label1;
    }
}

