﻿using Forms.BancoDeDados;
using ProjetoMonetaryBank.Principal;
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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            Lbl_CPF.Text = "CPF";
            Lbl_Senha.Text = "Senha";
            Lbl_Cadastro.Text = "É novo por aqui? então cadastre-se!";
            Lbl_Cadastro.ForeColor = Color.DarkGreen;
            Lbl_NovaSenha.Text = "Esqueci minha Senha";
            Lbl_NovaSenha.ForeColor = Color.DarkGreen;
            Btn_Continuar.Text = "Entrar";
        }

        private void Lbl_Cadastro_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Lbl_Cadastro_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Btn_Continuar_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Btn_Continuar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Lbl_Cadastro_Click(object sender, EventArgs e)
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

        public void Btn_Continuar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                using (var ctx = new Context())
                {
                    var query = ctx.login.Where(x => x.CPF == Msk_CPFLogin.Text 
                        && x.Senha == Txt_Senha.Text).FirstOrDefault<Login>();

                    if (query != null)
                    {
                        var queryNome = ctx.cliente.Where(x => x.CPF == Msk_CPFLogin.Text)
                            .FirstOrDefault<Cliente>().ToString();

                        MessageBox.Show($"Bem vindo {queryNome}");

                        try
                        {
                            this.Hide();
                            using (var f = new Frm_Principal(queryNome))
                            {
                                f.ShowDialog();
                            }
                        }
                        finally
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha estão incorretos!");
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void Lbl_NovaSenha_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Frm_CriaSenha f = new Frm_CriaSenha();
                f.ShowDialog();
            }
            finally
            {
                this.Close();
            }
        }

        private void Lbl_NovaSenha_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Lbl_NovaSenha_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}