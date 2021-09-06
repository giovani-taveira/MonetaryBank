using ProjetoMonetaryBank.Inicializacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMonetaryBank
{
    public partial class Frm_Carregamento : Form
    {
        private int contador = 0;

        public Frm_Carregamento()
        {
            InitializeComponent();
            Prb_Progress.MarqueeAnimationSpeed = 20;
            this.Text = "Monetary Bank";
            Lbl_Mensagem.Text = "Seja Bem Vindo!";
            Lbl_Loading.Text = "Aguarde um instante...";
            Cursor = Cursors.WaitCursor;
        }

        private void Trm_Carregamento_Tick(object sender, EventArgs e)
        {
            contador++;
            if(contador == 1)
            {
                try
                {
                    Trm_Carregamento.Stop();
                    this.Hide();
                    Frm_Login login = new Frm_Login();
                    login.ShowDialog();
                }
                finally
                {
                    this.Close();
                }
            }
        }
    }
}
