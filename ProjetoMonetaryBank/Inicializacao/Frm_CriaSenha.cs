﻿using System;
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
    public partial class Frm_CriaSenha : Form
    {
        public Frm_CriaSenha()
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

        Validacoes.Unit ValidaSenha()
        {
            Validacoes.Unit C = new Validacoes.Unit();
            C.Senha = Txt_Senha.Text;
            C.SenhaConfirma = Txt_SenhaConfirma.Text;
            return C;
        }

        private void Btn_Finalizar_Click(object sender, EventArgs e)
        {

            if(Txt_Senha.Text == Txt_SenhaConfirma.Text && Txt_Senha.Text != "" && Txt_SenhaConfirma.Text != "")
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
            else
            {
                MessageBox.Show( "As Senhas devem ser iguais!");
            }

           
        }
    }
}