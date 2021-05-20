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

        public List<ItemPedido> ItemPedidoByNota(int idPedido)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM ITEM_PEDIDO WHERE ID_PEDIDO = @ID_PEDIDO");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                MySqlDataReader dr;
                List<ItemPedido> listItemPedido = new List<ItemPedido>();

                cmd.Parameters.Add("ID_ITEM_PEDIDO", DbType.Int32).Value = idPedido;

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

                        listItemPedido.Add(itemPedido);
                    }
                }

                _dbConnection.Close();

                return listItemPedido;
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

                        itemPedidoById = itemPedido;
                    }
                }

                _dbConnection.Close();

                return itemPedidoById;
            }
        }


        public void UpdateItemPedido(ItemPedido itemPedido)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("UPDATE ITEM_PEDIDO SET ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO, ID_PEDIDO = @ID_PEDIDO, ID_PRODUTO = @ID_PRODUTO, CFOP = @CFOP, " +
                "QTDE = @QTDE");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_ITEM_PEDIDO", DbType.Int32).Value = itemPedido.IdItemPedido;
                command.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = itemPedido.IdPedido;
                command.Parameters.Add("ID_PRODUTO", DbType.Int32).Value = itemPedido.IdProduto;
                command.Parameters.Add("CFOP", DbType.Int32).Value = itemPedido.CFOP;
                command.Parameters.Add("QTDE", DbType.Decimal).Value = itemPedido.QTDE;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void IncludeItemNota(ItemPedido itemPedido)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("INSERT INTO ITEM_PEDIDO (ID_ITEM_PEDIDO, ID_PEDIDO, ID_PRODUTO, CFOP, QTDE) VALUES" +
                "(@ID_ITEM_PEDIDO, @ID_PEDIDO, @ID_PRODUTO, @CFOP, @QTDE)");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_ITEM_PEDIDO", DbType.Int32).Value = itemPedido.IdItemPedido;
                command.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = itemPedido.IdPedido;
                command.Parameters.Add("ID_PRODUTO", DbType.Int32).Value = itemPedido.IdProduto;
                command.Parameters.Add("CFOP", DbType.Int32).Value = itemPedido.CFOP;
                command.Parameters.Add("QTDE", DbType.Decimal).Value = itemPedido.QTDE;


                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void DeleteCliente(int idItemPedido)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("DELETE FROM ITEM_NOTA WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO");

                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_ITEM_PEDIDO", DbType.Int32).Value = idItemPedido;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }
    }
}
