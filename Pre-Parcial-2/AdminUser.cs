using System;
using System.Windows.Forms;

namespace Pre_Parcial_2
{
    public partial class AdminUser : Form
    {
        public AdminUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals("")||
                txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar los campos.", "Tienda San Ronaldo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }else
            { 
                Usuario usuario = new Usuario();
                usuario.Nombre = txtName.Text;
                usuario.Contraseña = txtPassword.Text;
                usuario.EsAdmin = chkAdmin.Checked;
                try
                {
                    UsuarioDAO.InsertUser(usuario);
                    MessageBox.Show("Usuario creado exitosamente.");
                    RefreshControls();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error, revise los campos.", "Tienda San Ronaldo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                
            }
        }
        private void AdminUser_Load(object sender, EventArgs e)
        {
            RefreshControls();
        }
        
        private void RefreshControls()
        {
            cmbUsers.DataSource = null;
            cmbUsers.ValueMember = "Nombre";
            cmbUsers.DisplayMember = "Nombre";
            cmbUsers.DataSource = UsuarioDAO.getUsers();
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario currentUser = (Usuario) cmbUsers.SelectedItem;
            txtModifyName.Text = currentUser.Nombre;
            txtModifyPassword.Text = currentUser.Contraseña;
            chkModifyAdmin.Checked = currentUser.EsAdmin;
        }
        private void btnModifyUser_Click(object sender, EventArgs e)
        {
            if (txtModifyName.Text.Equals("")||
                txtModifyPassword.Text.Equals(""))
            {
                MessageBox.Show("Debe rellenar los campos.","Tienda San Ronaldo");
            }
            else
            {
                Usuario modifyUser = new Usuario();
                try
                {
                    modifyUser.Nombre = txtModifyName.Text;
                    modifyUser.Contraseña = txtModifyPassword.Text;
                    modifyUser.EsAdmin = chkModifyAdmin.Checked;
                    if (MessageBox.Show($"¿Está seguro de modificar al usuario {((Usuario)cmbUsers.SelectedItem).Nombre}?",
                            "Tienda San Ronaldo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        UsuarioDAO.ModifyUser(modifyUser,((Usuario)cmbUsers.SelectedItem).Nombre);
                        RefreshControls();
                        MessageBox.Show("El usuario ha sido modificado con éxito.","Tienda San Ronaldo");
                        
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Tienda San Ronaldo");
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (txtModifyName.Text.Equals("")||
                txtModifyPassword.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar los campos.", "Tienda San Ronaldo");
            }
            else
            {
                Usuario deleteUser = new Usuario();
                deleteUser.Nombre = txtModifyName.Text;
                deleteUser.Contraseña = txtModifyPassword.Text;
                deleteUser.EsAdmin = chkModifyAdmin.Checked;
                try
                {
                    if (MessageBox.Show($"¿Desea eliminar al usuario {deleteUser.Nombre}?",
                            "Tienda San Ronaldo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        UsuarioDAO.DeleteUser(deleteUser);
                        RefreshControls();
                        MessageBox.Show("El usuario ha sido eliminado con éxito.", "Tienda San Ronaldo");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error, revise los campos.", "Tienda San Ronaldo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }
    }
}