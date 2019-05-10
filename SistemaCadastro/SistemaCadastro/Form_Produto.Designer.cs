namespace SistemaCadastro
{
    partial class Form_Produto
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
            this.btn_NovoProd = new System.Windows.Forms.Button();
            this.dgv_Produto = new System.Windows.Forms.DataGridView();
            this.lbl_Produto = new System.Windows.Forms.Label();
            this.txt_Produto = new System.Windows.Forms.TextBox();
            this.btn_PesquisarProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NovoProd
            // 
            this.btn_NovoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_NovoProd.Location = new System.Drawing.Point(303, 6);
            this.btn_NovoProd.Name = "btn_NovoProd";
            this.btn_NovoProd.Size = new System.Drawing.Size(205, 26);
            this.btn_NovoProd.TabIndex = 0;
            this.btn_NovoProd.Text = "Novo Produto";
            this.btn_NovoProd.UseVisualStyleBackColor = true;
            // 
            // dgv_Produto
            // 
            this.dgv_Produto.AllowUserToAddRows = false;
            this.dgv_Produto.AllowUserToDeleteRows = false;
            this.dgv_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produto.Location = new System.Drawing.Point(12, 46);
            this.dgv_Produto.Name = "dgv_Produto";
            this.dgv_Produto.ReadOnly = true;
            this.dgv_Produto.Size = new System.Drawing.Size(494, 394);
            this.dgv_Produto.TabIndex = 1;
            // 
            // lbl_Produto
            // 
            this.lbl_Produto.AutoSize = true;
            this.lbl_Produto.Location = new System.Drawing.Point(26, 19);
            this.lbl_Produto.Name = "lbl_Produto";
            this.lbl_Produto.Size = new System.Drawing.Size(47, 13);
            this.lbl_Produto.TabIndex = 2;
            this.lbl_Produto.Text = "Produto:";
            // 
            // txt_Produto
            // 
            this.txt_Produto.Location = new System.Drawing.Point(79, 16);
            this.txt_Produto.Name = "txt_Produto";
            this.txt_Produto.Size = new System.Drawing.Size(100, 20);
            this.txt_Produto.TabIndex = 3;
            // 
            // btn_PesquisarProd
            // 
            this.btn_PesquisarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_PesquisarProd.Location = new System.Drawing.Point(185, 12);
            this.btn_PesquisarProd.Name = "btn_PesquisarProd";
            this.btn_PesquisarProd.Size = new System.Drawing.Size(89, 26);
            this.btn_PesquisarProd.TabIndex = 4;
            this.btn_PesquisarProd.Text = "Pesquisar";
            this.btn_PesquisarProd.UseVisualStyleBackColor = true;
            // 
            // Form_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 450);
            this.Controls.Add(this.btn_PesquisarProd);
            this.Controls.Add(this.txt_Produto);
            this.Controls.Add(this.lbl_Produto);
            this.Controls.Add(this.dgv_Produto);
            this.Controls.Add(this.btn_NovoProd);
            this.Name = "Form_Produto";
            this.Text = "Form_Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NovoProd;
        private System.Windows.Forms.DataGridView dgv_Produto;
        private System.Windows.Forms.Label lbl_Produto;
        private System.Windows.Forms.TextBox txt_Produto;
        private System.Windows.Forms.Button btn_PesquisarProd;
    }
}