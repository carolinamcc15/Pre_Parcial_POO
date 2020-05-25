using System;
using System.Collections.Generic;
using System.Data;

namespace Pre_Parcial_2
{
    public static class PedidoDAO
    {
        public static DataTable ViewOrdersHistory ()
        {
            var dataT = DBConnection.ExecuteQuery("SELECT ped.numpedido, ped.nombre AS comprador, " +
                                                  "ped.fechacompra, " +
                                               $"SUM(det.precioventa* det.cantproducto) AS total " +
                                               $"FROM PEDIDO ped, INVENTARIO inv, DETALLE_PEDIDO det " +
                                               $"WHERE det.numpedido = ped.numpedido AND det.idproducto = " +
                                                  $"inv.idproducto " +
                                               $"GROUP BY ped.numpedido;");
            return dataT;
        }
        
        
        public static DataTable ViewUserOrders ()
        {
            var dataT = DBConnection.ExecuteQuery("SELECT ped.numpedido, ped.nombre AS comprador, " +
                                                  "ped.fechacompra, " +
                                                  $"SUM(det.precioventa* det.cantproducto) AS total " +
                                                  $"FROM PEDIDO ped, INVENTARIO inv, DETALLE_PEDIDO det " +
                                                  $"WHERE det.numpedido = ped.numpedido AND det.idproducto = " +
                                                  $"inv.idproducto " +
                                                  "and ped.nombre = 'Carolina Carranza'" +
                                                  $"GROUP BY ped.numpedido;");
            return dataT;
        }       
        
    }
}