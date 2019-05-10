using Cadastro.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.DAO
{
    public class PessoaDAO
    {
        private SqlConnection conexao;
        private List<PessoaMODEL> repositorio;

        //Construtor
        public PessoaDAO(SqlConnection conexao)
        {
            //Ações de Consontrução -  Será executado quando criar uma nova DAO
            this.conexao = conexao;

            repositorio = new List<PessoaMODEL>();
        }
        //---Ações da DAO - Metodos

        //Pesquisar
        public List<PessoaMODEL> Pesquisar()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @"SELECT * FROM Pessoas";

            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    repositorio.Clear();
                    while (reader.Read())
                    {
                        repositorio.Add(new PessoaMODEL()
                        {
                            Codigo = Convert.ToInt32(reader["Codigo"].ToString()),
                            Nome = reader["Nome"].ToString(),
                            Telefone = reader["Telefone"].ToString(),
                            Endereco = reader["Endereco"].ToString(),
                            Estado = reader["Estado"].ToString(),
                            Cidade = reader["Cidade"].ToString(),
                            Numero = reader["Numero"].ToString()
                        });
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }


            return repositorio;
        }

        public List<PessoaMODEL> Pesquisar(string nome)
        {
            var resultado = repositorio
                //Where - Estrutura do Linq para pesquisas
                // p.Nome == nome - pesquisa pela igualdade
                //do valor na lista pelo valor recebido
                .Where(p => p.Nome.Contains(nome));
            return resultado.ToList();
        }
        //Consultar
        public PessoaMODEL Consultar(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @"SELECT * FROM Pessoas WHERE Codigo = @Codigo";

            PessoaMODEL pessoa = null;

            try
            {
                cmd.Parameters.AddWithValue(@"Codigo", codigo);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        pessoa = new PessoaMODEL()
                        {
                            Codigo = Convert.ToInt32(reader["Codigo"].ToString()),
                            Nome = reader["Nome"].ToString(),
                            Telefone = reader["Telefone"].ToString(),
                            Endereco = reader["Endereco"].ToString(),
                            Estado = reader["Estado"].ToString(),
                            Cidade = reader["Cidade"].ToString(),
                            Numero = reader["Numero"].ToString()

                        };

                    }
                }
            }
            catch (Exception )
            {

                throw;
            }

            return pessoa;
        }
        //Inserir
        public bool Inserir(PessoaMODEL pessoa)
        {
            //Adiciona a Pessoa no Repositorio
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @"INSERT INTO Pessoas 
                                (Nome, Estado, Cidade, Telefone, Numero, Endereco)
                                VALUES (@Nome, @Estado, @Cidade, @Telefone, @Numero, @Endereco)";
            bool sucesso;

            try
            {
                cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@Estado", pessoa.Estado);
                cmd.Parameters.AddWithValue("@Cidade", pessoa.Cidade);
                cmd.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
                cmd.Parameters.AddWithValue("@Numero", pessoa.Numero);
                cmd.Parameters.AddWithValue("@Endereco", pessoa.Endereco);
                cmd.ExecuteNonQuery();
                sucesso = true;
            }
            catch (Exception)
            {
                sucesso = false;
            }

            return sucesso; // Retorna true =  inseriu, false = erro
        }
        //Alterar
        public bool Alterar(PessoaMODEL pessoa)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @" UPDATE Pessoas
                                    SET Nome = @Nome,
                                        Estado = @Estado,
                                        Cidade = @Cidade,
                                        Telefone = @Telefone,
                                        Numero = @Numero,
                                        Endereco = @Endereco
                                    WHERE Codigo = @Codigo";

            bool retorno;
            try
            {
                cmd.Parameters.AddWithValue("@Codigo", pessoa.Codigo);
                cmd.Parameters.AddWithValue("@Nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@Estado", pessoa.Estado);
                cmd.Parameters.AddWithValue("@Cidade", pessoa.Cidade);
                cmd.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
                cmd.Parameters.AddWithValue("@Numero", pessoa.Numero);
                cmd.Parameters.AddWithValue("@Endereco", pessoa.Endereco);
                cmd.ExecuteNonQuery();

                retorno = true;
            }
            catch (Exception)
            {

                retorno = false;
            }

            return retorno;

        }


        //Excluir - Sobrecarga recebendo parametro do tipo PessoaMODEL
        public bool Excluir(PessoaMODEL pessoa)
        {
           return Excluir(pessoa.Codigo);
        }

            //Excluir - Sobrecarga recebendo parametro do tipo int
            public bool Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = "DELETE FROM Pessoas WHERE Codigo = @Codigo";
            bool retorno;

            try
            {
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno; // Retorna true =  excluiu, false = erro
        }

    }
}
