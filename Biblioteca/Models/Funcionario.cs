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

        public string nome_func { get; set; }

        public int funcao { get; set; }

        public string senha_func { get; set; }

        public void Salvar(string nome, string idCidade, string dataNasc, string cpf, string foto, string venda)
        {
            try
            {
                Banco.Conexao.Open();
                Banco.Comando = new MySqlCommand
                    ("INSERT INTO clientes (cliente, idCidade, dataNasc, renda, cpf, foto, venda)" +
                    "VALUES (@cliente, @idCidade, @dataNasc, @renda, @cpf, @foto, @venda)", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@nome", nome);
                Banco.Comando.Parameters.AddWithValue("@idCidade", idCidade);
                Banco.Comando.Parameters.AddWithValue("@dataNasc", dataNasc);
                Banco.Comando.Parameters.AddWithValue("@cpf", cpf);
                Banco.Comando.Parameters.AddWithValue("@foto", foto);
                Banco.Comando.Parameters.AddWithValue("@venda", venda);
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
