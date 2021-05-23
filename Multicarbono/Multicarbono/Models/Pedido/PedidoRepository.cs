using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.Pedido
{
    public class PedidoRepository
    {
        private readonly MySqlConnection _dbConnection;


        public PedidoRepository(MySqlConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<Pedido> ListPedido()
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM PEDIDO");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                MySqlDataReader dr;
                List<Pedido> listPedido = new List<Pedido>();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Pedido pedido = new Pedido();

                        pedido.IdPedido = Convert.ToInt32(dr["ID_PEDIDO"]);
                        pedido.NumPedido = Convert.ToInt32(dr["NUM_PEDIDO"]);
                        pedido.CNPJCliente = Convert.ToString(dr["CNPJ_CLIENTE"]);
                        pedido.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                        pedido.DtEmissao = Convert.ToDateTime(dr["DT_EMISSAO"]);
                        pedido.DtCarregamento = Convert.ToDateTime(dr["DT_CARREGA"]);
                        pedido.Obs = Convert.ToString(dr["OBS"]);
                        pedido.TipoFrete = Convert.ToString(dr["TIPO_FRETE"]);


                        listPedido.Add(pedido);
                    }
                }

                _dbConnection.Close();

                return listPedido;
            }
        }

        public Pedido PedidoById(int idPedido)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM PEDIDO WHERE ID_PEDIDO = @ID_PEDIDO");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                cmd.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = idPedido;

                int result = cmd.ExecuteNonQuery();

                MySqlDataReader dr;
                Pedido pedidoById = new Pedido();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Pedido pedido = new Pedido();

                        pedido.IdPedido = Convert.ToInt32(dr["ID_PEDIDO"]);
                        pedido.NumPedido = Convert.ToInt32(dr["NUM_PEDIDO"]);
                        pedido.CNPJCliente = Convert.ToString(dr["CNPJ_CLIENTE"]);
                        pedido.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                        pedido.DtEmissao = Convert.ToDateTime(dr["DT_EMISSAO"]);
                        pedido.DtCarregamento = Convert.ToDateTime(dr["DT_CARREGA"]);
                        pedido.Obs = Convert.ToString(dr["OBS"]);
                        pedido.TipoFrete = Convert.ToString(dr["TIPO_FRETE"]);


                        pedidoById = pedido;
                    }
                }

                _dbConnection.Close();

                return pedidoById;
            }
        }

        public Pedido PedidoByFiltro(int idCliente, DateTime dataInit, DateTime dataFim)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM PEDIDO WHERE ID_CLIENTE = @ID_CLIENTE");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                cmd.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = idCliente;

                int result = cmd.ExecuteNonQuery();

                MySqlDataReader dr;
                Pedido pedidoByCliente = new Pedido();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Pedido pedido = new Pedido();

                        pedido.IdPedido = Convert.ToInt32(dr["ID_PEDIDO"]);
                        pedido.NumPedido = Convert.ToInt32(dr["NUM_PEDIDO"]);
                        pedido.CNPJCliente = Convert.ToString(dr["CNPJ_CLIENTE"]);
                        pedido.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                        pedido.DtEmissao = Convert.ToDateTime(dr["DT_EMISSAO"]);
                        pedido.DtCarregamento = Convert.ToDateTime(dr["DT_CARREGA"]);
                        pedido.Obs = Convert.ToString(dr["OBS"]);
                        pedido.TipoFrete = Convert.ToString(dr["TIPO_FRETE"]);


                        pedidoByCliente = pedido;
                    }
                }

                _dbConnection.Close();

                return pedidoByCliente;
            }
        }

        public void UpdatePedido(Pedido pedido)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("UPDATE PEDIDO SET ID_PEDIDO = @ID_PEDIDO, NUM_PEDIDO = @NUM_PEDIDO, CNPJ_CLIENTE = @CNPJ_CLIENTE, ID_USUARIO = @ID_USUARIO, " +
                "DT_EMISSAO = @DT_EMISSAO, DT_CARREGA = @DT_CARREGA, OBS = @OBS, TIPO_FRETE = @TIPO_FRETE");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = pedido.IdPedido;
                command.Parameters.Add("NUM_PEDIDO", DbType.Int32).Value = pedido.NumPedido;
                command.Parameters.Add("CNPJ_CLIENTE", DbType.String).Value = pedido.CNPJCliente;
                command.Parameters.Add("ID_USUARIO", DbType.Int32).Value = pedido.IdUsuario;
                command.Parameters.Add("DT_EMISSAO", DbType.DateTime).Value = pedido.DtEmissao;
                command.Parameters.Add("DT_CARREGA", DbType.DateTime).Value = pedido.DtCarregamento;
                command.Parameters.Add("OBS", DbType.String).Value = pedido.Obs;
                command.Parameters.Add("TIPO_FRETE", DbType.String).Value = pedido.TipoFrete;


                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void IncludePedido(Pedido pedido)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("INSERT INTO PEDIDO (ID_PEDIDO, NUM_PEDIDO, CNPJ_CLIENTE, ID_USUARIO, DT_EMISSAO, DT_CARREGA, OBS, TIPO_FRETE) VALUES" +
                "(@ID_PEDIDO, @NUM_PEDIDO, @CNPJ_CLIENTE, @ID_USUARIO, @DT_EMISSAO, @DT_CARREGA, @OBS, @TIPO_FRETE)");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = pedido.IdPedido;
                command.Parameters.Add("NUM_PEDIDO", DbType.Int32).Value = pedido.NumPedido;
                command.Parameters.Add("CNPJ_CLIENTE", DbType.String).Value = pedido.CNPJCliente;
                command.Parameters.Add("ID_USUARIO", DbType.Int32).Value = pedido.IdUsuario;
                command.Parameters.Add("DT_EMISSAO", DbType.DateTime).Value = pedido.DtEmissao;
                command.Parameters.Add("DT_CARREGA", DbType.DateTime).Value = pedido.DtCarregamento;
                command.Parameters.Add("OBS", DbType.String).Value = pedido.Obs;
                command.Parameters.Add("TIPO_FRETE", DbType.String).Value = pedido.TipoFrete;


                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void DeletePedido(int idPedido)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("DELETE FROM PEDIDO WHERE ID_PEDIDO = @ID_PEDIDO");

                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = idPedido;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

    }
}
