using System;

namespace Pre_Parcial_2
{
    public class Inventario
    {
        public int IdProducto { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public double Precio { get; set; }
        public String Categoria { get; set; }
        public int Stock { get; set; }
        public String Imagen { get; set; }
        
        public Inventario(){}

        public Inventario(int idProducto, string nombre, string descripcion, double precio, string categoria, int stock, string imagen)
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Categoria = categoria;
            Stock = stock;
            Imagen = imagen;
        }
    }
}