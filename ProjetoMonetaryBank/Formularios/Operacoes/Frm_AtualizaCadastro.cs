using Forms.BancoDeDados;
using Microsoft.VisualBasic;
using ProjetoMonetaryBank.Inicializacao;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Formularios.Operacoes
{
    public partial class Frm_AtualizaCadastro : Form
    {
        string CPF;
        public Frm_AtualizaCadastro()
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

        public Frm_AtualizaCadastro(string cpf) : this()
        {
            CPF = cpf;

            using(var ctx = new Context())
            {
                var query = ctx.cliente.FirstOrDefault(c => c.CPF == CPF);
                var queryEndereco = ctx.endereco.FirstOrDefault(e => e.Cep == query.CEP);
                var Renda = query.Renda;

                Txt_Nome.Text = query.Nome;
                Msk_CPF.Text = query.CPF;
                Msk_RG.Text = query.RG;
                Txt_Email.Text = query.Email;
                Txt_NomeMae.Text = query.NomeMae;
                Txt_NomePai.Text = query.NomePai;
                Msk_DataNascimento.Text = query.Nacimento;
                Msk_Telefone.Text = query.Telefone;
                Txt_Renda.Text = query.Renda.ToString("N2");
                Txt_Profissao.Text = query.Profissao;
                Msk_CEP.Text = query.CEP;

                Txt_Rua.Text = queryEndereco.Logradouro;
                Txt_Bairro.Text = queryEndereco.Bairro;
                Txt_Cidade.Text = queryEndereco.Cidade;
                Txt_Numero.Text = queryEndereco.Numero;
                Cmb_Estados.SelectedItem = queryEndereco.Estado;
                Txt_Complemento.Text = queryEndereco.Complemento;

                if (query.Sexo == "M")
                {
                    Rdb_Masculino.Checked = true;
                }
                else if (query.Sexo == "F")
                {
                    Rdb_Feminino.Checked = true;
                }
                else if (query.Sexo == "I")
                {
                    Rdb_Indefinido.Checked = true;
                }

                if (query.NaoConstaPai == true)
                {
                    Chk_TemPai.Checked = true;
                }
                else
                {
                    Chk_TemPai.Checked = false;
                }
                if (query.NaoConstaMae == true)
                {
                    Chk_TemMae.Checked = true;
                }
                else
                {
                    Chk_TemMae.Checked = false;
                }
            }
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

        private void Btn_Continuar_Click(object sender, EventArgs e)
        {
            try
            {
                Validacoes.Unit C = new Validacoes.Unit();
                C = LeituraFormulario();
                C.ValidaClasse();
                try
                {
                    using (var ctx = new Context())
                    {
                        var u = ctx.cliente.FirstOrDefault(c => c.CPF == CPF);
                        var a = ctx.endereco.FirstOrDefault(c => c.Cep == u.CEP);
                        var Renda = Txt_Renda.Text;

                        u.Email = Txt_Email.Text;
                        u.Telefone = Msk_Telefone.Text;
                        u.Profissao = Txt_Profissao.Text;
                        u.Renda = Convert.ToDecimal(Renda);
                        u.CEP = Msk_CEP.Text;
                        a.Cep = u.CEP;
                        a.Bairro = Txt_Bairro.Text;
                        a.Cidade = Txt_Cidade.Text;
                        a.Logradouro = Txt_Rua.Text;
                        a.Numero = Txt_Numero.Text;
                        a.Estado = Cmb_Estados.Text;
                        a.Complemento = Txt_Complemento.Text;

                        if (Rdb_Masculino.Checked)
                        {
                            u.Sexo = Rdb_Masculino.Text.First<char>().ToString();
                        }
                        else if (Rdb_Feminino.Checked)
                        {
                            u.Sexo = Rdb_Feminino.Text.First<char>().ToString();
                        }
                        else if (Rdb_Indefinido.Checked)
                        {
                            u.Sexo = Rdb_Indefinido.Text.First<char>().ToString();
                        }

                        ctx.SaveChanges();

                        MessageBox.Show("Cadastro atualizado com sucesso!");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Continuar_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Btn_Continuar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void Btn_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Btn_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        public void DesativaNumero(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void DesativaLetras(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void Txt_Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaLetras(e);
        }

        private void Txt_Bairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaNumero(e);
        }

        private void Txt_Cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Cidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaNumero(e);
        }

        private void Txt_Renda_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaLetras(e);
        }

        private void Txt_Profissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            DesativaNumero(e);
        }

        private void Msk_CEP_Leave(object sender, EventArgs e)
        {
            BuscarCEP(Msk_CEP.Text);
        }
    }
}
