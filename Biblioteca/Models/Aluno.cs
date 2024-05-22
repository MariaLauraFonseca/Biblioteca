using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Models
{
    public class Aluno
    {
        public int id { get; set; }

        public string nome_aluno { get; set; }

        public string rm { get; set; }

        public string senha_aluno { get; set; }

        public void Salvar(string nome_aluno, string senha_aluno, string rm)
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand
                    ("INSERT INTO alunos= (nome_aluno, senha_aluno, rm)" +
                    "VALUES (@nome_aluno, @senha_aluno, @rm)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome_aluno", nome_aluno);
                Banco.Comando.Parameters.AddWithValue("@senha_aluno", senha_aluno);
                Banco.Comando.Parameters.AddWithValue("@rm", rm);
                Banco.Comando.ExecuteNonQuery();
                Banco.Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}

