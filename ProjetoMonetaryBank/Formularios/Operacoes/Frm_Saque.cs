﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Formularios.Operacoes
{
    public partial class Frm_Saque : Form
    {
        public Frm_Saque()
        {
            InitializeComponent();
            Lbl_NomeOperacao.Text = "Operação de Saque";
            Lbl_ValidaSenha.Text = "Digite sua Senha";
            Lbl_Valor.Text = "Qual valor deseja sacar?";
            Btn_Cancelar.Text = "Cancelar";
            Btn_Confirmar.Text = "Confirmar";
            this.Text = "Sacar";
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você tem certeza que deseja realizar esta operação?", "Monetary Bank", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void Lbl_NomeOperacao_Click(object sender, EventArgs e)
        {
          
        }

        private void Btn_Cancelar_MouseEnter_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Btn_Cancelar_MouseLeave_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Btn_Confirmar_MouseEnter_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Btn_Confirmar_MouseLeave_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
