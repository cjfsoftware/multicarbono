using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Transportador
{
    public class TransportadorRepository
    {
        private readonly MySqlConnection _dbConnection;


        public TransportadorRepository(MySqlConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<Transportador> ListTransportador()
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM TRANSPORTADOR");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                MySqlDataReader dr;
                List<Transportador> listTransportador = new List<Transportador>();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Transportador transportador = new Transportador();

                        transportador.IdTransportador = Convert.ToInt32(dr["ID_TRANSPORTADOR"]);
                        transportador.CNPJTransportador = Convert.ToString(dr["CNPJ_TRANSPORTADOR"]);
                        transportador.RazaoSocial = Convert.ToString(dr["RAZAO_SOCIAL"]);
                        transportador.IETransportador = Convert.ToInt32(dr["IE_TRANSPORTADOR"]);
                        transportador.EnderecoTransp = Convert.ToString(dr["ENDERECO_TRANSP"]);

                        listTransportador.Add(transportador);
                    }
                }

                _dbConnection.Close();

                return listTransportador;
            }
        }

        public Transportador TransportadorById(int idTransportador)
        {
            _dbConnection.Open();

            var cmd = new MySqlCommand("SELECT * FROM TRANSPORTADOR WHERE ID_TRANSPORTADOR = @ID_TRANSPORTADOR");

            cmd.CommandType = CommandType.Text;
            cmd.Connection = _dbConnection;

            cmd.Parameters.Add("ID_TRANSPORTADOR", DbType.Int32).Value = idTransportador;

            int result = cmd.ExecuteNonQuery();

            MySqlDataReader dr;
            Transportador transportadorById = new Transportador();

            dr = cmd.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Transportador transportador = new Transportador();

                    transportador.IdTransportador = Convert.ToInt32(dr["ID_TRANSPORTADOR"]);
                    transportador.CNPJTransportador = Convert.ToString(dr["CNPJ_TRANSPORTADOR"]);
                    transportador.RazaoSocial = Convert.ToString(dr["RAZAO_SOCIAL"]);
                    transportador.IETransportador = Convert.ToInt32(dr["IE_TRANSPORTADOR"]);
                    transportador.EnderecoTransp = Convert.ToString(dr["ENDERECO_TRANSP"]);

                    transportadorById = transportador;
                }
            }

            _dbConnection.Close();

            return transportadorById;
            
        }


        public void UpdateTransportador(Transportador transportador)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("UPDATE TRANSPORTAOOR SET CNPJ_TRANSPORTADOR = @CNPJ_TRANSPORTADOR, RAZAO_SOCIAL = @RAZAO_SOCIAL, ENDERECO_TRANSP = @ENDERECO_TRANSP WHERE ID_TRANSPORTADOR = @ID_TRANSPORTADOR");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_TRANSPORTADOR", DbType.Int32).Value = transportador.IdTransportador;
                command.Parameters.Add("CNPJ_TRANSPORTADOR", DbType.String).Value = transportador.CNPJTransportador;
                command.Parameters.Add("RAZAO_SOCIAL", DbType.String).Value = transportador.RazaoSocial;
                command.Parameters.Add("IE_TRANSPORTADOR", DbType.Int32).Value = transportador.IETransportador;
                command.Parameters.Add("ENDERECO_TRANSP", DbType.String).Value = transportador.EnderecoTransp;


                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void IncludeTransportador(Transportador transportador)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("INSERT INTO TRANSPORTADOR (ID_TRANSPORTADOR, CNPJ_TRANSPORTADOR, RAZAO_SOCIAL, IE_TRANSPORTADOR, ENDERECO_TRANSP) VALUES" +
                "(@ID_TRANSPORTADOR, @CNPJ_TRANSPORTADOR, @RAZAO_SOCIAL, @IE_TRANSPORTADOR, @ENDERECO_TRANSP )");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;


                command.Parameters.Add("ID_TRANSPORTADOR", DbType.Int32).Value = transportador.IdTransportador;
                command.Parameters.Add("CNPJ_TRANSPORTADOR", DbType.String).Value = transportador.CNPJTransportador;
                command.Parameters.Add("RAZAO_SOCIAL", DbType.String).Value = transportador.RazaoSocial;
                command.Parameters.Add("IE_TRANSPORTADOR", DbType.Int32).Value = transportador.IETransportador;
                command.Parameters.Add("ENDERECO_TRANSP", DbType.String).Value = transportador.EnderecoTransp;


                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void DeleteTransportador(int idTransportador)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("DELETE FROM TRANSPORTADOR WHERE ID_TRANSPORTADOR = @ID_TRANSPORTADOR");

                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_TRANSPORTADOR", DbType.Int32).Value = idTransportador;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

    }
}
