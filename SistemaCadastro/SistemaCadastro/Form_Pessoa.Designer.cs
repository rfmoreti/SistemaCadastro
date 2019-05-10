namespace SistemaCadastro
{
	partial class Form_Pessoa
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
            this.btn_NovaPessoa = new System.Windows.Forms.Button();
            this.dgv_Pessoa = new System.Windows.Forms.DataGridView();
            this.tbc_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbc_Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbc_Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_NomPesq = new System.Windows.Forms.Label();
            this.txt_NomePesquisa = new System.Windows.Forms.TextBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NovaPessoa
            // 
            this.btn_NovaPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovaPessoa.Location = new System.Drawing.Point(303, 6);
            this.btn_NovaPessoa.Name = "btn_NovaPessoa";
            this.btn_NovaPessoa.Size = new System.Drawing.Size(205, 26);
            this.btn_NovaPessoa.TabIndex = 0;
            this.btn_NovaPessoa.Text = "Nova Pessoa";
            this.btn_NovaPessoa.UseVisualStyleBackColor = true;
            this.btn_NovaPessoa.Click += new System.EventHandler(this.btn_NovaPessoa_Click);
            // 
            // dgv_Pessoa
            // 
            this.dgv_Pessoa.AllowUserToAddRows = false;
            this.dgv_Pessoa.AllowUserToDeleteRows = false;
            this.dgv_Pessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbc_Codigo,
            this.tbc_Nome,
            this.tbc_Telefone});
            this.dgv_Pessoa.Location = new System.Drawing.Point(14, 44);
            this.dgv_Pessoa.Name = "dgv_Pessoa";
            this.dgv_Pessoa.ReadOnly = true;
            this.dgv_Pessoa.Size = new System.Drawing.Size(494, 394);
            this.dgv_Pessoa.TabIndex = 1;
            this.dgv_Pessoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pessoa_CellDoubleClick);
            // 
            // tbc_Codigo
            // 
            this.tbc_Codigo.DataPropertyName = "Codigo";
            this.tbc_Codigo.HeaderText = "Código";
            this.tbc_Codigo.Name = "tbc_Codigo";
            this.tbc_Codigo.ReadOnly = true;
            this.tbc_Codigo.Visible = false;
            // 
            // tbc_Nome
            // 
            this.tbc_Nome.DataPropertyName = "Nome";
            this.tbc_Nome.HeaderText = "Nome";
            this.tbc_Nome.Name = "tbc_Nome";
            this.tbc_Nome.ReadOnly = true;
            this.tbc_Nome.Width = 300;
            // 
            // tbc_Telefone
            // 
            this.tbc_Telefone.DataPropertyName = "Telefone";
            this.tbc_Telefone.HeaderText = "Telefone";
            this.tbc_Telefone.Name = "tbc_Telefone";
            this.tbc_Telefone.ReadOnly = true;
            this.tbc_Telefone.Width = 150;
            // 
            // lbl_NomPesq
            // 
            this.lbl_NomPesq.AutoSize = true;
            this.lbl_NomPesq.Location = new System.Drawing.Point(37, 19);
            this.lbl_NomPesq.Name = "lbl_NomPesq";
            this.lbl_NomPesq.Size = new System.Drawing.Size(38, 13);
            this.lbl_NomPesq.TabIndex = 2;
            this.lbl_NomPesq.Text = "Nome:";
            // 
            // txt_NomePesquisa
            // 
            this.txt_NomePesquisa.Location = new System.Drawing.Point(78, 16);
            this.txt_NomePesquisa.Name = "txt_NomePesquisa";
            this.txt_NomePesquisa.Size = new System.Drawing.Size(100, 20);
            this.txt_NomePesquisa.TabIndex = 3;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pesquisar.Location = new System.Drawing.Point(184, 12);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(89, 26);
            this.btn_Pesquisar.TabIndex = 4;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // Form_Pessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.txt_NomePesquisa);
            this.Controls.Add(this.lbl_NomPesq);
            this.Controls.Add(this.dgv_Pessoa);
            this.Controls.Add(this.btn_NovaPessoa);
            this.Name = "Form_Pessoa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form_Cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Pessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_NovaPessoa;
        private System.Windows.Forms.DataGridView dgv_Pessoa;
        private System.Windows.Forms.Label lbl_NomPesq;
        private System.Windows.Forms.TextBox txt_NomePesquisa;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbc_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbc_Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbc_Telefone;
    }
}