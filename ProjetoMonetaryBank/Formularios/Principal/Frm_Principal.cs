using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMonetaryBank.Principal
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
            Lbl_Operacoes.Text = "Operações";
            Lbl_SeuSaldo.Text = "Seu Saldo: ";
            Btn_Depositar.Text = "Depositar";
            Btn_Historico.Text = "Historico";
            Btn_Sacar.Text = "Sacar";
            Btn_Transferencia.Text = "Transferir";
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
