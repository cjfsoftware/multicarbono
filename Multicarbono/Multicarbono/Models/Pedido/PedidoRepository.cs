using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
                        pedido.TipoFrete = (Enum.TipoFrete)System.Enum.Parse(typeof(Enum.TipoFrete), Convert.ToString(dr["TIPO_FRETE"]), true);
                        pedido.IdTransport = Convert.ToInt32(dr["ID_TRANSPORT"]);


                        listPedido.Add(pedido);
                    }
                }

                _dbConnection.Close();
                _dbConnection.Dispose();

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

                //int result = cmd.ExecuteNonQuery();

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
                        pedido.TipoFrete = (Enum.TipoFrete)System.Enum.Parse(typeof(Enum.TipoFrete), Convert.ToString(dr["TIPO_FRETE"]), true);
                        pedido.IdTransport = Convert.ToInt32(dr["ID_TRANSPORT"]);
                        pedido.NFEmitida = Convert.ToChar(dr["NF_EMITIDA"]);


                        pedidoById = pedido;
                    }
                }

                _dbConnection.Close();

                return pedidoById;
            }
        }

        public List<Pedido> PedidoByFiltro(string razaoSocial=null, DateTime? dataInit=null, DateTime? dataFim=null)
        {
            string listIdStr = null;

            if (razaoSocial != null)
            {
                //using (_dbConnection)
                //{
                //    _dbConnection.Open();

                //    var command = new MySqlCommand($"SELECT ID_CLIENTE FROM CLIENTE WHERE UPPER(RAZAO_SOCIAL) LIKE '%{razaoSocial.ToUpper()}%'");

                //    command.CommandType = CommandType.Text;
                //    command.Connection = _dbConnection;

                //    //command.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = idCliente;

                //    MySqlDataReader dr1;

                //    dr1 = command.ExecuteReader();


                //    if (dr1.HasRows)
                //    {
                //        while (dr1.Read())
                //        {
                //            string id;

                //            id = Convert.ToString(dr1["ID_CLIENTE"]);
                //            listId.Add(id);
                //        }
                //    }
                //}

                listIdStr = PesquisaCliente(razaoSocial);
            }

            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM PEDIDO WHERE /*@ID_CLIENTE_FILTER_CLAUSE*/ DT_EMISSAO BETWEEN (SELECT STR_TO_DATE(@DT_EMISSAO_INI,'%d,%m,%Y')) AND (SELECT STR_TO_DATE(@DT_EMISSAO_FIM,'%d,%m,%Y'))");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                dataInit = dataInit == null ? DateTime.MinValue : dataInit;
                dataFim = dataFim == null ? DateTime.MaxValue : dataFim;
                //listIdStr = listIdStr == null ? " " : $"ID_CLIENTE in ({listIdStr}) AND ";

                //cmd.Parameters.Add("ID_CLIENTE_FILTER_CLAUSE", DbType.String).Value = listIdStr;
                cmd.Parameters.Add("DT_EMISSAO_INI", DbType.String).Value = dataInit/*DateTime.ParseExact(dataInit.ToString(),"YYYY-MM-dd hh:mm:ss", CultureInfo.InvariantCulture)*/.ToString().Replace('/', ',').Replace(':', ',').Replace(' ', ',').Replace(",PM","").Replace(",AM","");
                cmd.Parameters.Add("DT_EMISSAO_FIM", DbType.String).Value = dataFim.ToString().Replace('/', ',').Replace(':', ',').Replace(' ', ',').Replace(",PM", "").Replace(",AM", "");


                MySqlDataReader dr;
                List<Pedido> pedidoByFiltro = new List<Pedido>();

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
                        pedido.TipoFrete = (Enum.TipoFrete)dr["TIPO_FRETE"];
                        pedido.IdTransport = Convert.ToInt32(dr["ID_TRANSPORT"]);


                        pedidoByFiltro.Add(pedido);
                    }
                }

                //_dbConnection.Close();
                //_dbConnection.Dispose();

                return pedidoByFiltro;
            }
        }

        public string PesquisaCliente(string razaoSocial)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand($"SELECT ID_CLIENTE FROM CLIENTE WHERE UPPER(RAZAO_SOCIAL) LIKE '%{razaoSocial.ToUpper()}%'");

                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                //command.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = idCliente;

                MySqlDataReader dr1;
                List<string> listId = new List<string>();


                dr1 = command.ExecuteReader();


                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        string id;

                        id = Convert.ToString(dr1["ID_CLIENTE"]);
                        listId.Add(id);
                    }
                }

                string? listIdStr = string.Join(",", listId);

                return listIdStr;
            }
        }


        public void UpdatePedido(Pedido pedido)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("UPDATE PEDIDO SET ID_PEDIDO = @ID_PEDIDO, NUM_PEDIDO = @NUM_PEDIDO, CNPJ_CLIENTE = @CNPJ_CLIENTE, ID_USUARIO = @ID_USUARIO, " +
                "DT_EMISSAO = @DT_EMISSAO, DT_CARREGA = @DT_CARREGA, OBS = @OBS, TIPO_FRETE = @TIPO_FRETE, ID_TRANSPORT = @ID_TRANSPORT");


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
                command.Parameters.Add("ID_TRANSPORT", DbType.Int32).Value = pedido.IdTransport;


                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void IncludePedido(Pedido pedido)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("INSERT INTO PEDIDO (ID_PEDIDO, NUM_PEDIDO, CNPJ_CLIENTE, ID_USUARIO, DT_EMISSAO, DT_CARREGA, OBS, TIPO_FRETE, ID_TRANSPORT) VALUES" +
                "(@ID_PEDIDO, @NUM_PEDIDO, @CNPJ_CLIENTE, @ID_USUARIO, @DT_EMISSAO, @DT_CARREGA, @OBS, @TIPO_FRETE, @ID_TRANSPORT)");


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
                command.Parameters.Add("ID_TRANSPORT", DbType.Int32).Value = pedido.IdTransport;
                command.Parameters.Add("NF_EMITIDA", DbType.String).Value = 'N';


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
