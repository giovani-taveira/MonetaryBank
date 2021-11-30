using Forms.BancoDeDados;
using ProjetoMonetaryBank.Inicializacao;
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
    public partial class Frm_Tranferencia : Form
    {
        bool verSenha = false;
        string cpf;
        string senha;
        public Frm_Tranferencia()
        {
            InitializeComponent();
            Lbl_NomeOperacao.Text = "Operação de Transferência";
            Lbl_Valor.Text = "Digite o Valor a ser Transferido";
            Lbl_ValidaSenha.Text = "Insira Sua Senha";
            Lbl_CpfRecebedor.Text = "Digite o CPF do Recebedor";
            Btn_Cancelar.Text = "Cancelar";
            Btn_Confirmar.Text = "Confirmar";
            this.Text = "Transferir";
            Btn_Senha.Text = "Mostrar";
        }

        public Frm_Tranferencia(string Cpf, string Senha) : this()
        {
            cpf = Cpf;
            senha = Senha;
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
            try
            {
                Validacoes.Transferencia C = new Validacoes.Transferencia();
                C = LeituraFormulario();
                C.ValidaClasse();
                if (MessageBox.Show("Você tem certeza que deseja realizar esta operação?", "Monetary Bank", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
                        && Txt_ValidaSenha.Text == senha )
                {
                    using (var ctx = new Context())
                    {
                        try
                        {
                            var AdicionaSaldo = ctx.login.First(p => p.cpf == Msk_CpfRecebedor.Text);
                            if (Msk_CpfRecebedor.Text == cpf)
                            {
                                MessageBox.Show("Este CPF é inválido para esta operação!", "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                var ValorConvertido = Convert.ToDecimal(Txt_Valor.Text);
                                AdicionaSaldo.Saldo = AdicionaSaldo.Saldo + ValorConvertido;
                                var PerdeSaldo = ctx.login.First(p => p.cpf == cpf);

                                if (PerdeSaldo.Saldo >= ValorConvertido)
                                {
                                    if (ValorConvertido != 0)
                                    {
                                        PerdeSaldo.Saldo -= ValorConvertido;
                                        InsereHistorico();
                                        ctx.SaveChanges();
                                        MessageBox.Show("Operação realizada com sucesso!", "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("O valor deve ser maior que 0!", "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Saldo Insuficiente ", "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("CPF Inexistente", "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if(Txt_ValidaSenha.Text != senha)
                {
                    MessageBox.Show("Senha Incorreta", "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void InsereHistorico()
        {
            using (var ctx = new Context())
            {
                var Recebedor = ctx.cliente.First(p => p.CPF == Msk_CpfRecebedor.Text);
                var ValorConvertido = Convert.ToDecimal(Txt_Valor.Text);
                Historico h = new Historico();
                try
                {
                    h.Cpf = cpf;
                    h.Operacao = "Transferência";
                    h.NomeRecebedor = Recebedor.Nome;
                    h.Valor = Math.Round(ValorConvertido, 2);
                    h.Data_Operacao = DateTime.Now;

                    ctx.historico.Add(h);
                    ctx.SaveChanges();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        Validacoes.Transferencia LeituraFormulario()
        {
            //Validações dos dados do formulario
            Validacoes.Transferencia C = new Validacoes.Transferencia();
            C.Valor = Txt_Valor.Text;
            C.CPFRecebedor = Msk_CpfRecebedor.Text;
            C.Senha = Txt_ValidaSenha.Text;
            return C;
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

        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            if (verSenha == false)
            {
                Txt_ValidaSenha.PasswordChar = '\0';
                verSenha = true;
                Btn_Senha.Text = "Esconder";
            }
            else
            {
                Txt_ValidaSenha.PasswordChar = '*';
                verSenha = false;
                Btn_Senha.Text = "Mostrar";
            }
        }

        private void Txt_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46 && e.KeyChar != 44)
                e.Handled = true;
            else
                e.Handled = false;
        }
    }
}
