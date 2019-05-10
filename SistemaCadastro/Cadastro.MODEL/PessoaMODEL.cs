using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.MODEL
{
    public class PessoaMODEL
    {
		private int codigo;
		private string nome;
		private string endereco;
		private string numero;
		private string telefone;
		private string cidade;
		private string estado;

		public int Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}
		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}
		public string Endereco
		{
			get { return endereco; }
			set { endereco = value; }
		}
		public string Numero
		{
			get { return numero; }
			set { numero = value; }
		}
		public string Telefone
		{
			get { return telefone; }
			set { telefone = value; }
		}
		public string Cidade
		{
			get { return cidade; }
			set { cidade = value; }
		}
		public string Estado
		{
			get { return estado; }
			set { estado = value; }
		}
	}
}
