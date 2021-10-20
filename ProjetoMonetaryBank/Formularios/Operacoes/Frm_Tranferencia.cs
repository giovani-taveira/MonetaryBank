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
    public partial class Frm_Tranferencia : Form
    {
        string cpf;
        public Frm_Tranferencia()
        {
            InitializeComponent();
            Lbl_NomeOperacao.Text = "Operação de Transferência";
            Lbl_Valor.Text = "Digite o Valor a ser Transferido";
            Lbl_ValidaSenha.Text = "Confirme Sua Senha";
            Lbl_CpfRecebedor.Text = "Digite o CPF do Recebedor";
            Btn_Cancelar.Text = "Cancelar";
            Btn_Confirmar.Text = "Confirmar";
            this.Text = "Transferir";
        }

        public Frm_Tranferencia(string Cpf) : this()
        {
            cpf = Cpf;
        }

        private void Lbl_ValidaSenha_Click(object sender, EventArgs e)
        {

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
                    var AdicionaSaldo = ctx.cliente.First(p => p.CPF == Msk_CpfRecebedor.Text);
                    var ValorConvertido = Convert.ToDouble(Txt_Valor.Text);
                    AdicionaSaldo.Saldo = AdicionaSaldo.Saldo + ValorConvertido;
                    var PerdeSaldo = ctx.cliente.First(p => p.CPF == cpf);
                    PerdeSaldo.Saldo -= ValorConvertido;

                    ctx.SaveChanges();
                }
            }
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
