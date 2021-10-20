﻿using Forms.BancoDeDados;
using ProjetoMonetaryBank.Principal;
using System;
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
    public partial class Frm_Deposito : Form
    {
        string cpf;
        public Frm_Deposito()
        {
            InitializeComponent();
            Lbl_NomeOperacao.Text = "Operação de Deposito";
            Lbl_Valor.Text = "Digite o Valor a ser Depositado";
            Lbl_ValidaSenha.Text = "Confirme Sua Senha";
            Btn_Cancelar.Text = "Cancelar";
            Btn_Confirmar.Text = "Confirmar";
            this.Text = "Depositar";
        }

        public Frm_Deposito(string Cpf) : this()
        {
            cpf = Cpf;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você tem certeza que deseja realizar esta operação?", "Monetary Bank", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                using (var ctx = new Context())
                {
                    var AdicionaSaldo = ctx.cliente.First(p => p.CPF == cpf);
                    var ValorConvertido = Convert.ToDouble(Txt_Valor.Text);
                    AdicionaSaldo.Saldo = AdicionaSaldo.Saldo + ValorConvertido;
                    ctx.SaveChanges();
                    //using (var f = new Frm_Principal(AdicionaSaldo.Saldo))
                    //{

                    //}
                    this.Close();
                }
            }
        }

        private void Btn_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Btn_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Btn_Confirmar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Btn_Confirmar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
