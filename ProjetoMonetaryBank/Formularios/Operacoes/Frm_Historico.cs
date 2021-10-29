using Forms.BancoDeDados;
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
    public partial class Frm_Historico : Form
    {
        string cpf;
        public Frm_Historico()
        {
            InitializeComponent();
            this.Name = "Histórico";
            Lbl_Operacoes.Text = "Qual Histórico deseja consultar?";
            Btn_Pesquisar.Text = "Pesquisar";
            Btn_Cancelar.Text = "Cancelar";

            Cmb_Operacoes.Items.Add("Todas");
            Cmb_Operacoes.Items.Add("Saque");
            Cmb_Operacoes.Items.Add("Deposito");
            Cmb_Operacoes.Items.Add("Transferência");
        }

        public Frm_Historico(string Cpf) : this()
        {
            cpf = Cpf;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_Historico_Load(object sender, EventArgs e)
        {
            using(var ctx = new Context())
            {
                Cmb_Operacoes.SelectedItem = "Todos";
                Dgv_Historico.DataSource = ctx.historico.Where(h => h.CPF == cpf).OrderByDescending(t => t.Data_Operacao).ToList<Historico>();
            }
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if(Cmb_Operacoes.Text == "Saque")
            {
                using (var ctx = new Context())
                {
                    Dgv_Historico.DataSource = ctx.historico.Where(h => h.CPF == cpf && h.Operacao == "Saque").ToList<Historico>();
                }
            }
            if (Cmb_Operacoes.Text == "Deposito")
            {
                using (var ctx = new Context())
                {
                    Dgv_Historico.DataSource = ctx.historico.Where(h => h.CPF == cpf && h.Operacao == "Deposito").ToList<Historico>();
                }
            }
            if (Cmb_Operacoes.Text == "Transferência")
            {
                using (var ctx = new Context())
                {
                    Dgv_Historico.DataSource = ctx.historico.Where(h => h.CPF == cpf && h.Operacao == "Transferência").ToList<Historico>();
                }
            }
            if (Cmb_Operacoes.Text == "Todas")
            {
                using (var ctx = new Context())
                {
                    Dgv_Historico.DataSource = ctx.historico.Where(h => h.CPF == cpf).ToList<Historico>();
                }
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cancelar_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Btn_Cancelar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
