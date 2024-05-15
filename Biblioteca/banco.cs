using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class banco
    {
        // Método para verificar credenciais de login
        public bool VerificarCredenciais(string txt_NomeLogin, string txt_SenhaLogin)
        {
            // Connection string para conectar ao banco de dados(substitua com suas próprias credenciais e detalhes do banco de dados)
            string connectionString = "Data Source=SEUSERVIDOR;Initial Catalog=SUA_BASE_DE_DADOS;User ID=SEU_USUARIO;Password=SUA_SENHA;";

            // Consulta SQL para recuperar a senha do usuário
            string query = "SELECT Senha FROM Usuarios WHERE NomeUsuario = @Usuario";
        }
    }
}
