using MySqlConnector;
using System;
using System.Windows.Forms;

namespace Biblioteca.Models
{
    internal class Professor
    {
        public int id { get; set; }

        public string nome_professor { get; set; }

        public string materia { get; set; }

        public string senha_professor { get; set; }

        public void Salvar(string nome_professor, string senha_professor, string materia)
        {
            try
            {
                Banco.AbrirConexao();

                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand
                    ("INSERT INTO professores= (nome_professor, senha_professor, materia)" +
                    "VALUES (@nome_professor, @senha_professor, @materia)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome_professor", nome_professor);
                Banco.Comando.Parameters.AddWithValue("@senha_professor", senha_professor);
                Banco.Comando.Parameters.AddWithValue("@materia", materia);
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
