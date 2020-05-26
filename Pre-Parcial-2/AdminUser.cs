using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using Pre_Parcial_2.Properties;
using CartesianChart = LiveCharts.WinForms.CartesianChart;
using PieChart = LiveCharts.WinForms.PieChart;

namespace Pre_Parcial_2
{
    public partial class AdminUser : Form
    {
        private PieChart pieGraphic;
        private CartesianChart columnGraphic;
        public AdminUser()
        {
            InitializeComponent();
        }
        
        private void AdminUser_Load(object sender, EventArgs e)
        {
            RefreshUserControls();
            RefreshProductsControls();
            dvgOrdersHistory1.DataSource = PedidoDAO.ViewOrdersHistory();
            String[] categories;
            categories = new string[6];
            categories[0] = "Bebidas";
            categories[1] = "Boquitas";
            categories[2] = "Despensa";
            categories[3] = "Frutas y verduras";
            categories[4] = "Lácteos";
            categories[5] = "Desechables";
            cmbCategory.DataSource = categories;
            //Gráfico de pastel
            pieGraphic = new PieChart();
            Controls.Add(pieGraphic);
            pieGraphic.Parent = tabAdmin.TabPages[3];
            pieGraphic.Top = 10;
            pieGraphic.Left = 10;
            pieGraphic.Width = pieGraphic.Parent.Width - 20;
            pieGraphic.Height = pieGraphic.Parent.Height - 20;
            UpdatePieGraphic();
            //Gráfico de columnas
            columnGraphic = new CartesianChart();
            Controls.Add(columnGraphic);
            columnGraphic.Parent = tabAdmin.TabPages[4];
            columnGraphic.Top = 10;
            columnGraphic.Left = 10;
            columnGraphic.Width = columnGraphic.Parent.Width - 20;
            columnGraphic.Height = columnGraphic.Parent.Height - 20;
            UpdateColumnGraphic();
        }
        private void UpdatePieGraphic()
        {
            pieGraphic.Series = null;
            SeriesCollection collection = new SeriesCollection();
            DataTable dataTable= InventarioDAO.getSumByCategory();
            foreach (DataRow row in dataTable.Rows)
            {
                collection.Add(new PieSeries{Title = row[0].ToString(), Values = new ChartValues<int>{Convert.ToInt32(row[1].ToString())}, DataLabels = true});
            }
            pieGraphic.Series = collection;
            pieGraphic.LegendLocation = LegendLocation.Bottom;
        }

        private void UpdateColumnGraphic()
        {
            columnGraphic.Series = null;
            columnGraphic.AxisX = new AxesCollection();
            columnGraphic.BackColor = Color.FloralWhite;
            columnGraphic.Series= new SeriesCollection
            {
                new ColumnSeries() {Title = "Productos con mayor stock", Values = new ChartValues<int>{}}
            };
            columnGraphic.LegendLocation = LegendLocation.Top;
            columnGraphic.AxisX.Add(new Axis {Labels = new List<string>()});
            columnGraphic.AxisX[0].Separator = new Separator(){Step = 1, IsEnabled = false};
            columnGraphic.AxisX[0].LabelsRotation = 15;
            // Poblado de datos
            foreach (DataRow row in InventarioDAO.getTopFiveStocks().Rows)
            {
                columnGraphic.Series[0].Values.Add(Convert.ToInt32(row[1]));
                columnGraphic.AxisX[0].Labels.Add(row[0].ToString());
            }
        }
        
        private void RefreshUserControls()
        {
            cmbUsers.DataSource = null;
            cmbUsers.ValueMember = "Nombre";
            cmbUsers.DisplayMember = "Nombre";
            cmbUsers.DataSource = UsuarioDAO.getUsers();
        }
        
        private void RefreshProductsControls()
        {
            cmbProducts.DataSource = null;
            cmbProducts.ValueMember = "IdProducto";
            cmbProducts.DisplayMember = "Nombre";
            cmbProducts.DataSource = InventarioDAO.GetInventory();
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
                        RefreshUserControls();
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
                        RefreshUserControls();
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

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            dvgOrdersHistory1.DataSource = null;
            dvgOrdersHistory1.DataSource = PedidoDAO.ViewOrdersDetails((int) nudNumPedido.Value);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtNameP.Text.Equals("")||
                txtDesc.Text.Equals("")||
                txtPrice.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar los campos.", "Tienda San Ronaldo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }else
            { 
                Inventario product = new Inventario();
                product.Nombre = txtNameP.Text;
                product.Descripcion = txtDesc.Text;
                product.Precio = Convert.ToDouble(txtPrice.Text);
                product.Categoria = cmbCategory.SelectedItem.ToString();
                product.Stock = Convert.ToInt32(txtStock.Text);
                try
                {
                    InventarioDAO.InsertProduct(product);
                    MessageBox.Show("Nuevo producto agregado exitosamente.");
                    UpdatePieGraphic();
                    UpdateColumnGraphic();
                    RefreshProductsControls();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error, revise los campos.", "Tienda San Ronaldo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }


        private void AdminUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnModifyStock_Click(object sender, EventArgs e)
        {
            try
            {
                Inventario selectedProduct = (Inventario) cmbProducts.SelectedItem;
                InventarioDAO.ModifyInventory(selectedProduct,(int) nudStock.Value);
                MessageBox.Show($"El stock de {selectedProduct.Nombre} ha sido modificado con éxito.");
                RefreshProductsControls();
                UpdatePieGraphic();
                UpdateColumnGraphic();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ha ocurrido un error.", "Tienda San Ronaldo", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Inventario currentProduct = (Inventario) cmbProducts.SelectedItem;
            nudStock.Value = currentProduct.Stock;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Inventario currentProduct = (Inventario) cmbProducts.SelectedItem;
            if (MessageBox.Show($"¿Está seguro que desea eliminar el producto {currentProduct.Nombre}?",
                "Tienda San Ronaldo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                
                    InventarioDAO.DeleteProduct(currentProduct);
                    MessageBox.Show($"El producto \"{currentProduct.Nombre}\" ha sido eliminado con éxito.","Tienda San Ronaldo",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    UpdatePieGraphic();
                    RefreshProductsControls();
                    UpdateColumnGraphic();
                
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error.", "Tienda San Ronaldo", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dvgOrdersHistory1.DataSource = null;
            dvgOrdersHistory1.DataSource = PedidoDAO.ViewOrdersHistory();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
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
                    RefreshUserControls();
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