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

namespace Forms.Formularios.Inicializacao
{
    public partial class AtualizaSenha : Form
    {
        bool verSenha = false;
        public static bool FechaFormPrincipal = false;
        public AtualizaSenha()
        {
            InitializeComponent();

            Lbl_CPF.Text = "CPF";
            Lbl_Senha.Text = "nova senha";
            Lbl_SenhaConfirma.Text = "Digite a senha novamente";
            Btn_Finalizar.Text = "Finalizar";
            Btn_Voltar.Text = "Voltar";
            this.Text = "Monetary Bank";
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
             this.Close();
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
                            MessageBox.Show("Senha Atualizada com Sucesso");
                            try
                            {
                                this.Hide();
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

        private void Btn_Finalizar_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Btn_Finalizar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void Btn_Voltar_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Btn_Voltar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
