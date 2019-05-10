using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.MODEL
{
    public class CategoriaMODEL
    {
        private int codigo;
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

    }
}
