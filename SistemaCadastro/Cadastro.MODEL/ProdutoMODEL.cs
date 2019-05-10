using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.MODEL
{
    public class ProdutoMODEL
    {
        private int codigo;
        private string descricao;
        private double precoVenda;
        private double precoCusto;
        private int estoqueAt;        
        private int codigoCat;             


        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }        

        public int EstoqueAt
        {
            get { return estoqueAt; }
            set { estoqueAt = value; }
        }

        public double PrecoCusto
        {
            get { return precoCusto; }
            set { precoCusto = value; }
        }

        public double PrecoVenda
        {
            get { return precoVenda; }
            set { precoVenda = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public int CodigoCat
        {
            get { return codigoCat; }
            set { codigoCat = value; }
        }

    }
}
