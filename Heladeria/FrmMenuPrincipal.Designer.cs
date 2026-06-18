namespace Heladeria
{
    partial class FrmMenuPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
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
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel3 = new Panel();
            label3 = new Label();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label5 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            label7 = new Label();
            panel5 = new Panel();
            label8 = new Label();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            label9 = new Label();
            panel6 = new Panel();
            dgvUltimasVentas = new DataGridView();
            colIDVenta = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colCliente = new DataGridViewTextBoxColumn();
            colMetodo = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            label4 = new Label();
            label11 = new Label();
            label12 = new Label();
            lbl_Fecha_Menu_Principal = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lbl_Hora_MenuPrincipal = new Label();
            lbl_BienvenidoUsuario = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
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
            btn_Salir_FrmPrincipal.TabIndex = 53;
            btn_Salir_FrmPrincipal.Text = "Salir";
            btn_Salir_FrmPrincipal.UseVisualStyleBackColor = false;
            btn_Salir_FrmPrincipal.Click += btn_Salir_FrmPrincipal_Click;
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
            btn_IrUsuarios_frmPrincipal.TabIndex = 52;
            btn_IrUsuarios_frmPrincipal.Text = "Usuarios";
            btn_IrUsuarios_frmPrincipal.UseVisualStyleBackColor = false;
            btn_IrUsuarios_frmPrincipal.Click += btn_IrUsuarios_frmPrincipal_Click;
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
            btn_IrInventario_frmPrincipal.TabIndex = 51;
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
            btn_IrCliente_frmPrincipal.TabIndex = 50;
            btn_IrCliente_frmPrincipal.Text = "Clientes";
            btn_IrCliente_frmPrincipal.UseVisualStyleBackColor = false;
            btn_IrCliente_frmPrincipal.Click += btn_IrCliente_frmPrincipal_Click;
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
            btn_irProducto_frmPrincipal.TabIndex = 49;
            btn_irProducto_frmPrincipal.Text = "Productos";
            btn_irProducto_frmPrincipal.UseVisualStyleBackColor = false;
            btn_irProducto_frmPrincipal.Click += btn_irProducto_frmPrincipal_Click;
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
            btn_irVenta_frmPrincipal.TabIndex = 48;
            btn_irVenta_frmPrincipal.Text = "Ventas";
            btn_irVenta_frmPrincipal.UseVisualStyleBackColor = false;
            btn_irVenta_frmPrincipal.Click += btn_irVenta_frmPrincipal_Click;
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
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Location = new Point(269, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 150);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(38, 150, 76);
            label2.Location = new Point(15, 106);
            label2.Name = "label2";
            label2.Size = new Size(141, 32);
            label2.TabIndex = 7;
            label2.Text = "C$1,200.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(27, 85);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 6;
            label1.Text = "Ventas de Hoy";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(253, 253, 253);
            iconPictureBox1.ForeColor = Color.FromArgb(38, 150, 76);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            iconPictureBox1.IconColor = Color.FromArgb(38, 150, 76);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 55;
            iconPictureBox1.Location = new Point(60, 25);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(60, 55);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(iconPictureBox2);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(455, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 150);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(72, 106);
            label3.Name = "label3";
            label3.Size = new Size(42, 32);
            label3.TabIndex = 10;
            label3.Text = "45";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(253, 253, 253);
            iconPictureBox2.ForeColor = Color.FromArgb(47, 102, 197);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Box;
            iconPictureBox2.IconColor = Color.FromArgb(47, 102, 197);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 55;
            iconPictureBox2.Location = new Point(63, 25);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(60, 55);
            iconPictureBox2.TabIndex = 8;
            iconPictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(49, 85);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 9;
            label5.Text = "Productos";
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Controls.Add(iconPictureBox3);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(641, 85);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 150);
            panel4.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label6.Location = new Point(70, 106);
            label6.Name = "label6";
            label6.Size = new Size(42, 32);
            label6.TabIndex = 13;
            label6.Text = "12";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(253, 253, 253);
            iconPictureBox3.ForeColor = Color.FromArgb(152, 111, 206);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconPictureBox3.IconColor = Color.FromArgb(152, 111, 206);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 55;
            iconPictureBox3.Location = new Point(61, 25);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(60, 55);
            iconPictureBox3.TabIndex = 11;
            iconPictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(61, 85);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 12;
            label7.Text = "Clientes";
            // 
            // panel5
            // 
            panel5.Controls.Add(label8);
            panel5.Controls.Add(iconPictureBox4);
            panel5.Controls.Add(label9);
            panel5.Location = new Point(827, 85);
            panel5.Name = "panel5";
            panel5.Size = new Size(180, 150);
            panel5.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(225, 64, 54);
            label8.Location = new Point(21, 106);
            label8.Name = "label8";
            label8.Size = new Size(141, 32);
            label8.TabIndex = 16;
            label8.Text = "C$1,200.00";
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(253, 253, 253);
            iconPictureBox4.ForeColor = Color.FromArgb(225, 64, 54);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            iconPictureBox4.IconColor = Color.FromArgb(225, 64, 54);
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 55;
            iconPictureBox4.Location = new Point(66, 25);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(60, 55);
            iconPictureBox4.TabIndex = 14;
            iconPictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(70, 85);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 15;
            label9.Text = "Stock";
            // 
            // panel6
            // 
            panel6.Controls.Add(dgvUltimasVentas);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(269, 253);
            panel6.Name = "panel6";
            panel6.Size = new Size(1042, 403);
            panel6.TabIndex = 2;
            // 
            // dgvUltimasVentas
            // 
            dgvUltimasVentas.AllowUserToAddRows = false;
            dgvUltimasVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 248, 240);
            dgvUltimasVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUltimasVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUltimasVentas.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(65, 36, 2);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUltimasVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUltimasVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltimasVentas.Columns.AddRange(new DataGridViewColumn[] { colIDVenta, colFecha, colCliente, colMetodo, colTotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(250, 238, 218);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(65, 36, 2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUltimasVentas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUltimasVentas.Location = new Point(12, 43);
            dgvUltimasVentas.Name = "dgvUltimasVentas";
            dgvUltimasVentas.ReadOnly = true;
            dgvUltimasVentas.RowHeadersVisible = false;
            dgvUltimasVentas.RowHeadersWidth = 62;
            dgvUltimasVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUltimasVentas.Size = new Size(1027, 344);
            dgvUltimasVentas.TabIndex = 7;
            // 
            // colIDVenta
            // 
            colIDVenta.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colIDVenta.FillWeight = 203.045685F;
            colIDVenta.HeaderText = "N° Venta";
            colIDVenta.MinimumWidth = 8;
            colIDVenta.Name = "colIDVenta";
            colIDVenta.ReadOnly = true;
            colIDVenta.Width = 200;
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
            colCliente.Width = 300;
            // 
            // colMetodo
            // 
            colMetodo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colMetodo.FillWeight = 18.00486F;
            colMetodo.HeaderText = "Método Pago";
            colMetodo.MinimumWidth = 8;
            colMetodo.Name = "colMetodo";
            colMetodo.ReadOnly = true;
            colMetodo.Width = 250;
            // 
            // colTotal
            // 
            colTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colTotal.FillWeight = 8.328922F;
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 8;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.Width = 250;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(159, 28);
            label4.TabIndex = 6;
            label4.Text = "Ventas del mes:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label11.Location = new Point(1113, 51);
            label11.Name = "label11";
            label11.Size = new Size(62, 25);
            label11.TabIndex = 12;
            label11.Text = "Hora:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label12.Location = new Point(1105, 13);
            label12.Name = "label12";
            label12.Size = new Size(67, 25);
            label12.TabIndex = 13;
            label12.Text = "Fecha:";
            // 
            // lbl_Fecha_Menu_Principal
            // 
            lbl_Fecha_Menu_Principal.AutoSize = true;
            lbl_Fecha_Menu_Principal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Fecha_Menu_Principal.Location = new Point(1181, 17);
            lbl_Fecha_Menu_Principal.Name = "lbl_Fecha_Menu_Principal";
            lbl_Fecha_Menu_Principal.Size = new Size(100, 21);
            lbl_Fecha_Menu_Principal.TabIndex = 14;
            lbl_Fecha_Menu_Principal.Text = "01/02/2052 ";
            lbl_Fecha_Menu_Principal.Click += lbl_Fecha_Menu_Principal_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lbl_Hora_MenuPrincipal
            // 
            lbl_Hora_MenuPrincipal.AutoSize = true;
            lbl_Hora_MenuPrincipal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Hora_MenuPrincipal.Location = new Point(1181, 55);
            lbl_Hora_MenuPrincipal.Margin = new Padding(2, 0, 2, 0);
            lbl_Hora_MenuPrincipal.Name = "lbl_Hora_MenuPrincipal";
            lbl_Hora_MenuPrincipal.Size = new Size(14, 21);
            lbl_Hora_MenuPrincipal.TabIndex = 15;
            lbl_Hora_MenuPrincipal.Text = ".";
            // 
            // lbl_BienvenidoUsuario
            // 
            lbl_BienvenidoUsuario.AutoSize = true;
            lbl_BienvenidoUsuario.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_BienvenidoUsuario.Location = new Point(445, 46);
            lbl_BienvenidoUsuario.Margin = new Padding(2, 0, 2, 0);
            lbl_BienvenidoUsuario.Name = "lbl_BienvenidoUsuario";
            lbl_BienvenidoUsuario.Size = new Size(21, 32);
            lbl_BienvenidoUsuario.TabIndex = 17;
            lbl_BienvenidoUsuario.Text = ".";
            lbl_BienvenidoUsuario.Click += label14_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(269, 44);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(156, 32);
            label10.TabIndex = 18;
            label10.Text = " Bienvenido ";
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 253, 253);
            ClientSize = new Size(1350, 729);
            Controls.Add(label10);
            Controls.Add(lbl_BienvenidoUsuario);
            Controls.Add(lbl_Hora_MenuPrincipal);
            Controls.Add(lbl_Fecha_Menu_Principal);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += FrmMenuPrincipal_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Label label5;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Label label7;
        private Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label lbl_Fecha_Menu_Principal;
        private DataGridView dgvUltimasVentas;
        private FontAwesome.Sharp.IconButton btn_Salir_FrmPrincipal;
        private FontAwesome.Sharp.IconButton btn_IrUsuarios_frmPrincipal;
        private FontAwesome.Sharp.IconButton btn_IrInventario_frmPrincipal;
        private FontAwesome.Sharp.IconButton btn_IrCliente_frmPrincipal;
        private FontAwesome.Sharp.IconButton btn_irProducto_frmPrincipal;
        private FontAwesome.Sharp.IconButton btn_irVenta_frmPrincipal;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label lbl_Hora_MenuPrincipal;
        private Label label13;
        private Label lbl_BienvenidoUsuario;
        private DataGridViewTextBoxColumn colIDVenta;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colCliente;
        private DataGridViewTextBoxColumn colMetodo;
        private DataGridViewTextBoxColumn colTotal;
        private Label label10;
    }
}