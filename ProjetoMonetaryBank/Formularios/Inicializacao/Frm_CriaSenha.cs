using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjetoMonetaryBank.Inicializacao;
using Forms.BancoDeDados;

namespace ProjetoMonetaryBank.Inicializacao
{
    public partial class Frm_CriaSenha : Form
    {
        bool verSenha = false;
        public Frm_CriaSenha()
        {
            InitializeComponent();
            Lbl_CPF.Text = "Digite seu CPF";
            Lbl_Senha.Text = "nova senha";
            Lbl_SenhaConfirma.Text = "Digite a senha novamente";
            Btn_Finalizar.Text = "Finalizar";
            Btn_Voltar.Text = "Voltar";
            this.Text = "Monetary Bank";
        }

        private void Lbl_SenhaConfirma_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Frm_Cadastro f = new Frm_Cadastro();
                f.ShowDialog();
            }
            finally
            {
                this.Close();
            }
        }

        Validacoes.Unit ValidaSenha()
        {
            Validacoes.Unit C = new Validacoes.Unit();
            C.Senha = Txt_Senha.Text;
            C.SenhaConfirma = Txt_SenhaConfirma.Text;
            return C;
        }

        private void Btn_Finalizar_Click(object sender, EventArgs e)
        {
            NovaSenha();
        }

        private void Btn_Senha1_Click(object sender, EventArgs e)
        {
            if (verSenha == false)
            {
                Txt_Senha.PasswordChar = '\0';
                verSenha = true;
                Btn_Senha1.Text = "Esconder";
            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                verSenha = false;
                Btn_Senha1.Text = "Mostrar";
            }
        }

        private void Btn_Senha2_Click(object sender, EventArgs e)
        {
            if (verSenha == false)
            {
                Txt_SenhaConfirma.PasswordChar = '\0';
                verSenha = true;
                Btn_Senha2.Text = "Esconder";
            }
            else
            {
                Txt_SenhaConfirma.PasswordChar = '*';
                verSenha = false;
                Btn_Senha2.Text = "Mostrar";
            }
        }
        void NovaSenha()
        {
            try
            {
                Login l = new Login();

                using (var ctx = new Context())
                {
                    var resultado = ctx.cliente.Where(x => x.CPF == Msk_CPF.Text).FirstOrDefault<Cliente>();
                    l.CPF = Msk_CPF.Text;
                    if (resultado != null)
                    {
                        if (Txt_Senha.Text == Txt_SenhaConfirma.Text && Txt_Senha.Text != "" && Txt_SenhaConfirma.Text != "")
                        {
                            l.Senha = Txt_Senha.Text;
                            ctx.login.Add(l);
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
                        else
                        {
                            MessageBox.Show("As senha devem ser iguais");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CPF inválido");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro, Tente novamente" + ex);
            }
        }
    }
}
