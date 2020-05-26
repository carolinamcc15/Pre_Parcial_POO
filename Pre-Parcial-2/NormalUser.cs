using System;
using System.Globalization;
using System.Windows.Forms;

namespace Pre_Parcial_2
{
    public partial class NormalUser : Form
    {
        private Usuario user;
        private Pedido _order;
        public NormalUser(Usuario user)
        {
            this.user = user;
            InitializeComponent();
            
        }

        private void NormalUser_Load(object sender, EventArgs e)
        {
            _order = new Pedido();
            _order.NombreComprador = user.Nombre;
            dgvOrdersHistory.DataSource = PedidoDAO.ViewUserOrdersHistory(user);
            lblHistory.Text += user.Nombre; 
            cmbProduct.DataSource = null;
            cmbProduct.ValueMember = "IdProducto";
            cmbProduct.DisplayMember = "Nombre";
            cmbProduct.DataSource = InventarioDAO.GetInventory();
            
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            dgvOrdersHistory.DataSource = null;
            dgvOrdersHistory.DataSource = PedidoDAO.viewUserOrdersDetails((int) nudIdPedido.Value,user);
        }

        private void NormalUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dgvOrdersHistory.DataSource = null;
            dgvOrdersHistory.DataSource = PedidoDAO.ViewUserOrdersHistory(user);
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Inventario producto = new Inventario();
            Inventario currentProduct = ((Inventario) cmbProduct.SelectedItem);
            producto.Nombre = currentProduct.Nombre;
            producto.Categoria = currentProduct.Categoria;
            producto.IdProducto = currentProduct.IdProducto;
            producto.Descripcion = currentProduct.Descripcion;
            producto.Stock = (int) nudCant.Value;
            producto.Precio = currentProduct.Precio * 1.1;
            _order.Productos.Add(producto);
            String[] row = { producto.Nombre,producto.Stock.ToString(),producto.Precio.ToString("0.##"),(producto.Stock * producto.Precio).ToString("0.##")};
            dgvOrderList.Rows.Add(row);
        }
        
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDisplayPrice.Text = ((Inventario) cmbProduct.SelectedItem).Precio.ToString();
            double precio = ((Inventario) cmbProduct.SelectedItem).Precio;
            double aumento = (precio * 0.10);
            double tot = (precio + aumento) * Convert.ToDouble(nudCant.Value);    
            lblDisplayTotal.Text = Convert.ToString(tot);
        }

        private void nudCant_ValueChanged(object sender, EventArgs e)
        { 
            lblDisplayTotal.Text = "$" + Convert.ToString(((Inventario) cmbProduct.SelectedItem).Precio * (double) nudCant.Value, CultureInfo.InvariantCulture);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrderList.Rows.Count>=2)
            {
                try
                {
                    PedidoDAO.InsertOrder(_order);
                    PedidoDAO.InsertOrderDetails(_order);
                    dgvOrderList.Rows.Clear(); 
                    _order = new Pedido();
                    _order.NombreComprador = user.Nombre;
                    MessageBox.Show("El pedido se ha realizado con éxito.","Tienda San Ronaldo");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Tienda San Ronaldo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un producto.", "Tienda San Ronaldo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
            
        }
    }
}