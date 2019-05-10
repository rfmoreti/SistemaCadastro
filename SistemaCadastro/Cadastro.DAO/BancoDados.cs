using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cadastro.DAO
{   
    //static = permite utilizar a Classe SEM a Instanciação
    //ou seja, ela ja existe no programa assim que o programa executa

    public static class BancoDados
    {
        private static PessoaDAO pessoaDAO;
        //Conexão com o banco de dados
        private static SqlConnection conexao;

        public static SqlConnection Conexao
        {
            get
            {
                conexao = conexao ?? new SqlConnection(ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString);

                if (conexao.State == System.Data.ConnectionState.Closed)
                    conexao.Open();

                return conexao;
            }
        }


        public static PessoaDAO Pessoas
        {
            get
            {//Controla a inicialização da DAO
                pessoaDAO = pessoaDAO ?? new PessoaDAO(Conexao);
                return pessoaDAO;
            }
            set { pessoaDAO = value; }
        }



    }
}
