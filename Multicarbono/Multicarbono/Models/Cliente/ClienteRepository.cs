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
                        cliente.Situacao = Convert.ToChar(dr["SITUACAO"]);
                        
                        listClientes.Add(cliente);
                    }
                }

                _dbConnection.Close();

                return listClientes;
            }


        }
    }
}
