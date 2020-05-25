using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pre_Parcial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario loginUser = UsuarioDAO.verifyUser(txtName.Text, txtPassword.Text);
                if (loginUser.EsAdmin)
                {
                    AdminUser admin = new AdminUser(); 
                    admin.Show();   
                }
                else
                {
                    NormalUser normal = new NormalUser(loginUser); 
                    normal.Show();
                }
                Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show("El usuario no ha sido encontrado. Verifique las credenciales.", "Tienda San Ronaldo",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtName.Clear();
                txtPassword.Clear();
            } 
        }
    }
}