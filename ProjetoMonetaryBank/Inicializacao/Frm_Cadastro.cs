using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ProjetoMonetaryBank.Inicializacao;
using System.Data.SqlClient;
using DataBase;


namespace ProjetoMonetaryBank.Inicializacao
{
    public partial class Frm_Cadastro : Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();

            //Texts que aparecerão no formulário
            Lbl_Nome.Text = "Nome Completo";
            Lbl_CPF.Text = "CPF";
            Lbl_Sexo.Text = "Sexo";
            Rdb_Masculino.Text = "Masculino";
            Rdb_Feminino.Text = "Feminino";
            Rdb_Indefinido.Text = "Indefinido";
            Lbl_RG.Text = "RG";
            Lbl_Nascimento.Text = "Data de Nascimento";
            Lbl_Telefone.Text = "Telefone";
            Lbl_Email.Text = "Email";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Chk_TemMae.Text = "Não Consta";
            Lbl_NomePai.Text = "Nome do Pai";
            Chk_TemPai.Text = "Não Consta";
            Lbl_CEP.Text = "CEP";
            Grp_DadosPessoais.Text = "Dados Pessoais";
            Grp_Endereco.Text = "Endereço";
            Lbl_Rua.Text = "Rua";
            Lbl_Numero.Text = "Número";
            Lbl_Complemento.Text = "Complemento";
            Lbl_Cidade.Text = "Cidade";
            Lbl_Estado.Text = "Estado";
            Lbl_Profissao.Text = "Profissão";
            Lbl_Renda.Text = "Renda Mensal";
            Grp_Profissao.Text = "Profissão";
            Btn_Cancelar.Text = "Cancelar";
            Btn_Continuar.Text = "Continuar";
            Lbl_Bairro.Text = "Bairro";


            //Estados do combo box
            Cmb_Estados.Items.Clear();
            Cmb_Estados.Items.Add("Acre (AC)");
            Cmb_Estados.Items.Add("Alagoas(AL)");
            Cmb_Estados.Items.Add("Amapá(AP)");
            Cmb_Estados.Items.Add("Amazonas(AM)");
            Cmb_Estados.Items.Add("Bahia(BA)");
            Cmb_Estados.Items.Add("Ceará(CE)");
            Cmb_Estados.Items.Add("Distrito Federal(DF)");
            Cmb_Estados.Items.Add("Espírito Santo(ES)");
            Cmb_Estados.Items.Add("Goiás(GO)");
            Cmb_Estados.Items.Add("Maranhão(MA)");
            Cmb_Estados.Items.Add("Mato Grosso(MT)");
            Cmb_Estados.Items.Add("Mato Grosso do Sul(MS)");
            Cmb_Estados.Items.Add("Minas Gerais(MG)");
            Cmb_Estados.Items.Add("Pará(PA)");
            Cmb_Estados.Items.Add("Paraíba(PB)");
            Cmb_Estados.Items.Add("Paraná(PR)");
            Cmb_Estados.Items.Add("Pernambuco(PE)");
            Cmb_Estados.Items.Add("Piauí(PI)");
            Cmb_Estados.Items.Add("Rio de Janeiro(RJ)");
            Cmb_Estados.Items.Add("Rio Grande do Norte(RN)");
            Cmb_Estados.Items.Add("Rio Grande do Sul(RS)");
            Cmb_Estados.Items.Add("Rondônia(RO)");
            Cmb_Estados.Items.Add("Roraima(RR)");
            Cmb_Estados.Items.Add("Santa Catarina(SC)");
            Cmb_Estados.Items.Add("São Paulo(SP)");
            Cmb_Estados.Items.Add("Sergipe(SE)");
            Cmb_Estados.Items.Add("Tocantins(TO)");
        }
        private void Btn_Cancelar_Click(object sender, EventArgs e)
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

        private void Btn_Cancelar_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Btn_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void Btn_Continuar_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Btn_Continuar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void Chk_TemMae_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemMae.Checked == true)
            {
                Txt_NomeMae.Enabled = false;
                Txt_NomeMae.Text = "";
            }
            else
            {
                Txt_NomeMae.Enabled = true;
            }
        }

        private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemPai.Checked == true)
            {
                Txt_NomePai.Enabled = false;
                Txt_NomePai.Text = "";
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }

        public  void Btn_Continuar_Click(object sender, EventArgs e)
        {
            Cliente NovoCliente = new Cliente();

            NovoCliente.CPF = Msk_CPF.Text;
            Random NumeroConta = new Random();
            NumeroConta.Next();
            NovoCliente.Nome = Txt_Nome.Text;
            NovoCliente.RG = Msk_RG.Text;
            NovoCliente.Email = Txt_Email.Text;
            NovoCliente.Nascimento = Msk_DataNascimento.Text;
            NovoCliente.Telefone = Msk_Telefone.Text;
            NovoCliente.NomeMae = Txt_NomeMae.Text;
            NovoCliente.NaoConstaMae = Chk_TemMae.Checked;
            NovoCliente.NomePai = Txt_NomePai.Text;
            NovoCliente.NaoConstaPai = Chk_TemPai.Checked;
            NovoCliente.CEP = Msk_CEP.Text;
            NovoCliente.Rua = Txt_Rua.Text;
            NovoCliente.Numero = Txt_Rua.Text;
            NovoCliente.Complemento = Txt_Complemento.Text;
            NovoCliente.Bairro = Txt_Bairro.Text; 
            NovoCliente.Cidade = Txt_Cidade.Text;
            NovoCliente.Estado = Txt_Cidade.Text;
            NovoCliente.Profissao = Txt_Profissao.Text;
            //NovoCliente.Renda = Convert.ToDecimal(Txt_Renda.Text);

            if (Rdb_Feminino.Checked)
            {
                NovoCliente.Sexo = Rdb_Feminino.Text.First<char>();
            }
            else if (Rdb_Masculino.Checked)
            {
                NovoCliente.Sexo = Rdb_Masculino.Text.First<char>();
            }
            else if (Rdb_Indefinido.Checked)
            {
                NovoCliente.Sexo = Rdb_Indefinido.Text.First<char>();
            }

            try
            {
                AcessoDB.InsereCliente(NovoCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Ocorreu uma falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //String de conexão
            //SqlConnection connect = new SqlConnection("Data Source=DESKTOP-S261MAM;Initial Catalog=MonetaryBank;Integrated Security=True");

            //comando de inserção de dados no banco
            //string sql = "INSERT INTO Cliente(CPF, NumeroConta, Nome, Sexo, RG, Email, Nascimento, Telefone, NomeMae, NaoConstaMae, " +
            //    "NomePai, NaoConstaPai, CEP, Rua, Numero, Complemento, Bairro, Cidade, Estado, Carteira, Profissao, Renda)" +
            //    "VALUES (@CPF, @NumeroCOnta, @Nome, @Sexo, @RG, @Email, @Nascimento, @Telefone, @NomeMae, @NaoConstaMae, " +
            //    "@NomePai, @NaoConstaPai, @CEP, @Rua, @Numero, @Complemento, @Bairro, @Cidade, @Estado, @Carteira, @Profissao, @Renda)";

            
            //string sql2 = "INSERT INTO LoginTable(CPF) VALUES (@CPF)";

            //try
            //{
                //SqlCommand c = new SqlCommand(sql, connect);
                

                //Inserindo os dados no banco
                //c.Parameters.Add(new SqlParameter("@CPF", this.Msk_CPF.Text));
               // c.Parameters.Add(new SqlParameter("@NumeroConta", NumeroConta.Next()));
                //c.Parameters.Add(new SqlParameter("@Nome", this.Txt_Nome.Text));

                //if (Rdb_Masculino.Checked)
                //{
                    //c.Parameters.Add(new SqlParameter("@Sexo", Rdb_Masculino.Text.First<char>()));
                //}
               // else if (Rdb_Feminino.Checked)
                //{
                    //c.Parameters.Add(new SqlParameter("@Sexo", Rdb_Feminino.Text.First<char>()));
                //}
                //else if (Rdb_Indefinido.Checked)
                //{
                    //c.Parameters.Add(new SqlParameter("@Sexo", Rdb_Indefinido.Text.First<char>()));
                //}

                //c.Parameters.Add(new SqlParameter("@RG", this.Msk_RG.Text));
                //c.Parameters.Add(new SqlParameter("@Email", this.Txt_Email.Text));
                //c.Parameters.Add(new SqlParameter("@Nascimento", this.Msk_DataNascimento.Text));
                //c.Parameters.Add(new SqlParameter("@Telefone", this.Msk_Telefone1.Text));
                //c.Parameters.Add(new SqlParameter("@NomeMae", this.Txt_NomeMae.Text));
                //c.Parameters.Add(new SqlParameter("@NaoConstaMae", this.Chk_TemMae.Checked));
                //c.Parameters.Add(new SqlParameter("@NomePai", this.Txt_NomePai.Text));
                //c.Parameters.Add(new SqlParameter("@NaoConstaPai", this.Chk_TemPai.Checked));
                //c.Parameters.Add(new SqlParameter("@CEP", this.Msk_CEP.Text));
                //c.Parameters.Add(new SqlParameter("@Rua", this.Txt_Rua.Text));
                //c.Parameters.Add(new SqlParameter("@Numero", this.Txt_Numero.Text));
                //c.Parameters.Add(new SqlParameter("@Complemento", this.Txt_Complemento.Text));
                //c.Parameters.Add(new SqlParameter("@Bairro", this.Txt_Bairro.Text));
                //c.Parameters.Add(new SqlParameter("@Cidade", this.Txt_Cidade.Text));
                //c.Parameters.Add(new SqlParameter("@Estado", this.Cmb_Estados.Text));
                //c.Parameters.Add(new SqlParameter("@Profissao", this.Txt_Profissao.Text));
                //c.Parameters.Add(new SqlParameter("@Renda", this.Txt_Renda.Text));

                //SqlCommand d = new SqlCommand(sql2, connect);
                //d.Parameters.Add(new SqlParameter("@CPF", this.Msk_CPF.Text));

                try
                {
                    Validacoes.Unit C = new Validacoes.Unit();
                    C = LeituraFormulario();
                    C.ValidaClasse();
                    try
                    {
                        //Abrindo uma conexão com o banco
                        //connect.Open();

                        //Executando o banco
                        //c.ExecuteNonQuery();
                        //d.ExecuteNonQuery();

                        //fechando a conexão com o banco
                        //connect.Close();

                        //status = 1;
                        // (status == 1)
                        //{
                            this.Hide();
                            Frm_CriaSenha f = new Frm_CriaSenha();
                            f.ShowDialog();
                        //}
                    }
                    finally
                    {
                        this.Close();
                    }
                }
                catch (ValidationException Ex)
                {
                    MessageBox.Show(Ex.Message, "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("Ocorreu um erro, Tente novamente" + ex);
            //}

            Validacoes.Unit LeituraFormulario()
            {
                //Validações dos dados do formulario
                Validacoes.Unit C = new Validacoes.Unit();
                C.RG = Msk_RG.Text;
                C.Nome = Txt_Nome.Text;
                C.NomeMae = Txt_NomeMae.Text;
                C.NomePai = Txt_NomePai.Text;
                C.DataDeNascimento = Msk_DataNascimento.Text;
                C.Numero = Txt_Numero.Text;
                
                if (Chk_TemPai.Checked)
                {
                    C.TemPai = true;
                }
                else
                {
                    C.TemPai = false;
                }
                if (Rdb_Masculino.Checked)
                {
                    C.Sexo = 0;
                }
                if (Rdb_Feminino.Checked)
                {
                    C.Sexo = 1;
                }
                if (Rdb_Indefinido.Checked)
                {
                    C.Sexo = 2;
                }

                C.CPF = Msk_CPF.Text;
                C.CEP = Msk_CEP.Text;
                C.Rua = Txt_Rua.Text;
                C.Complemento = Txt_Complemento.Text;
                C.Cidade = Txt_Cidade.Text;
                C.Bairro = Txt_Bairro.Text;

                if (Cmb_Estados.SelectedIndex < 0)
                {
                    C.Estado = "";
                }
                else
                {
                    C.Estado = Cmb_Estados.Items[Cmb_Estados.SelectedIndex].ToString();
                }

                C.Telefone1 = Msk_Telefone.Text;
                C.Profissao = Txt_Profissao.Text;

                //metodo do VB
                if (Information.IsNumeric(Txt_Renda.Text))
                {
                    Double vRenda = Convert.ToDouble(Txt_Renda.Text);
                    if (vRenda < 0)
                    {
                        C.Renda = 0;
                    }
                    else
                    {
                        C.Renda = vRenda;
                    }
                }
                return C;
            }
        }

        private void Frm_Cadastro_Load(object sender, EventArgs e)
        {
        }
    }
}
