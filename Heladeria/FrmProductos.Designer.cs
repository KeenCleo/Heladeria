namespace Heladeria
{
    partial class FrmProductos
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            panel1 = new Panel();
            panel2 = new Panel();
            textBox6 = new TextBox();
            groupBox2 = new GroupBox();
            dgvUltimasVentas = new DataGridView();
            colCódigo = new DataGridViewTextBoxColumn();
            colFecha = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colSabor = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            iconButton12 = new FontAwesome.Sharp.IconButton();
            iconButton11 = new FontAwesome.Sharp.IconButton();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label12 = new Label();
            iconButton10 = new FontAwesome.Sharp.IconButton();
            iconButton9 = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(253, 253, 253);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1100, 729);
            panel2.TabIndex = 1;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI Light", 12F);
            textBox6.Location = new Point(876, 306);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = " Buscar producto...";
            textBox6.Size = new Size(206, 29);
            textBox6.TabIndex = 28;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvUltimasVentas);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(6, 328);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1082, 328);
            groupBox2.TabIndex = 28;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de Productos";
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUltimasVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUltimasVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUltimasVentas.Columns.AddRange(new DataGridViewColumn[] { colCódigo, colFecha, colPrecio, colStock, colSabor });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(250, 238, 218);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(65, 36, 2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUltimasVentas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUltimasVentas.Location = new Point(16, 28);
            dgvUltimasVentas.Name = "dgvUltimasVentas";
            dgvUltimasVentas.ReadOnly = true;
            dgvUltimasVentas.RowHeadersVisible = false;
            dgvUltimasVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUltimasVentas.Size = new Size(1060, 294);
            dgvUltimasVentas.TabIndex = 28;
            // 
            // colCódigo
            // 
            colCódigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colCódigo.FillWeight = 203.045685F;
            colCódigo.HeaderText = "Código";
            colCódigo.Name = "colCódigo";
            colCódigo.ReadOnly = true;
            colCódigo.Width = 80;
            // 
            // colFecha
            // 
            colFecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colFecha.FillWeight = 103.325485F;
            colFecha.HeaderText = "Nombre";
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            colFecha.Width = 220;
            // 
            // colPrecio
            // 
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colPrecio.FillWeight = 167.295044F;
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 150;
            // 
            // colStock
            // 
            colStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colStock.FillWeight = 18.00486F;
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            colStock.Resizable = DataGridViewTriState.True;
            colStock.Width = 77;
            // 
            // colSabor
            // 
            colSabor.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colSabor.FillWeight = 8.328922F;
            colSabor.HeaderText = "Sabor";
            colSabor.Name = "colSabor";
            colSabor.ReadOnly = true;
            colSabor.Width = 200;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(iconButton12);
            groupBox1.Controls.Add(iconButton11);
            groupBox1.Controls.Add(iconButton8);
            groupBox1.Controls.Add(iconButton5);
            groupBox1.Controls.Add(iconButton4);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label12);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(6, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1082, 288);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Producto";
            // 
            // iconButton12
            // 
            iconButton12.BackColor = Color.Gray;
            iconButton12.FlatStyle = FlatStyle.Flat;
            iconButton12.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            iconButton12.ForeColor = Color.White;
            iconButton12.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton12.IconColor = Color.White;
            iconButton12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton12.IconSize = 30;
            iconButton12.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton12.Location = new Point(601, 213);
            iconButton12.Name = "iconButton12";
            iconButton12.Size = new Size(125, 50);
            iconButton12.TabIndex = 27;
            iconButton12.Text = "Buscar";
            iconButton12.UseVisualStyleBackColor = false;
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
            iconButton11.Location = new Point(458, 213);
            iconButton11.Name = "iconButton11";
            iconButton11.Size = new Size(125, 50);
            iconButton11.TabIndex = 26;
            iconButton11.Text = "Eliminar";
            iconButton11.UseVisualStyleBackColor = false;
            // 
            // iconButton8
            // 
            iconButton8.BackColor = Color.FromArgb(253, 193, 81);
            iconButton8.FlatStyle = FlatStyle.Flat;
            iconButton8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            iconButton8.ForeColor = Color.White;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButton8.IconColor = Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 30;
            iconButton8.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton8.Location = new Point(313, 213);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(125, 50);
            iconButton8.TabIndex = 25;
            iconButton8.Text = "Editar";
            iconButton8.UseVisualStyleBackColor = false;
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
            iconButton5.Location = new Point(163, 213);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(125, 50);
            iconButton5.TabIndex = 24;
            iconButton5.Text = "Guardar";
            iconButton5.UseVisualStyleBackColor = false;
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
            iconButton4.Location = new Point(15, 213);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(125, 50);
            iconButton4.TabIndex = 12;
            iconButton4.Text = "Ingresar";
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Light", 12F);
            textBox4.Location = new Point(449, 122);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Sabor del producto";
            textBox4.Size = new Size(277, 29);
            textBox4.TabIndex = 23;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Light", 12F);
            textBox5.Location = new Point(449, 74);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "¿Cuanto queda del producto?";
            textBox5.Size = new Size(277, 29);
            textBox5.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(386, 125);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 21;
            label3.Text = "Sabor:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(386, 77);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 20;
            label4.Text = "Stock:";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Light", 12F);
            textBox3.Location = new Point(88, 122);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = " Ingrese precio del producto";
            textBox3.Size = new Size(247, 29);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Light", 12F);
            textBox2.Location = new Point(88, 74);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = " Ingrese nombre del producto";
            textBox2.Size = new Size(268, 29);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Light", 12F);
            textBox1.Location = new Point(88, 28);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Ingrese su codigo";
            textBox1.Size = new Size(172, 29);
            textBox1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(6, 125);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 16;
            label2.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(6, 77);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 15;
            label1.Text = "Nombre:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(6, 31);
            label12.Name = "label12";
            label12.Size = new Size(76, 21);
            label12.TabIndex = 14;
            label12.Text = "Códigos:";
            // 
            // iconButton10
            // 
            iconButton10.BackColor = Color.FromArgb(3, 57, 135);
            iconButton10.Dock = DockStyle.Top;
            iconButton10.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 34, 76);
            iconButton10.FlatStyle = FlatStyle.Flat;
            iconButton10.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            iconButton10.ForeColor = Color.White;
            iconButton10.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton10.IconColor = Color.Red;
            iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton10.IconSize = 40;
            iconButton10.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton10.Location = new Point(0, 644);
            iconButton10.Name = "iconButton10";
            iconButton10.Size = new Size(250, 82);
            iconButton10.TabIndex = 45;
            iconButton10.Text = "Salir";
            iconButton10.UseVisualStyleBackColor = false;
            // 
            // iconButton9
            // 
            iconButton9.BackColor = Color.FromArgb(3, 57, 135);
            iconButton9.Dock = DockStyle.Top;
            iconButton9.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 34, 76);
            iconButton9.FlatStyle = FlatStyle.Flat;
            iconButton9.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            iconButton9.ForeColor = Color.White;
            iconButton9.IconChar = FontAwesome.Sharp.IconChar.UserLarge;
            iconButton9.IconColor = Color.White;
            iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton9.IconSize = 40;
            iconButton9.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton9.Location = new Point(0, 563);
            iconButton9.Name = "iconButton9";
            iconButton9.Size = new Size(250, 81);
            iconButton9.TabIndex = 44;
            iconButton9.Text = "Usuarios";
            iconButton9.UseVisualStyleBackColor = false;
            // 
            // iconButton7
            // 
            iconButton7.BackColor = Color.FromArgb(3, 57, 135);
            iconButton7.Dock = DockStyle.Top;
            iconButton7.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 34, 76);
            iconButton7.FlatStyle = FlatStyle.Flat;
            iconButton7.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            iconButton7.ForeColor = Color.White;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.Book;
            iconButton7.IconColor = Color.White;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.IconSize = 40;
            iconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton7.Location = new Point(0, 482);
            iconButton7.Name = "iconButton7";
            iconButton7.Size = new Size(250, 81);
            iconButton7.TabIndex = 43;
            iconButton7.Text = "Inventario";
            iconButton7.UseVisualStyleBackColor = false;
            // 
            // iconButton6
            // 
            iconButton6.BackColor = Color.FromArgb(3, 57, 135);
            iconButton6.Dock = DockStyle.Top;
            iconButton6.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 34, 76);
            iconButton6.FlatStyle = FlatStyle.Flat;
            iconButton6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            iconButton6.ForeColor = Color.White;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            iconButton6.IconColor = Color.White;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 40;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(0, 401);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(250, 81);
            iconButton6.TabIndex = 42;
            iconButton6.Text = "Clientes";
            iconButton6.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(3, 57, 135);
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 34, 76);
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Coins;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 40;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 320);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(250, 81);
            iconButton3.TabIndex = 41;
            iconButton3.Text = "Productos";
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(3, 57, 135);
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 34, 76);
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 239);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(250, 81);
            iconButton2.TabIndex = 40;
            iconButton2.Text = "Ventas";
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(3, 57, 135);
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(7, 34, 76);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 158);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(250, 81);
            iconButton1.TabIndex = 39;
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
            pictureBox1.Size = new Size(250, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmProductos";
            Text = "Productos";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label12;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton iconButton12;
        private FontAwesome.Sharp.IconButton iconButton11;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox textBox6;
        private GroupBox groupBox2;
        private DataGridView dgvUltimasVentas;
        private DataGridViewTextBoxColumn colCódigo;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colSabor;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox1;
    }
}