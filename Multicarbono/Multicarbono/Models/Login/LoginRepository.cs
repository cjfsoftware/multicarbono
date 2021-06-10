using Multicarbono.Configuration;
using MySqlConnector;
using System.Collections.Generic;
using System.Data;

namespace Multicarbono.Models.Login
{
    public class LoginRepository
    {

        private readonly MySqlConnection _dbConnection;
        private readonly Security _security;

        public LoginRepository(MySqlConnection dbConnection, Security security)
        {
            _dbConnection = dbConnection;
            _security = security;
        }

        public string ValidarLogin(string userName, string password)
        {
            var encryptedPassword = _security.Encrypt(password);

            using (_dbConnection)
            {
                _dbConnection.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT SENHA FROM USUARIO WHERE LOGIN = @LOGIN AND SENHA = @SENHA" 
                        );
                
                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;
                MySqlDataReader dr;
                IList<Login> lista = new List<Login>();

                cmd.Parameters.Add("LOGIN", DbType.String).Value = userName;
                cmd.Parameters.Add("SENHA", DbType.String).Value = encryptedPassword;

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return "OK";
                }
                else
                {
                    return "999";
                }

            }
        }
    }
}
