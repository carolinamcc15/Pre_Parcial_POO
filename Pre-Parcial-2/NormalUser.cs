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
            String[] categories = 
            {
                "Bebidas",
                "Boquitas",
                "Despensa",
                "Frutas y verduras",
                "Lácteos",
                "Desechables"
            };
            cmbCategories.DataSource = categories;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            dgvOrdersHistory.DataSource = null;
            dgvOrdersHistory.DataSource = PedidoDAO.viewUserOrdersDetails((int) nudIdPedido.Value,user);
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Productos por categorías
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
    }
}