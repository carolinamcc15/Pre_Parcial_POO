using System.ComponentModel;

namespace Pre_Parcial_2
{
    partial class NormalUser
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
                new System.ComponentModel.ComponentResourceManager(typeof(NormalUser));
            this.tlpNormalUser = new System.Windows.Forms.TableLayoutPanel();
            this.tabNormalUser = new System.Windows.Forms.TabControl();
            this.tpOrder = new System.Windows.Forms.TabPage();
            this.tlpOrder = new System.Windows.Forms.TableLayoutPanel();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tpViewOrders = new System.Windows.Forms.TabPage();
            this.tlpViewOrders = new System.Windows.Forms.TableLayoutPanel();
            this.dgvOrdersHistory = new System.Windows.Forms.DataGridView();
            this.btnDetails = new System.Windows.Forms.Button();
            this.nudIdPedido = new System.Windows.Forms.NumericUpDown();
            this.lblID = new System.Windows.Forms.Label();
            this.lblHistory = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.tlpNormalUser.SuspendLayout();
            this.tabNormalUser.SuspendLayout();
            this.tpOrder.SuspendLayout();
            this.tlpOrder.SuspendLayout();
            this.tpViewOrders.SuspendLayout();
            this.tlpViewOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrdersHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudIdPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpNormalUser
            // 
            this.tlpNormalUser.BackColor = System.Drawing.Color.Transparent;
            this.tlpNormalUser.ColumnCount = 3;
            this.tlpNormalUser.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.418549F));
            this.tlpNormalUser.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.60264F));
            this.tlpNormalUser.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.978813F));
            this.tlpNormalUser.Controls.Add(this.tabNormalUser, 1, 1);
            this.tlpNormalUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNormalUser.Location = new System.Drawing.Point(0, 0);
            this.tlpNormalUser.Margin = new System.Windows.Forms.Padding(2);
            this.tlpNormalUser.Name = "tlpNormalUser";
            this.tlpNormalUser.RowCount = 3;
            this.tlpNormalUser.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.058941F));
            this.tlpNormalUser.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.35465F));
            this.tlpNormalUser.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.586414F));
            this.tlpNormalUser.Size = new System.Drawing.Size(1058, 946);
            this.tlpNormalUser.TabIndex = 0;
            // 
            // tabNormalUser
            // 
            this.tabNormalUser.Controls.Add(this.tpOrder);
            this.tabNormalUser.Controls.Add(this.tpViewOrders);
            this.tabNormalUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabNormalUser.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabNormalUser.Location = new System.Drawing.Point(27, 12);
            this.tabNormalUser.Margin = new System.Windows.Forms.Padding(2);
            this.tabNormalUser.Name = "tabNormalUser";
            this.tabNormalUser.SelectedIndex = 0;
            this.tabNormalUser.Size = new System.Drawing.Size(1007, 898);
            this.tabNormalUser.TabIndex = 0;
            // 
            // tpOrder
            // 
            this.tpOrder.BackColor = System.Drawing.Color.FloralWhite;
            this.tpOrder.Controls.Add(this.tlpOrder);
            this.tpOrder.Location = new System.Drawing.Point(4, 33);
            this.tpOrder.Margin = new System.Windows.Forms.Padding(2);
            this.tpOrder.Name = "tpOrder";
            this.tpOrder.Padding = new System.Windows.Forms.Padding(2);
            this.tpOrder.Size = new System.Drawing.Size(999, 861);
            this.tpOrder.TabIndex = 0;
            this.tpOrder.Text = "Realizar pedido";
            // 
            // tlpOrder
            // 
            this.tlpOrder.ColumnCount = 4;
            this.tlpOrder.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.417344F));
            this.tlpOrder.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.44696F));
            this.tlpOrder.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.18435F));
            this.tlpOrder.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpOrder.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOrder.Controls.Add(this.cmbCategories, 2, 1);
            this.tlpOrder.Controls.Add(this.lblCategory, 1, 1);
            this.tlpOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOrder.Location = new System.Drawing.Point(2, 2);
            this.tlpOrder.Margin = new System.Windows.Forms.Padding(2);
            this.tlpOrder.Name = "tlpOrder";
            this.tlpOrder.RowCount = 4;
            this.tlpOrder.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.884615F));
            this.tlpOrder.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.533654F));
            this.tlpOrder.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.58173F));
            this.tlpOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOrder.Size = new System.Drawing.Size(995, 857);
            this.tlpOrder.TabIndex = 1;
            // 
            // cmbCategories
            // 
            this.cmbCategories.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCategories.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(474, 41);
            this.cmbCategories.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(333, 37);
            this.cmbCategories.TabIndex = 0;
            this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCategory.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCategory.Location = new System.Drawing.Point(141, 36);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(329, 47);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Seleccione una categoría: ";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpViewOrders
            // 
            this.tpViewOrders.BackColor = System.Drawing.Color.FloralWhite;
            this.tpViewOrders.Controls.Add(this.tlpViewOrders);
            this.tpViewOrders.Location = new System.Drawing.Point(4, 33);
            this.tpViewOrders.Margin = new System.Windows.Forms.Padding(2);
            this.tpViewOrders.Name = "tpViewOrders";
            this.tpViewOrders.Padding = new System.Windows.Forms.Padding(2);
            this.tpViewOrders.Size = new System.Drawing.Size(999, 861);
            this.tpViewOrders.TabIndex = 1;
            this.tpViewOrders.Text = "Historial de pedidos";
            // 
            // tlpViewOrders
            // 
            this.tlpViewOrders.ColumnCount = 6;
            this.tlpViewOrders.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.416534F));
            this.tlpViewOrders.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.57442F));
            this.tlpViewOrders.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.1195F));
            this.tlpViewOrders.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 305F));
            this.tlpViewOrders.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tlpViewOrders.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpViewOrders.Controls.Add(this.dgvOrdersHistory, 1, 1);
            this.tlpViewOrders.Controls.Add(this.lblHistory, 1, 0);
            this.tlpViewOrders.Controls.Add(this.btnDetails, 4, 2);
            this.tlpViewOrders.Controls.Add(this.nudIdPedido, 3, 2);
            this.tlpViewOrders.Controls.Add(this.lblID, 2, 2);
            this.tlpViewOrders.Controls.Add(this.btnBack, 1, 2);
            this.tlpViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpViewOrders.Location = new System.Drawing.Point(2, 2);
            this.tlpViewOrders.Margin = new System.Windows.Forms.Padding(2);
            this.tlpViewOrders.Name = "tlpViewOrders";
            this.tlpViewOrders.RowCount = 4;
            this.tlpViewOrders.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.533654F));
            this.tlpViewOrders.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.56731F));
            this.tlpViewOrders.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.89904F));
            this.tlpViewOrders.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpViewOrders.Size = new System.Drawing.Size(995, 857);
            this.tlpViewOrders.TabIndex = 1;
            // 
            // dgvOrdersHistory
            // 
            this.dgvOrdersHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrdersHistory.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvOrdersHistory.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpViewOrders.SetColumnSpan(this.dgvOrdersHistory, 4);
            this.dgvOrdersHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdersHistory.GridColor = System.Drawing.Color.FloralWhite;
            this.dgvOrdersHistory.Location = new System.Drawing.Point(13, 73);
            this.dgvOrdersHistory.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrdersHistory.Name = "dgvOrdersHistory";
            this.dgvOrdersHistory.RowTemplate.Height = 28;
            this.dgvOrdersHistory.Size = new System.Drawing.Size(958, 661);
            this.dgvOrdersHistory.TabIndex = 0;
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDetails.BackColor = System.Drawing.Color.Wheat;
            this.btnDetails.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDetails.Location = new System.Drawing.Point(784, 758);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(187, 55);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Ver detalles";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // nudIdPedido
            // 
            this.nudIdPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudIdPedido.Location = new System.Drawing.Point(549, 770);
            this.nudIdPedido.Margin = new System.Windows.Forms.Padding(2);
            this.nudIdPedido.Name = "nudIdPedido";
            this.nudIdPedido.Size = new System.Drawing.Size(160, 30);
            this.nudIdPedido.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblID.Location = new System.Drawing.Point(197, 766);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(278, 38);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Ingrese ID de pedido: ";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHistory
            // 
            this.lblHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpViewOrders.SetColumnSpan(this.lblHistory, 4);
            this.lblHistory.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblHistory.Location = new System.Drawing.Point(134, 16);
            this.lblHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(716, 38);
            this.lblHistory.TabIndex = 4;
            this.lblHistory.Text = "Pedidos de ";
            this.lblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBack.BackColor = System.Drawing.Color.Wheat;
            this.btnBack.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnBack.Location = new System.Drawing.Point(13, 758);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(173, 55);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Ver pedidos";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // NormalUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Pre_Parcial_2.Properties.Resources.Back;
            this.ClientSize = new System.Drawing.Size(1058, 946);
            this.Controls.Add(this.tlpNormalUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "NormalUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSR - Usuario normal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NormalUser_FormClosed);
            this.Load += new System.EventHandler(this.NormalUser_Load);
            this.tlpNormalUser.ResumeLayout(false);
            this.tabNormalUser.ResumeLayout(false);
            this.tpOrder.ResumeLayout(false);
            this.tlpOrder.ResumeLayout(false);
            this.tpViewOrders.ResumeLayout(false);
            this.tlpViewOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrdersHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudIdPedido)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpNormalUser;
        private System.Windows.Forms.TabPage tpViewOrders;
        private System.Windows.Forms.TabPage tpOrder;
        private System.Windows.Forms.TableLayoutPanel tlpViewOrders;
        private System.Windows.Forms.TableLayoutPanel tlpOrder;
        private System.Windows.Forms.TabControl tabNormalUser;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DataGridView dgvOrdersHistory;
        private System.Windows.Forms.NumericUpDown nudIdPedido;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnBack;
    }
}