using System;
using System.Collections.Generic;
using System.Data;

namespace Pre_Parcial_2
{
    public static class InventarioDAO
    {
        public static void InsertProduct(Inventario inventario)
        {
            String querySQL = $"INSERT INTO INVENTARIO (nombre, descripcion, precio, categoria, stock, imagen) " +
                              $" VALUES ('{inventario.Nombre}'," +
                              $"'{inventario.Descripcion}'," +
                              $"{inventario.Precio}, " +
                              $"'{inventario.Categoria}', " +
                              $"{inventario.Stock}, " +
                              $"'{inventario.Imagen}');";
            DBConnection.ExecuteNonQuery(querySQL);
        }
        
        public static List<Inventario> getInventory()
        {
            String querySQL = "SELECT * FROM INVENTARIO;";
            DataTable dataT = DBConnection.ExecuteQuery(querySQL);
            var listaProductos = new List<Inventario>();
            foreach (DataRow fila in dataT.Rows)
            {
                Inventario inventarioAux = new Inventario();
                inventarioAux.Nombre = fila[1].ToString();
                inventarioAux.Descripcion = fila[2].ToString();
                inventarioAux.Precio = Convert.ToDouble(fila[3].ToString());
                inventarioAux.Categoria = fila[4].ToString();
                inventarioAux.Stock = Convert.ToInt32(fila[5].ToString());
                inventarioAux.Imagen = fila[6].ToString();
                listaProductos.Add(inventarioAux);
            }
            return listaProductos;
        }
        
        public static void ModifyInventory(Inventario inv, int pk)
        {
            String querySQL = $"UPDATE INVENTARIO SET stock = " +
                              $"{inv.Stock});" +
                              $" WHERE idProducto = '{pk}';";
            DBConnection.ExecuteNonQuery(querySQL);
        }

        public static void DeleteProduct(Inventario inv, int pk)
        {
            String querySQL = $"DELETE FROM INVENTARIO WHERE idProducto = '{pk}';";
            DBConnection.ExecuteNonQuery(querySQL);
        }
    }
}