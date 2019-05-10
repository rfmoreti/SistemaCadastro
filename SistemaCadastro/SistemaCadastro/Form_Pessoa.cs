using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro.DAO;
using Cadastro.MODEL;


namespace SistemaCadastro
{
	public partial class Form_Pessoa : Form
	{
        BindingSource binding;

		public Form_Pessoa()
		{
			InitializeComponent();
            binding = new BindingSource();//Inicializa o Construtor
		}

		private void btn_NovaPessoa_Click(object sender, EventArgs e)
		{
			Form_Cadastro cadastro = new Form_Cadastro("Cadastro Nova Pessoa");
			cadastro.ShowDialog();
            AtualizaGrid();

			//MessageBox.Show(cadastro.msgDeSucesso);
		}

        private void AtualizaGrid(object data=null)
        {           
            binding.DataSource = data?? BancoDados.Pessoas.Pesquisar();
            binding.ResetBindings(true);
            dgv_Pessoa.DataSource = binding;
        }

        private void Form_Pessoa_Load(object sender, EventArgs e)
        {
            dgv_Pessoa.AutoGenerateColumns = false;

            AtualizaGrid();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            dgv_Pessoa.DataSource = BancoDados.Pessoas.Pesquisar(txt_NomePesquisa.Text);
        }

        private void dgv_Pessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var pessoa = (PessoaMODEL)dgv_Pessoa.Rows[e.RowIndex].DataBoundItem;

            Form_Cadastro cadastro = new Form_Cadastro("Alteração de Cadastro de Pessoa", pessoa.Codigo);

            cadastro.ShowDialog();

            AtualizaGrid();
        }
    }
}
