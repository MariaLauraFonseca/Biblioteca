using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Models
{
    public class Funcionario
    {
        public int id { get; set; }

        public string nome_funcionario { get; set; }

        public string funcao_funcionario { get; set; }

        public string senha_funcionario { get; set; }

        public void Salvar(string nome_funcionario, string senha_funcionario, string funcao_funcionario)
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand
                    ("INSERT INTO funcionarios (nome_funcionario, senha_funcionario, funcao_funcionario)" +
                    "VALUES (@nome_funcionario, @senha_funcionario, @funcao_funcionario)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome_funcionario", nome_funcionario);
                Banco.Comando.Parameters.AddWithValue("@senha_funcionario", senha_funcionario);
                Banco.Comando.Parameters.AddWithValue("@funcao_funcionario", funcao_funcionario);
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
