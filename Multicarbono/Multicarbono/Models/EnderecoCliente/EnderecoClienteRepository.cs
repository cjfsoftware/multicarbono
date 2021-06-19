using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.EnderecoCliente
{
    public class EnderecoClienteRepository
    {
        private readonly MySqlConnection _dbConnection;


        public EnderecoClienteRepository(MySqlConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<EnderecoCliente> ListEndereco()
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM ENDERECO_CLIENTE");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                MySqlDataReader dr;
                List<EnderecoCliente> listEndereco = new List<EnderecoCliente>();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EnderecoCliente endereco = new EnderecoCliente();

                        endereco.IdEndereco = Convert.ToInt32(dr["ID_ENDERECO"]);
                        endereco.IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                        endereco.Endereco = Convert.ToString(dr["ENDERECO"]);
                        endereco.CEP = Convert.ToString(dr["CEP"]);
                        endereco.TipoEndereco = (Enum.TipoEnderecoCliente)System.Enum.Parse(typeof(Enum.TipoEnderecoCliente), Convert.ToString(dr["TIPO_ENDERECO"]));


                        listEndereco.Add(endereco);
                    }
                }

                _dbConnection.Close();

                return listEndereco;
            }
        }

        public EnderecoCliente EnderecoById(int idEndereco)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM ENDERECO_CLIENTE WHERE ID_ENDERECO = @ID_ENDERECO");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                cmd.Parameters.Add("ID_ENDERECO", DbType.Int32).Value = idEndereco;

                int result = cmd.ExecuteNonQuery();

                MySqlDataReader dr;
                EnderecoCliente enderecoById = new EnderecoCliente();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EnderecoCliente endereco = new EnderecoCliente();

                        endereco.IdEndereco = Convert.ToInt32(dr["ID_ENDERECO"]);
                        endereco.IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                        endereco.Endereco = Convert.ToString(dr["ENDERECO"]);
                        endereco.CEP = Convert.ToString(dr["CEP"]);
                        endereco.TipoEndereco = (Enum.TipoEnderecoCliente)System.Enum.Parse(typeof(Enum.TipoEnderecoCliente), Convert.ToString(dr["TIPO_ENDERECO"]), true);

                        enderecoById = endereco;
                    }
                }

                _dbConnection.Close();

                return enderecoById;
            }
        }

        public List<EnderecoCliente> EnderecoByCliente(int idCliente)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM ENDERECO_CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                cmd.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = idCliente;

                int result = cmd.ExecuteNonQuery();

                MySqlDataReader dr;
                List<EnderecoCliente> listEndereco = new List<EnderecoCliente>();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EnderecoCliente endereco = new EnderecoCliente();

                        endereco.IdEndereco = Convert.ToInt32(dr["ID_ENDERECO"]);
                        endereco.IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                        endereco.Endereco = Convert.ToString(dr["ENDERECO"]);
                        endereco.CEP = Convert.ToString(dr["CEP"]);
                        endereco.TipoEndereco = (Enum.TipoEnderecoCliente)System.Enum.Parse(typeof(Enum.TipoEnderecoCliente), Convert.ToString(dr["TIPO_ENDERECO"]), true);

                        listEndereco.Add(endereco);
                    }
                }

                _dbConnection.Close();

                return listEndereco;
            }
        }

        public void UpdateEndereco(EnderecoCliente endereco)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("UPDATE ENDERECO_CLIENTE SET ENDERECO = @ENDERECO, CEP = @CEP, " +
                "TIPO_ENDERECO = @TIPO_ENDERECO WHERE ID_CLIENTE = @ID_CLIENTE");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_ENDERECO", DbType.Int32).Value = endereco.IdEndereco;
                command.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = endereco.IdCliente;
                command.Parameters.Add("ENDERECO", DbType.String).Value = endereco.Endereco;
                command.Parameters.Add("CEP", DbType.String).Value = endereco.CEP;
                command.Parameters.Add("TIPO_ENDERECO", DbType.String).Value = endereco.TipoEndereco;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void IncludeEndereco(EnderecoCliente endereco)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("INSERT INTO ENDERECO_CLIENTE (ID_CLIENTE, ENDERECO, CEP, TIPO_ENDERECO) VALUES" +
                "(@ID_CLIENTE, @ENDERECO, @CEP, @TIPO_ENDERECO)");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = endereco.IdCliente;
                command.Parameters.Add("ENDERECO", DbType.String).Value = endereco.Endereco;
                command.Parameters.Add("CEP", DbType.String).Value = endereco.CEP;
                command.Parameters.Add("TIPO_ENDERECO", DbType.String).Value = endereco.TipoEndereco;


                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void DeleteEndereco(int idEndereco)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("DELETE FROM ENDERECO_CLIENTE WHERE ID_ENDERECO = @ID_ENDERECO");

                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_ENDERECO", DbType.Int32).Value = idEndereco;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }
    }
}
