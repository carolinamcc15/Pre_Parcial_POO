using System.ComponentModel;

namespace Pre_Parcial_2
{
    partial class AdminUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(AdminUser));
            this.tlpTabCtrl = new System.Windows.Forms.TableLayoutPanel();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tpAdminU = new System.Windows.Forms.TabPage();
            this.tpAdminI = new System.Windows.Forms.TabPage();
            this.tlpInsideTab = new System.Windows.Forms.TableLayoutPanel();
            this.grpCreateUser = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tlpGroup1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpModifyUser = new System.Windows.Forms.GroupBox();
            this.tlpGroup2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.lblModifyName = new System.Windows.Forms.Label();
            this.lblModifyPass = new System.Windows.Forms.Label();
            this.txtModifyName = new System.Windows.Forms.TextBox();
            this.txtModifyPassword = new System.Windows.Forms.TextBox();
            this.chkModifyAdmin = new System.Windows.Forms.CheckBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.tpAdminP = new System.Windows.Forms.TabPage();
            this.tlpTabCtrl.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tpAdminU.SuspendLayout();
            this.tlpInsideTab.SuspendLayout();
            this.grpCreateUser.SuspendLayout();
            this.tlpGroup1.SuspendLayout();
            this.grpModifyUser.SuspendLayout();
            this.tlpGroup2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpTabCtrl
            // 
            this.tlpTabCtrl.BackColor = System.Drawing.Color.Transparent;
            this.tlpTabCtrl.ColumnCount = 3;
            this.tlpTabCtrl.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.423198F));
            this.tlpTabCtrl.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.65628F));
            this.tlpTabCtrl.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.983003F));
            this.tlpTabCtrl.Controls.Add(this.tabAdmin, 1, 1);
            this.tlpTabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTabCtrl.Location = new System.Drawing.Point(0, 0);
            this.tlpTabCtrl.Name = "tlpTabCtrl";
            this.tlpTabCtrl.RowCount = 3;
            this.tlpTabCtrl.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.057082F));
            this.tlpTabCtrl.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.45454F));
            this.tlpTabCtrl.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.59408F));
            this.tlpTabCtrl.Size = new System.Drawing.Size(1059, 946);
            this.tlpTabCtrl.TabIndex = 0;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tpAdminU);
            this.tabAdmin.Controls.Add(this.tpAdminI);
            this.tabAdmin.Controls.Add(this.tpAdminP);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabAdmin.Location = new System.Drawing.Point(28, 12);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1006, 896);
            this.tabAdmin.TabIndex = 0;
            // 
            // tpAdminU
            // 
            this.tpAdminU.BackColor = System.Drawing.Color.FloralWhite;
            this.tpAdminU.Controls.Add(this.tlpInsideTab);
            this.tpAdminU.Location = new System.Drawing.Point(4, 33);
            this.tpAdminU.Name = "tpAdminU";
            this.tpAdminU.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdminU.Size = new System.Drawing.Size(998, 859);
            this.tpAdminU.TabIndex = 0;
            this.tpAdminU.Text = "Modificar usuario";
            // 
            // tpAdminI
            // 
            this.tpAdminI.BackColor = System.Drawing.Color.FloralWhite;
            this.tpAdminI.Location = new System.Drawing.Point(4, 33);
            this.tpAdminI.Name = "tpAdminI";
            this.tpAdminI.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdminI.Size = new System.Drawing.Size(998, 859);
            this.tpAdminI.TabIndex = 1;
            this.tpAdminI.Text = "Mantenimiento de inventario";
            // 
            // tlpInsideTab
            // 
            this.tlpInsideTab.BackColor = System.Drawing.Color.Transparent;
            this.tlpInsideTab.ColumnCount = 2;
            this.tlpInsideTab.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInsideTab.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInsideTab.Controls.Add(this.grpCreateUser, 0, 0);
            this.tlpInsideTab.Controls.Add(this.grpModifyUser, 0, 1);
            this.tlpInsideTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInsideTab.Location = new System.Drawing.Point(3, 3);
            this.tlpInsideTab.Name = "tlpInsideTab";
            this.tlpInsideTab.RowCount = 2;
            this.tlpInsideTab.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.02462F));
            this.tlpInsideTab.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.97538F));
            this.tlpInsideTab.Size = new System.Drawing.Size(992, 853);
            this.tlpInsideTab.TabIndex = 0;
            // 
            // grpCreateUser
            // 
            this.tlpInsideTab.SetColumnSpan(this.grpCreateUser, 2);
            this.grpCreateUser.Controls.Add(this.tlpGroup1);
            this.grpCreateUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCreateUser.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.grpCreateUser.Location = new System.Drawing.Point(3, 3);
            this.grpCreateUser.Name = "grpCreateUser";
            this.grpCreateUser.Size = new System.Drawing.Size(986, 361);
            this.grpCreateUser.TabIndex = 0;
            this.grpCreateUser.TabStop = false;
            this.grpCreateUser.Text = "Crear usuario";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblName.Location = new System.Drawing.Point(157, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(174, 37);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre:";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPassword.Location = new System.Drawing.Point(157, 108);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(174, 37);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtName.Location = new System.Drawing.Point(431, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(417, 35);
            this.txtName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPassword.Location = new System.Drawing.Point(431, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(417, 35);
            this.txtPassword.TabIndex = 3;
            // 
            // chkAdmin
            // 
            this.chkAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkAdmin.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chkAdmin.Location = new System.Drawing.Point(542, 167);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(195, 34);
            this.chkAdmin.TabIndex = 4;
            this.chkAdmin.Text = "Administrador";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button1.Location = new System.Drawing.Point(337, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 63);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tlpGroup1
            // 
            this.tlpGroup1.ColumnCount = 3;
            this.tlpGroup1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.37118F));
            this.tlpGroup1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.62882F));
            this.tlpGroup1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlpGroup1.Controls.Add(this.txtName, 1, 0);
            this.tlpGroup1.Controls.Add(this.txtPassword, 1, 1);
            this.tlpGroup1.Controls.Add(this.lblPassword, 0, 1);
            this.tlpGroup1.Controls.Add(this.lblName, 0, 0);
            this.tlpGroup1.Controls.Add(this.chkAdmin, 1, 2);
            this.tlpGroup1.Controls.Add(this.button1, 1, 3);
            this.tlpGroup1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGroup1.Location = new System.Drawing.Point(3, 28);
            this.tlpGroup1.Name = "tlpGroup1";
            this.tlpGroup1.RowCount = 4;
            this.tlpGroup1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.943F));
            this.tlpGroup1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.79793F));
            this.tlpGroup1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.68912F));
            this.tlpGroup1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.31088F));
            this.tlpGroup1.Size = new System.Drawing.Size(980, 330);
            this.tlpGroup1.TabIndex = 6;
            // 
            // grpModifyUser
            // 
            this.tlpInsideTab.SetColumnSpan(this.grpModifyUser, 2);
            this.grpModifyUser.Controls.Add(this.tlpGroup2);
            this.grpModifyUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpModifyUser.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.grpModifyUser.Location = new System.Drawing.Point(3, 370);
            this.grpModifyUser.Name = "grpModifyUser";
            this.grpModifyUser.Size = new System.Drawing.Size(986, 480);
            this.grpModifyUser.TabIndex = 1;
            this.grpModifyUser.TabStop = false;
            this.grpModifyUser.Text = "Modificar usuario";
            // 
            // tlpGroup2
            // 
            this.tlpGroup2.ColumnCount = 3;
            this.tlpGroup2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGroup2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGroup2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGroup2.Controls.Add(this.chkModifyAdmin, 1, 3);
            this.tlpGroup2.Controls.Add(this.txtModifyName, 1, 1);
            this.tlpGroup2.Controls.Add(this.lblModifyPass, 0, 2);
            this.tlpGroup2.Controls.Add(this.lblModifyName, 0, 1);
            this.tlpGroup2.Controls.Add(this.cmbUsers, 1, 0);
            this.tlpGroup2.Controls.Add(this.txtModifyPassword, 1, 2);
            this.tlpGroup2.Controls.Add(this.btnDeleteUser, 0, 4);
            this.tlpGroup2.Controls.Add(this.btnModifyUser, 2, 4);
            this.tlpGroup2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGroup2.Location = new System.Drawing.Point(3, 28);
            this.tlpGroup2.Name = "tlpGroup2";
            this.tlpGroup2.RowCount = 5;
            this.tlpGroup2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpGroup2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpGroup2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpGroup2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpGroup2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpGroup2.Size = new System.Drawing.Size(980, 449);
            this.tlpGroup2.TabIndex = 0;
            // 
            // cmbUsers
            // 
            this.cmbUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(329, 27);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(320, 35);
            this.cmbUsers.TabIndex = 0;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // lblModifyName
            // 
            this.lblModifyName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModifyName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblModifyName.Location = new System.Drawing.Point(149, 115);
            this.lblModifyName.Name = "lblModifyName";
            this.lblModifyName.Size = new System.Drawing.Size(174, 37);
            this.lblModifyName.TabIndex = 6;
            this.lblModifyName.Text = "Nombre:";
            // 
            // lblModifyPass
            // 
            this.lblModifyPass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModifyPass.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblModifyPass.Location = new System.Drawing.Point(149, 204);
            this.lblModifyPass.Name = "lblModifyPass";
            this.lblModifyPass.Size = new System.Drawing.Size(174, 37);
            this.lblModifyPass.TabIndex = 6;
            this.lblModifyPass.Text = "Contraseña:";
            // 
            // txtModifyName
            // 
            this.txtModifyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpGroup2.SetColumnSpan(this.txtModifyName, 2);
            this.txtModifyName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtModifyName.Location = new System.Drawing.Point(444, 116);
            this.txtModifyName.Name = "txtModifyName";
            this.txtModifyName.Size = new System.Drawing.Size(417, 35);
            this.txtModifyName.TabIndex = 6;
            // 
            // txtModifyPassword
            // 
            this.txtModifyPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpGroup2.SetColumnSpan(this.txtModifyPassword, 2);
            this.txtModifyPassword.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtModifyPassword.Location = new System.Drawing.Point(444, 205);
            this.txtModifyPassword.Name = "txtModifyPassword";
            this.txtModifyPassword.Size = new System.Drawing.Size(417, 35);
            this.txtModifyPassword.TabIndex = 7;
            // 
            // chkModifyAdmin
            // 
            this.chkModifyAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tlpGroup2.SetColumnSpan(this.chkModifyAdmin, 2);
            this.chkModifyAdmin.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chkModifyAdmin.Location = new System.Drawing.Point(555, 270);
            this.chkModifyAdmin.Name = "chkModifyAdmin";
            this.chkModifyAdmin.Size = new System.Drawing.Size(195, 34);
            this.chkModifyAdmin.TabIndex = 6;
            this.chkModifyAdmin.Text = "Administrador";
            this.chkModifyAdmin.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDeleteUser.BackColor = System.Drawing.Color.Wheat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(141, 371);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(182, 63);
            this.btnDeleteUser.TabIndex = 6;
            this.btnDeleteUser.Text = "Eliminar";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModifyUser.BackColor = System.Drawing.Color.Wheat;
            this.btnModifyUser.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnModifyUser.Location = new System.Drawing.Point(655, 371);
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.Size = new System.Drawing.Size(182, 63);
            this.btnModifyUser.TabIndex = 8;
            this.btnModifyUser.Text = "Modificar";
            this.btnModifyUser.UseVisualStyleBackColor = false;
            this.btnModifyUser.Click += new System.EventHandler(this.btnModifyUser_Click);
            // 
            // tpAdminP
            // 
            this.tpAdminP.BackColor = System.Drawing.Color.FloralWhite;
            this.tpAdminP.Location = new System.Drawing.Point(4, 33);
            this.tpAdminP.Name = "tpAdminP";
            this.tpAdminP.Size = new System.Drawing.Size(998, 859);
            this.tpAdminP.TabIndex = 2;
            this.tpAdminP.Text = "Historial de pedidos";
            // 
            // AdminUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Pre_Parcial_2.Properties.Resources.Back;
            this.ClientSize = new System.Drawing.Size(1059, 946);
            this.Controls.Add(this.tlpTabCtrl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AdminUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSR - Usuario administrador";
            this.Load += new System.EventHandler(this.AdminUser_Load);
            this.tlpTabCtrl.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            this.tpAdminU.ResumeLayout(false);
            this.tlpInsideTab.ResumeLayout(false);
            this.grpCreateUser.ResumeLayout(false);
            this.tlpGroup1.ResumeLayout(false);
            this.tlpGroup1.PerformLayout();
            this.grpModifyUser.ResumeLayout(false);
            this.tlpGroup2.ResumeLayout(false);
            this.tlpGroup2.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTabCtrl;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TableLayoutPanel tlpInsideTab;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpCreateUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tpAdminU;
        private System.Windows.Forms.TabPage tpAdminI;
        private System.Windows.Forms.GroupBox grpModifyUser;
        private System.Windows.Forms.TableLayoutPanel tlpGroup1;
        private System.Windows.Forms.TableLayoutPanel tlpGroup2;
        private System.Windows.Forms.Label lblModifyName;
        private System.Windows.Forms.Label lblModifyPass;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.TextBox txtModifyPassword;
        private System.Windows.Forms.TextBox txtModifyName;
        private System.Windows.Forms.CheckBox chkModifyAdmin;
        private System.Windows.Forms.Button btnModifyUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TabPage tpAdminP;
    }
}