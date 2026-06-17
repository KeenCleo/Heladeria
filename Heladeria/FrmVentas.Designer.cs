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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panel1 = new Panel();
            iconButton10 = new FontAwesome.Sharp.IconButton();
            iconButton9 = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            dgvUltimasVentas = new DataGridView();
            groupBox1 = new GroupBox();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            cmbMetodoPago = new TextBox();
            lblMetodoPago = new Label();
            cmbCliente = new TextBox();
            txtStock = new TextBox();
            lblCliente = new Label();
            lblProducto = new Label();
            lblNumeroVenta = new Label();
            colFactura = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblStock = new Label();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            label13 = new Label();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            lblUsuario = new Label();
            lblFecha = new Label();
            textBox9 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            cmbProducto = new ComboBox();
            lblVenta = new Label();
            dtpFecha = new DateTimePicker();
            panel4 = new Panel();
            btnAgregarVenta = new FontAwesome.Sharp.IconButton();
            iconButton11 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).BeginInit();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(iconButton10);
            panel1.Controls.Add(iconButton9);
            panel1.Controls.Add(iconButton7);
            panel1.Controls.Add(iconButton6);
            panel1.Controls.Add(iconButton3);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 729);
            panel1.TabIndex = 0;
            // 
            // iconButton10
            // 
            iconButton10.BackColor = Color.FromArgb(142, 197, 130);
            iconButton10.Dock = DockStyle.Top;
            iconButton10.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 133, 88);
            iconButton10.FlatStyle = FlatStyle.Flat;
            iconButton10.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            iconButton10.ForeColor = Color.White;
            iconButton10.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton10.IconColor = Color.Red;
            iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton10.IconSize = 40;
            iconButton10.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton10.Location = new Point(0, 654);
            iconButton10.Name = "iconButton10";
            iconButton10.Size = new Size(250, 75);
            iconButton10.TabIndex = 53;
            iconButton10.Text = "Salir";
            iconButton10.UseVisualStyleBackColor = false;
            // 
            // iconButton9
            // 
            iconButton9.BackColor = Color.FromArgb(142, 197, 130);
            iconButton9.Dock = DockStyle.Top;
            iconButton9.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 133, 88);
            iconButton9.FlatStyle = FlatStyle.Flat;
            iconButton9.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            iconButton9.ForeColor = Color.White;
            iconButton9.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            iconButton9.IconColor = Color.White;
            iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton9.IconSize = 40;
            iconButton9.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton9.Location = new Point(0, 579);
            iconButton9.Name = "iconButton9";
            iconButton9.Size = new Size(250, 75);
            iconButton9.TabIndex = 52;
            iconButton9.Text = "Usuarios";
            iconButton9.UseVisualStyleBackColor = false;
            // 
            // iconButton7
            // 
            iconButton7.BackColor = Color.FromArgb(142, 197, 130);
            iconButton7.Dock = DockStyle.Top;
            iconButton7.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 133, 88);
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            iconButton7.ForeColor = Color.White;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.Book;
            iconButton7.IconColor = Color.White;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.IconSize = 40;
            iconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton7.Location = new Point(0, 504);
            iconButton7.Name = "iconButton7";
            iconButton7.Size = new Size(250, 75);
            iconButton7.TabIndex = 51;
            iconButton7.Text = "Inventario";
            iconButton7.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            iconButton6.BackColor = Color.FromArgb(142, 197, 130);
            iconButton6.Dock = DockStyle.Top;
            iconButton6.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 133, 88);
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            iconButton6.ForeColor = Color.White;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            iconButton6.IconColor = Color.White;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 40;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(0, 429);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(250, 75);
            iconButton6.TabIndex = 50;
            iconButton6.Text = "Clientes";
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(142, 197, 130);
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 133, 88);
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Coins;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 40;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 354);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(250, 75);
            iconButton3.TabIndex = 49;
            iconButton3.Text = "Productos";
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(142, 197, 130);
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 133, 88);
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 279);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(250, 75);
            iconButton2.TabIndex = 48;
            iconButton2.Text = "Ventas";
            iconButton2.UseVisualStyleBackColor = false;
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
            iconButton1.TabIndex = 47;
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
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(253, 253, 253);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1100, 729);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel4);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(dgvUltimasVentas);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(6, 306);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1082, 411);
            groupBox2.TabIndex = 31;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle de Venta";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dgvUltimasVentas
            // 
            dgvUltimasVentas.AllowUserToAddRows = false;
            dgvUltimasVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 248, 240);
            dgvUltimasVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvUltimasVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUltimasVentas.BackgroundColor = Color.White;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(65, 36, 2);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvUltimasVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvUltimasVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltimasVentas.Columns.AddRange(new DataGridViewColumn[] { colFactura, colFecha, colCliente, colTotal, colUsuario });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(250, 238, 218);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(65, 36, 2);
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvUltimasVentas.DefaultCellStyle = dataGridViewCellStyle9;
            dgvUltimasVentas.Location = new Point(14, 28);
            dgvUltimasVentas.Name = "dgvUltimasVentas";
            dgvUltimasVentas.ReadOnly = true;
            dgvUltimasVentas.RowHeadersVisible = false;
            dgvUltimasVentas.RowHeadersWidth = 51;
            dgvUltimasVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUltimasVentas.Size = new Size(811, 282);
            dgvUltimasVentas.TabIndex = 28;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(lblVenta);
            groupBox1.Controls.Add(cmbProducto);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(textBox9);
            groupBox1.Controls.Add(lblFecha);
            groupBox1.Controls.Add(lblUsuario);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(lblStock);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(cmbMetodoPago);
            groupBox1.Controls.Add(lblMetodoPago);
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(lblCliente);
            groupBox1.Controls.Add(lblProducto);
            groupBox1.Controls.Add(lblNumeroVenta);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(6, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1082, 288);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(31, 107, 199);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 30;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(776, 196);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 50);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Gray;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.White;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 30;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(907, 195);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 50);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.Font = new Font("Segoe UI Light", 12F);
            cmbMetodoPago.Location = new Point(684, 55);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(295, 29);
            cmbMetodoPago.TabIndex = 22;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMetodoPago.Location = new Point(684, 31);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(140, 21);
            lblMetodoPago.TabIndex = 20;
            lblMetodoPago.Text = "Metodo de Pago:";
            // 
            // cmbCliente
            // 
            cmbCliente.Font = new Font("Segoe UI Light", 12F);
            cmbCliente.Location = new Point(474, 55);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.PlaceholderText = "Ingrese nombre del cliente...";
            cmbCliente.Size = new Size(204, 29);
            cmbCliente.TabIndex = 19;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI Light", 12F);
            txtStock.Location = new Point(247, 218);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.ShortcutsEnabled = false;
            txtStock.Size = new Size(107, 29);
            txtStock.TabIndex = 17;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCliente.Location = new Point(474, 31);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(68, 21);
            lblCliente.TabIndex = 16;
            lblCliente.Text = "Cliente:";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProducto.Location = new Point(14, 192);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(84, 21);
            lblProducto.TabIndex = 15;
            lblProducto.Text = "Producto:";
            // 
            // lblNumeroVenta
            // 
            lblNumeroVenta.AutoSize = true;
            lblNumeroVenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNumeroVenta.Location = new Point(14, 31);
            lblNumeroVenta.Name = "lblNumeroVenta";
            lblNumeroVenta.Size = new Size(126, 21);
            lblNumeroVenta.TabIndex = 14;
            lblNumeroVenta.Text = "N de la factura:";
            // 
            // colFactura
            // 
            colFactura.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colFactura.FillWeight = 203.045685F;
            colFactura.HeaderText = "Factura";
            colFactura.MinimumWidth = 6;
            colFactura.Name = "colFactura";
            colFactura.ReadOnly = true;
            colFactura.Width = 150;
            // 
            // colFecha
            // 
            colFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colFecha.FillWeight = 103.325485F;
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            colFecha.Width = 150;
            // 
            // colCliente
            // 
            colCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colCliente.FillWeight = 167.295044F;
            colCliente.HeaderText = "Cliente";
            colCliente.MinimumWidth = 6;
            colCliente.Name = "colCliente";
            colCliente.ReadOnly = true;
            colCliente.Width = 150;
            // 
            // colTotal
            // 
            colTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colTotal.FillWeight = 18.00486F;
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.Resizable = DataGridViewTriState.True;
            colTotal.Width = 73;
            // 
            // colUsuario
            // 
            colUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colUsuario.FillWeight = 8.328922F;
            colUsuario.HeaderText = "Usuario";
            colUsuario.MinimumWidth = 6;
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            colUsuario.Width = 150;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(5, 8);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 28;
            label3.Text = "Subtotal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(5, 36);
            label5.Name = "label5";
            label5.Size = new Size(117, 28);
            label5.TabIndex = 29;
            label5.Text = "Descuento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(123, 78);
            label6.Name = "label6";
            label6.Size = new Size(105, 37);
            label6.TabIndex = 30;
            label6.Text = "C$ 350";
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(831, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(245, 128);
            panel3.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(136, 38);
            label7.Name = "label7";
            label7.Size = new Size(92, 32);
            label7.TabIndex = 31;
            label7.Text = "C$ 350";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label8.ForeColor = Color.Green;
            label8.Location = new Point(136, 8);
            label8.Name = "label8";
            label8.Size = new Size(92, 32);
            label8.TabIndex = 32;
            label8.Text = "C$ 350";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label9.Location = new Point(5, 78);
            label9.Name = "label9";
            label9.Size = new Size(89, 37);
            label9.TabIndex = 33;
            label9.Text = "Total:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStock.Location = new Point(247, 192);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(57, 21);
            lblStock.TabIndex = 28;
            lblStock.Text = "Stock:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPrecio.Location = new Point(360, 194);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(129, 21);
            lblPrecio.TabIndex = 30;
            lblPrecio.Text = "Precio Unitario:";
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI Light", 12F);
            txtPrecio.Location = new Point(360, 218);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(153, 29);
            txtPrecio.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.Location = new Point(519, 192);
            label13.Name = "label13";
            label13.Size = new Size(83, 21);
            label13.TabIndex = 32;
            label13.Text = "Cantidad:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(48, 161, 73);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAgregar.IconColor = Color.White;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 30;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(645, 198);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(125, 50);
            btnAgregar.TabIndex = 33;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsuario.Location = new Point(14, 87);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(89, 21);
            lblUsuario.TabIndex = 35;
            lblUsuario.Text = "Vendedor:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFecha.Location = new Point(197, 31);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(58, 21);
            lblFecha.TabIndex = 36;
            lblFecha.Text = "Fecha:";
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI Light", 12F);
            textBox9.Location = new Point(14, 111);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(174, 29);
            textBox9.TabIndex = 38;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(519, 219);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 29);
            numericUpDown1.TabIndex = 39;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(19, 216);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(222, 29);
            cmbProducto.TabIndex = 40;
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Location = new Point(19, 55);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(64, 21);
            lblVenta.TabIndex = 41;
            lblVenta.Text = "000001";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(197, 52);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(271, 29);
            dtpFecha.TabIndex = 42;
            // 
            // panel4
            // 
            panel4.Controls.Add(iconButton5);
            panel4.Controls.Add(iconButton11);
            panel4.Controls.Add(btnAgregarVenta);
            panel4.Location = new Point(14, 320);
            panel4.Name = "panel4";
            panel4.Size = new Size(1062, 78);
            panel4.TabIndex = 32;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.BackColor = Color.FromArgb(48, 161, 73);
            btnAgregarVenta.BackgroundImageLayout = ImageLayout.None;
            btnAgregarVenta.FlatStyle = FlatStyle.Flat;
            btnAgregarVenta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregarVenta.ForeColor = Color.White;
            btnAgregarVenta.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAgregarVenta.IconColor = Color.White;
            btnAgregarVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarVenta.IconSize = 30;
            btnAgregarVenta.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarVenta.Location = new Point(210, 15);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(224, 50);
            btnAgregarVenta.TabIndex = 43;
            btnAgregarVenta.Text = "Nueva Venta";
            btnAgregarVenta.UseVisualStyleBackColor = false;
            // 
            // iconButton11
            // 
            iconButton11.BackColor = Color.FromArgb(225, 56, 50);
            iconButton11.FlatStyle = FlatStyle.Flat;
            iconButton11.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            iconButton11.ForeColor = Color.White;
            iconButton11.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton11.IconColor = Color.White;
            iconButton11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton11.IconSize = 30;
            iconButton11.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton11.Location = new Point(440, 15);
            iconButton11.Name = "iconButton11";
            iconButton11.Size = new Size(224, 50);
            iconButton11.TabIndex = 44;
            iconButton11.Text = "Cancelar";
            iconButton11.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.FromArgb(31, 107, 199);
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            iconButton5.ForeColor = Color.White;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 30;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(670, 15);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(224, 50);
            iconButton5.TabIndex = 43;
            iconButton5.Text = "Guardar Venta";
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ventas";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox cmbMetodoPago;
        private Label lblMetodoPago;
        private TextBox cmbCliente;
        private TextBox textBox2;
        private TextBox txtStock;
        private Label lblCliente;
        private Label lblProducto;
        private Label lblNumeroVenta;
        private GroupBox groupBox2;
        private DataGridView dgvUltimasVentas;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Panel panel3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private DataGridViewTextBoxColumn colFactura;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colUsuario;
        private Label label13;
        private TextBox textBox6;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblStock;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private TextBox textBox9;
        private Label lblFecha;
        private Label lblUsuario;
        private ComboBox cmbProducto;
        private NumericUpDown numericUpDown1;
        private Label lblVenta;
        private DateTimePicker dtpFecha;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnAgregarVenta;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton11;
    }
}