using Forms.Formularios.Operacoes;
using ProjetoMonetaryBank.Inicializacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMonetaryBank.Principal
{
    public partial class Frm_Principal : Form
    {
        string CPF;
        public Frm_Principal()
        {
            InitializeComponent();
            Lbl_Operacoes.Text = "Operações";
            Lbl_Saldo.Text = "Seu Saldo: ";
            Btn_Depositar.Text = "Depositar";
            Btn_Historico.Text = "Historico";
            Btn_Sacar.Text = "Sacar";
            Btn_Transferencia.Text = "Transferir";
            this.Text = "Monetary Bank";
        }

        public Frm_Principal(string Nome, double Saldo, string Cpf) : this()
        {
             Lbl_NomeUsuario.Text = "Olá " + Nome;
             Lbl_Saldo.Text = "Seu Saldo: R$" + Saldo.ToString();
             CPF = Cpf;
        }

        public Frm_Principal(double Saldo) : this()
        {
            Lbl_Saldo.Text = Saldo.ToString();
        }
        public void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Sacar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new Frm_Saque(CPF))
                {
                    f.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Um erro inesperado aconteceu", "Erro");
            }
        }

        private void Btn_Depositar_Click(object sender, EventArgs e)
        {
            using (var f = new Frm_Deposito(CPF))
            {
                f.ShowDialog();
            }
        }

        private void Btn_Transferencia_Click(object sender, EventArgs e)
        {
            using (var f = new Frm_Tranferencia(CPF))
            {
                f.ShowDialog();
            }
        }

        private void Btn_Historico_Click(object sender, EventArgs e)
        {
            Frm_Historico f = new Frm_Historico();
            f.ShowDialog();
        }

        private void Pcb_Imagem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Frm_Login f = new Frm_Login();
                f.ShowDialog();
            }
            finally
            {
                this.Close();
            }
        }

        private void Btn_Sacar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Btn_Sacar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Btn_Depositar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Btn_Depositar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Btn_Transferencia_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Btn_Transferencia_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Btn_Historico_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Btn_Historico_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Pcb_Imagem_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Pcb_Imagem_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Lbl_Teste_Click(object sender, EventArgs e)
        {

        }
    }
}
