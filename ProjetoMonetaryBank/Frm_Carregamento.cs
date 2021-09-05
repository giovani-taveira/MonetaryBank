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
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Trm_Carregamento_Tick(object sender, EventArgs e)
        {
            contador++;
            if(contador == 9)
            {
                Trm_Carregamento.Stop();
                this.Close();

            }
        }

        private void Frm_Carregamento_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
