using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Cliente
{
    public class ClienteRepository
    {
        private readonly MySqlConnection _dbConnection;


        public ClienteRepository(MySqlConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<Cliente> ListCliente()
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM CLIENTE");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                MySqlDataReader dr;
                List<Cliente> listClientes = new List<Cliente>();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Cliente cliente = new Cliente();

                        cliente.IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                        cliente.CNPJ = Convert.ToString(dr["CNPJ"]);
                        cliente.RazaoSocial = Convert.ToString(dr["RAZAO_SOCIAL"]);
                        cliente.NomeFantasia = Convert.ToString(dr["NOME_FANTASIA"]);
                        cliente.IE = Convert.ToString(dr["IE"]);
                        cliente.DtCadastro = Convert.ToDateTime(dr["DT_CADASTRO"]);
                        cliente.Saldo = Convert.ToDecimal(dr["SALDO"]);
                        cliente.Situacao = (Enum.SituacaoCliente)System.Enum.Parse(typeof(Enum.SituacaoCliente), Convert.ToString(dr["SITUACAO"]), true);
                        
                        listClientes.Add(cliente);
                    }
                }

                _dbConnection.Close();

                return listClientes;
            }
        }

        public Cliente ClienteById(int idCliente)
        {
            _dbConnection.Open();

            var cmd = new MySqlCommand("SELECT * FROM CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE ");

            cmd.CommandType = CommandType.Text;
            cmd.Connection = _dbConnection;

            cmd.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = idCliente;

            int result = cmd.ExecuteNonQuery();

            MySqlDataReader dr;
            Cliente clienteById = new Cliente();

            dr = cmd.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                    cliente.CNPJ = Convert.ToString(dr["CNPJ"]);
                    cliente.RazaoSocial = Convert.ToString(dr["RAZAO_SOCIAL"]);
                    cliente.NomeFantasia = Convert.ToString(dr["NOME_FANTASIA"]);
                    cliente.IE = Convert.ToString(dr["IE"]);
                    cliente.DtCadastro = Convert.ToDateTime(dr["DT_CADASTRO"]);
                    cliente.Saldo = Convert.ToDecimal(dr["SALDO"]);
                    cliente.Situacao = (Enum.SituacaoCliente)System.Enum.Parse(typeof(Enum.SituacaoCliente), Convert.ToString(dr["SITUACAO"]), true);

                    clienteById = cliente;
                }
            }

            _dbConnection.Close();

            return clienteById;
        }

        public void UpdateCliente(Cliente cliente)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("UPDATE CLIENTE SET CNPJ = @CNPJ, RAZAO_SOCIAL = @RAZAO_SOCIAL, NOME_FANTASIA = @NOME_FANTASIA, IE = @IE, " +
                "DT_CADASTRO = @DT_CADASTRO, SALDO = @SALDO, SITUACAO = @SITUACAO WHERE ID_CLIENTE = @ID_CLIENTE");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("CNPJ", DbType.String).Value = cliente.CNPJ;
                command.Parameters.Add("RAZAO_SOCIAL", DbType.String).Value = cliente.RazaoSocial;
                command.Parameters.Add("NOME_FANTASIA", DbType.String).Value = cliente.NomeFantasia;
                command.Parameters.Add("IE", DbType.String).Value = cliente.IE;
                command.Parameters.Add("DT_CADASTRO", DbType.DateTime).Value = cliente.DtCadastro;
                command.Parameters.Add("SALDO", DbType.Decimal).Value = cliente.Saldo;
                command.Parameters.Add("SITUACAO", DbType.String).Value = cliente.Situacao;
                command.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = cliente.IdCliente;


                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void IncludeCliente(Cliente cliente)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("INSERT INTO CLIENTE (CNPJ, RAZAO_SOCIAL, NOME_FANTASIA, IE, DT_CADASTRO, SALDO, SITUACAO) VALUES" + 
                "(@CNPJ, @RAZAO_SOCIAL, @NOME_FANTASIA, @IE, @DT_CADASTRO, @SALDO, @SITUACAO)");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("CNPJ", DbType.String).Value = cliente.CNPJ;
                command.Parameters.Add("RAZAO_SOCIAL", DbType.String).Value = cliente.RazaoSocial;
                command.Parameters.Add("NOME_FANTASIA", DbType.String).Value = cliente.NomeFantasia;
                command.Parameters.Add("IE", DbType.String).Value = cliente.IE;
                command.Parameters.Add("DT_CADASTRO", DbType.DateTime).Value = cliente.DtCadastro;
                command.Parameters.Add("SALDO", DbType.Decimal).Value = cliente.Saldo;
                command.Parameters.Add("SITUACAO", DbType.String).Value = cliente.Situacao;
                command.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = cliente.IdCliente;


                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void DeleteCliente(int idCliente)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("DELETE FROM CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE");

                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = idCliente;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }
    }
}
