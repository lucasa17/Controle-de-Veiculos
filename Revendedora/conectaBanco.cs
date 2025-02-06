using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;
using Mysqlx.Crud;


namespace Revendedora
{
    internal class conectaBanco
    {

    MySqlConnection conexao = new MySqlConnection("server = localhost; user id = root; password = ; database = revendedora");

    public string mensagem;

        
        public bool insereVeiculo(Veiculo novoVeiculo)
        {

            try
            {
                conexao.Open();

                    MySqlCommand cmd = new MySqlCommand("sp_insereVeiculo", conexao);

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("placa", novoVeiculo.Placa);
                        cmd.Parameters.AddWithValue("marca", novoVeiculo.Marca);
                        cmd.Parameters.AddWithValue("modelo", novoVeiculo.Modelo);
                        cmd.Parameters.AddWithValue("cor", novoVeiculo.Cor);
                        cmd.Parameters.AddWithValue("ano", novoVeiculo.Ano);
                        cmd.Parameters.AddWithValue("valor", novoVeiculo.Valor);
                        
                        cmd.ExecuteNonQuery();

                return true;

            }

            catch (MySqlException erro){

                mensagem = erro.Message;
                return false;

            }

        }


        public DataTable listaVeiculos()
        {

            MySqlCommand listaVei = new MySqlCommand("sp_buscaVeiculo", conexao);

            listaVei.CommandType = CommandType.StoredProcedure;

            try
            {

                conexao.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(listaVei);

                DataTable tabela = new DataTable(); 

                da.Fill(tabela);

                return tabela;
            }

            catch (MySqlException erro)
            {

                mensagem = "Erro:" + erro.Message;

                return null;
            }

            finally
            {

                conexao.Close();

            }
        }

        public bool deletaVeiculo(int idDeletaVeiculo)
        {

            MySqlCommand deletar = new MySqlCommand("sp_deletaVeiculo", conexao);

            deletar.CommandType = CommandType.StoredProcedure;

            deletar.Parameters.AddWithValue("id", idDeletaVeiculo);


            try
            {

                conexao.Open();

                deletar.ExecuteNonQuery(); //executa o comando

                return true;
            }
            catch (MySqlException erro)
            {

                mensagem = erro.Message;
                return false;

            }
        }

        public bool alteraVeiculo(Veiculo aVeiculo, int idVeiculo)
        {

            MySqlCommand altera = new MySqlCommand("sp_alteraVeiculo", conexao);

            altera.CommandType = CommandType.StoredProcedure;

            altera.Parameters.AddWithValue("id", idVeiculo);
            altera.Parameters.AddWithValue("placa", aVeiculo.Placa);
            altera.Parameters.AddWithValue("marca", aVeiculo.Marca);
            altera.Parameters.AddWithValue("modelo", aVeiculo.Modelo);
            altera.Parameters.AddWithValue("cor", aVeiculo.Cor);
            altera.Parameters.AddWithValue("ano", aVeiculo.Ano);
            altera.Parameters.AddWithValue("valor", aVeiculo.Valor);

            try
            {

                conexao.Open();

                    altera.ExecuteNonQuery();

                return true;
            }
            catch(MySqlException erro)
            {

                mensagem = "Erro:" + erro.Message;
                
                return false;
            }
            finally
            {

                conexao.Close();

            }
        }


        public bool insereMarca(Marca novaMarca)
        {

            try
            {
                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("sp_insereMarca", conexao);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("nome", novaMarca.Nome);

                cmd.ExecuteNonQuery();

                return true;

            }

            catch (MySqlException erro)
            {

                mensagem = erro.Message;
                return false;

            }

        }
        public DataTable listaMarcas(){

            MySqlCommand listaMar = new MySqlCommand("sp_buscaMarca", conexao);

            listaMar.CommandType = CommandType.StoredProcedure;

            try
            {

                conexao.Open();

                    MySqlDataAdapter da = new MySqlDataAdapter(listaMar);

                    DataTable tabela = new DataTable();

                    da.Fill(tabela);

                return tabela;
            }

            catch (MySqlException erro)
            {

                    mensagem = "Erro:" + erro.Message;

                return null;
            }

            finally {

                conexao.Close();

            }
        }


        public DataTable listaVendas()
        {

            MySqlCommand listaVen = new MySqlCommand("sp_buscaVendas", conexao);

            listaVen.CommandType = CommandType.StoredProcedure;

            try
            {

                conexao.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(listaVen);

                DataTable tabela = new DataTable();

                da.Fill(tabela);

                return tabela;
            }

            catch (MySqlException erro)
            {

                mensagem = "Erro:" + erro.Message;

                return null;
            }

            finally
            {

                conexao.Close();

            }
        }

        public bool cadastro(user novoUser)
        {

            string pass = novoUser.Senha;

            string senha = biblioteca.makeHash(pass);

            try
            {
                conexao.Open();

                MySqlCommand check = new MySqlCommand("sp_cadastroCheck", conexao);
                check.CommandType = CommandType.StoredProcedure;

                check.Parameters.AddWithValue("user", novoUser.Email);

                check.ExecuteNonQuery();


                MySqlDataAdapter da = new MySqlDataAdapter(check);

                DataSet ds = new DataSet();// tabela virtual

                da.Fill(ds); //passando os valores consultados para o DataSet

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MySqlCommand inserir = new MySqlCommand("sp_insereEmpresa", conexao);
                    inserir.CommandType = CommandType.StoredProcedure;

                    inserir.Parameters.AddWithValue("nome", novoUser.Nome);
                    inserir.Parameters.AddWithValue("email", novoUser.Email);
                    inserir.Parameters.AddWithValue("senha", senha);


                    inserir.ExecuteNonQuery();

                    return true;

                }
                else
                {

                    return false;

                }
            }
            finally
            {

                conexao.Close();
            }
           
        }


        public bool verifica(string email, string pass)
        {
            string senha = biblioteca.makeHash(pass);

            MySqlCommand cmd = new MySqlCommand("sp_login", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("user", email);
            cmd.Parameters.AddWithValue("password", senha);
            try
            {
                conexao.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet
                if (ds.Tables[0].Rows.Count > 0) // verifica se houve retorno
                    return true;
                else
                    return false;

            }
            catch (MySqlException erro)
            {
                mensagem = "Erro" + erro.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool insereVenda(Venda novaVenda, int idAlterar)
        {

            try
            {

                DateTime data = DateTime.Today;

                conexao.Open();

                MySqlCommand cmd = new MySqlCommand("sp_vendeVeiculo", conexao);

                cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("cpf", novaVenda.Cpf);
                cmd.Parameters.AddWithValue("nome", novaVenda.Nome);
                cmd.Parameters.AddWithValue("data", data);                
                cmd.Parameters.AddWithValue("valor", novaVenda.Valor);
                cmd.Parameters.AddWithValue("id", idAlterar);


                cmd.ExecuteNonQuery();

                return true;

            }

            catch (MySqlException erro)
            {

                mensagem = erro.Message;
                return false;

            }

        }

        public bool deletaMarca(int idDeletaMarca)
        {

            MySqlCommand deletar = new MySqlCommand("sp_deletaMarca", conexao);

            deletar.CommandType = CommandType.StoredProcedure;

            deletar.Parameters.AddWithValue("id", idDeletaMarca);


            try
            {

                conexao.Open();

                deletar.ExecuteNonQuery(); //executa o comando

                return true;
            }
            catch (MySqlException erro)
            {

                mensagem = erro.Message;
                return false;

            }
        }


    }//fecha class
}
