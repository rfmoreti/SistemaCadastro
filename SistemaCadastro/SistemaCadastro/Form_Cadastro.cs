using Cadastro.DAO;
using Cadastro.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Form_Cadastro : Form
    {
        private int? codigo;

        public Form_Cadastro(string titulo)
        {
            InitializeComponent();
            this.Text = titulo;
        }

        public Form_Cadastro(string titulo, int codigo)
            : this(titulo)
        {
            this.codigo = codigo;
            var pessoa = BancoDados.Pessoas.Consultar(codigo);
            txt_Cidade.Text = pessoa.Cidade;
            txt_Endereco.Text = pessoa.Endereco;
            txt_Nome.Text = pessoa.Nome;
            txt_Numero.Text = pessoa.Numero;
            txt_Telefone.Text = pessoa.Telefone;
            cbx_Estado.Text = pessoa.Estado;
        }


        string campos;
        public string msgDeSucesso;

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nome.Text))
            {
                campos += "Nome\n";
            }
            if (string.IsNullOrWhiteSpace(txt_Telefone.Text))
            {
                campos += "Telefone\n";
            }
            if (string.IsNullOrWhiteSpace(txt_Endereco.Text))
            {
                campos += "Endereço\n";
            }
            if (string.IsNullOrWhiteSpace(txt_Cidade.Text))
            {
                campos += "Cidade\n";
            }
            if (string.IsNullOrWhiteSpace(txt_Numero.Text))
            {
                campos += "Numero\n";
            }
            if (string.IsNullOrWhiteSpace(cbx_Estado.Text))
            {
                campos += "UF\n";
            }


            if (string.IsNullOrWhiteSpace(txt_Nome.Text) || string.IsNullOrWhiteSpace(txt_Telefone.Text) ||
                string.IsNullOrWhiteSpace(txt_Endereco.Text) || string.IsNullOrWhiteSpace(txt_Cidade.Text) ||
                string.IsNullOrWhiteSpace(txt_Numero.Text) || string.IsNullOrWhiteSpace(cbx_Estado.Text))
            {
                MessageBox.Show($"Os Campos :\n{campos}Precisam ser preenchidos");
            }
            else
            {
                //Declara e instancia o objeto pessoa, do tipo Pessoa
                PessoaMODEL pessoa = new PessoaMODEL();
                //Atribui os valores dos campos do formulário às propriedades
                pessoa.Nome = txt_Nome.Text;
                pessoa.Telefone = txt_Telefone.Text;
                pessoa.Endereco = txt_Endereco.Text;
                pessoa.Numero = txt_Numero.Text;
                pessoa.Cidade = txt_Cidade.Text;
                pessoa.Estado = cbx_Estado.Text;

                //Declara e instancia o objeto dao, do tipo PessoaDAO
                if (!codigo.HasValue)
                {
                    //Invoco o Método Inserir da DAO, para adicionar uma Pessoa
                    BancoDados.Pessoas.Inserir(pessoa);

                }
                else
                {
                    pessoa.Codigo = codigo.Value;
                    //Invoco o Método Inserir da DAO, para alterar uma Pessoa
                    BancoDados.Pessoas.Alterar(pessoa);
                }
               


                msgDeSucesso = $"Pessoa cadastrada com sucesso.\nNome:\t{txt_Nome.Text}\nTelefone:\t{txt_Telefone.Text}" +
                $"\nEndereço: {txt_Endereco.Text}, nº {txt_Numero.Text}\nCidade:\t{txt_Cidade.Text}\nUF:\t{cbx_Estado.Text}";

                this.Close();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
