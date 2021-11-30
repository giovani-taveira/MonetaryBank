
namespace ProjetoMonetaryBank.Inicializacao
{
    partial class Frm_Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cadastro));
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_NomePai = new System.Windows.Forms.TextBox();
            this.Txt_NomeMae = new System.Windows.Forms.TextBox();
            this.Grp_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.Lbl_Email = new System.Windows.Forms.Label();
            this.Txt_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Telefone = new System.Windows.Forms.Label();
            this.Msk_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Nascimento = new System.Windows.Forms.Label();
            this.Msk_RG = new System.Windows.Forms.MaskedTextBox();
            this.Msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.Msk_DataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.Chk_TemPai = new System.Windows.Forms.CheckBox();
            this.Chk_TemMae = new System.Windows.Forms.CheckBox();
            this.Lbl_RG = new System.Windows.Forms.Label();
            this.Lbl_NomePai = new System.Windows.Forms.Label();
            this.Lbl_NomeMae = new System.Windows.Forms.Label();
            this.Lbl_Sexo = new System.Windows.Forms.Label();
            this.Lbl_CPF = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Rdb_Indefinido = new System.Windows.Forms.RadioButton();
            this.Rdb_Feminino = new System.Windows.Forms.RadioButton();
            this.Rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.Grp_Endereco = new System.Windows.Forms.GroupBox();
            this.Lbl_Bairro = new System.Windows.Forms.Label();
            this.Txt_Bairro = new System.Windows.Forms.TextBox();
            this.Lbl_Estado = new System.Windows.Forms.Label();
            this.Lbl_Cidade = new System.Windows.Forms.Label();
            this.Lbl_Complemento = new System.Windows.Forms.Label();
            this.Lbl_Numero = new System.Windows.Forms.Label();
            this.Lbl_Rua = new System.Windows.Forms.Label();
            this.Lbl_CEP = new System.Windows.Forms.Label();
            this.Msk_CEP = new System.Windows.Forms.MaskedTextBox();
            this.Cmb_Estados = new System.Windows.Forms.ComboBox();
            this.Txt_Cidade = new System.Windows.Forms.TextBox();
            this.Txt_Complemento = new System.Windows.Forms.TextBox();
            this.Txt_Numero = new System.Windows.Forms.TextBox();
            this.Txt_Rua = new System.Windows.Forms.TextBox();
            this.Grp_Profissao = new System.Windows.Forms.GroupBox();
            this.Lbl_Renda = new System.Windows.Forms.Label();
            this.Lbl_Profissao = new System.Windows.Forms.Label();
            this.Txt_Renda = new System.Windows.Forms.TextBox();
            this.Txt_Profissao = new System.Windows.Forms.TextBox();
            this.Btn_Continuar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Grp_DadosPessoais.SuspendLayout();
            this.Grp_Endereco.SuspendLayout();
            this.Grp_Profissao.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(6, 43);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(401, 23);
            this.Txt_Nome.TabIndex = 1;
            this.Txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nome_KeyPress);
            // 
            // Txt_NomePai
            // 
            this.Txt_NomePai.Location = new System.Drawing.Point(5, 261);
            this.Txt_NomePai.Name = "Txt_NomePai";
            this.Txt_NomePai.Size = new System.Drawing.Size(400, 23);
            this.Txt_NomePai.TabIndex = 12;
            this.Txt_NomePai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NomePai_KeyPress);
            // 
            // Txt_NomeMae
            // 
            this.Txt_NomeMae.Location = new System.Drawing.Point(5, 192);
            this.Txt_NomeMae.Name = "Txt_NomeMae";
            this.Txt_NomeMae.Size = new System.Drawing.Size(399, 23);
            this.Txt_NomeMae.TabIndex = 9;
            this.Txt_NomeMae.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NomeMae_KeyPress);
            // 
            // Grp_DadosPessoais
            // 
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_Email);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_Email);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_Telefone);
            this.Grp_DadosPessoais.Controls.Add(this.Msk_Telefone);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_Nascimento);
            this.Grp_DadosPessoais.Controls.Add(this.Msk_RG);
            this.Grp_DadosPessoais.Controls.Add(this.Msk_CPF);
            this.Grp_DadosPessoais.Controls.Add(this.Msk_DataNascimento);
            this.Grp_DadosPessoais.Controls.Add(this.Chk_TemPai);
            this.Grp_DadosPessoais.Controls.Add(this.Chk_TemMae);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_RG);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomePai);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_NomeMae);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_Sexo);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_CPF);
            this.Grp_DadosPessoais.Controls.Add(this.Lbl_Nome);
            this.Grp_DadosPessoais.Controls.Add(this.Rdb_Indefinido);
            this.Grp_DadosPessoais.Controls.Add(this.Rdb_Feminino);
            this.Grp_DadosPessoais.Controls.Add(this.Rdb_Masculino);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_Nome);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomePai);
            this.Grp_DadosPessoais.Controls.Add(this.Txt_NomeMae);
            this.Grp_DadosPessoais.Location = new System.Drawing.Point(12, 12);
            this.Grp_DadosPessoais.Name = "Grp_DadosPessoais";
            this.Grp_DadosPessoais.Size = new System.Drawing.Size(629, 313);
            this.Grp_DadosPessoais.TabIndex = 4;
            this.Grp_DadosPessoais.TabStop = false;
            this.Grp_DadosPessoais.Text = "groupBox1";
            // 
            // Lbl_Email
            // 
            this.Lbl_Email.AutoSize = true;
            this.Lbl_Email.Location = new System.Drawing.Point(6, 126);
            this.Lbl_Email.Name = "Lbl_Email";
            this.Lbl_Email.Size = new System.Drawing.Size(44, 15);
            this.Lbl_Email.TabIndex = 13;
            this.Lbl_Email.Text = "label19";
            // 
            // Txt_Email
            // 
            this.Txt_Email.Location = new System.Drawing.Point(6, 144);
            this.Txt_Email.Name = "Txt_Email";
            this.Txt_Email.Size = new System.Drawing.Size(399, 23);
            this.Txt_Email.TabIndex = 7;
            // 
            // Lbl_Telefone
            // 
            this.Lbl_Telefone.AutoSize = true;
            this.Lbl_Telefone.Location = new System.Drawing.Point(425, 174);
            this.Lbl_Telefone.Name = "Lbl_Telefone";
            this.Lbl_Telefone.Size = new System.Drawing.Size(44, 15);
            this.Lbl_Telefone.TabIndex = 0;
            this.Lbl_Telefone.Text = "label18";
            // 
            // Msk_Telefone
            // 
            this.Msk_Telefone.Location = new System.Drawing.Point(424, 192);
            this.Msk_Telefone.Mask = "(00)90000-0000";
            this.Msk_Telefone.Name = "Msk_Telefone";
            this.Msk_Telefone.Size = new System.Drawing.Size(199, 23);
            this.Msk_Telefone.TabIndex = 11;
            // 
            // Lbl_Nascimento
            // 
            this.Lbl_Nascimento.AutoSize = true;
            this.Lbl_Nascimento.Location = new System.Drawing.Point(424, 126);
            this.Lbl_Nascimento.Name = "Lbl_Nascimento";
            this.Lbl_Nascimento.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Nascimento.TabIndex = 0;
            this.Lbl_Nascimento.Text = "label7";
            // 
            // Msk_RG
            // 
            this.Msk_RG.Location = new System.Drawing.Point(424, 92);
            this.Msk_RG.Mask = "00,000,000-0";
            this.Msk_RG.Name = "Msk_RG";
            this.Msk_RG.Size = new System.Drawing.Size(199, 23);
            this.Msk_RG.TabIndex = 6;
            // 
            // Msk_CPF
            // 
            this.Msk_CPF.Location = new System.Drawing.Point(424, 43);
            this.Msk_CPF.Mask = "000,000,000-00";
            this.Msk_CPF.Name = "Msk_CPF";
            this.Msk_CPF.Size = new System.Drawing.Size(199, 23);
            this.Msk_CPF.TabIndex = 2;
            // 
            // Msk_DataNascimento
            // 
            this.Msk_DataNascimento.Location = new System.Drawing.Point(424, 144);
            this.Msk_DataNascimento.Mask = "00/00/0000";
            this.Msk_DataNascimento.Name = "Msk_DataNascimento";
            this.Msk_DataNascimento.Size = new System.Drawing.Size(199, 23);
            this.Msk_DataNascimento.TabIndex = 8;
            this.Msk_DataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // Chk_TemPai
            // 
            this.Chk_TemPai.AutoSize = true;
            this.Chk_TemPai.Location = new System.Drawing.Point(6, 290);
            this.Chk_TemPai.Name = "Chk_TemPai";
            this.Chk_TemPai.Size = new System.Drawing.Size(83, 19);
            this.Chk_TemPai.TabIndex = 13;
            this.Chk_TemPai.Text = "checkBox2";
            this.Chk_TemPai.UseVisualStyleBackColor = true;
            this.Chk_TemPai.CheckedChanged += new System.EventHandler(this.Chk_TemPai_CheckedChanged);
            // 
            // Chk_TemMae
            // 
            this.Chk_TemMae.AutoSize = true;
            this.Chk_TemMae.Location = new System.Drawing.Point(6, 221);
            this.Chk_TemMae.Name = "Chk_TemMae";
            this.Chk_TemMae.Size = new System.Drawing.Size(83, 19);
            this.Chk_TemMae.TabIndex = 10;
            this.Chk_TemMae.Text = "checkBox1";
            this.Chk_TemMae.UseVisualStyleBackColor = true;
            this.Chk_TemMae.CheckedChanged += new System.EventHandler(this.Chk_TemMae_CheckedChanged);
            // 
            // Lbl_RG
            // 
            this.Lbl_RG.AutoSize = true;
            this.Lbl_RG.Location = new System.Drawing.Point(424, 74);
            this.Lbl_RG.Name = "Lbl_RG";
            this.Lbl_RG.Size = new System.Drawing.Size(38, 15);
            this.Lbl_RG.TabIndex = 0;
            this.Lbl_RG.Text = "label6";
            // 
            // Lbl_NomePai
            // 
            this.Lbl_NomePai.AutoSize = true;
            this.Lbl_NomePai.Location = new System.Drawing.Point(5, 243);
            this.Lbl_NomePai.Name = "Lbl_NomePai";
            this.Lbl_NomePai.Size = new System.Drawing.Size(38, 15);
            this.Lbl_NomePai.TabIndex = 0;
            this.Lbl_NomePai.Text = "label5";
            // 
            // Lbl_NomeMae
            // 
            this.Lbl_NomeMae.AutoSize = true;
            this.Lbl_NomeMae.Location = new System.Drawing.Point(5, 174);
            this.Lbl_NomeMae.Name = "Lbl_NomeMae";
            this.Lbl_NomeMae.Size = new System.Drawing.Size(38, 15);
            this.Lbl_NomeMae.TabIndex = 0;
            this.Lbl_NomeMae.Text = "label4";
            // 
            // Lbl_Sexo
            // 
            this.Lbl_Sexo.AutoSize = true;
            this.Lbl_Sexo.Location = new System.Drawing.Point(5, 78);
            this.Lbl_Sexo.Name = "Lbl_Sexo";
            this.Lbl_Sexo.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Sexo.TabIndex = 0;
            this.Lbl_Sexo.Text = "label3";
            // 
            // Lbl_CPF
            // 
            this.Lbl_CPF.AutoSize = true;
            this.Lbl_CPF.Location = new System.Drawing.Point(424, 23);
            this.Lbl_CPF.Name = "Lbl_CPF";
            this.Lbl_CPF.Size = new System.Drawing.Size(38, 15);
            this.Lbl_CPF.TabIndex = 0;
            this.Lbl_CPF.Text = "label2";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Location = new System.Drawing.Point(7, 23);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Nome.TabIndex = 0;
            this.Lbl_Nome.Text = "label1";
            // 
            // Rdb_Indefinido
            // 
            this.Rdb_Indefinido.AutoSize = true;
            this.Rdb_Indefinido.Location = new System.Drawing.Point(245, 96);
            this.Rdb_Indefinido.Name = "Rdb_Indefinido";
            this.Rdb_Indefinido.Size = new System.Drawing.Size(94, 19);
            this.Rdb_Indefinido.TabIndex = 5;
            this.Rdb_Indefinido.TabStop = true;
            this.Rdb_Indefinido.Text = "radioButton3";
            this.Rdb_Indefinido.UseVisualStyleBackColor = true;
            // 
            // Rdb_Feminino
            // 
            this.Rdb_Feminino.AutoSize = true;
            this.Rdb_Feminino.Location = new System.Drawing.Point(126, 96);
            this.Rdb_Feminino.Name = "Rdb_Feminino";
            this.Rdb_Feminino.Size = new System.Drawing.Size(94, 19);
            this.Rdb_Feminino.TabIndex = 4;
            this.Rdb_Feminino.TabStop = true;
            this.Rdb_Feminino.Text = "radioButton2";
            this.Rdb_Feminino.UseVisualStyleBackColor = true;
            // 
            // Rdb_Masculino
            // 
            this.Rdb_Masculino.AutoSize = true;
            this.Rdb_Masculino.Location = new System.Drawing.Point(6, 96);
            this.Rdb_Masculino.Name = "Rdb_Masculino";
            this.Rdb_Masculino.Size = new System.Drawing.Size(94, 19);
            this.Rdb_Masculino.TabIndex = 3;
            this.Rdb_Masculino.TabStop = true;
            this.Rdb_Masculino.Text = "radioButton1";
            this.Rdb_Masculino.UseVisualStyleBackColor = true;
            // 
            // Grp_Endereco
            // 
            this.Grp_Endereco.Controls.Add(this.Lbl_Bairro);
            this.Grp_Endereco.Controls.Add(this.Txt_Bairro);
            this.Grp_Endereco.Controls.Add(this.Lbl_Estado);
            this.Grp_Endereco.Controls.Add(this.Lbl_Cidade);
            this.Grp_Endereco.Controls.Add(this.Lbl_Complemento);
            this.Grp_Endereco.Controls.Add(this.Lbl_Numero);
            this.Grp_Endereco.Controls.Add(this.Lbl_Rua);
            this.Grp_Endereco.Controls.Add(this.Lbl_CEP);
            this.Grp_Endereco.Controls.Add(this.Msk_CEP);
            this.Grp_Endereco.Controls.Add(this.Cmb_Estados);
            this.Grp_Endereco.Controls.Add(this.Txt_Cidade);
            this.Grp_Endereco.Controls.Add(this.Txt_Complemento);
            this.Grp_Endereco.Controls.Add(this.Txt_Numero);
            this.Grp_Endereco.Controls.Add(this.Txt_Rua);
            this.Grp_Endereco.Location = new System.Drawing.Point(12, 331);
            this.Grp_Endereco.Name = "Grp_Endereco";
            this.Grp_Endereco.Size = new System.Drawing.Size(629, 185);
            this.Grp_Endereco.TabIndex = 5;
            this.Grp_Endereco.TabStop = false;
            this.Grp_Endereco.Text = "groupBox2";
            // 
            // Lbl_Bairro
            // 
            this.Lbl_Bairro.AutoSize = true;
            this.Lbl_Bairro.Location = new System.Drawing.Point(5, 130);
            this.Lbl_Bairro.Name = "Lbl_Bairro";
            this.Lbl_Bairro.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Bairro.TabIndex = 19;
            this.Lbl_Bairro.Text = "label1";
            // 
            // Txt_Bairro
            // 
            this.Txt_Bairro.Location = new System.Drawing.Point(5, 148);
            this.Txt_Bairro.Name = "Txt_Bairro";
            this.Txt_Bairro.Size = new System.Drawing.Size(176, 23);
            this.Txt_Bairro.TabIndex = 18;
            this.Txt_Bairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Bairro_KeyPress);
            // 
            // Lbl_Estado
            // 
            this.Lbl_Estado.AutoSize = true;
            this.Lbl_Estado.Location = new System.Drawing.Point(516, 130);
            this.Lbl_Estado.Name = "Lbl_Estado";
            this.Lbl_Estado.Size = new System.Drawing.Size(44, 15);
            this.Lbl_Estado.TabIndex = 0;
            this.Lbl_Estado.Text = "label13";
            // 
            // Lbl_Cidade
            // 
            this.Lbl_Cidade.AutoSize = true;
            this.Lbl_Cidade.Location = new System.Drawing.Point(207, 130);
            this.Lbl_Cidade.Name = "Lbl_Cidade";
            this.Lbl_Cidade.Size = new System.Drawing.Size(44, 15);
            this.Lbl_Cidade.TabIndex = 0;
            this.Lbl_Cidade.Text = "label12";
            // 
            // Lbl_Complemento
            // 
            this.Lbl_Complemento.AutoSize = true;
            this.Lbl_Complemento.Location = new System.Drawing.Point(207, 77);
            this.Lbl_Complemento.Name = "Lbl_Complemento";
            this.Lbl_Complemento.Size = new System.Drawing.Size(44, 15);
            this.Lbl_Complemento.TabIndex = 0;
            this.Lbl_Complemento.Text = "label11";
            // 
            // Lbl_Numero
            // 
            this.Lbl_Numero.AutoSize = true;
            this.Lbl_Numero.Location = new System.Drawing.Point(5, 77);
            this.Lbl_Numero.Name = "Lbl_Numero";
            this.Lbl_Numero.Size = new System.Drawing.Size(44, 15);
            this.Lbl_Numero.TabIndex = 0;
            this.Lbl_Numero.Text = "label10";
            // 
            // Lbl_Rua
            // 
            this.Lbl_Rua.AutoSize = true;
            this.Lbl_Rua.Location = new System.Drawing.Point(207, 28);
            this.Lbl_Rua.Name = "Lbl_Rua";
            this.Lbl_Rua.Size = new System.Drawing.Size(38, 15);
            this.Lbl_Rua.TabIndex = 0;
            this.Lbl_Rua.Text = "label9";
            // 
            // Lbl_CEP
            // 
            this.Lbl_CEP.AutoSize = true;
            this.Lbl_CEP.Location = new System.Drawing.Point(6, 28);
            this.Lbl_CEP.Name = "Lbl_CEP";
            this.Lbl_CEP.Size = new System.Drawing.Size(38, 15);
            this.Lbl_CEP.TabIndex = 0;
            this.Lbl_CEP.Text = "label8";
            // 
            // Msk_CEP
            // 
            this.Msk_CEP.Location = new System.Drawing.Point(5, 46);
            this.Msk_CEP.Mask = "00000-000";
            this.Msk_CEP.Name = "Msk_CEP";
            this.Msk_CEP.Size = new System.Drawing.Size(176, 23);
            this.Msk_CEP.TabIndex = 14;
            this.Msk_CEP.Leave += new System.EventHandler(this.Msk_CEP_Leave);
            this.Msk_CEP.MouseLeave += new System.EventHandler(this.Msk_CEP_MouseLeave);
            // 
            // Cmb_Estados
            // 
            this.Cmb_Estados.FormattingEnabled = true;
            this.Cmb_Estados.Location = new System.Drawing.Point(516, 148);
            this.Cmb_Estados.Name = "Cmb_Estados";
            this.Cmb_Estados.Size = new System.Drawing.Size(107, 23);
            this.Cmb_Estados.TabIndex = 20;
            // 
            // Txt_Cidade
            // 
            this.Txt_Cidade.Location = new System.Drawing.Point(207, 148);
            this.Txt_Cidade.Name = "Txt_Cidade";
            this.Txt_Cidade.Size = new System.Drawing.Size(300, 23);
            this.Txt_Cidade.TabIndex = 19;
            this.Txt_Cidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cidade_KeyPress);
            // 
            // Txt_Complemento
            // 
            this.Txt_Complemento.Location = new System.Drawing.Point(207, 95);
            this.Txt_Complemento.Name = "Txt_Complemento";
            this.Txt_Complemento.Size = new System.Drawing.Size(416, 23);
            this.Txt_Complemento.TabIndex = 17;
            // 
            // Txt_Numero
            // 
            this.Txt_Numero.Location = new System.Drawing.Point(5, 95);
            this.Txt_Numero.Name = "Txt_Numero";
            this.Txt_Numero.Size = new System.Drawing.Size(176, 23);
            this.Txt_Numero.TabIndex = 16;
            this.Txt_Numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Numero_KeyPress);
            // 
            // Txt_Rua
            // 
            this.Txt_Rua.Location = new System.Drawing.Point(207, 46);
            this.Txt_Rua.Name = "Txt_Rua";
            this.Txt_Rua.Size = new System.Drawing.Size(416, 23);
            this.Txt_Rua.TabIndex = 15;
            // 
            // Grp_Profissao
            // 
            this.Grp_Profissao.Controls.Add(this.Lbl_Renda);
            this.Grp_Profissao.Controls.Add(this.Lbl_Profissao);
            this.Grp_Profissao.Controls.Add(this.Txt_Renda);
            this.Grp_Profissao.Controls.Add(this.Txt_Profissao);
            this.Grp_Profissao.Location = new System.Drawing.Point(12, 522);
            this.Grp_Profissao.Name = "Grp_Profissao";
            this.Grp_Profissao.Size = new System.Drawing.Size(629, 86);
            this.Grp_Profissao.TabIndex = 6;
            this.Grp_Profissao.TabStop = false;
            this.Grp_Profissao.Text = "groupBox3";
            // 
            // Lbl_Renda
            // 
            this.Lbl_Renda.AutoSize = true;
            this.Lbl_Renda.Location = new System.Drawing.Point(5, 23);
            this.Lbl_Renda.Name = "Lbl_Renda";
            this.Lbl_Renda.Size = new System.Drawing.Size(44, 15);
            this.Lbl_Renda.TabIndex = 0;
            this.Lbl_Renda.Text = "label16";
            // 
            // Lbl_Profissao
            // 
            this.Lbl_Profissao.AutoSize = true;
            this.Lbl_Profissao.Location = new System.Drawing.Point(207, 23);
            this.Lbl_Profissao.Name = "Lbl_Profissao";
            this.Lbl_Profissao.Size = new System.Drawing.Size(44, 15);
            this.Lbl_Profissao.TabIndex = 0;
            this.Lbl_Profissao.Text = "label15";
            // 
            // Txt_Renda
            // 
            this.Txt_Renda.Location = new System.Drawing.Point(7, 41);
            this.Txt_Renda.Name = "Txt_Renda";
            this.Txt_Renda.Size = new System.Drawing.Size(180, 23);
            this.Txt_Renda.TabIndex = 21;
            this.Txt_Renda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Renda_KeyPress);
            // 
            // Txt_Profissao
            // 
            this.Txt_Profissao.Location = new System.Drawing.Point(207, 41);
            this.Txt_Profissao.Name = "Txt_Profissao";
            this.Txt_Profissao.Size = new System.Drawing.Size(416, 23);
            this.Txt_Profissao.TabIndex = 22;
            this.Txt_Profissao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Profissao_KeyPress);
            // 
            // Btn_Continuar
            // 
            this.Btn_Continuar.Location = new System.Drawing.Point(514, 628);
            this.Btn_Continuar.Name = "Btn_Continuar";
            this.Btn_Continuar.Size = new System.Drawing.Size(130, 40);
            this.Btn_Continuar.TabIndex = 7;
            this.Btn_Continuar.Text = "button1";
            this.Btn_Continuar.UseVisualStyleBackColor = true;
            this.Btn_Continuar.Click += new System.EventHandler(this.Btn_Continuar_Click);
            this.Btn_Continuar.MouseLeave += new System.EventHandler(this.Btn_Continuar_MouseLeave);
            this.Btn_Continuar.MouseHover += new System.EventHandler(this.Btn_Continuar_MouseHover);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(12, 628);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(130, 40);
            this.Btn_Cancelar.TabIndex = 8;
            this.Btn_Cancelar.Text = "button2";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            this.Btn_Cancelar.MouseLeave += new System.EventHandler(this.Btn_Cancelar_MouseLeave);
            this.Btn_Cancelar.MouseHover += new System.EventHandler(this.Btn_Cancelar_MouseHover);
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 687);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Continuar);
            this.Controls.Add(this.Grp_Profissao);
            this.Controls.Add(this.Grp_Endereco);
            this.Controls.Add(this.Grp_DadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Frm_Cadastro_Load);
            this.Grp_DadosPessoais.ResumeLayout(false);
            this.Grp_DadosPessoais.PerformLayout();
            this.Grp_Endereco.ResumeLayout(false);
            this.Grp_Endereco.PerformLayout();
            this.Grp_Profissao.ResumeLayout(false);
            this.Grp_Profissao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_NomePai;
        private System.Windows.Forms.TextBox Txt_NomeMae;
        private System.Windows.Forms.GroupBox Grp_DadosPessoais;
        private System.Windows.Forms.MaskedTextBox Msk_DataNascimento;
        private System.Windows.Forms.CheckBox Chk_TemPai;
        private System.Windows.Forms.CheckBox Chk_TemMae;
        private System.Windows.Forms.Label Lbl_RG;
        private System.Windows.Forms.Label Lbl_NomePai;
        private System.Windows.Forms.Label Lbl_NomeMae;
        private System.Windows.Forms.Label Lbl_Sexo;
        private System.Windows.Forms.Label Lbl_CPF;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.RadioButton Rdb_Indefinido;
        private System.Windows.Forms.RadioButton Rdb_Feminino;
        private System.Windows.Forms.RadioButton Rdb_Masculino;
        private System.Windows.Forms.GroupBox Grp_Endereco;
        private System.Windows.Forms.ComboBox Cmb_Estados;
        private System.Windows.Forms.TextBox Txt_Cidade;
        private System.Windows.Forms.TextBox Txt_Complemento;
        private System.Windows.Forms.TextBox Txt_Numero;
        private System.Windows.Forms.TextBox Txt_Rua;
        private System.Windows.Forms.Label Lbl_Nascimento;
        private System.Windows.Forms.MaskedTextBox Msk_RG;
        private System.Windows.Forms.MaskedTextBox Msk_CPF;
        private System.Windows.Forms.Label Lbl_Estado;
        private System.Windows.Forms.Label Lbl_Cidade;
        private System.Windows.Forms.Label Lbl_Complemento;
        private System.Windows.Forms.Label Lbl_Numero;
        private System.Windows.Forms.Label Lbl_Rua;
        private System.Windows.Forms.Label Lbl_CEP;
        private System.Windows.Forms.MaskedTextBox Msk_CEP;
        private System.Windows.Forms.GroupBox Grp_Profissao;
        private System.Windows.Forms.TextBox Txt_Renda;
        private System.Windows.Forms.TextBox Txt_Profissao;
        private System.Windows.Forms.Button Btn_Continuar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.MaskedTextBox Msk_Telefone;
        private System.Windows.Forms.Label Lbl_Renda;
        private System.Windows.Forms.Label Lbl_Profissao;
        private System.Windows.Forms.Label Lbl_Telefone;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox Txt_Email;
        private System.Windows.Forms.Label Lbl_Bairro;
        private System.Windows.Forms.TextBox Txt_Bairro;
    }
}