﻿using MySqlConnector;
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
                        itemPedido.CodProduto = Convert.ToInt32(dr["COD_PRODUTO"]);


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
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("UPDATE ITEM_PEDIDO SET ID_PRODUTO = @ID_PRODUTO, CFOP = @CFOP, " +
                "QTDE = @QTDE, SUBTOTAL_ITEM_PEDIDO = @SUBTOTAL_ITEM_PEDIDO, COD_PRODUTO = (SELECT COD_PRODUTO FROM PRODUTO WHERE ID_PRODUTO = @ID_PRODUTO) WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO;COMMIT; UPDATE PEDIDO SET VALOR_PEDIDO = (SELECT SUM(SUBTOTAL_ITEM_PEDIDO) FROM " +
                "(SELECT * FROM ITEM_PEDIDO WHERE ID_PEDIDO IN (SELECT ID_PEDIDO FROM ITEM_PEDIDO WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO)) SUB ) " +
                " WHERE ID_PEDIDO IN (SELECT ID_PEDIDO FROM ITEM_PEDIDO WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO);COMMIT;" +
                "UPDATE PEDIDO SET VALOR_PAGAR = (SELECT SUM(SUBTOTAL_ITEM_PEDIDO) FROM " +
                "(SELECT * FROM ITEM_PEDIDO WHERE ID_PEDIDO IN (SELECT ID_PEDIDO FROM ITEM_PEDIDO WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO)) SUB ) " +
                " WHERE ID_PEDIDO IN (SELECT ID_PEDIDO FROM ITEM_PEDIDO WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO)");


                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_ITEM_PEDIDO", DbType.Int32).Value = itemPedido.IdItemPedido;
                command.Parameters.Add("ID_PRODUTO", DbType.Int32).Value = itemPedido.IdProduto;
                command.Parameters.Add("CFOP", DbType.Int32).Value = itemPedido.CFOP;
                command.Parameters.Add("QTDE", DbType.Decimal).Value = itemPedido.QTDE;
                command.Parameters.Add("SUBTOTAL_ITEM_PEDIDO", DbType.Decimal).Value = itemPedido.QTDE * valProduto;


                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void IncludeItemPedido(ItemPedido itemPedido, decimal valProduto)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("INSERT INTO ITEM_PEDIDO (ID_PEDIDO, ID_PRODUTO, CFOP, QTDE, SUBTOTAL_ITEM_PEDIDO, COD_PRODUTO VALUES" +
                "(@ID_PEDIDO, @ID_PRODUTO, @CFOP, @QTDE, @SUBTOTAL_ITEM_PEDIDO, (SELECT COD_PRODUTO FROM PRODUTO WHERE ID_PRODUTO = @ID_PRODUTO)); COMMIT; UPDATE PEDIDO SET VALOR_PEDIDO = (SELECT SUM(SUBTOTAL_ITEM_PEDIDO) FROM " +
                "(SELECT * FROM ITEM_PEDIDO WHERE ID_PEDIDO IN (SELECT ID_PEDIDO FROM ITEM_PEDIDO WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO)) SUB) WHERE ID_PEDIDO IN" +
                " (SELECT ID_PEDIDO FROM ITEM_PEDIDO WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO);COMMIT;" +
                "UPDATE PEDIDO SET VALOR_PAGAR = (SELECT SUM(SUBTOTAL_ITEM_PEDIDO) FROM " +
                "(SELECT * FROM ITEM_PEDIDO WHERE ID_PEDIDO IN (SELECT ID_PEDIDO FROM ITEM_PEDIDO WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO)) SUB ) " +
                " WHERE ID_PEDIDO IN (SELECT ID_PEDIDO FROM ITEM_PEDIDO WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO)");


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
            using (_dbConnection)
            {
                _dbConnection.Open();

                var command = new MySqlCommand("DELETE FROM ITEM_PEDIDO WHERE ID_ITEM_PEDIDO = @ID_ITEM_PEDIDO");

                command.CommandType = CommandType.Text;
                command.Connection = _dbConnection;

                command.Parameters.Add("ID_ITEM_PEDIDO", DbType.Int32).Value = idItemPedido;

                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }
    }
}
