using Forms.BancoDeDados;
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

namespace Forms.Formularios.Operacoes
{
    public partial class Frm_Saque : Form
    {
        bool verSenha = false;
        string cpf;
        string senha;
        public Frm_Saque()
        {
            InitializeComponent();
            Lbl_NomeOperacao.Text = "Operação de Saque";
            Lbl_ValidaSenha.Text = "Digite sua Senha";
            Lbl_Valor.Text = "Qual valor deseja sacar?";
            Btn_Cancelar.Text = "Cancelar";
            Btn_Confirmar.Text = "Confirmar";
            this.Text = "Sacar";
            Btn_Senha.Text = "Mostrar";
        }

        public Frm_Saque(string Cpf, string Senha) : this()
        {
            cpf = Cpf;
            senha = Senha;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Validacoes.OutrasOperacoes C = new Validacoes.OutrasOperacoes();
                C = LeituraFormulario();
                C.ValidaClasse();

                if (MessageBox.Show("Você tem certeza que deseja realizar esta operação?", "Monetary Bank", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes
                    && Txt_ValidaSenha.Text == senha)
                {
                    try
                    {
                        using (var ctx = new Context())
                        {
                            var RetiraSaldo = ctx.cliente.First(p => p.CPF == cpf);
                            var ValorConvertido = Convert.ToDouble(Txt_Valor.Text);
                            if (RetiraSaldo.Saldo >= ValorConvertido)
                            {
                                if (ValorConvertido != 0)
                                {
                                    RetiraSaldo.Saldo = RetiraSaldo.Saldo - ValorConvertido;
                                    ctx.SaveChanges();
                                    MessageBox.Show("Operação realizada com sucesso!", "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("O Valor deve ser maior que 0! ", "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Saldo Insuficiente ", "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message, "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Senha Incorreta", "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Validacoes.OutrasOperacoes LeituraFormulario()
        {
            //Validações dos dados do formulario
            Validacoes.OutrasOperacoes C = new Validacoes.OutrasOperacoes();
            C.Valor = Txt_Valor.Text;
            C.Senha = Txt_ValidaSenha.Text;
            return C;
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

        private void button1_Click(object sender, EventArgs e)
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
    }
}
