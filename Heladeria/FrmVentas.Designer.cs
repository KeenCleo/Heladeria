namespace Heladeria
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btn_Salir_FrmPrincipal = new FontAwesome.Sharp.IconButton();
            btn_IrUsuarios_frmPrincipal = new FontAwesome.Sharp.IconButton();
            btn_IrInventario_frmPrincipal = new FontAwesome.Sharp.IconButton();
            btn_IrCliente_frmPrincipal = new FontAwesome.Sharp.IconButton();
            btn_irProducto_frmPrincipal = new FontAwesome.Sharp.IconButton();
            btn_irVenta_frmPrincipal = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            cmbCliente = new ComboBox();
            txtVendedor = new TextBox();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            cmbMetodoPago = new ComboBox();
            dtpFecha = new DateTimePicker();
            lblNumerodeFactura = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            nudCantidad = new NumericUpDown();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            cmbProducto = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            lblCambio = new Label();
            label17 = new Label();
            txtDineroRecibido = new TextBox();
            lbelentrada = new Label();
            dgvVentas = new DataGridView();
            colFactura = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            label13 = new Label();
            groupBox4 = new GroupBox();
            iconButton11 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Salir_FrmPrincipal);
            panel1.Controls.Add(btn_IrUsuarios_frmPrincipal);
            panel1.Controls.Add(btn_IrInventario_frmPrincipal);
            panel1.Controls.Add(btn_IrCliente_frmPrincipal);
            panel1.Controls.Add(btn_irProducto_frmPrincipal);
            panel1.Controls.Add(btn_irVenta_frmPrincipal);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 729);
            panel1.TabIndex = 0;
            // 
            // btn_Salir_FrmPrincipal
            // 
            btn_Salir_FrmPrincipal.BackColor = Color.FromArgb(142, 197, 130);
            btn_Salir_FrmPrincipal.Dock = DockStyle.Top;
            btn_Salir_FrmPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 133, 88);
            btn_Salir_FrmPrincipal.FlatStyle = FlatStyle.Flat;
            btn_Salir_FrmPrincipal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_Salir_FrmPrincipal.ForeColor = Color.White;
            btn_Salir_FrmPrincipal.IconChar = FontAwesome.Sharp.IconChar.X;
            btn_Salir_FrmPrincipal.IconColor = Color.Red;
            btn_Salir_FrmPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Salir_FrmPrincipal.IconSize = 40;
            btn_Salir_FrmPrincipal.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Salir_FrmPrincipal.Location = new Point(0, 654);
            btn_Salir_FrmPrincipal.Name = "btn_Salir_FrmPrincipal";
            btn_Salir_FrmPrincipal.Size = new Size(250, 75);
            btn_Salir_FrmPrincipal.TabIndex = 60;
            btn_Salir_FrmPrincipal.Text = "Salir";
            btn_Salir_FrmPrincipal.UseVisualStyleBackColor = false;
            // 
            // btn_IrUsuarios_frmPrincipal
            // 
            btn_IrUsuarios_frmPrincipal.BackColor = Color.FromArgb(142, 197, 130);
            btn_IrUsuarios_frmPrincipal.Dock = DockStyle.Top;
            btn_IrUsuarios_frmPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 133, 88);
            btn_IrUsuarios_frmPrincipal.FlatStyle = FlatStyle.Flat;
            btn_IrUsuarios_frmPrincipal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_IrUsuarios_frmPrincipal.ForeColor = Color.White;
            btn_IrUsuarios_frmPrincipal.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            btn_IrUsuarios_frmPrincipal.IconColor = Color.White;
            btn_IrUsuarios_frmPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_IrUsuarios_frmPrincipal.IconSize = 40;
            btn_IrUsuarios_frmPrincipal.ImageAlign = ContentAlignment.MiddleLeft;
            btn_IrUsuarios_frmPrincipal.Location = new Point(0, 579);
            btn_IrUsuarios_frmPrincipal.Name = "btn_IrUsuarios_frmPrincipal";
            btn_IrUsuarios_frmPrincipal.Size = new Size(250, 75);
            btn_IrUsuarios_frmPrincipal.TabIndex = 59;
            btn_IrUsuarios_frmPrincipal.Text = "Usuarios";
            btn_IrUsuarios_frmPrincipal.UseVisualStyleBackColor = false;
            // 
            // btn_IrInventario_frmPrincipal
            // 
            btn_IrInventario_frmPrincipal.BackColor = Color.FromArgb(142, 197, 130);
            btn_IrInventario_frmPrincipal.Dock = DockStyle.Top;
            btn_IrInventario_frmPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 133, 88);
            btn_IrInventario_frmPrincipal.FlatStyle = FlatStyle.Flat;
            btn_IrInventario_frmPrincipal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_IrInventario_frmPrincipal.ForeColor = Color.White;
            btn_IrInventario_frmPrincipal.IconChar = FontAwesome.Sharp.IconChar.Book;
            btn_IrInventario_frmPrincipal.IconColor = Color.White;
            btn_IrInventario_frmPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_IrInventario_frmPrincipal.IconSize = 40;
            btn_IrInventario_frmPrincipal.ImageAlign = ContentAlignment.MiddleLeft;
            btn_IrInventario_frmPrincipal.Location = new Point(0, 504);
            btn_IrInventario_frmPrincipal.Name = "btn_IrInventario_frmPrincipal";
            btn_IrInventario_frmPrincipal.Size = new Size(250, 75);
            btn_IrInventario_frmPrincipal.TabIndex = 58;
            btn_IrInventario_frmPrincipal.Text = "Inventario";
            btn_IrInventario_frmPrincipal.UseVisualStyleBackColor = false;
            btn_IrInventario_frmPrincipal.Click += btn_IrInventario_frmPrincipal_Click;
            // 
            // btn_IrCliente_frmPrincipal
            // 
            btn_IrCliente_frmPrincipal.BackColor = Color.FromArgb(142, 197, 130);
            btn_IrCliente_frmPrincipal.Dock = DockStyle.Top;
            btn_IrCliente_frmPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 133, 88);
            btn_IrCliente_frmPrincipal.FlatStyle = FlatStyle.Flat;
            btn_IrCliente_frmPrincipal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_IrCliente_frmPrincipal.ForeColor = Color.White;
            btn_IrCliente_frmPrincipal.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btn_IrCliente_frmPrincipal.IconColor = Color.White;
            btn_IrCliente_frmPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_IrCliente_frmPrincipal.IconSize = 40;
            btn_IrCliente_frmPrincipal.ImageAlign = ContentAlignment.MiddleLeft;
            btn_IrCliente_frmPrincipal.Location = new Point(0, 429);
            btn_IrCliente_frmPrincipal.Name = "btn_IrCliente_frmPrincipal";
            btn_IrCliente_frmPrincipal.Size = new Size(250, 75);
            btn_IrCliente_frmPrincipal.TabIndex = 57;
            btn_IrCliente_frmPrincipal.Text = "Clientes";
            btn_IrCliente_frmPrincipal.UseVisualStyleBackColor = false;
            // 
            // btn_irProducto_frmPrincipal
            // 
            btn_irProducto_frmPrincipal.BackColor = Color.FromArgb(142, 197, 130);
            btn_irProducto_frmPrincipal.Dock = DockStyle.Top;
            btn_irProducto_frmPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 133, 88);
            btn_irProducto_frmPrincipal.FlatStyle = FlatStyle.Flat;
            btn_irProducto_frmPrincipal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_irProducto_frmPrincipal.ForeColor = Color.White;
            btn_irProducto_frmPrincipal.IconChar = FontAwesome.Sharp.IconChar.Coins;
            btn_irProducto_frmPrincipal.IconColor = Color.White;
            btn_irProducto_frmPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_irProducto_frmPrincipal.IconSize = 40;
            btn_irProducto_frmPrincipal.ImageAlign = ContentAlignment.MiddleLeft;
            btn_irProducto_frmPrincipal.Location = new Point(0, 354);
            btn_irProducto_frmPrincipal.Name = "btn_irProducto_frmPrincipal";
            btn_irProducto_frmPrincipal.Size = new Size(250, 75);
            btn_irProducto_frmPrincipal.TabIndex = 56;
            btn_irProducto_frmPrincipal.Text = "Productos";
            btn_irProducto_frmPrincipal.UseVisualStyleBackColor = false;
            // 
            // btn_irVenta_frmPrincipal
            // 
            btn_irVenta_frmPrincipal.BackColor = Color.FromArgb(142, 197, 130);
            btn_irVenta_frmPrincipal.Dock = DockStyle.Top;
            btn_irVenta_frmPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 133, 88);
            btn_irVenta_frmPrincipal.FlatStyle = FlatStyle.Flat;
            btn_irVenta_frmPrincipal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_irVenta_frmPrincipal.ForeColor = Color.White;
            btn_irVenta_frmPrincipal.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            btn_irVenta_frmPrincipal.IconColor = Color.White;
            btn_irVenta_frmPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_irVenta_frmPrincipal.IconSize = 40;
            btn_irVenta_frmPrincipal.ImageAlign = ContentAlignment.MiddleLeft;
            btn_irVenta_frmPrincipal.Location = new Point(0, 279);
            btn_irVenta_frmPrincipal.Name = "btn_irVenta_frmPrincipal";
            btn_irVenta_frmPrincipal.Size = new Size(250, 75);
            btn_irVenta_frmPrincipal.TabIndex = 55;
            btn_irVenta_frmPrincipal.Text = "Ventas";
            btn_irVenta_frmPrincipal.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(142, 197, 130);
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 133, 88);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 204);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(250, 75);
            iconButton1.TabIndex = 54;
            iconButton1.Text = "Inicio";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveBorder;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Enabled = false;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Controls.Add(txtVendedor);
            groupBox1.Controls.Add(iconButton6);
            groupBox1.Controls.Add(cmbMetodoPago);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(lblNumerodeFactura);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox1.Location = new Point(261, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1077, 159);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de la Venta";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(391, 49);
            cmbCliente.Margin = new Padding(2);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(201, 28);
            cmbCliente.TabIndex = 36;
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(10, 101);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.ReadOnly = true;
            txtVendedor.Size = new Size(209, 27);
            txtVendedor.TabIndex = 35;
            // 
            // iconButton6
            // 
            iconButton6.BackColor = Color.FromArgb(48, 161, 73);
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            iconButton6.ForeColor = Color.White;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton6.IconColor = Color.White;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 30;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(597, 49);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(125, 30);
            iconButton6.TabIndex = 34;
            iconButton6.Text = "Agregar";
            iconButton6.UseVisualStyleBackColor = false;
            iconButton6.Click += iconButton6_Click;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cmbMetodoPago.Location = new Point(782, 49);
            cmbMetodoPago.Margin = new Padding(2);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(196, 28);
            cmbMetodoPago.TabIndex = 10;
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(202, 47);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(131, 27);
            dtpFecha.TabIndex = 6;
            // 
            // lblNumerodeFactura
            // 
            lblNumerodeFactura.AutoSize = true;
            lblNumerodeFactura.Location = new Point(111, 26);
            lblNumerodeFactura.Name = "lblNumerodeFactura";
            lblNumerodeFactura.Size = new Size(54, 20);
            lblNumerodeFactura.TabIndex = 5;
            lblNumerodeFactura.Text = "00001";
            lblNumerodeFactura.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 78);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 4;
            label5.Text = "Vendedor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(782, 28);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 3;
            label4.Text = "Metodo de Pago:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 26);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 26);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 26);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "N de Factura:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(iconButton4);
            groupBox2.Controls.Add(nudCantidad);
            groupBox2.Controls.Add(txtPrecio);
            groupBox2.Controls.Add(txtStock);
            groupBox2.Controls.Add(cmbProducto);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox2.Location = new Point(261, 175);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1077, 104);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar Producto";
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.FromArgb(48, 161, 73);
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(595, 54);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(240, 30);
            iconButton4.TabIndex = 32;
            iconButton4.Text = "Agregar nuevo producto";
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(458, 57);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 27);
            nudCantidad.TabIndex = 16;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(306, 56);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(146, 27);
            txtPrecio.TabIndex = 15;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(173, 55);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(127, 27);
            txtStock.TabIndex = 10;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(10, 54);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(157, 28);
            cmbProducto.TabIndex = 14;
            cmbProducto.SelectionChangeCommitted += cmbProducto_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(458, 29);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 13;
            label10.Text = "Cantidad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(306, 29);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 12;
            label9.Text = "Precio Unitario:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(167, 29);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 11;
            label8.Text = "Stock:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 29);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 10;
            label7.Text = "Producto:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblCambio);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(txtDineroRecibido);
            groupBox3.Controls.Add(lbelentrada);
            groupBox3.Controls.Add(dgvVentas);
            groupBox3.Controls.Add(lblTotal);
            groupBox3.Controls.Add(label13);
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox3.Location = new Point(261, 285);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1077, 346);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalle de la Venta";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCambio.ForeColor = Color.Blue;
            lblCambio.Location = new Point(967, 138);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(64, 32);
            lblCambio.TabIndex = 20;
            lblCambio.Text = "C$ 0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label17.Location = new Point(883, 144);
            label17.Name = "label17";
            label17.Size = new Size(85, 25);
            label17.TabIndex = 19;
            label17.Text = "Cambio:";
            // 
            // txtDineroRecibido
            // 
            txtDineroRecibido.Location = new Point(966, 94);
            txtDineroRecibido.Margin = new Padding(2);
            txtDineroRecibido.Name = "txtDineroRecibido";
            txtDineroRecibido.Size = new Size(106, 27);
            txtDineroRecibido.TabIndex = 18;
            txtDineroRecibido.TextChanged += txtDineroRecibido_TextChanged;
            // 
            // lbelentrada
            // 
            lbelentrada.AutoSize = true;
            lbelentrada.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbelentrada.Location = new Point(880, 93);
            lbelentrada.Name = "lbelentrada";
            lbelentrada.Size = new Size(86, 25);
            lbelentrada.TabIndex = 17;
            lbelentrada.Text = "Entrada:";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 248, 240);
            dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(65, 36, 2);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { colFactura, colProducto, ColCantidad, colFecha, colCliente, colUsuario, colTotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(250, 238, 218);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(65, 36, 2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvVentas.Location = new Point(6, 25);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 62;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(871, 305);
            dgvVentas.TabIndex = 16;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
            // 
            // colFactura
            // 
            colFactura.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colFactura.FillWeight = 203.045685F;
            colFactura.HeaderText = "Factura";
            colFactura.MinimumWidth = 8;
            colFactura.Name = "colFactura";
            colFactura.ReadOnly = true;
            colFactura.Width = 120;
            // 
            // colProducto
            // 
            colProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colProducto.HeaderText = "Producto";
            colProducto.MinimumWidth = 8;
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            colProducto.Width = 200;
            // 
            // ColCantidad
            // 
            ColCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ColCantidad.HeaderText = "Cantidad";
            ColCantidad.MinimumWidth = 8;
            ColCantidad.Name = "ColCantidad";
            ColCantidad.ReadOnly = true;
            ColCantidad.Width = 150;
            // 
            // colFecha
            // 
            colFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colFecha.FillWeight = 103.325485F;
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 8;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            colFecha.Width = 200;
            // 
            // colCliente
            // 
            colCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colCliente.FillWeight = 167.295044F;
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 8;
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            colCliente.Width = 250;
            // 
            // colUsuario
            // 
            colUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colUsuario.FillWeight = 8.328922F;
            colUsuario.HeaderText = "Usuario";
            colUsuario.MinimumWidth = 8;
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            colUsuario.Width = 200;
            // 
            // colTotal
            // 
            colTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colTotal.FillWeight = 18.00486F;
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 8;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.Width = 120;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Blue;
            lblTotal.Location = new Point(967, 25);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(64, 32);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "C$ 0";
            lblTotal.Click += label16_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label13.Location = new Point(883, 25);
            label13.Name = "label13";
            label13.Size = new Size(77, 32);
            label13.TabIndex = 12;
            label13.Text = "Total:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(iconButton11);
            groupBox4.Controls.Add(iconButton2);
            groupBox4.Controls.Add(iconButton3);
            groupBox4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox4.Location = new Point(261, 637);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1077, 80);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            // 
            // iconButton11
            // 
            iconButton11.BackColor = Color.FromArgb(225, 56, 50);
            iconButton11.FlatStyle = FlatStyle.Flat;
            iconButton11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            iconButton11.ForeColor = Color.White;
            iconButton11.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton11.IconColor = Color.White;
            iconButton11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton11.IconSize = 30;
            iconButton11.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton11.Location = new Point(416, 17);
            iconButton11.Name = "iconButton11";
            iconButton11.Size = new Size(250, 50);
            iconButton11.TabIndex = 36;
            iconButton11.Text = "Cancelar";
            iconButton11.UseVisualStyleBackColor = false;
            iconButton11.Click += iconButton11_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(31, 107, 199);
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(672, 17);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(250, 50);
            iconButton2.TabIndex = 35;
            iconButton2.Text = "Guardar Venta";
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(48, 161, 73);
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Add;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(160, 17);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(250, 50);
            iconButton3.TabIndex = 34;
            iconButton3.Text = "Nueva Venta";
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 253, 253);
            ClientSize = new Size(1350, 729);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmVentas";
            Text = "Ventas";
            Load += FrmVentas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton btn_IrUsuarios_frmPrincipal;
        private FontAwesome.Sharp.IconButton btn_IrInventario_frmPrincipal;
        private FontAwesome.Sharp.IconButton btn_IrCliente_frmPrincipal;
        private FontAwesome.Sharp.IconButton btn_irProducto_frmPrincipal;
        private FontAwesome.Sharp.IconButton btn_irVenta_frmPrincipal;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btn_Salir_FrmPrincipal;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DateTimePicker dtpFecha;
        private Label lblNumerodeFactura;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDineroRecibido;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private ComboBox cmbProducto;
        private NumericUpDown nudCantidad;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label lblTotal;
        private Label label13;
        private DataGridView dgvVentas;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton11;
        private FontAwesome.Sharp.IconButton iconButton6;
        private ComboBox cmbMetodoPago;
        private DataGridViewTextBoxColumn colFactura;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colTotal;
        private TextBox txtVendedor;
        private ComboBox cmbCliente;
        private Label lbelentrada;
        private Label lblCambio;
        private Label label17;
    }
}