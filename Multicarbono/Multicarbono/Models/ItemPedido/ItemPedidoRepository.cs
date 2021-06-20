using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.ItemPedido
{
    public class ItemPedidoRepository
    {
        private readonly MySqlConnection _dbConnection;


        public ItemPedidoRepository(MySqlConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<ItemPedido> ItemPedidoByPedido(int idPedido)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM ITEM_PEDIDO WHERE ID_PEDIDO = @ID_PEDIDO");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                MySqlDataReader dr;
                List<ItemPedido> listItemPedido = new List<ItemPedido>();

                cmd.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = idPedido;

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ItemPedido itemPedido = new ItemPedido();

                        itemPedido.IdItemPedido = Convert.ToInt32(dr["ID_ITEM_PEDIDO"]);
                        itemPedido.IdPedido = Convert.ToInt32(dr["ID_PEDIDO"]);
                        itemPedido.IdProduto = Convert.ToInt32(dr["ID_PRODUTO"]);
                        itemPedido.CFOP = Convert.ToInt32(dr["CFOP"]);
                        itemPedido.QTDE = Convert.ToInt32(dr["QTDE"]);
                        itemPedido.SubtotalItemPedido = Convert.ToInt32(dr["SUBTOTAL_ITEM_PEDIDO"]);


                        listItemPedido.Add(itemPedido);
                    }
                }

                _dbConnection.Close();

                return listItemPedido;
            }
        }

        public List<ItemPedido> ItemPedidoNFByPedido(int idPedido)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT ID_ITEM_PEDIDO, ID_PRODUTO, QTDE, SUBTOTAL_ITEM_PEDIDO FROM ITEM_PEDIDO WHERE ID_PEDIDO = @ID_PEDIDO");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                MySqlDataReader dr;
                List<ItemPedido> listItemPedidoNF = new List<ItemPedido>();

                cmd.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = idPedido;

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ItemPedido itemPedido = new ItemPedido();

                        itemPedido.IdItemPedido = Convert.ToInt32(dr["ID_ITEM_PEDIDO"]);
                        itemPedido.IdProduto = Convert.ToInt32(dr["ID_PRODUTO"]);
                        itemPedido.QTDE = Convert.ToInt32(dr["QTDE"]);
                        itemPedido.SubtotalItemPedido = Convert.ToInt32(dr["SUBTOTAL_ITEM_PEDIDO"]);

                        listItemPedidoNF.Add(itemPedido);
                    }
                }

                _dbConnection.Close();

                return listItemPedidoNF;
            }
        }


        public ItemPedido ItemPedidoById (int idItemPedido)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM ITEM_PEDIDO WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                cmd.Parameters.Add("ID_ITEM_PEDIDO", DbType.Int32).Value = idItemPedido;

                int result = cmd.ExecuteNonQuery();

                MySqlDataReader dr;
                ItemPedido itemPedidoById = new ItemPedido();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ItemPedido itemPedido = new ItemPedido();

                        itemPedido.IdItemPedido = Convert.ToInt32(dr["ID_ITEM_PEDIDO"]);
                        itemPedido.IdPedido = Convert.ToInt32(dr["ID_PEDIDO"]);
                        itemPedido.IdProduto = Convert.ToInt32(dr["ID_PRODUTO"]);
                        itemPedido.CFOP = Convert.ToInt32(dr["CFOP"]);
                        itemPedido.QTDE = Convert.ToInt32(dr["QTDE"]);
                        itemPedido.SubtotalItemPedido = Convert.ToInt32(dr["SUBTOTAL_ITEM_PEDIDO"]);

                        itemPedidoById = itemPedido;
                    }
                }

                _dbConnection.Close();

                return itemPedidoById;
            }
        }


        public void UpdateItemPedido(ItemPedido itemPedido, decimal valProduto)
        {
            _dbConnection.Open();

            var cmd1 = new MySqlCommand("SELECT SUBTOTAL_ITEM_PEDIDO FROM ITEM_PEDIDO WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO");
            cmd1.Parameters.Add("ID_ITEM_PEDIDO", DbType.Int32).Value = itemPedido.IdItemPedido;

            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = _dbConnection;

            MySqlDataReader dr;
            dr = cmd1.ExecuteReader();

            decimal oldSubTotal = 0;

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    oldSubTotal = Convert.ToDecimal(dr["SUBTOTAL_ITEM_PEDIDO"]);
                }
            }

            _dbConnection.Close();

            _dbConnection.Open();

            var command = new MySqlCommand("UPDATE ITEM_PEDIDO SET ID_PRODUTO = @ID_PRODUTO, CFOP = @CFOP, " +
            "QTDE = @QTDE, SUBTOTAL_ITEM_PEDIDO = @SUBTOTAL_ITEM_PEDIDO WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO; " +
            "UPDATE PEDIDO SET VALOR_PEDIDO = VALOR_PEDIDO - @SUBTOTAL_ANTIGO + @SUBTOTAL_ITEM_PEDIDO");


            command.CommandType = CommandType.Text;
            command.Connection = _dbConnection;

            command.Parameters.Add("ID_ITEM_PEDIDO", DbType.Int32).Value = itemPedido.IdItemPedido;
            command.Parameters.Add("ID_PRODUTO", DbType.Int32).Value = itemPedido.IdProduto;
            command.Parameters.Add("CFOP", DbType.Int32).Value = itemPedido.CFOP;
            command.Parameters.Add("QTDE", DbType.Decimal).Value = itemPedido.QTDE;
            command.Parameters.Add("SUBTOTAL_ITEM_PEDIDO", DbType.Decimal).Value = itemPedido.QTDE * valProduto;
            command.Parameters.Add("SUBTOTAL_ANTIGO", DbType.Decimal).Value = oldSubTotal;


            int result = command.ExecuteNonQuery();

            _dbConnection.Close();
        }

        public void IncludeItemPedido(ItemPedido itemPedido, decimal valProduto)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("INSERT INTO ITEM_PEDIDO (ID_PEDIDO, ID_PRODUTO, CFOP, QTDE, SUBTOTAL_ITEM_PEDIDO) VALUES" +
                "(@ID_PEDIDO, @ID_PRODUTO, @CFOP, @QTDE, @SUBTOTAL_ITEM_PEDIDO); " +
                "UPDATE PEDIDO SET VALOR_PEDIDO = VALOR_PEDIDO + @SUBTOTAL_ITEM_PEDIDO");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = itemPedido.IdPedido;
                command.Parameters.Add("ID_PRODUTO", DbType.Int32).Value = itemPedido.IdProduto;
                command.Parameters.Add("CFOP", DbType.Int32).Value = itemPedido.CFOP;
                command.Parameters.Add("QTDE", DbType.Decimal).Value = itemPedido.QTDE;
                command.Parameters.Add("SUBTOTAL_ITEM_PEDIDO", DbType.Decimal).Value = itemPedido.QTDE * valProduto;
                command.Parameters.Add("ID_ITEM_PEDIDO", DbType.Int32).Value = itemPedido.IdItemPedido;


                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void DeleteItemPedido(int idItemPedido)
        {
            _dbConnection.Open();

            var cmd1 = new MySqlCommand("SELECT SUBTOTAL_ITEM_PEDIDO FROM ITEM_PEDIDO WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO");
            cmd1.Parameters.Add("ID_ITEM_PEDIDO", DbType.Int32).Value = idItemPedido;

            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = _dbConnection;

            MySqlDataReader dr;
            dr = cmd1.ExecuteReader();

            decimal oldSubTotal = 0;

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    oldSubTotal = Convert.ToDecimal(dr["SUBTOTAL_ITEM_PEDIDO"]);
                }
            }

            _dbConnection.Close();

            _dbConnection.Open();

            var command = new MySqlCommand("DELETE FROM ITEM_PEDIDO WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO; " +
                "UPDATE PEDIDO SET VALOR_PEDIDO = VALOR_PEDIDO - @SUBTOTAL_ANTIGO;");

            command.CommandType = CommandType.Text;
            command.Connection = _dbConnection;

            command.Parameters.Add("ID_ITEM_PEDIDO", DbType.Int32).Value = idItemPedido;
            command.Parameters.Add("SUBTOTAL_ANTIGO", DbType.Decimal).Value = oldSubTotal;

            int result = command.ExecuteNonQuery();

            _dbConnection.Close();
        }
    }
}
