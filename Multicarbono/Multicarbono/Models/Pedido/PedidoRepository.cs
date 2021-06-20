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
                        pedido.IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                        pedido.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                        pedido.DtEmissao = Convert.ToDateTime(dr["DT_EMISSAO"]);
                        pedido.DtCarregamento = Convert.ToDateTime(dr["DT_CARREGA"]);
                        pedido.Obs = Convert.ToString(dr["OBS"]);
                        pedido.TipoFrete = (Enum.TipoFrete)System.Enum.Parse(typeof(Enum.TipoFrete), Convert.ToString(dr["TIPO_FRETE"]), true);
                        pedido.IdTransport = Convert.ToInt32(dr["ID_TRANSPORT"]);
                        pedido.ValorPedido = Convert.ToDecimal(dr["VALOR_PEDIDO"]);
                        pedido.ValorPagar = Convert.ToDecimal(dr["VALOR_PAGAR"]);


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
                        pedido.IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                        pedido.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                        pedido.DtEmissao = Convert.ToDateTime(dr["DT_EMISSAO"]);
                        pedido.DtCarregamento = Convert.ToDateTime(dr["DT_CARREGA"]);
                        pedido.Obs = Convert.ToString(dr["OBS"]);
                        pedido.TipoFrete = (Enum.TipoFrete)System.Enum.Parse(typeof(Enum.TipoFrete), Convert.ToString(dr["TIPO_FRETE"]), true);
                        pedido.IdTransport = Convert.ToInt32(dr["ID_TRANSPORT"]);
                        pedido.ValorPedido = Convert.ToDecimal(dr["VALOR_PEDIDO"]);
                        pedido.ValorPagar = Convert.ToDecimal(dr["VALOR_PAGAR"]);
                        pedido.NFEmitida = Convert.ToBoolean(dr["NF_EMITIDA"]);

                        pedidoById = pedido;
                    }
                }

                _dbConnection.Close();

                return pedidoById;
            }
        }

        public decimal getSaldo(int idPedido, int idCliente, decimal valorPedido)
        {
            //using (_dbConnection)
            //{
                _dbConnection.Open();

                var getSaldo = new MySqlCommand("SELECT SALDO FROM CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE");

                getSaldo.CommandType = CommandType.Text;
                getSaldo.Connection = _dbConnection;

                getSaldo.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = idCliente;

                MySqlDataReader dr;
                decimal saldo = 0;

                dr = getSaldo.ExecuteReader();

                while (dr.Read())
                {
                    saldo = Convert.ToDecimal(dr["SALDO"]);
                }

            _dbConnection.Close();


            return saldo;

            //}
        }

        public void ValorPagar(int idPedido, int idCliente, decimal valorPedido, decimal saldo)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();
                
                if(saldo >= valorPedido)
                {
                    decimal novoSaldo = saldo - valorPedido;
                    var updateSaldo = new MySqlCommand("UPDATE CLIENTE SET SALDO = @SALDO WHERE ID_CLIENTE = @ID_CLIENTE; COMMIT; UPDATE PEDIDO SET VALOR_PAGAR = 0 WHERE ID_PEDIDO = @ID_PEDIDO") ;

                    updateSaldo.Parameters.Add("SALDO", DbType.Int32).Value = novoSaldo;
                    updateSaldo.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = idCliente;
                    updateSaldo.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = idPedido;

                    updateSaldo.CommandType = CommandType.Text;
                    updateSaldo.Connection = _dbConnection;

                    int result = updateSaldo.ExecuteNonQuery();
                }
                else
                {
                    decimal novoValPedido = valorPedido - saldo;
                    var updateValPedido = new MySqlCommand("UPDATE CLIENTE SET SALDO = 0 WHERE ID_CLIENTE = @ID_CLIENTE; COMMIT; UPDATE PEDIDO SET VALOR_PAGAR = @VALOR_PAGAR WHERE ID_PEDIDO = @ID_PEDIDO");

                    updateValPedido.Parameters.Add("VALOR_PAGAR", DbType.Int32).Value = novoValPedido;
                    updateValPedido.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = idCliente;
                    updateValPedido.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = idPedido;

                    updateValPedido.CommandType = CommandType.Text;
                    updateValPedido.Connection = _dbConnection;

                    int result = updateValPedido.ExecuteNonQuery();
                }

                _dbConnection.Close();
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
                        pedido.IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
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

                var command = new MySqlCommand("UPDATE PEDIDO SET ID_CLIENTE = @ID_CLIENTE, " +
                "DT_CARREGA = @DT_CARREGA, OBS = @OBS, TIPO_FRETE = @TIPO_FRETE, ID_TRANSPORT = @ID_TRANSPORT " +
                "WHERE ID_PEDIDO = @ID_PEDIDO");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = pedido.IdPedido;
                command.Parameters.Add("ID_CLIENTE", DbType.String).Value = pedido.IdCliente;
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
            _dbConnection.Open();

            var command = new MySqlCommand("INSERT INTO PEDIDO (ID_PEDIDO, NUM_PEDIDO, ID_CLIENTE, ID_USUARIO, DT_EMISSAO, DT_CARREGA, OBS, TIPO_FRETE, ID_TRANSPORT, VALOR_PEDIDO, VALOR_PAGAR) VALUES" +
            "(@ID_PEDIDO, @NUM_PEDIDO, @ID_CLIENTE, @ID_USUARIO, @DT_EMISSAO, @DT_CARREGA, @OBS, @TIPO_FRETE, @ID_TRANSPORT, 0, 0)");


            command.CommandType = CommandType.Text;
            command.Connection = _dbConnection;

            command.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = pedido.IdPedido;
            command.Parameters.Add("NUM_PEDIDO", DbType.Int32).Value = pedido.NumPedido;
            command.Parameters.Add("ID_CLIENTE", DbType.String).Value = pedido.IdCliente;
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

        public int GetNextNumPedido()
        {
            MySqlDataReader dr1;


            _dbConnection.Open();

            var command = new MySqlCommand("SELECT MAX(NUM_PEDIDO) + 1 AS NEXT_NUM_PEDIDO FROM PEDIDO");
            command.CommandType = CommandType.Text;
            command.Connection = _dbConnection;

            dr1 = command.ExecuteReader();
            dr1.Read();

            var nextNumPedido = Convert.ToInt32(dr1["NEXT_NUM_PEDIDO"] is DBNull ? 1 : dr1["NEXT_NUM_PEDIDO"]) ;

            _dbConnection.Close();


            return nextNumPedido;
        }

        public List<Pedido> GetPedidosByCriteria(DateTime? inicioEmissao, DateTime? fimEmissao, int? idCliente, DateTime? inicioCarrega, DateTime? fimCarrega)
        {
          
            _dbConnection.Open();

            var command = new MySqlCommand("SELECT * FROM PEDIDO " +
                "WHERE (@ID_CLIENTE IS NULL OR ID_CLIENTE = @ID_CLIENTE) " +
                "AND ((@INICIO_EMISSAO IS NULL AND @FIM_EMISSAO IS NULL) " +
                  "OR (@INICIO_EMISSAO IS NULL AND @FIM_EMISSAO > DT_EMISSAO) " +
                  "OR (@INICIO_EMISSAO < DT_EMISSAO AND @FIM_EMISSAO IS NULL) " +
                  "OR (DT_EMISSAO BETWEEN @INICIO_EMISSAO AND @FIM_EMISSAO)) " +
                "AND ((@INICIO_CARREGA IS NULL AND @FIM_CARREGA IS NULL) " +
                  "OR (@INICIO_CARREGA IS NULL AND @FIM_CARREGA > DT_CARREGA) " +
                  "OR (@INICIO_CARREGA < DT_CARREGA AND @FIM_CARREGA IS NULL) " +
                  "OR (DT_CARREGA BETWEEN @INICIO_CARREGA AND @FIM_CARREGA))");

            command.CommandType = CommandType.Text;
            command.Connection = _dbConnection;

            command.Parameters.Add("ID_CLIENTE", DbType.Int32).Value = idCliente;
            command.Parameters.Add("INICIO_EMISSAO", DbType.DateTime).Value = inicioEmissao;
            command.Parameters.Add("FIM_EMISSAO", DbType.DateTime).Value = fimEmissao;
            command.Parameters.Add("INICIO_CARREGA", DbType.DateTime).Value = inicioCarrega;
            command.Parameters.Add("FIM_CARREGA", DbType.DateTime).Value = fimCarrega;

            MySqlDataReader dr;

            dr = command.ExecuteReader();

            List<Pedido> pedidosByCriteria = new List<Pedido>();

            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    Pedido pedido = new Pedido();

                    pedido.IdPedido = Convert.ToInt32(dr["ID_PEDIDO"]);
                    pedido.NumPedido = Convert.ToInt32(dr["NUM_PEDIDO"]);
                    pedido.IdCliente = Convert.ToInt32(dr["ID_CLIENTE"]);
                    pedido.IdUsuario = Convert.ToInt32(dr["ID_USUARIO"]);
                    pedido.DtEmissao = Convert.ToDateTime(dr["DT_EMISSAO"]);
                    pedido.DtCarregamento = Convert.ToDateTime(dr["DT_CARREGA"]);
                    pedido.Obs = Convert.ToString(dr["OBS"]);
                    pedido.TipoFrete = (Enum.TipoFrete)System.Enum.Parse(typeof(Enum.TipoFrete), Convert.ToString(dr["TIPO_FRETE"]), true);
                    pedido.IdTransport = Convert.ToInt32(dr["ID_TRANSPORT"]);
                    pedido.ValorPedido = Convert.ToDecimal(dr["VALOR_PEDIDO"]);
                    pedido.ValorPagar = Convert.ToDecimal(dr["VALOR_PAGAR"]);
                    pedido.NFEmitida = Convert.ToBoolean(dr["NF_EMITIDA"]);

                    pedidosByCriteria.Add(pedido);
                }
            }

            _dbConnection.Close();

            return pedidosByCriteria;
        }
    }
}
