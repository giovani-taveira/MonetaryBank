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
            Lbl_CPF.Text = "CPF";
            Lbl_Senha.Text = "Nova senha";
            Lbl_SenhaConfirma.Text = "Digite a senha novamente";
            Btn_Finalizar.Text = "Finalizar";
            Btn_Voltar.Text = "Voltar";
            this.Text = "Monetary Bank";
        }

        public Frm_CriaSenha(string cpf) : this()
        {
            Msk_CPF.Text = cpf;
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

        private void Btn_Finalizar_Click(object sender, EventArgs e)
        {
            try
            {
                NovaSenha();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                using (var ctx = new Context())
                {
                    var resultado = ctx.login.Where(x => x.cpf == Msk_CPF.Text).FirstOrDefault<Login>();
                    if (resultado != null)
                    {
                        if (Txt_Senha.Text == Txt_SenhaConfirma.Text && Txt_Senha.Text != "" && Txt_SenhaConfirma.Text != "")
                        {
                            resultado.Senha = Txt_Senha.Text;
                            ctx.SaveChanges();
                            MessageBox.Show("Senha Criada com Sucesso");
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, Tente novamente" + ex);
            }
        }
    }
}
