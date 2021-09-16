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

namespace ProjetoMonetaryBank.Inicializacao
{
    public partial class Frm_CriaSenha : Form
    {
        public Frm_CriaSenha()
        {
            InitializeComponent();
            Lbl_CPF.Text = "Digite seu CPF";
            Lbl_Senha.Text = "nova senha";
            Lbl_SenhaConfirma.Text = "Digite a senha novamente";
            Btn_Finalizar.Text = "Finalizar";
            Btn_Voltar.Text = "Voltar";
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

        void NovaSenha()
        {
            //
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-S261MAM;Initial Catalog=MonetaryBank;Integrated Security=True");

            try
            {
                string verificaCpf = "(SELECT * FROM Cliente WHERE CPF = @CPF) ";
                conn.Open();
                SqlCommand c = new SqlCommand(verificaCpf, conn);
                c.Parameters.AddWithValue("@CPF", Msk_CPF.Text);
                SqlDataReader retorno = c.ExecuteReader();

                if (retorno.HasRows)
                {
                    if (Txt_Senha.Text == Txt_SenhaConfirma.Text && Txt_Senha.Text != "" && Txt_SenhaConfirma.Text != "")
                    {
                        //Atualizando a senha de acordo com a coluna CPF
                        conn.Close();

                        string novaSenha = "UPDATE LoginTable SET Senha = @Senha WHERE CPF = '" + Msk_CPF.Text + "'";

                        conn.Open();
                        SqlCommand d = new SqlCommand(novaSenha, conn);
                        d.Parameters.Add(new SqlParameter("@Senha", this.Txt_Senha.Text));
                        d.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Cadastro bem sucedido");
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
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro, Tente novamente" + ex);
            }
        }
        
    }
}
