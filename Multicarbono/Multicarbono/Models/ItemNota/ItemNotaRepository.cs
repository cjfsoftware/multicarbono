using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Multicarbono.Models.ItemNota
{
    public class ItemNotaRepository
    {
        private readonly MySqlConnection _dbConnection;


        public ItemNotaRepository(MySqlConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<ItemNota> ListItemNota()
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM ITEM_NOTA");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                MySqlDataReader dr;
                List<ItemNota> listItemNota = new List<ItemNota>();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ItemNota itemNota = new ItemNota();

                        itemNota.IdItemNF = Convert.ToInt32(dr["ID_ITEM_NF"]);
                        itemNota.IdNF = Convert.ToInt32(dr["ID_NF"]);
                        itemNota.IdItemPedido = Convert.ToInt32(dr["ID_ITEM_PEDIDO"]);
                        itemNota.CodProduto = Convert.ToInt32(dr["COD_PRODUTO"]);
                        itemNota.QtdePesada = Convert.ToDecimal(dr["QTDE_PESADA"]);


                        listItemNota.Add(itemNota);
                    }
                }

                _dbConnection.Close();

                return listItemNota;
            }
        }

        public List<ItemNota> ItemNotaByPedido(int? idPedido)
        {
            _dbConnection.Open();

            var cmd = new MySqlCommand("SELECT * FROM ITEM_NOTA WHERE ID_ITEM_PEDIDO IN (SELECT ID_ITEM_PEDIDO FROM ITEM_PEDIDO WHERE ID_PEDIDO = @ID_PEDIDO)");

            cmd.CommandType = CommandType.Text;
            cmd.Connection = _dbConnection;

            cmd.Parameters.Add("ID_PEDIDO", DbType.Int32).Value = idPedido;

            int result = cmd.ExecuteNonQuery();

            MySqlDataReader dr;
            List<ItemNota> itemNotaByPedido = new List<ItemNota>();

            dr = cmd.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ItemNota itemNota = new ItemNota();

                    itemNota.IdItemNF = Convert.ToInt32(dr["ID_ITEM_NF"]);
                    itemNota.IdNF = Convert.ToInt32(dr["ID_NF"]);
                    itemNota.IdItemPedido = Convert.ToInt32(dr["ID_ITEM_PEDIDO"]);
                    itemNota.CodProduto = Convert.ToInt32(dr["COD_PRODUTO"]);
                    itemNota.QtdePesada = Convert.ToDecimal(dr["QTDE_PESADA"]);

                    itemNotaByPedido.Add(itemNota);
                }
            }

            _dbConnection.Close();

            return itemNotaByPedido;
        }

        public ItemNota ItemNotaById(int idItemNota)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM ITEM_NOTA WHERE ID_NOTA_NF = @ID_NOTA_NF");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                cmd.Parameters.Add("ID_NOTA_NF", DbType.Int32).Value = idItemNota;

                int result = cmd.ExecuteNonQuery();

                MySqlDataReader dr;
                ItemNota itemNotaById = new ItemNota();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ItemNota itemNota = new ItemNota();

                        itemNota.IdItemNF = Convert.ToInt32(dr["ID_ITEM_NF"]);
                        itemNota.IdNF= Convert.ToInt32(dr["ID_NF"]);
                        itemNota.IdItemPedido= Convert.ToInt32(dr["ID_ITEM_PEDIDO"]);
                        itemNota.CodProduto = Convert.ToInt32(dr["COD_PRODUTO"]);
                        itemNota.QtdePesada = Convert.ToDecimal(dr["QTDE_PESADA"]);

                        itemNotaById = itemNota;
                    }
                }

                _dbConnection.Close();

                return itemNotaById;
            }
        }

        public ItemNota ItemNotaByNF(int idNota)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();

                var cmd = new MySqlCommand("SELECT * FROM ITEM_NOTA WHERE ID_NF = @ID_NF");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = _dbConnection;

                cmd.Parameters.Add("ID_NF", DbType.Int32).Value = idNota;

                int result = cmd.ExecuteNonQuery();

                MySqlDataReader dr;
                ItemNota itemNotaByNF = new ItemNota();

                dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ItemNota itemNota = new ItemNota();

                        itemNota.IdItemNF = Convert.ToInt32(dr["ID_ITEM_NF"]);
                        itemNota.IdNF = Convert.ToInt32(dr["ID_NF"]);
                        itemNota.IdItemPedido = Convert.ToInt32(dr["ID_ITEM_PEDIDO"]);
                        itemNota.CodProduto = Convert.ToInt32(dr["COD_PRODUTO"]);
                        itemNota.QtdePesada = Convert.ToDecimal(dr["QTDE_PESADA"]);

                        itemNotaByNF = itemNota;
                    }
                }

                _dbConnection.Close();

                return itemNotaByNF;
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
                command.Parameters.Add("COD_PRODUTO", DbType.Int32).Value = itemNota.CodProduto;
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
                command.Parameters.Add("COD_PRODUTO", DbType.Int32).Value = itemNota.CodProduto;
                command.Parameters.Add("QTDE_PESADA", DbType.Decimal).Value = itemNota.QtdePesada;



                int result = command.ExecuteNonQuery();

                _dbConnection.Close();
            }
        }

        public void DeleteItemNota(int idItemNota)
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
