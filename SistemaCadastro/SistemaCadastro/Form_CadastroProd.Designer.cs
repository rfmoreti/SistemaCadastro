namespace SistemaCadastro
{
    partial class Form_CadastroProd
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
            this.gpb_DadosProduto = new System.Windows.Forms.GroupBox();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.lbl_CadastroProduto = new System.Windows.Forms.Label();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.lbl_PrecoVenda = new System.Windows.Forms.Label();
            this.lbl_PrecoCusto = new System.Windows.Forms.Label();
            this.lbl_EstoqueAt = new System.Windows.Forms.Label();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.txt_PrecoVenda = new System.Windows.Forms.TextBox();
            this.txt_PrecoCusto = new System.Windows.Forms.TextBox();
            this.txt_EstoqueAt = new System.Windows.Forms.TextBox();
            this.gpb_DadosProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_DadosProduto
            // 
            this.gpb_DadosProduto.Controls.Add(this.txt_EstoqueAt);
            this.gpb_DadosProduto.Controls.Add(this.txt_PrecoCusto);
            this.gpb_DadosProduto.Controls.Add(this.txt_PrecoVenda);
            this.gpb_DadosProduto.Controls.Add(this.txt_Descricao);
            this.gpb_DadosProduto.Controls.Add(this.lbl_EstoqueAt);
            this.gpb_DadosProduto.Controls.Add(this.lbl_PrecoCusto);
            this.gpb_DadosProduto.Controls.Add(this.lbl_PrecoVenda);
            this.gpb_DadosProduto.Controls.Add(this.lbl_Descricao);
            this.gpb_DadosProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_DadosProduto.Location = new System.Drawing.Point(12, 50);
            this.gpb_DadosProduto.Name = "gpb_DadosProduto";
            this.gpb_DadosProduto.Size = new System.Drawing.Size(326, 168);
            this.gpb_DadosProduto.TabIndex = 0;
            this.gpb_DadosProduto.TabStop = false;
            this.gpb_DadosProduto.Text = "Dados do Produto";
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(263, 224);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 5;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(182, 224);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // lbl_CadastroProduto
            // 
            this.lbl_CadastroProduto.AutoSize = true;
            this.lbl_CadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CadastroProduto.Location = new System.Drawing.Point(38, 16);
            this.lbl_CadastroProduto.Name = "lbl_CadastroProduto";
            this.lbl_CadastroProduto.Size = new System.Drawing.Size(283, 31);
            this.lbl_CadastroProduto.TabIndex = 2;
            this.lbl_CadastroProduto.Text = "Cadastro de Produto";
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descricao.Location = new System.Drawing.Point(29, 28);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(75, 17);
            this.lbl_Descricao.TabIndex = 0;
            this.lbl_Descricao.Text = "Descrição:";
            // 
            // lbl_PrecoVenda
            // 
            this.lbl_PrecoVenda.AutoSize = true;
            this.lbl_PrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecoVenda.Location = new System.Drawing.Point(29, 62);
            this.lbl_PrecoVenda.Name = "lbl_PrecoVenda";
            this.lbl_PrecoVenda.Size = new System.Drawing.Size(114, 17);
            this.lbl_PrecoVenda.TabIndex = 0;
            this.lbl_PrecoVenda.Text = "Preço de Venda:";
            // 
            // lbl_PrecoCusto
            // 
            this.lbl_PrecoCusto.AutoSize = true;
            this.lbl_PrecoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecoCusto.Location = new System.Drawing.Point(29, 96);
            this.lbl_PrecoCusto.Name = "lbl_PrecoCusto";
            this.lbl_PrecoCusto.Size = new System.Drawing.Size(109, 17);
            this.lbl_PrecoCusto.TabIndex = 0;
            this.lbl_PrecoCusto.Text = "Preço de Custo:";
            // 
            // lbl_EstoqueAt
            // 
            this.lbl_EstoqueAt.AutoSize = true;
            this.lbl_EstoqueAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EstoqueAt.Location = new System.Drawing.Point(29, 130);
            this.lbl_EstoqueAt.Name = "lbl_EstoqueAt";
            this.lbl_EstoqueAt.Size = new System.Drawing.Size(100, 17);
            this.lbl_EstoqueAt.TabIndex = 0;
            this.lbl_EstoqueAt.Text = "Estoque Atual:";
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(104, 25);
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(184, 21);
            this.txt_Descricao.TabIndex = 0;
            // 
            // txt_PrecoVenda
            // 
            this.txt_PrecoVenda.Location = new System.Drawing.Point(145, 59);
            this.txt_PrecoVenda.Name = "txt_PrecoVenda";
            this.txt_PrecoVenda.Size = new System.Drawing.Size(143, 21);
            this.txt_PrecoVenda.TabIndex = 1;
            // 
            // txt_PrecoCusto
            // 
            this.txt_PrecoCusto.Location = new System.Drawing.Point(141, 93);
            this.txt_PrecoCusto.Name = "txt_PrecoCusto";
            this.txt_PrecoCusto.Size = new System.Drawing.Size(147, 21);
            this.txt_PrecoCusto.TabIndex = 2;
            // 
            // txt_EstoqueAt
            // 
            this.txt_EstoqueAt.Location = new System.Drawing.Point(130, 127);
            this.txt_EstoqueAt.Name = "txt_EstoqueAt";
            this.txt_EstoqueAt.Size = new System.Drawing.Size(158, 21);
            this.txt_EstoqueAt.TabIndex = 3;
            // 
            // Form_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 254);
            this.Controls.Add(this.lbl_CadastroProduto);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.gpb_DadosProduto);
            this.Name = "Form_Produto";
            this.Text = "Form_Produto";
            this.gpb_DadosProduto.ResumeLayout(false);
            this.gpb_DadosProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_DadosProduto;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label lbl_CadastroProduto;
        private System.Windows.Forms.Label lbl_Descricao;
        private System.Windows.Forms.TextBox txt_EstoqueAt;
        private System.Windows.Forms.TextBox txt_PrecoCusto;
        private System.Windows.Forms.TextBox txt_PrecoVenda;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.Label lbl_EstoqueAt;
        private System.Windows.Forms.Label lbl_PrecoCusto;
        private System.Windows.Forms.Label lbl_PrecoVenda;
    }
}