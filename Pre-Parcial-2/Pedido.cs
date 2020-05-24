using System;
using System.Collections.Generic;

namespace Pre_Parcial_2
{
    public class Pedido
    {
        public int NumPedido { get; set; }
        public DateTime FechaCompra { get; set; }
        public String NombreComprador { get; set; }
        public List<Inventario> Productos { get; set; }
        public double Total { get; set; }

        public Pedido(){}

        public Pedido(int numPedido, DateTime fechaCompra, string nombreComprador, List<Inventario> productos, double total)
        {
            NumPedido = numPedido;
            FechaCompra = fechaCompra;
            NombreComprador = nombreComprador;
            Productos = productos;
            Total = total;
        }
    }
}