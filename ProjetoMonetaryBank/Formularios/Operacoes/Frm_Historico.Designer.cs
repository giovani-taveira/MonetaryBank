
namespace Forms.Formularios.Operacoes
{
    partial class Frm_Historico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Historico));
            this.Dgv_Historico = new System.Windows.Forms.DataGridView();
            this.Lbl_Operacoes = new System.Windows.Forms.Label();
            this.Cmb_Operacoes = new System.Windows.Forms.ComboBox();
            this.Btn_Pesquisar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Historico)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Historico
            // 
            this.Dgv_Historico.AllowUserToOrderColumns = true;
            this.Dgv_Historico.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Dgv_Historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Historico.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_Historico.Location = new System.Drawing.Point(12, 102);
            this.Dgv_Historico.Name = "Dgv_Historico";
            this.Dgv_Historico.RowTemplate.Height = 25;
            this.Dgv_Historico.Size = new System.Drawing.Size(645, 223);
            this.Dgv_Historico.TabIndex = 0;
            this.Dgv_Historico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Lbl_Operacoes
            // 
            this.Lbl_Operacoes.AutoSize = true;
            this.Lbl_Operacoes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Operacoes.Location = new System.Drawing.Point(12, 14);
            this.Lbl_Operacoes.Name = "Lbl_Operacoes";
            this.Lbl_Operacoes.Size = new System.Drawing.Size(63, 25);
            this.Lbl_Operacoes.TabIndex = 1;
            this.Lbl_Operacoes.Text = "label1";
            // 
            // Cmb_Operacoes
            // 
            this.Cmb_Operacoes.FormattingEnabled = true;
            this.Cmb_Operacoes.Location = new System.Drawing.Point(12, 62);
            this.Cmb_Operacoes.Name = "Cmb_Operacoes";
            this.Cmb_Operacoes.Size = new System.Drawing.Size(189, 23);
            this.Cmb_Operacoes.TabIndex = 2;
            // 
            // Btn_Pesquisar
            // 
            this.Btn_Pesquisar.Location = new System.Drawing.Point(207, 60);
            this.Btn_Pesquisar.Name = "Btn_Pesquisar";
            this.Btn_Pesquisar.Size = new System.Drawing.Size(75, 25);
            this.Btn_Pesquisar.TabIndex = 3;
            this.Btn_Pesquisar.Text = "button1";
            this.Btn_Pesquisar.UseVisualStyleBackColor = true;
            this.Btn_Pesquisar.Click += new System.EventHandler(this.Btn_Pesquisar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(12, 340);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(105, 36);
            this.Btn_Cancelar.TabIndex = 4;
            this.Btn_Cancelar.Text = "button1";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            this.Btn_Cancelar.MouseEnter += new System.EventHandler(this.Btn_Cancelar_MouseEnter);
            this.Btn_Cancelar.MouseLeave += new System.EventHandler(this.Btn_Cancelar_MouseLeave);
            // 
            // Frm_Historico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 388);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Pesquisar);
            this.Controls.Add(this.Cmb_Operacoes);
            this.Controls.Add(this.Lbl_Operacoes);
            this.Controls.Add(this.Dgv_Historico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Historico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historico";
            this.Load += new System.EventHandler(this.Frm_Historico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Historico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Historico;
        private System.Windows.Forms.Label Lbl_Operacoes;
        private System.Windows.Forms.ComboBox Cmb_Operacoes;
        private System.Windows.Forms.Button Btn_Pesquisar;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}