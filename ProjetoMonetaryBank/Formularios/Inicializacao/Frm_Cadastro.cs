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
using Forms.BancoDeDados;
using Refit;
using Forms;
//using WSCorreios;


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

        public void Btn_Continuar_Click(object sender, EventArgs e)
        {


            bool CadastroConcluido = false;
            try
            {
                
                Validacoes.Unit C = new Validacoes.Unit();
                C = LeituraFormulario();
                C.ValidaClasse();
                try
                {
                    var ctx = new Context();
                    
                    var verificaExistencia = ctx.cliente.Where(c => c.CPF == Msk_CPF.Text).SingleOrDefault();
                    
                    if(verificaExistencia != null)
                    {
                        MessageBox.Show("Esse usuário ja existe!", "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        InsereCliente();
                        MessageBox.Show("Cadastro Realizado com Sucesso!");
                        using (var f = new Frm_CriaSenha(Msk_CPF.Text))
                        {
                            this.Hide();
                            f.ShowDialog();
                        }
                        CadastroConcluido = true;
                    }
                }
                catch(System.Exception Ex)
                {
                   MessageBox.Show(Ex.Message, "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if(CadastroConcluido == true)
                    {
                        this.Close();
                    }
                }
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Msk_CEP_Leave(object sender, EventArgs e)
        {
            BuscarCEP(Msk_CEP.Text);
        }

        async Task BuscarCEP(string cep)
        {
            try
            {
                var cepBuscar = RestService.For<ICepApiService>("https://viacep.com.br");
                var endereco = await cepBuscar.GetAddressAsync(cep);

                Txt_Rua.Text = endereco.Logradouro;
                Txt_Bairro.Text = endereco.Bairro;
                Txt_Cidade.Text = endereco.Localidade;

                Cmb_Estados.SelectedIndex = -1;
                for (int i = 0; i <= Cmb_Estados.Items.Count - 1; i++)
                {
                    var vPos = Strings.InStr(Cmb_Estados.Items[i].ToString(), "(" + endereco.Uf + ")");
                    if (vPos > 0)
                    {
                        Cmb_Estados.SelectedIndex = i;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Banco de dados
        public void InsereCliente()
        {
            Cliente c = new Cliente();
            Endereco e = new Endereco();
            Login l = new Login();
            Context ctx = new Context();

            try
            {
                var Renda = Txt_Renda.Text;
                c.Nome = Txt_Nome.Text;
                c.CPF = Msk_CPF.Text;
                c.RG = Msk_RG.Text;
                c.Email = Txt_Email.Text;
                c.Nacimento = Msk_DataNascimento.Text;
                c.Telefone = Msk_Telefone.Text;
                c.NomeMae = Txt_NomeMae.Text;
                c.NaoConstaMae = Chk_TemMae.Checked;
                c.NomePai = Txt_NomePai.Text;
                c.NaoConstaPai = Chk_TemPai.Checked;
                c.CEP = Msk_CEP.Text;
                c.Profissao = Txt_Profissao.Text;
                c.Renda = Convert.ToDecimal(Renda);

                l.Saldo = 0;

                e.Cep = Msk_CEP.Text;
                e.Logradouro = Txt_Rua.Text;
                e.Numero = Txt_Numero.Text;
                e.Complemento = Txt_Complemento.Text;
                e.Bairro = Txt_Bairro.Text;
                e.Cidade = Txt_Cidade.Text;
                e.Estado = Cmb_Estados.Text;

                l.cpf = Msk_CPF.Text;

                if (Rdb_Masculino.Checked)
                {
                    c.Sexo = Rdb_Masculino.Text.First<char>().ToString();
                }
                else if (Rdb_Feminino.Checked)
                {
                    c.Sexo = Rdb_Feminino.Text.First<char>().ToString();
                }
                else if (Rdb_Indefinido.Checked)
                {
                    c.Sexo = Rdb_Indefinido.Text.First<char>().ToString();
                }

                ctx.login.Add(l);
                ctx.endereco.Add(e);
                ctx.cliente.Add(c);
                ctx.SaveChanges();
            }
            catch (ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void Frm_Cadastro_Load(object sender, EventArgs e)
        {
        }

        private void Msk_CEP_MouseLeave(object sender, EventArgs e)
        {

        }


    }
}