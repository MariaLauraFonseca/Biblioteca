using MySqlConnector;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Biblioteca
{
    public class Banco
    {
        //Criando as variáveis publicas para conexão e consulta serão usadas em todo o projeto
        //Connection responsavel pela conexao com o MySQL
        public static MySqlConnection Conexao;

        //Command responsavel pelas instrucoes SQL a serem executadas
        public static MySqlCommand Comando;

        //Adapter responsavel por inserir dados em um dataTable
        public static MySqlDataAdapter Adaptador;

        //DataTable responsavel por ligar o banco em controles com a propriedade DataSource
        public static DataTable datTabela;

        public static void AbrirConexao()
        {
            try
            {
                //Estabelece os parametros para a conexao com o banco
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");

                //Abre a conexao com o banco de dados
                Conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                //Fecha a conexão com o banco de dados
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CriarBanco()
        {
            try
            {
                //Chama a fun~cao para abertura de conexao com o banco
                AbrirConexao();

                //Informaa instrucao SQL 
                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS biblioteca; USE biblioteca", Conexao);

                //Executa a Query no MySQL (Raio do Workbench)
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS alunos " +
                                            "(id integer auto_increment primary key, " +
                                            "nome_aluno varchar(40), " +
                                            "senha_aluno varchar(25),"+
                                            "rm char(6))", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS professores " +
                                            "(id integer auto_increment primary key, " +
                                            "nome_prof varchar(40)," +
                                            "senha_prof varchar(15)," +
                                            "materia varchar(40)) ", Conexao);
                Comando.ExecuteNonQuery();

                Comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS funcionarios " +
                            "(id integer auto_increment primary key, " +
                            "nome_func varchar(40),"+
                            "senha_func varchar(15)," +
                            "funcao varchar(40)) ", Conexao);
                Comando.ExecuteNonQuery();


                Comando.ExecuteNonQuery();

                //Chama a funcao para fechar a conexao com o banco
                FecharConexao();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
