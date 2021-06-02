using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Telefone
{
    public class TelefoneRepository
    {
        private readonly MySqlConnection _dbConnection;


        public TelefoneRepository(MySqlConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<Telefone> ListTelefone()
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM TELEFONE");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                MySqlDataReader dr;
                List<Telefone> listTelefone = new List<Telefone>();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Telefone telefone = new Telefone();

                        telefone.IdTelefone = Convert.ToInt32(dr["ID_TELEFONE"]);
                        telefone.IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                        telefone.NumTelefone = Convert.ToString(dr["NUM_TELEFONE"]);
                        telefone.Contato = Convert.ToString(dr["CONTATO"]);

                        listTelefone.Add(telefone);
                    }
                }

                _dbConnection.Close();

                return listTelefone;
            }
        }

        public Telefone TelefoneById(int idTelefone)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM TELEFONE WHERE ID_TELEFONE = @ID_TELEFONE");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                cmd.Parameters.Add("ID_TELEFONE", DbType.Int32).Value = idTelefone;

                int result = cmd.ExecuteNonQuery();

                MySqlDataReader dr;
                Telefone telefoneById = new Telefone();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Telefone telefone = new Telefone();

                        telefone.IdTelefone = Convert.ToInt32(dr["ID_TELEFONE"]);
                        telefone.IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                        telefone.NumTelefone = Convert.ToString(dr["NUM_TELEFONE"]);
                        telefone.Contato = Convert.ToString(dr["CONTATO"]);

                        telefoneById = telefone;
                    }
                }

                _dbConnection.Close();

                return telefoneById;
            }
        }

        public List<Telefone> TelefoneByCliente(int idCliente)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM TELEFONE WHERE ID_CLIENTE = @ID_CLIENTE");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                cmd.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = idCliente;

                int result = cmd.ExecuteNonQuery();

                MySqlDataReader dr;
                List<Telefone> listTelefone = new List<Telefone>();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Telefone telefone = new Telefone();

                        telefone.IdTelefone = Convert.ToInt32(dr["ID_TELEFONE"]);
                        telefone.IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                        telefone.NumTelefone = Convert.ToString(dr["NUM_TELEFONE"]);
                        telefone.Contato = Convert.ToString(dr["CONTATO"]);

                        listTelefone.Add(telefone);
                    }
                }

                _dbConnection.Close();

                return listTelefone;
            }
        }

        public void UpdateTelefone(Telefone telefone)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("UPDATE TELEFONE SET ID_TELEFONE = @ID_TELEFONE, ID_CLIENTE = @ID_CLIENTE, NUM_TELEFONE = @NUM_TELEFONE, CONTATO = @CONTATO");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_TELEFONE", DbType.Int32).Value = telefone.IdTelefone;
                command.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = telefone.IdCliente;
                command.Parameters.Add("NUM_TELEFONE", DbType.String).Value = telefone.NumTelefone;
                command.Parameters.Add("CONTATO", DbType.String).Value = telefone.Contato;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void IncludeTelefone(Telefone telefone)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("INSERT INTO TELEFONE (ID_TELEFONE, ID_CLIENTE, NUM_TELEFONE, CONTATO) VALUES" +
                "(@ID_TELEFONE, @ID_CLIENTE, @NUM_TELEFONE, @CONTATO)");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_TELEFONE", DbType.Int32).Value = telefone.IdTelefone;
                command.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = telefone.IdCliente;
                command.Parameters.Add("NUM_TELEFONE", DbType.String).Value = telefone.NumTelefone;
                command.Parameters.Add("CONTATO", DbType.String).Value = telefone.Contato;


                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void DeleteTelefone(int idTelefone)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("DELETE FROM TELEFONE WHERE ID_TELEFONE = @ID_TELEFONE");

                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_TELEFONE", DbType.Int32).Value = idTelefone;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }
    }
}
