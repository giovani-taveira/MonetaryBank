using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMonetaryBank.Inicializacao
{
    public partial class Frm_CriaSenhacs : Form
    {
        public Frm_CriaSenhacs()
        {
            InitializeComponent();
            Lbl_CPF.Text = "CPF";
            Txt_CPF.Enabled = false;
            Lbl_Senha.Text = "Crie uma nova senha";
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
    }
}
