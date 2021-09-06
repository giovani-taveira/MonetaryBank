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
using Microsoft.VisualBasic;
using ProjetoMonetaryBank.Inicializacao;

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
            Lbl_Telefone1.Text = "Telefone 1";
            Lbl_Telefone2.Text = "Telefone 2";
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
            Lbl_Carteira.Text = "Carteira de Trabalho";
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }

        public  void Btn_Continuar_Click(object sender, EventArgs e)
        {
            try
            {
                Validacoes.Unit C = new Validacoes.Unit();
                C = LeituraFormulario();
                C.ValidaClasse();
                try
                {
                    this.Hide();
                    Frm_CriaSenhacs f = new Frm_CriaSenhacs();
                    f.ShowDialog();
                }
                finally
                {
                    this.Close();
                }
            }
            catch(ValidationException Ex)
            {
                MessageBox.Show(Ex.Message, "Monetary Bank", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Validacoes.Unit LeituraFormulario()
            {
                Validacoes.Unit C = new Validacoes.Unit();
                C.RG = Msk_RG.Text;
                C.Nome = Txt_Nome.Text;
                C.NomeMae = Txt_NomeMae.Text;
                C.NomePai = Txt_NomePai.Text;
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

                C.Telefone1 = Msk_Telefone1.Text;
                C.Telefone2 = Msk_Telefone2.Text;
                C.Profissao = Txt_Profissao.Text;

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
    }
}
