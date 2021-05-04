using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Login
{
    public class LoginRepository
    {

        private readonly MySqlConnection _dbConnection;

        public LoginRepository(MySqlConnection dbConnection)
        {
            this._dbConnection = dbConnection;
        }

        public string ValidarLogin(string userName, string password)
        {           
            using (_dbConnection)
            {
                _dbConnection.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT SENHA FROM usuario WHERE LOGIN = @LOGIN AND SENHA = @SENHA" 
                        );
                
                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;
                MySqlDataReader dr;
                IList<Login> lista = new List<Login>();

                cmd.Parameters.Add("LOGIN", DbType.String).Value = userName;
                cmd.Parameters.Add("SENHA", DbType.String).Value = password;

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
