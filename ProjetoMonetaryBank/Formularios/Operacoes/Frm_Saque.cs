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
        public Frm_Saque()
        {
            InitializeComponent();
            Lbl_NomeOperacao.Text = "Operação de Saque";
            Lbl_ValidaSenha.Text = "Digite sua Senha";
            Lbl_Valor.Text = "Qual valor deseja sacar?";
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você tem certeza que deseja realizar esta operação?", MessageBoxButtons.YesNo.ToString());
        }

        private void Lbl_NomeOperacao_Click(object sender, EventArgs e)
        {
          
        }
    }
}
