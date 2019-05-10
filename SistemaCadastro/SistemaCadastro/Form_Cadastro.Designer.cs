namespace SistemaCadastro
{
    partial class Form_Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpb_DadosPessoais = new System.Windows.Forms.GroupBox();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.cbx_Estado = new System.Windows.Forms.ComboBox();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_CadastroPessoa = new System.Windows.Forms.Label();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.bnt_Cancelar = new System.Windows.Forms.Button();
            this.gpb_DadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_DadosPessoais
            // 
            this.gpb_DadosPessoais.Controls.Add(this.lbl_Numero);
            this.gpb_DadosPessoais.Controls.Add(this.lbl_Estado);
            this.gpb_DadosPessoais.Controls.Add(this.lbl_Cidade);
            this.gpb_DadosPessoais.Controls.Add(this.label2);
            this.gpb_DadosPessoais.Controls.Add(this.lbl_Endereco);
            this.gpb_DadosPessoais.Controls.Add(this.lbl_Telefone);
            this.gpb_DadosPessoais.Controls.Add(this.lbl_Nome);
            this.gpb_DadosPessoais.Controls.Add(this.cbx_Estado);
            this.gpb_DadosPessoais.Controls.Add(this.txt_Cidade);
            this.gpb_DadosPessoais.Controls.Add(this.txt_Numero);
            this.gpb_DadosPessoais.Controls.Add(this.txt_Endereco);
            this.gpb_DadosPessoais.Controls.Add(this.txt_Telefone);
            this.gpb_DadosPessoais.Controls.Add(this.txt_Nome);
            this.gpb_DadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_DadosPessoais.Location = new System.Drawing.Point(12, 50);
            this.gpb_DadosPessoais.Name = "gpb_DadosPessoais";
            this.gpb_DadosPessoais.Size = new System.Drawing.Size(329, 169);
            this.gpb_DadosPessoais.TabIndex = 0;
            this.gpb_DadosPessoais.TabStop = false;
            this.gpb_DadosPessoais.Text = "Dados Pessoais";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Numero.Location = new System.Drawing.Point(231, 79);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(25, 17);
            this.lbl_Numero.TabIndex = 3;
            this.lbl_Numero.Text = "nº:";
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.Location = new System.Drawing.Point(20, 131);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(56, 17);
            this.lbl_Estado.TabIndex = 3;
            this.lbl_Estado.Text = "Estado:";
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cidade.Location = new System.Drawing.Point(20, 105);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(56, 17);
            this.lbl_Cidade.TabIndex = 3;
            this.lbl_Cidade.Text = "Cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Endereco.Location = new System.Drawing.Point(3, 79);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(73, 17);
            this.lbl_Endereco.TabIndex = 3;
            this.lbl_Endereco.Text = "Endereço:";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefone.Location = new System.Drawing.Point(8, 53);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(68, 17);
            this.lbl_Telefone.TabIndex = 3;
            this.lbl_Telefone.Text = "Telefone:";
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome.Location = new System.Drawing.Point(27, 26);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(49, 17);
            this.lbl_Nome.TabIndex = 3;
            this.lbl_Nome.Text = "Nome:";
            // 
            // cbx_Estado
            // 
            this.cbx_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Estado.FormattingEnabled = true;
            this.cbx_Estado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cbx_Estado.Location = new System.Drawing.Point(82, 130);
            this.cbx_Estado.Name = "cbx_Estado";
            this.cbx_Estado.Size = new System.Drawing.Size(56, 23);
            this.cbx_Estado.TabIndex = 5;
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cidade.Location = new System.Drawing.Point(82, 104);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(142, 21);
            this.txt_Cidade.TabIndex = 4;
            // 
            // txt_Numero
            // 
            this.txt_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Numero.Location = new System.Drawing.Point(262, 79);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(38, 21);
            this.txt_Numero.TabIndex = 3;
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Endereco.Location = new System.Drawing.Point(82, 78);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(142, 21);
            this.txt_Endereco.TabIndex = 2;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefone.Location = new System.Drawing.Point(82, 52);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(100, 21);
            this.txt_Telefone.TabIndex = 1;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(82, 26);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(142, 21);
            this.txt_Nome.TabIndex = 0;
            // 
            // lbl_CadastroPessoa
            // 
            this.lbl_CadastroPessoa.AutoSize = true;
            this.lbl_CadastroPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CadastroPessoa.Location = new System.Drawing.Point(36, 9);
            this.lbl_CadastroPessoa.Name = "lbl_CadastroPessoa";
            this.lbl_CadastroPessoa.Size = new System.Drawing.Size(278, 31);
            this.lbl_CadastroPessoa.TabIndex = 3;
            this.lbl_CadastroPessoa.Text = "Cadastro de Pessoa";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(266, 225);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 7;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // bnt_Cancelar
            // 
            this.bnt_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Cancelar.Location = new System.Drawing.Point(185, 225);
            this.bnt_Cancelar.Name = "bnt_Cancelar";
            this.bnt_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.bnt_Cancelar.TabIndex = 6;
            this.bnt_Cancelar.Text = "Cancelar";
            this.bnt_Cancelar.UseVisualStyleBackColor = true;
            this.bnt_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Form_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 254);
            this.Controls.Add(this.bnt_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.gpb_DadosPessoais);
            this.Controls.Add(this.lbl_CadastroPessoa);
            this.Name = "Form_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro Pessoa";
            this.gpb_DadosPessoais.ResumeLayout(false);
            this.gpb_DadosPessoais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_DadosPessoais;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.ComboBox cbx_Estado;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_CadastroPessoa;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_Endereco;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button bnt_Cancelar;
    }
}

