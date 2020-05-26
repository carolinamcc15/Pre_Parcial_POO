using System;
using System.Windows.Forms;

namespace Pre_Parcial_2
{
    public partial class NormalUser : Form
    {
        private Usuario user;
        public NormalUser(Usuario user)
        {
            this.user = user;
            InitializeComponent();
            
        }

        private void NormalUser_Load(object sender, EventArgs e)
        {
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
            Pedido order = new Pedido();
            order.NombreComprador = user.Nombre;
  
            try
            {
                PedidoDAO.InsertOrder(order);
                MessageBox.Show("Producto agregado a su pedido.");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error, revise los campos.", "Tienda San Ronaldo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDisplayPrice.Text = ((Inventario) cmbProduct.SelectedItem).Precio.ToString();
            double precio = ((Inventario) cmbProduct.SelectedItem).Precio;
            double aumento = (precio * 0.10);
            double tot = (precio + aumento) * Convert.ToDouble(nudCant.Value);    
            lblDisplayTotal.Text = Convert.ToString(tot);
        }

    }
}