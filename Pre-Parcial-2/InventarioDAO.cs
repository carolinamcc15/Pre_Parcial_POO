using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using LiveCharts;
using LiveCharts.Wpf;

namespace Pre_Parcial_2
{
    public static class InventarioDAO
    {
        public static void InsertProduct(Inventario inventario)
        {
            String querySql = $"INSERT INTO INVENTARIO (nombre, descripcion, precio, categoria, stock) " +
                              $" VALUES ('{inventario.Nombre}'," +
                              $"'{inventario.Descripcion}'," +
                              $"{inventario.Precio:0.##}, " +
                              $"'{inventario.Categoria}', " +
                              $"{inventario.Stock});"; 
                            
            DBConnection.ExecuteNonQuery(querySql);
        }
        
        public static List<Inventario> GetInventory()
        {
            String querySQL = "SELECT * FROM INVENTARIO;";
            DataTable dataT = DBConnection.ExecuteQuery(querySQL);
            var listaProductos = new List<Inventario>();
            foreach (DataRow fila in dataT.Rows)
            {
                Inventario inventarioAux = new Inventario();
                inventarioAux.IdProducto = Convert.ToInt32(fila[0].ToString());
                inventarioAux.Nombre = fila[1].ToString();
                inventarioAux.Descripcion = fila[2].ToString();
                inventarioAux.Precio = Convert.ToDouble(fila[3].ToString());
                inventarioAux.Categoria = fila[4].ToString();
                inventarioAux.Stock = Convert.ToInt32(fila[5].ToString());
                listaProductos.Add(inventarioAux);
            }
            return listaProductos;
        }
        
        public static void ModifyInventory(Inventario inv, int stock)
        {
            String querySql = $"UPDATE INVENTARIO SET stock = " +
                              $"{stock}" +
                              $" WHERE idproducto = {inv.IdProducto};";
            DBConnection.ExecuteNonQuery(querySql);
        }

        public static void DeleteProduct(Inventario inv)
        {
            String querySql = $"DELETE FROM INVENTARIO WHERE idproducto = {inv.IdProducto};";
            DBConnection.ExecuteNonQuery(querySql);
        }

        public static DataTable getSumByCategory()
        {
            String querySql = "select categoria, sum(stock) from inventario group by categoria;";
            DataTable dataTable = DBConnection.ExecuteQuery(querySql);
            return dataTable;
        }

        public static DataTable getTopFiveStocks()
        {
            String sqlQuery = "SELECT nombre, stock FROM INVENTARIO ORDER BY stock DESC"+ 
            " FETCH FIRST 5 ROWS ONLY;";
            DataTable dataTable = DBConnection.ExecuteQuery(sqlQuery);
            return dataTable;
        }
    }
}