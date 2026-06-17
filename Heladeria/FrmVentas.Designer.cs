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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            cmbClientes = new ComboBox();
            textBox2 = new TextBox();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            comboBox2 = new ComboBox();
            dtpFecha = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            numericUpDown1 = new NumericUpDown();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            cmbProductos = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            dgvUltimasVentas = new DataGridView();
            colFactura = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            ColCantidad = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox4 = new GroupBox();
            iconButton11 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).BeginInit();
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
            panel1.Size = new Size(250, 827);
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
            groupBox1.Controls.Add(cmbClientes);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(iconButton6);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(label6);
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
            // cmbClientes
            // 
            cmbClientes.FormattingEnabled = true;
            cmbClientes.Location = new Point(391, 49);
            cmbClientes.Margin = new Padding(2, 2, 2, 2);
            cmbClientes.Name = "cmbClientes";
            cmbClientes.Size = new Size(201, 28);
            cmbClientes.TabIndex = 36;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 99);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(131, 27);
            textBox2.TabIndex = 35;
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
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(782, 49);
            comboBox2.Margin = new Padding(2, 2, 2, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(196, 28);
            comboBox2.TabIndex = 10;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(111, 26);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 5;
            label6.Text = "00001";
            label6.Click += label6_Click;
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
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(cmbProductos);
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
            iconButton4.Location = new Point(595, 56);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(125, 28);
            iconButton4.TabIndex = 32;
            iconButton4.Text = "Agregar";
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(458, 57);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 27);
            numericUpDown1.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(306, 56);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(146, 27);
            textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(173, 55);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(127, 27);
            textBox4.TabIndex = 10;
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(10, 54);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(157, 28);
            cmbProductos.TabIndex = 14;
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
            groupBox3.Controls.Add(dgvUltimasVentas);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            groupBox3.Location = new Point(261, 285);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1077, 346);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Detalle de la Venta";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // dgvUltimasVentas
            // 
            dgvUltimasVentas.AllowUserToAddRows = false;
            dgvUltimasVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 248, 240);
            dgvUltimasVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvUltimasVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUltimasVentas.BackgroundColor = Color.White;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(65, 36, 2);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvUltimasVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvUltimasVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltimasVentas.Columns.AddRange(new DataGridViewColumn[] { colFactura, colProducto, ColCantidad, colFecha, colCliente, colUsuario, colTotal });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(250, 238, 218);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(65, 36, 2);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvUltimasVentas.DefaultCellStyle = dataGridViewCellStyle6;
            dgvUltimasVentas.Location = new Point(6, 25);
            dgvUltimasVentas.Name = "dgvUltimasVentas";
            dgvUltimasVentas.ReadOnly = true;
            dgvUltimasVentas.RowHeadersVisible = false;
            dgvUltimasVentas.RowHeadersWidth = 62;
            dgvUltimasVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUltimasVentas.Size = new Size(871, 305);
            dgvUltimasVentas.TabIndex = 16;
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
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label16.ForeColor = Color.Blue;
            label16.Location = new Point(964, 73);
            label16.Name = "label16";
            label16.Size = new Size(92, 32);
            label16.TabIndex = 15;
            label16.Text = "C$ 350";
            label16.Click += label16_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(253, 253, 253);
            label15.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(0, 192, 0);
            label15.Location = new Point(998, 48);
            label15.Name = "label15";
            label15.Size = new Size(73, 25);
            label15.TabIndex = 14;
            label15.Text = "C$ 350";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(253, 253, 253);
            label14.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label14.ForeColor = Color.FromArgb(0, 192, 0);
            label14.Location = new Point(998, 25);
            label14.Name = "label14";
            label14.Size = new Size(73, 25);
            label14.TabIndex = 13;
            label14.Text = "C$ 350";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label13.Location = new Point(881, 73);
            label13.Name = "label13";
            label13.Size = new Size(77, 32);
            label13.TabIndex = 12;
            label13.Text = "Total:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label12.Location = new Point(881, 48);
            label12.Name = "label12";
            label12.Size = new Size(111, 25);
            label12.TabIndex = 11;
            label12.Text = "Descuento:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(881, 25);
            label11.Name = "label11";
            label11.Size = new Size(93, 25);
            label11.TabIndex = 10;
            label11.Text = "Subtotal:";
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
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 253, 253);
            ClientSize = new Size(1452, 827);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).EndInit();
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
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox5;
        private TextBox textBox4;
        private ComboBox cmbProductos;
        private NumericUpDown numericUpDown1;
        private Label label11;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private DataGridView dgvUltimasVentas;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton11;
        private FontAwesome.Sharp.IconButton iconButton6;
        private ComboBox comboBox2;
        private DataGridViewTextBoxColumn colFactura;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn ColCantidad;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colTotal;
        private TextBox textBox2;
        private ComboBox cmbClientes;
    }
}