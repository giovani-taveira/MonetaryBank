using Forms.BancoDeDados;
using Forms.Formularios.Inicializacao;
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
        string senha;
        decimal saldo;
        string Cep;
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
            Tsm_AlterarDados.Text = "Alterar Dados";
            Tsm_ApagarConta.Text = "Apagar Conta";
            Tsm_AlterarDados.Text = "Alterar Dados";
            Tsm_AlterarSenha.Text = "Alterar Senha";
            Tsm_Conta.Text = "Conta";
            Tsm_Sair.Text = "Sair";
        }

        public Frm_Principal(string Nome, decimal Saldo, string Cpf, string Senha, string CEP) : this()
        {
            Lbl_NomeUsuario.Text = "Olá " + Nome;
            CPF = Cpf;
            senha = Senha;
            Cep = CEP;
            VerificaSaldo(CPF);
        }

        private void Btn_Sacar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new Frm_Saque(CPF, senha))
                {
                    f.ShowDialog();
                    VerificaSaldo(CPF);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Um erro inesperado aconteceu", "Erro");
            }
        }

        private void Btn_Depositar_Click(object sender, EventArgs e)
        {
            using (var f = new Frm_Deposito(CPF, senha))
            {
                f.ShowDialog();
                VerificaSaldo(CPF);
            }
        }

        private void Btn_Transferencia_Click(object sender, EventArgs e)
        {
            using (var f = new Frm_Tranferencia(CPF, senha))
            {
                f.ShowDialog();
                VerificaSaldo(CPF);
            }
        }

        public void VerificaSaldo(string Cpf)
        {
            using (var ctx = new Context())
            {
                var saldoAtualiza = ctx.login.Where(p => p.cpf == Cpf).FirstOrDefault<Login>();
                
                saldo = saldoAtualiza.Saldo;
                Lbl_Saldo.Text = "Seu Saldo: R$" + saldo.ToString("N2");
            }
        }

        private void Btn_Historico_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new Frm_Historico(CPF))
                {
                    f.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Um erro inesperado aconteceu", "Erro");
            }
        }

        private void Tls_Sair_Click_1(object sender, EventArgs e)
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

        private void Tsm_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Monetary Bank", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
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
        }

        private void Tsm_ApagarConta_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você tem certeza que deseja apagar sua conta? Essa ação não poderá ser desfeita!", "Monetary Bank", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                using (var ctx = new Context())
                {
                    var RemoverConta = ctx.cliente.SingleOrDefault(x => x.CPF == CPF);
                    var RemoverContaLogin = ctx.login.SingleOrDefault(x => x.cpf == CPF);
                    var RemoverContaEndereco = ctx.endereco.SingleOrDefault(x => x.Cep == Cep);
                    var RemoverHistorico = ctx.historico.Where(x => x.Cpf == CPF).ToList();

                    ctx.cliente.Remove(RemoverConta);
                    ctx.login.Remove(RemoverContaLogin);
                    ctx.endereco.Remove(RemoverContaEndereco);
                    foreach(Historico historico in RemoverHistorico)
                    {
                        ctx.historico.Remove(historico);
                    }
                    ctx.SaveChanges();

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
            }
        }

        private void Tsm_AlterarDados_Click(object sender, EventArgs e)
        {
            using (var f = new Frm_AtualizaCadastro(CPF))
            {
                f.ShowDialog();
            }
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void Tsm_AlterarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizaSenha f = new AtualizaSenha();
                f.ShowDialog();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
