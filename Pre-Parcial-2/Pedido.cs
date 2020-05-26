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

        public Pedido()
        {
            Productos = new List<Inventario>();
        }

        public Pedido(int numPedido, DateTime fechaCompra, string nombreComprador, double total)
        {
            NumPedido = numPedido;
            FechaCompra = fechaCompra;
            NombreComprador = nombreComprador;
            Productos = new List<Inventario>();
            Total = total;
        }
    }
}