namespace Heladeria
{
    partial class FrmInventarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventarios));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            dgvUltimasVentas = new DataGridView();
            colProducto = new DataGridViewTextBoxColumn();
            colSabor = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            iconButton12 = new FontAwesome.Sharp.IconButton();
            textBox6 = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).BeginInit();
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
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(dgvUltimasVentas);
            panel2.Controls.Add(iconButton12);
            panel2.Controls.Add(textBox6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1100, 729);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(28, 600);
            panel3.Name = "panel3";
            panel3.Size = new Size(1060, 38);
            panel3.TabIndex = 32;
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
            dgvUltimasVentas.Columns.AddRange(new DataGridViewColumn[] { colProducto, colSabor, colStock, colPrecio, colEstado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(250, 238, 218);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(65, 36, 2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUltimasVentas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUltimasVentas.Location = new Point(28, 65);
            dgvUltimasVentas.Name = "dgvUltimasVentas";
            dgvUltimasVentas.ReadOnly = true;
            dgvUltimasVentas.RowHeadersVisible = false;
            dgvUltimasVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUltimasVentas.Size = new Size(1060, 515);
            dgvUltimasVentas.TabIndex = 31;
            // 
            // colProducto
            // 
            colProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colProducto.FillWeight = 203.045685F;
            colProducto.HeaderText = "Producto";
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            colProducto.Width = 180;
            // 
            // colSabor
            // 
            colSabor.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colSabor.FillWeight = 103.325485F;
            colSabor.HeaderText = "Sabor";
            colSabor.Name = "colSabor";
            colSabor.ReadOnly = true;
            colSabor.Width = 250;
            // 
            // colStock
            // 
            colStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colStock.FillWeight = 167.295044F;
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            colStock.Width = 250;
            // 
            // colPrecio
            // 
            colPrecio.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colPrecio.FillWeight = 18.00486F;
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            colPrecio.Resizable = DataGridViewTriState.True;
            colPrecio.Width = 150;
            // 
            // colEstado
            // 
            colEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colEstado.FillWeight = 8.328922F;
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 250;
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
            iconButton12.IconSize = 25;
            iconButton12.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton12.Location = new Point(963, 30);
            iconButton12.Name = "iconButton12";
            iconButton12.Size = new Size(125, 29);
            iconButton12.TabIndex = 30;
            iconButton12.Text = "Buscar";
            iconButton12.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI Light", 12F);
            textBox6.Location = new Point(29, 30);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = " Buscar producto...";
            textBox6.Size = new Size(928, 29);
            textBox6.TabIndex = 29;
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
            // FrmInventarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmInventarios";
            Text = "Inventario";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUltimasVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBox6;
        private FontAwesome.Sharp.IconButton iconButton12;
        private DataGridView dgvUltimasVentas;
        private Panel panel3;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colSabor;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colEstado;
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