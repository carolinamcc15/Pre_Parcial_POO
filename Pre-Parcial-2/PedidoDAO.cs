﻿using System;
using System.Collections.Generic;
using System.Data;

namespace Pre_Parcial_2
{
    public static class PedidoDAO
    {
        public static DataTable ViewOrdersHistory ()
        {
            var dataTable = DBConnection.ExecuteQuery("SELECT ped.numpedido, ped.nombre AS comprador, " +
                                                  "ped.fechacompra, " +
                                               $"CAST( ROUND(CAST(SUM(det.precioventa*det.cantproducto) AS numeric),2)" +
                                                  $" AS text) AS total " +
                                               $"FROM PEDIDO ped, INVENTARIO inv, DETALLE_PEDIDO det " +
                                               $"WHERE det.numpedido = ped.numpedido AND det.idproducto = " +
                                                  $"inv.idproducto " +
                                               $"GROUP BY ped.numpedido " +
                                                  $"ORDER BY ped.numpedido ASC;");
            foreach (DataRow row in dataTable.Rows)
            {
                row[3] = "$" + row[3];
            }
            return dataTable;
        }
        
        
        public static DataTable ViewUserOrdersHistory (Usuario user)
        {
            var dataTable = DBConnection.ExecuteQuery("SELECT ped.numpedido, ped.fechacompra, " +
                                                  $"CAST( ROUND(CAST(SUM(det.precioventa*det.cantproducto) AS numeric)," +
                                                  $"2) AS text) AS total " +
                                                  $"FROM PEDIDO ped, INVENTARIO inv, DETALLE_PEDIDO det " +
                                                  $"WHERE det.numpedido = ped.numpedido AND det.idproducto = " +
                                                  $"inv.idproducto " +
                                                  $"and ped.nombre = '{user.Nombre}'" +
                                                  $"GROUP BY ped.numpedido;");
            foreach (DataRow row in dataTable.Rows)
            {
                row[2] = "$" + row[2];
            }
            return dataTable;
        }

        public static DataTable viewUserOrdersDetails(int orderID, Usuario user)
        {
            var dataTable = DBConnection.ExecuteQuery($"SELECT inv.nombre AS producto, det.cantproducto AS " +
                                                      $"cantidadproducto, " +
                                                      $"CAST(ROUND(CAST(det.precioventa AS numeric),2) AS text) AS " +
                                                      $"precioUnitario , " +
                                                      $"CAST(ROUND(CAST((det.precioventa * det.cantproducto) AS " +
                                                      $"numeric),2) AS text) AS precio " +
                                                      $"FROM detalle_pedido det, inventario inv, pedido ped, " +
                                                      $"usuario us " +
                                                      $"WHERE inv.idproducto = det.idproducto AND ped.numpedido = " +
                                                      $"det.numpedido " +
                                                      $"AND det.numpedido = {orderID} AND us.nombre = ped.nombre AND " +
                                                      $"us.nombre = '{user.Nombre}';");
            foreach (DataRow row in dataTable.Rows)
            {
                row[2] = "$" + row[2];
                row[3] = "$" + row[3];
            }
            return dataTable;
        }
        public static DataTable ViewOrdersDetails(int orderID)
        {
            var dataTable = DBConnection.ExecuteQuery($"SELECT inv.nombre AS producto, det.cantproducto AS " +
                                                      $"cantidadproducto, " +
                                                      $"CAST(ROUND(CAST(det.precioventa AS numeric),2) AS text) AS " +
                                                      $"precioUnitario , " +
                                                      $"CAST(ROUND(CAST((det.precioventa * det.cantproducto) AS " +
                                                      $"numeric),2) AS text) AS precio " +
                                                      $"FROM detalle_pedido det, inventario inv, pedido ped " +
                                                      $"WHERE inv.idproducto = det.idproducto AND ped.numpedido = " +
                                                      $"det.numpedido " +
                                                      $"AND det.numpedido = {orderID};");
            foreach (DataRow row in dataTable.Rows)
            {
                row[2] = "$" + row[2];
                row[3] = "$" + row[3];
            }
            return dataTable;
        }
        
        public static void InsertOrder(Pedido pedido)
        {
            string querySQL = $"INSERT INTO PEDIDO(nombre)" +
                              $" VALUES ('{pedido.NombreComprador}');";
            DBConnection.ExecuteNonQuery(querySQL);
        }
        
        public static void InsertOrderDetails(Pedido pedido)
        {
            
            int numpedido;
            numpedido = Convert.ToInt32(DBConnection.ExecuteQuery("select numpedido from pedido ORDER BY numpedido DESC").Rows[0][0].ToString());
            string querySQL = $"INSERT INTO DETALLE_PEDIDO(numpedido,idproducto,cantproducto,precioventa) VALUES ";
            foreach (Inventario producto in pedido.Productos)
            {
                DBConnection.ExecuteNonQuery($"UPDATE INVENTARIO SET stock = stock - {producto.Stock} WHERE idproducto = {producto.IdProducto};");
                querySQL += $"({numpedido},{producto.IdProducto},{producto.Stock}, ROUND(CAST({producto.Precio} AS NUMERIC),2)),";
            }
            querySQL = querySQL.Remove(querySQL.Length-1);
            querySQL += ";";
            DBConnection.ExecuteNonQuery(querySQL);
        }
  
    }
}