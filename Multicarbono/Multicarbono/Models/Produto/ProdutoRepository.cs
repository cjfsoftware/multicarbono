using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace Multicarbono.Models.Produto
{
    public class ProdutoRepository
    {
        private readonly MySqlConnection _dbConnection;


        public ProdutoRepository(MySqlConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<Produto> ListProduto()
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM PRODUTO");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                MySqlDataReader dr;
                List<Produto> listProduto = new List<Produto>();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Produto produto = new Produto();

                        produto.IdProduto = Convert.ToInt32(dr["ID_PRODUTO"]);
                        produto.CodProduto = Convert.ToInt32(dr["COD_PRODUTO"]);
                        produto.Descricao = Convert.ToString(dr["DESCRICAO"]);
                        produto.Ativo = Convert.ToBoolean(dr["ATIVO"]);
                        produto.NCM_SH = Convert.ToInt32(dr["NCM_SH"]);
                        produto.CST = Convert.ToInt32(dr["CST"]);
                        produto.Unidade = (Enum.TipoUnidadeProduto)System.Enum.Parse(typeof(Enum.TipoUnidadeProduto), Convert.ToString(dr["UNIDADE"]), true);
                        produto.VrUnitario = Convert.ToDecimal(dr["VR_UNITARIO"]);
                        produto.Ali_ICMS = Convert.ToDecimal(dr["ALI_ICMS"]);
                        produto.Ali_IPI = Convert.ToDecimal(dr["ALI_IPI"]);                   

                        listProduto.Add(produto);
                    }
                }

                _dbConnection.Close();

                return listProduto;
            }
        }

        public Produto ProdutoById(int idProduto)
        {
            
            _dbConnection.Open();

            var cmd = new MySqlCommand("SELECT * FROM PRODUTO WHERE ID_PRODUTO = @ID_PRODUTO");

            cmd.CommandType = CommandType.Text;
            cmd.Connection = _dbConnection;

            cmd.Parameters.Add("ID_PRODUTO", DbType.Int32).Value = idProduto;

            int result = cmd.ExecuteNonQuery();

            MySqlDataReader dr;
            Produto produtoById = new Produto();

            dr = cmd.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Produto produto = new Produto();

                    produto.IdProduto = Convert.ToInt32(dr["ID_PRODUTO"]);
                    produto.CodProduto = Convert.ToInt32(dr["COD_PRODUTO"]);
                    produto.Descricao = Convert.ToString(dr["DESCRICAO"]);
                    produto.Ativo = Convert.ToBoolean(dr["ATIVO"]);
                    produto.NCM_SH = Convert.ToInt32(dr["NCM_SH"]);
                    produto.CST = Convert.ToInt32(dr["CST"]);
                    produto.Unidade = (Enum.TipoUnidadeProduto)System.Enum.Parse(typeof(Enum.TipoUnidadeProduto), Convert.ToString(dr["UNIDADE"]), true);
                    produto.VrUnitario = Convert.ToDecimal(dr["VR_UNITARIO"]);
                    produto.Ali_ICMS = Convert.ToDecimal(dr["ALI_ICMS"]);
                    produto.Ali_IPI = Convert.ToDecimal(dr["ALI_IPI"]);
                        
                    produtoById = produto;
                }
            }

            _dbConnection.Close();

            return produtoById;
        }


        public void UpdateProduto(Produto produto)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("UPDATE PRODUTO SET COD_PRODUTO = @COD_PRODUTO, DESCRICAO = @DESCRICAO, ATIVO = @ATIVO, NCM_SH = @NCM_SH, CST = @CST, UNIDADE = @UNIDADE," +
                    "VR_UNITARIO = @VR_UNITARIO, ALI_ICMS = @ALI_ICMS, ALI_IPI = @ALI_IPI WHERE ID_PRODUTO = @ID_PRODUTO");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_PRODUTO", DbType.Int32).Value = produto.IdProduto;
                command.Parameters.Add("COD_PRODUTO", DbType.Int32).Value = produto.CodProduto;
                command.Parameters.Add("DESCRICAO", DbType.String).Value = produto.Descricao;
                command.Parameters.Add("ATIVO", DbType.Boolean).Value = produto.Ativo;
                command.Parameters.Add("NCM_SH", DbType.Int32).Value = produto.NCM_SH;
                command.Parameters.Add("CST", DbType.Int32).Value = produto.CST;
                command.Parameters.Add("UNIDADE", DbType.String).Value = produto.Unidade;
                command.Parameters.Add("VR_UNITARIO", DbType.Decimal).Value = produto.VrUnitario;
                command.Parameters.Add("ALI_ICMS", DbType.Decimal).Value = produto.Ali_ICMS;
                command.Parameters.Add("ALI_IPI", DbType.Decimal).Value = produto.Ali_IPI;


                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void IncludeProduto(Produto produto)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("INSERT INTO PRODUTO (COD_PRODUTO, DESCRICAO, ATIVO, NCM_SH, CST, UNIDADE, VR_UNITARIO, ALI_ICMS, ALI_IPI) VALUES" +
                "(@COD_PRODUTO, @DESCRICAO, @ATIVO, @NCM_SH, @CST, @UNIDADE, @VR_UNITARIO, @ALI_ICMS, @ALI_IPI)");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;


                command.Parameters.Add("COD_PRODUTO", DbType.Int32).Value = produto.CodProduto;
                command.Parameters.Add("DESCRICAO", DbType.String).Value = produto.Descricao;
                command.Parameters.Add("ATIVO", DbType.String).Value = produto.Ativo;
                command.Parameters.Add("NCM_SH", DbType.Int32).Value = produto.NCM_SH;
                command.Parameters.Add("CST", DbType.Int32).Value = produto.CST;
                command.Parameters.Add("UNIDADE", DbType.String).Value = produto.Unidade;
                command.Parameters.Add("VR_UNITARIO", DbType.Decimal).Value = produto.VrUnitario;
                command.Parameters.Add("ALI_ICMS", DbType.Decimal).Value = produto.Ali_ICMS;
                command.Parameters.Add("ALI_IPI", DbType.Decimal).Value = produto.Ali_IPI;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void DeleteProduto(int idProduto)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("DELETE FROM PRODUTO WHERE ID_PRODUTO = @ID_PRODUTO");

                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_PRODUTO", DbType.Int32).Value = idProduto;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

    }
}
