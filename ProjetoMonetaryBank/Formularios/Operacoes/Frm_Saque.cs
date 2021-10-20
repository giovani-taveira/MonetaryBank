using Forms.BancoDeDados;
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
    public partial class Frm_Saque : Form
    {
        string cpf;
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

        public Frm_Saque(string Cpf) : this()
        {
            cpf = Cpf;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja realizar esta operação?", "Monetary Bank", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var ctx = new Context())
                {
                    var RetiraSaldo = ctx.cliente.First(p => p.CPF == cpf);
                    var ValorConvertido = Convert.ToDouble(Txt_Valor.Text);
                    if(RetiraSaldo.Saldo >= ValorConvertido)
                    {
                        RetiraSaldo.Saldo = RetiraSaldo.Saldo - ValorConvertido;
                    }
                    else
                    {
                        MessageBox.Show("Saldo Insuficiente ", "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ctx.SaveChanges();
                }
            }
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
