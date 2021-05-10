using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Usuario
{
    public class UsuarioRepository
    {
        private readonly MySqlConnection _dbConnection;

        public UsuarioRepository(MySqlConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void IncludeUsuario(Usuario usuario)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();
                
                var command = new MySqlCommand("INSERT INTO USUARIO VALUES (@NOME, @DT_NASCIMENTO, @CARGO, @ENDERECO, @LOGIN, " +
                 "@EMAIL, @STATUS, @DT_CRIACAO, @NIVEL_ACESSO, @SENHA)");

                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("NOME", DbType.String).Value = usuario.Nome;
                command.Parameters.Add("DT_NASCIMENTO", DbType.DateTime).Value = usuario.DtNascimento;
                command.Parameters.Add("CARGO", DbType.String).Value = usuario.Cargo;
                command.Parameters.Add("ENDERECO", DbType.String).Value = usuario.Endereco;
                command.Parameters.Add("LOGIN", DbType.String).Value = usuario.Login;
                command.Parameters.Add("EMAIL", DbType.String).Value = usuario.Email;
                command.Parameters.Add("STATUS", DbType.String).Value = usuario.Status;
                command.Parameters.Add("DT_CRIACAO", DbType.DateTime).Value = usuario.DtCriacao;
                command.Parameters.Add("NIVEL_ACESSO", DbType.String).Value = usuario.NivelAcesso;
                command.Parameters.Add("SENHA", DbType.String).Value = usuario.Senha;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }


        }

        public void UpdateUsuario(Usuario usuario)
        {
            using (_dbConnection)
            {
                var command = new MySqlCommand("UPDATE USUARIO SET NOME = @NOME, DT_NASCIMENTO = @DT_NASCIMENTO, CARGO = @CARGO, ENDERECO = @ENDERECO, LOGIN = @LOGIN, " +
                "EMAIL = @EMAIL, STATUS = @STATUS, DT_CRIACAO = @DT_CRIACAO, NIVEL_ACESSO = @NIVEL_ACESSO, SENHA = @SENHA WHERE ID_USUARIO = @ID_USUARIO");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("NOME", DbType.String).Value = usuario.Nome;
                command.Parameters.Add("DT_NASCIMENTO", DbType.DateTime).Value = usuario.DtNascimento;
                command.Parameters.Add("CARGO", DbType.String).Value = usuario.Cargo;
                command.Parameters.Add("ENDERECO", DbType.String).Value = usuario.Endereco;
                command.Parameters.Add("LOGIN", DbType.String).Value = usuario.Login;
                command.Parameters.Add("EMAIL", DbType.String).Value = usuario.Email;
                command.Parameters.Add("STATUS", DbType.String).Value = usuario.Status;
                command.Parameters.Add("DT_CRIACAO", DbType.DateTime).Value = usuario.DtCriacao;
                command.Parameters.Add("NIVEL_ACESSO", DbType.String).Value = usuario.NivelAcesso;
                command.Parameters.Add("SENHA", DbType.String).Value = usuario.Senha;
                command.Parameters.Add("ID_USUARIO", DbType.Int32).Value = usuario.IdUsuario;


                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void DeleteUsuario(Usuario usuario)
        {
            using (_dbConnection)
            {
                var command = new MySqlCommand("DELETE FROM USUARIO WHERE ID_USUARIO = @ID_USUARIO");

                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;
         
                command.Parameters.Add("ID_USUARIO", DbType.Int32).Value = usuario.IdUsuario;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }


        public List<Usuario> ListUsuario()
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM USUARIO");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                MySqlDataReader dr;
                List<Usuario> listUsuarios = new List<Usuario>();

                dr = cmd.ExecuteReader();


                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        Usuario usuario = new Usuario();

                        usuario.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                        usuario.Login = Convert.ToString(dr["LOGIN"]);
                        usuario.Nome = Convert.ToString(dr["NOME"]) ;
                        usuario.DtNascimento = Convert.ToDateTime(dr["DT_NASCIMENTO"]);
                        usuario.Cargo = Convert.ToString(dr["CARGO"]);
                        usuario.Email = Convert.ToString(dr["EMAIL"]);
                        usuario.Status = Convert.ToChar(dr["STATUS"]);
                        usuario.DtCriacao = Convert.ToDateTime(dr["DT_CRIACAO"]);
                        usuario.NivelAcesso = Convert.ToString(dr["NIVEL_ACESSO"]);
                        usuario.Senha = Convert.ToString(dr["SENHA"]);
                        usuario.Endereco = Convert.ToString(dr["ENDERECO"]);
                                           
                        listUsuarios.Add(usuario);
                    }
                }

                _dbConnection.Close();

                return listUsuarios;
            }


        }

    }
}
