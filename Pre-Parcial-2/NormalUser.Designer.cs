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
            this.label1 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.nudCant = new System.Windows.Forms.NumericUpDown();
            this.lblDisplayPrice = new System.Windows.Forms.Label();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tpViewOrders = new System.Windows.Forms.TabPage();
            this.tlpViewOrders = new System.Windows.Forms.TableLayoutPanel();
            this.dgvOrdersHistory = new System.Windows.Forms.DataGridView();
            this.lblHistory = new System.Windows.Forms.Label();
            this.btnDetails = new System.Windows.Forms.Button();
            this.nudIdPedido = new System.Windows.Forms.NumericUpDown();
            this.lblID = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrder = new System.Windows.Forms.Button();
            this.tlpNormalUser.SuspendLayout();
            this.tabNormalUser.SuspendLayout();
            this.tpOrder.SuspendLayout();
            this.tlpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudCant)).BeginInit();
            this.tpViewOrders.SuspendLayout();
            this.tlpViewOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrdersHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudIdPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrderList)).BeginInit();
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
            this.tlpNormalUser.Size = new System.Drawing.Size(882, 788);
            this.tlpNormalUser.TabIndex = 0;
            // 
            // tabNormalUser
            // 
            this.tabNormalUser.Controls.Add(this.tpOrder);
            this.tabNormalUser.Controls.Add(this.tpViewOrders);
            this.tabNormalUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabNormalUser.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabNormalUser.Location = new System.Drawing.Point(23, 10);
            this.tabNormalUser.Margin = new System.Windows.Forms.Padding(2);
            this.tabNormalUser.Name = "tabNormalUser";
            this.tabNormalUser.SelectedIndex = 0;
            this.tabNormalUser.Size = new System.Drawing.Size(839, 747);
            this.tabNormalUser.TabIndex = 0;
            // 
            // tpOrder
            // 
            this.tpOrder.BackColor = System.Drawing.Color.FloralWhite;
            this.tpOrder.Controls.Add(this.tlpOrder);
            this.tpOrder.Location = new System.Drawing.Point(4, 29);
            this.tpOrder.Margin = new System.Windows.Forms.Padding(2);
            this.tpOrder.Name = "tpOrder";
            this.tpOrder.Padding = new System.Windows.Forms.Padding(2);
            this.tpOrder.Size = new System.Drawing.Size(831, 714);
            this.tpOrder.TabIndex = 0;
            this.tpOrder.Text = "Realizar pedido";
            // 
            // tlpOrder
            // 
            this.tlpOrder.ColumnCount = 5;
            this.tlpOrder.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.416168F));
            this.tlpOrder.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.42437F));
            this.tlpOrder.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.15946F));
            this.tlpOrder.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tlpOrder.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOrder.Controls.Add(this.label1, 0, 0);
            this.tlpOrder.Controls.Add(this.lblProduct, 1, 1);
            this.tlpOrder.Controls.Add(this.cmbProduct, 2, 1);
            this.tlpOrder.Controls.Add(this.lblPrice, 1, 2);
            this.tlpOrder.Controls.Add(this.lblCant, 2, 2);
            this.tlpOrder.Controls.Add(this.lblTotal, 3, 2);
            this.tlpOrder.Controls.Add(this.nudCant, 2, 3);
            this.tlpOrder.Controls.Add(this.lblDisplayPrice, 1, 3);
            this.tlpOrder.Controls.Add(this.lblDisplayTotal, 3, 3);
            this.tlpOrder.Controls.Add(this.btnAdd, 2, 6);
            this.tlpOrder.Controls.Add(this.dgvOrderList, 1, 4);
            this.tlpOrder.Controls.Add(this.btnOrder, 2, 7);
            this.tlpOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOrder.Location = new System.Drawing.Point(2, 2);
            this.tlpOrder.Margin = new System.Windows.Forms.Padding(2);
            this.tlpOrder.Name = "tlpOrder";
            this.tlpOrder.RowCount = 8;
            this.tlpOrder.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.983664F));
            this.tlpOrder.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.01867F));
            this.tlpOrder.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.48541F));
            this.tlpOrder.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.484247F));
            this.tlpOrder.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.36873F));
            this.tlpOrder.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.57176F));
            this.tlpOrder.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpOrder.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpOrder.Size = new System.Drawing.Size(827, 710);
            this.tlpOrder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 11);
            this.label1.TabIndex = 3;
            this.label1.Text = "Precio";
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProduct.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblProduct.Location = new System.Drawing.Point(15, 37);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(252, 39);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Seleccione un producto:";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbProduct
            // 
            this.cmbProduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpOrder.SetColumnSpan(this.cmbProduct, 2);
            this.cmbProduct.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(271, 40);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(278, 32);
            this.cmbProduct.TabIndex = 0;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPrice.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPrice.Location = new System.Drawing.Point(109, 150);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 37);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Precio";
            // 
            // lblCant
            // 
            this.lblCant.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCant.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCant.Location = new System.Drawing.Point(356, 150);
            this.lblCant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(107, 37);
            this.lblCant.TabIndex = 4;
            this.lblCant.Text = "Cantidad";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotal.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTotal.Location = new System.Drawing.Point(650, 150);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 37);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            // 
            // nudCant
            // 
            this.nudCant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudCant.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.nudCant.Location = new System.Drawing.Point(345, 191);
            this.nudCant.Margin = new System.Windows.Forms.Padding(2);
            this.nudCant.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudCant.Name = "nudCant";
            this.nudCant.Size = new System.Drawing.Size(129, 30);
            this.nudCant.TabIndex = 6;
            this.nudCant.Value = new decimal(new int[] {1, 0, 0, 0});
            this.nudCant.ValueChanged += new System.EventHandler(this.nudCant_ValueChanged);
            // 
            // lblDisplayPrice
            // 
            this.lblDisplayPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDisplayPrice.BackColor = System.Drawing.SystemColors.Window;
            this.lblDisplayPrice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDisplayPrice.Location = new System.Drawing.Point(82, 193);
            this.lblDisplayPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplayPrice.Name = "lblDisplayPrice";
            this.lblDisplayPrice.Size = new System.Drawing.Size(117, 26);
            this.lblDisplayPrice.TabIndex = 7;
            this.lblDisplayPrice.Text = "$";
            this.lblDisplayPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDisplayTotal.BackColor = System.Drawing.SystemColors.Window;
            this.lblDisplayTotal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDisplayTotal.Location = new System.Drawing.Point(619, 193);
            this.lblDisplayTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(117, 26);
            this.lblDisplayTotal.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.BackColor = System.Drawing.Color.Wheat;
            this.btnAdd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAdd.Location = new System.Drawing.Point(329, 569);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 46);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tpViewOrders
            // 
            this.tpViewOrders.BackColor = System.Drawing.Color.FloralWhite;
            this.tpViewOrders.Controls.Add(this.tlpViewOrders);
            this.tpViewOrders.Location = new System.Drawing.Point(4, 29);
            this.tpViewOrders.Margin = new System.Windows.Forms.Padding(2);
            this.tpViewOrders.Name = "tpViewOrders";
            this.tpViewOrders.Padding = new System.Windows.Forms.Padding(2);
            this.tpViewOrders.Size = new System.Drawing.Size(831, 714);
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
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tlpViewOrders.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tlpViewOrders.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
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
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpViewOrders.Size = new System.Drawing.Size(827, 710);
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
            this.dgvOrdersHistory.Location = new System.Drawing.Point(11, 61);
            this.dgvOrdersHistory.Margin = new System.Windows.Forms.Padding(2);
            this.dgvOrdersHistory.Name = "dgvOrdersHistory";
            this.dgvOrdersHistory.RowTemplate.Height = 28;
            this.dgvOrdersHistory.Size = new System.Drawing.Size(789, 547);
            this.dgvOrdersHistory.TabIndex = 0;
            // 
            // lblHistory
            // 
            this.lblHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpViewOrders.SetColumnSpan(this.lblHistory, 4);
            this.lblHistory.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblHistory.Location = new System.Drawing.Point(107, 13);
            this.lblHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(597, 32);
            this.lblHistory.TabIndex = 4;
            this.lblHistory.Text = "Pedidos de ";
            this.lblHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDetails.BackColor = System.Drawing.Color.Wheat;
            this.btnDetails.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDetails.Location = new System.Drawing.Point(645, 628);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(155, 46);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Ver detalles";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // nudIdPedido
            // 
            this.nudIdPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudIdPedido.Location = new System.Drawing.Point(449, 638);
            this.nudIdPedido.Margin = new System.Windows.Forms.Padding(2);
            this.nudIdPedido.Name = "nudIdPedido";
            this.nudIdPedido.Size = new System.Drawing.Size(133, 26);
            this.nudIdPedido.TabIndex = 2;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblID.Location = new System.Drawing.Point(161, 635);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(226, 32);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "Ingrese ID de pedido: ";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBack.BackColor = System.Drawing.Color.Wheat;
            this.btnBack.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnBack.Location = new System.Drawing.Point(11, 628);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 46);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Ver pedidos";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderList.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
                {this.Column1, this.Column2, this.Column3, this.Column4});
            this.tlpOrder.SetColumnSpan(this.dgvOrderList, 3);
            this.dgvOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderList.Location = new System.Drawing.Point(16, 228);
            this.dgvOrderList.Name = "dgvOrderList";
            this.tlpOrder.SetRowSpan(this.dgvOrderList, 2);
            this.dgvOrderList.RowTemplate.Height = 24;
            this.dgvOrderList.Size = new System.Drawing.Size(786, 298);
            this.dgvOrderList.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOrder.BackColor = System.Drawing.Color.Wheat;
            this.btnOrder.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnOrder.Location = new System.Drawing.Point(335, 663);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(150, 44);
            this.btnOrder.TabIndex = 11;
            this.btnOrder.Text = "Comprar";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // NormalUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Pre_Parcial_2.Properties.Resources.Back;
            this.ClientSize = new System.Drawing.Size(882, 788);
            this.Controls.Add(this.tlpNormalUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            ((System.ComponentModel.ISupportInitialize) (this.nudCant)).EndInit();
            this.tpViewOrders.ResumeLayout(false);
            this.tlpViewOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrdersHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudIdPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvOrderList)).EndInit();
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCant;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblDisplayPrice;
        private System.Windows.Forms.Label lblDisplayTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnOrder;
    }
}