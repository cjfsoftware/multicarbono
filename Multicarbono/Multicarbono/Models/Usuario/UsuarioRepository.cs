using Multicarbono.Configuration;
using Multicarbono.Exceptions;
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
        private readonly Security _security;

        public UsuarioRepository(MySqlConnection dbConnection, Security security)
        {
            _dbConnection = dbConnection;
            _security = security;
        }

        public void IncludeUsuario(Usuario usuario)
        {
            var encryptedPassword = _security.Encrypt(usuario.Senha);

            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("INSERT INTO USUARIO (NOME, DT_NASCIMENTO, CARGO, ENDERECO, LOGIN, EMAIL, STATUS, DT_CRIACAO, NIVEL_ACESSO, SENHA ) " +
                    "VALUES (@NOME, @DT_NASCIMENTO, @CARGO, @ENDERECO, @LOGIN, @EMAIL, @STATUS, @DT_CRIACAO, @NIVEL_ACESSO, @SENHA)");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("NOME", DbType.String).Value = usuario.Nome;
                command.Parameters.Add("DT_NASCIMENTO", DbType.DateTime).Value = usuario.DtNascimento;
                command.Parameters.Add("CARGO", DbType.String).Value = usuario.Cargo;
                command.Parameters.Add("ENDERECO", DbType.String).Value = usuario.Endereco;
                command.Parameters.Add("LOGIN", DbType.String).Value = usuario.Login;
                command.Parameters.Add("EMAIL", DbType.String).Value = usuario.Email;
                command.Parameters.Add("STATUS", DbType.Boolean).Value = usuario.Ativo;
                command.Parameters.Add("DT_CRIACAO", DbType.DateTime).Value = usuario.DtCriacao;
                command.Parameters.Add("NIVEL_ACESSO", DbType.String).Value = usuario.NivelAcesso;
                command.Parameters.Add("SENHA", DbType.String).Value = encryptedPassword;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void UpdateUsuario(Usuario usuario)
        {
            var encryptedPassword = _security.Encrypt(usuario.Senha);
            
            _dbConnection.Open();

            var command = new MySqlCommand("UPDATE USUARIO SET NOME = @NOME, DT_NASCIMENTO = @DT_NASCIMENTO, CARGO = @CARGO, ENDERECO = @ENDERECO, LOGIN = @LOGIN, " +
            "EMAIL = @EMAIL, STATUS = @STATUS, NIVEL_ACESSO = @NIVEL_ACESSO, SENHA = @SENHA WHERE ID_USUARIO = @ID_USUARIO");


            command.CommandType = CommandType.Text;
            command.Connection = _dbConnection;

            command.Parameters.Add("NOME", DbType.String).Value = usuario.Nome;
            command.Parameters.Add("DT_NASCIMENTO", DbType.DateTime).Value = usuario.DtNascimento;
            command.Parameters.Add("CARGO", DbType.String).Value = usuario.Cargo;
            command.Parameters.Add("ENDERECO", DbType.String).Value = usuario.Endereco;
            command.Parameters.Add("LOGIN", DbType.String).Value = usuario.Login;
            command.Parameters.Add("EMAIL", DbType.String).Value = usuario.Email;
            command.Parameters.Add("STATUS", DbType.Boolean).Value = usuario.Ativo;
            command.Parameters.Add("NIVEL_ACESSO", DbType.String).Value = usuario.NivelAcesso;
            command.Parameters.Add("SENHA", DbType.String).Value = encryptedPassword;
            command.Parameters.Add("ID_USUARIO", DbType.Int32).Value = usuario.IdUsuario;

            int result = command.ExecuteNonQuery();

            _dbConnection.Close();
        }

        public void DeleteUsuario(int idUsuario)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("DELETE FROM USUARIO WHERE ID_USUARIO = @ID_USUARIO");

                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_USUARIO", DbType.Int32).Value = idUsuario;

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


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Usuario usuario = new Usuario();

                        usuario.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                        usuario.Login = Convert.ToString(dr["LOGIN"]);
                        usuario.Nome = Convert.ToString(dr["NOME"]);
                        usuario.DtNascimento = Convert.ToDateTime(dr["DT_NASCIMENTO"]);
                        usuario.Cargo = Convert.ToString(dr["CARGO"]);
                        usuario.Email = Convert.ToString(dr["EMAIL"]);
                        usuario.Ativo = Convert.ToBoolean(dr["STATUS"]);
                        usuario.DtCriacao = Convert.ToDateTime(dr["DT_CRIACAO"]);
                        usuario.NivelAcesso = (Enum.NivelAcesso)System.Enum.Parse(typeof(Enum.NivelAcesso), Convert.ToString(dr["NIVEL_ACESSO"]), true);
                        usuario.Senha = Convert.ToString(dr["SENHA"]);
                        usuario.Endereco = Convert.ToString(dr["ENDERECO"]);

                        listUsuarios.Add(usuario);
                    }
                }

                _dbConnection.Close();

                return listUsuarios;
            }
        }

        public Usuario UsuarioById(int idUsuario)
        {
            _dbConnection.Open();

            var cmd = new MySqlCommand("SELECT * FROM USUARIO WHERE ID_USUARIO = @ID_USUARIO ");

            cmd.CommandType = CommandType.Text;
            cmd.Connection = _dbConnection;

            cmd.Parameters.Add("ID_USUARIO", DbType.Int32).Value = idUsuario;

            int result = cmd.ExecuteNonQuery();

            MySqlDataReader dr;
            Usuario usuarioById = new Usuario();

            dr = cmd.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Usuario user = new Usuario();

                    user.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                    user.Login = Convert.ToString(dr["LOGIN"]);
                    user.Nome = Convert.ToString(dr["NOME"]);
                    user.DtNascimento = Convert.ToDateTime(dr["DT_NASCIMENTO"]);
                    user.Cargo = Convert.ToString(dr["CARGO"]);
                    user.Email = Convert.ToString(dr["EMAIL"]);
                    user.Ativo = Convert.ToBoolean(dr["STATUS"]);
                    user.DtCriacao = Convert.ToDateTime(dr["DT_CRIACAO"]);
                    user.NivelAcesso = (Enum.NivelAcesso)System.Enum.Parse(typeof(Enum.NivelAcesso), Convert.ToString(dr["NIVEL_ACESSO"]), true);
                    user.Senha = Convert.ToString(dr["SENHA"]);
                    user.Endereco = Convert.ToString(dr["ENDERECO"]);

                    usuarioById = user;
                }
            }

            _dbConnection.Close();

            return usuarioById;
            
        }

        public Usuario UsuarioByLogin(string login)
        {
            _dbConnection.Open();

            var cmd = new MySqlCommand("SELECT * FROM USUARIO WHERE LOWER(LOGIN) = @LOGIN")
            {
                CommandType = CommandType.Text,
                Connection = _dbConnection,
            };

            cmd.Parameters.Add("LOGIN", DbType.String).Value = login;

            int result = cmd.ExecuteNonQuery();

            MySqlDataReader dr;
            Usuario usuarioByLogin = new Usuario();

            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    usuarioByLogin.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                    usuarioByLogin.Login = Convert.ToString(dr["LOGIN"]);
                    usuarioByLogin.Nome = Convert.ToString(dr["NOME"]);
                    usuarioByLogin.DtNascimento = Convert.ToDateTime(dr["DT_NASCIMENTO"]);
                    usuarioByLogin.Cargo = Convert.ToString(dr["CARGO"]);
                    usuarioByLogin.Email = Convert.ToString(dr["EMAIL"]);
                    usuarioByLogin.Ativo = Convert.ToBoolean(dr["STATUS"]);
                    usuarioByLogin.DtCriacao = Convert.ToDateTime(dr["DT_CRIACAO"]);
                    usuarioByLogin.NivelAcesso = (Enum.NivelAcesso)System.Enum.Parse(typeof(Enum.NivelAcesso), Convert.ToString(dr["NIVEL_ACESSO"]), true);
                    usuarioByLogin.Senha = Convert.ToString(dr["SENHA"]);
                    usuarioByLogin.Endereco = Convert.ToString(dr["ENDERECO"]);
                }

                return usuarioByLogin;
            }

            else
            {
                throw new ResourceNotFoundException();
            }
        }
    }
}
