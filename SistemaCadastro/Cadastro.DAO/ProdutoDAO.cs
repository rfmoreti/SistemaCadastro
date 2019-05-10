using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.MODEL;


namespace Produto.DAO
{
    public class ProdutoDAO
    {
        private List<ProdutoMODEL> repositorio;

        public ProdutoDAO()
        {
            //Ações de Consontrução -  Será executado quando criar uma nova DAO
            //Exemplo:  PessoaDAO  dao= new PessoaDAO();
            repositorio = new List<ProdutoMODEL>();
        }


        public void Incluir(ProdutoMODEL produto)
        {
            repositorio.Add(produto);
        }
        public void Alterar()
        {

        }
        public void Listar()
        {

        }
        public void Exibir()
        {

        }

    }
}
