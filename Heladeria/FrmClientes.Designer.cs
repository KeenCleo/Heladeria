namespace Heladeria
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            iconButton10 = new FontAwesome.Sharp.IconButton();
            iconButton9 = new FontAwesome.Sharp.IconButton();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            iconButton11 = new FontAwesome.Sharp.IconButton();
            txtBuscar = new TextBox();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtDireccionCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtNombreCliente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvClientes = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
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
            panel1.Size = new Size(250, 765);
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
            iconButton10.TabIndex = 45;
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
            iconButton9.TabIndex = 44;
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
            iconButton7.TabIndex = 43;
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
            iconButton6.TabIndex = 42;
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
            iconButton3.TabIndex = 41;
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
            iconButton2.TabIndex = 40;
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
            pictureBox1.Size = new Size(250, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(iconButton11);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(iconButton8);
            groupBox1.Controls.Add(iconButton5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDireccionCliente);
            groupBox1.Controls.Add(txtTelefonoCliente);
            groupBox1.Controls.Add(txtNombreCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(256, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1082, 272);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            groupBox1.Enter += groupBox1_Enter;
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
            btnBuscar.Location = new Point(943, 238);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 29);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
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
            iconButton11.Location = new Point(447, 192);
            iconButton11.Name = "iconButton11";
            iconButton11.Size = new Size(125, 50);
            iconButton11.TabIndex = 33;
            iconButton11.Text = "Eliminar";
            iconButton11.UseVisualStyleBackColor = false;
            iconButton11.Click += iconButton11_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI Light", 12F);
            txtBuscar.Location = new Point(645, 238);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Nombre del Cliente";
            txtBuscar.Size = new Size(292, 29);
            txtBuscar.TabIndex = 30;
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
            iconButton8.Location = new Point(248, 192);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(125, 50);
            iconButton8.TabIndex = 32;
            iconButton8.Text = "Editar";
            iconButton8.UseVisualStyleBackColor = false;
            iconButton8.Click += iconButton8_Click;
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
            iconButton5.Location = new Point(50, 192);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(125, 50);
            iconButton5.TabIndex = 31;
            iconButton5.Text = "Guardar";
            iconButton5.UseVisualStyleBackColor = false;
            iconButton5.Click += iconButton5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(6, 120);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 29;
            label3.Text = "Dirección:";
            // 
            // txtDireccionCliente
            // 
            txtDireccionCliente.Font = new Font("Segoe UI Light", 12F);
            txtDireccionCliente.Location = new Point(102, 118);
            txtDireccionCliente.Name = "txtDireccionCliente";
            txtDireccionCliente.PlaceholderText = " Ingrese su dirección...";
            txtDireccionCliente.Size = new Size(483, 29);
            txtDireccionCliente.TabIndex = 28;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Font = new Font("Segoe UI Light", 12F);
            txtTelefonoCliente.Location = new Point(103, 80);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.PlaceholderText = " Ingrese su telefono...";
            txtTelefonoCliente.Size = new Size(483, 29);
            txtTelefonoCliente.TabIndex = 19;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Font = new Font("Segoe UI Light", 12F);
            txtNombreCliente.Location = new Point(103, 40);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.PlaceholderText = " Ingrese su nombre...";
            txtNombreCliente.Size = new Size(483, 29);
            txtNombreCliente.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(7, 80);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 16;
            label2.Text = "Teléfono:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(7, 40);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 15;
            label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvClientes);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(256, 290);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1082, 378);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de Productos";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 248, 240);
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(65, 36, 2);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(250, 238, 218);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(65, 36, 2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.Location = new Point(16, 28);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 62;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1060, 338);
            dgvClientes.TabIndex = 28;
            dgvClientes.CellContentClick += dgvUltimasVentas_CellContentClick;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1365, 765);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmClientes";
            Text = "FrmClientes";
            Load += FrmClientes_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox txtTelefonoCliente;
        private TextBox txtNombreCliente;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtDireccionCliente;
        private GroupBox groupBox2;
        private DataGridView dgvClientes;
        private FontAwesome.Sharp.IconButton iconButton11;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBuscar;
    }
}