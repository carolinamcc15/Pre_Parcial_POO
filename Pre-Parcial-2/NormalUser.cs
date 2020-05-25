using System;
using System.Windows.Forms;

namespace Pre_Parcial_2
{
    public partial class NormalUser : Form
    {
        public NormalUser()
        {
            InitializeComponent();
            
        }

        private void NormalUser_Load(object sender, EventArgs e)
        {
            dgvOrdersHistory.DataSource = PedidoDAO.ViewOrdersHistory();
            String[] categories;
                        categories = new string[6];
                        categories[0] = "Bebidas";
                        categories[1] = "Boquitas";
                        categories[2] = "Despensa";
                        categories[3] = "Frutas y verduras";
                        categories[4] = "Lácteos";
                        categories[5] = "Desechables";
            cmbCategories.DataSource = categories;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Productos por categorías
        }
    }
}