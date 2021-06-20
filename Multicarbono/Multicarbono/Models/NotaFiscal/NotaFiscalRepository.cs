using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.NotaFiscal
{
    public class NotaFiscalRepository
    {
        private readonly MySqlConnection _dbConnection;


        public NotaFiscalRepository(MySqlConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<NotaFiscal> ListNotaFiscal()
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM NOTA_FISCAL");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                MySqlDataReader dr;
                List<NotaFiscal> listNota = new List<NotaFiscal>();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        NotaFiscal notaFiscal = new NotaFiscal();

                        notaFiscal.IdNF = Convert.ToInt32(dr["ID_NF"]);
                        notaFiscal.IdPedido = Convert.ToInt32(dr["ID_PEDIDO"]);
                        notaFiscal.NumNF = Convert.ToInt32(dr["NUM_NF"]);
                        notaFiscal.Chave = Convert.ToInt32(dr["CHAVE"]);
                        notaFiscal.NaturezaOper = Convert.ToString(dr["NATUREZA_OPER"]);
                        notaFiscal.DtEmissao = Convert.ToDateTime(dr["DT_EMISSAO"]);
                        notaFiscal.DtSaida = Convert.ToDateTime(dr["DT_SAIDA"]);
                        notaFiscal.VrFrete = Convert.ToDecimal(dr["VR_FRETE"]);
                        notaFiscal.QtdeEmbalagens = Convert.ToInt32(dr["QTDE_EMBALAGENS"]);
                        notaFiscal.CNPJEmitente = Convert.ToString(dr["CNPJ_EMITENTE"]);


                        listNota.Add(notaFiscal);
                    }
                }

                _dbConnection.Close();

                return listNota;
            }
        }

        public NotaFiscal NotaById(int idNota)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM NOTA_FISCAL WHERE ID_NF = @ID_NF");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                cmd.Parameters.Add("ID_NF", DbType.Int32).Value = idNota;

                int result = cmd.ExecuteNonQuery();

                MySqlDataReader dr;
                NotaFiscal notaById = new NotaFiscal();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        NotaFiscal notaFiscal = new NotaFiscal();

                        notaFiscal.IdNF = Convert.ToInt32(dr["ID_NF"]);
                        notaFiscal.IdPedido = Convert.ToInt32(dr["ID_PEDIDO"]);
                        notaFiscal.NumNF = Convert.ToInt32(dr["NUM_NF"]);
                        notaFiscal.Chave = Convert.ToInt32(dr["CHAVE"]);
                        notaFiscal.NaturezaOper = Convert.ToString(dr["NATUREZA_OPER"]);
                        notaFiscal.DtEmissao = Convert.ToDateTime(dr["DT_EMISSAO"]);
                        notaFiscal.DtSaida = Convert.ToDateTime(dr["DT_SAIDA"]);
                        notaFiscal.VrFrete = Convert.ToDecimal(dr["VR_FRETE"]);
                        notaFiscal.QtdeEmbalagens = Convert.ToInt32(dr["QTDE_EMBALAGENS"]);
                        notaFiscal.CNPJEmitente = Convert.ToString(dr["CNPJ_EMITENTE"]);


                       notaById = notaFiscal;
                    }
                }

                _dbConnection.Close();

                return notaById;
            }
        }

        public NotaFiscal NotaByFiltro(int idCliente, DateTime dataInit, DateTime dataFim)
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
                NotaFiscal notaById = new NotaFiscal();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        NotaFiscal notaFiscal = new NotaFiscal();

                        notaFiscal.IdNF = Convert.ToInt32(dr["ID_NF"]);
                        notaFiscal.IdPedido = Convert.ToInt32(dr["ID_PEDIDO"]);
                        notaFiscal.NumNF = Convert.ToInt32(dr["NUM_NF"]);
                        notaFiscal.Chave = Convert.ToInt32(dr["CHAVE"]);
                        notaFiscal.NaturezaOper = Convert.ToString(dr["NATUREZA_OPER"]);
                        notaFiscal.DtEmissao = Convert.ToDateTime(dr["DT_EMISSAO"]);
                        notaFiscal.DtSaida = Convert.ToDateTime(dr["DT_SAIDA"]);
                        notaFiscal.VrFrete = Convert.ToDecimal(dr["VR_FRETE"]);
                        notaFiscal.QtdeEmbalagens = Convert.ToInt32(dr["QTDE_EMBALAGENS"]);
                        notaFiscal.CNPJEmitente = Convert.ToString(dr["CNPJ_EMITENTE"]);


                        notaById = notaFiscal;
                    }
                }

                _dbConnection.Close();

                return notaById;
            }
        }

        public void UpdateNota(NotaFiscal notaFiscal)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("UPDATE NOTA_FISCAL SET ID_PEDIDO = @ID_PEDIDO, NUM_NF = @NUM_NF, CHAVE = @CHAVE, " +
                "NATUREZA_OPER = @NATUREZA_OPER, DT_EMISSAO = @DT_EMISSAO, DT_SAIDA = @DT_SAIDA, VR_FRETE = @VR_FRETE, QTDE_EMBALAGENS = @QTDE_EMBALAGENS," +
                " CNPJ_EMITENTE = @CNPJ_EMITENTE, VALOR_NOTA = (SELECT VALOR_PAGAR FROM PEDIDO WHERE ID_PEDIDO = @ID_PEDIDO)");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = notaFiscal.IdPedido;
                command.Parameters.Add("NUM_NF", DbType.Int32).Value = notaFiscal.NumNF;
                command.Parameters.Add("CHAVE", DbType.Int32).Value = notaFiscal.Chave;
                command.Parameters.Add("NATUREZA_OPER", DbType.String).Value = notaFiscal.NaturezaOper;
                command.Parameters.Add("DT_EMISSAO", DbType.DateTime).Value = notaFiscal.DtEmissao;
                command.Parameters.Add("DT_SAIDA", DbType.DateTime).Value = notaFiscal.DtSaida;
                command.Parameters.Add("VR_FRETE", DbType.Decimal).Value = notaFiscal.VrFrete;
                command.Parameters.Add("QTDE_EMBALAGENS", DbType.Int32).Value = notaFiscal.QtdeEmbalagens;
                command.Parameters.Add("CNPJ_EMITENTE", DbType.DateTime).Value = notaFiscal.CNPJEmitente;


                try
                {
                    int result = command.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    throw;
                }
                _dbConnection.Close();
            }
        }

        public void IncludeNota(NotaFiscal notaFiscal)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("INSERT INTO NOTA_FISCAL (ID_PEDIDO, NUM_NF, CHAVE, NATUREZA_OPER, DT_EMISSAO, DT_SAIDA, VR_FRETE, QTDE_EMBALAGENS, CNPJ_EMITENTE, VALOR_NOTA) VALUES" +
                "(@ID_PEDIDO, @NUM_NF, @CHAVE, @NATUREZA_OPER, @DT_EMISSAO, @DT_SAIDA, @VR_FRETE, @QTDE_EMBALAGENS, @CNPJ_EMITENTE, (SELECT VALOR_PAGAR FROM PEDIDO WHERE ID_PEDIDO = @ID_PEDIDO)); " +
                "UPDATE PEDIDO SET NF_EMITIDA = TRUE WHERE ID_PEDIDO = @ID_PEDIDO;");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_NF", DbType.Int32).Value = notaFiscal.IdNF;
                command.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = notaFiscal.IdPedido;
                command.Parameters.Add("NUM_NF", DbType.Int32).Value = notaFiscal.NumNF;
                command.Parameters.Add("CHAVE", DbType.Int32).Value = notaFiscal.Chave;
                command.Parameters.Add("NATUREZA_OPER", DbType.String).Value = notaFiscal.NaturezaOper;
                command.Parameters.Add("DT_EMISSAO", DbType.DateTime).Value = notaFiscal.DtEmissao;
                command.Parameters.Add("DT_SAIDA", DbType.DateTime).Value = notaFiscal.DtSaida;
                command.Parameters.Add("VR_FRETE", DbType.String).Value = notaFiscal.VrFrete;
                command.Parameters.Add("QTDE_EMBALAGENS", DbType.Int32).Value = notaFiscal.QtdeEmbalagens;
                command.Parameters.Add("CNPJ_EMITENTE", DbType.DateTime).Value = notaFiscal.CNPJEmitente;



                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void DeleteNota(int idNotaFiscal)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("DELETE FROM NOTA_FISCAL WHERE ID_NF = @ID_NF");

                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_NF", DbType.Int32).Value = idNotaFiscal;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public int GetNextNumNota()
        {
            MySqlDataReader dr1;


            _dbConnection.Open();

            var command = new MySqlCommand("SELECT MAX(NUM_NF) + 1 AS NEXT_NUM_NF FROM NOTA_FISCAL");
            command.CommandType = CommandType.Text;
            command.Connection = _dbConnection;

            dr1 = command.ExecuteReader();
            dr1.Read();

            var nextNumNF = Convert.ToInt32(dr1["NEXT_NUM_NF"] is DBNull ? 1 : dr1["NEXT_NUM_NF"]);

            _dbConnection.Close();


            return nextNumNF;
        }
    }
}
