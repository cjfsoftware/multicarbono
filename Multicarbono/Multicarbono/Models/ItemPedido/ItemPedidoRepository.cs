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

                        itemPedido.ID_ITEM_PEDIDO = Convert.ToInt32(dr["ID_ITEM_PEDIDO"]);
                        itemPedido.ID_PEDIDO = Convert.ToInt32(dr["ID_PEDIDO"]);
                        itemPedido.ID_PRODUTO = Convert.ToInt32(dr["ID_PRODUTO"]);
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

                        itemPedido.ID_ITEM_PEDIDO = Convert.ToInt32(dr["ID_ITEM_PEDIDO"]);
                        itemPedido.ID_PEDIDO = Convert.ToInt32(dr["ID_PEDIDO"]);
                        itemPedido.ID_PRODUTO = Convert.ToInt32(dr["ID_PRODUTO"]);
                        itemPedido.CFOP = Convert.ToInt32(dr["CFOP"]);
                        itemPedido.QTDE = Convert.ToInt32(dr["QTDE"]);

                        itemPedidoById = itemPedido;
                    }
                }

                _dbConnection.Close();

                return itemPedidoById;
            }
        }


        public void UpdateItemNota(ItemNota itemNota)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("UPDATE ITEM_NOTA SET ID_ITEM_NF = @ID_ITEM_NF, ID_NF = @ID_NF, ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO, COD_PRODUTO = @COD_PRODUTO, " +
                "QTDE_PESADA = @QTDE_PESADA");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_ITEM_NF", DbType.Int32).Value = itemNota.IdItemNF;
                command.Parameters.Add("ID_NF", DbType.Int32).Value = itemNota.IdNF;
                command.Parameters.Add("ID_ITEM_PEDIDO", DbType.Int32).Value = itemNota.IdItemPedido;
                command.Parameters.Add("CODIGO_PRODUTO", DbType.Int32).Value = itemNota.CodProduto;
                command.Parameters.Add("QTDE_PESADA", DbType.Decimal).Value = itemNota.QtdePesada;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void IncludeItemNota(ItemNota itemNota)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("INSERT INTO ITEM_NOTA (ID_ITEM_NF, ID_NF, ID_ITEM_PEDIDO, COD_PRODUTO, QTDE_PESADA) VALUES" +
                "(@ID_ITEM_NF, @ID_NF, @ID_ITEM_PEDIDO, @COD_PRODUTO, @QTDE_PESADA)");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_ITEM_NF", DbType.Int32).Value = itemNota.IdItemNF;
                command.Parameters.Add("ID_NF", DbType.Int32).Value = itemNota.IdNF;
                command.Parameters.Add("ID_ITEM_PEDIDO", DbType.Int32).Value = itemNota.IdItemPedido;
                command.Parameters.Add("CODIGO_PRODUTO", DbType.Int32).Value = itemNota.CodProduto;
                command.Parameters.Add("QTDE_PESADA", DbType.Decimal).Value = itemNota.QtdePesada;



                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void DeleteCliente(int idItemNota)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("DELETE FROM ITEM_NOTA WHERE ID_ITEM_NF = @ID_ITEM_NF");

                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_ITEM_NF", DbType.Int32).Value = idItemNota;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }
    }
}
