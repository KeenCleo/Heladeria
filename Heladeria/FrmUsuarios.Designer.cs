namespace Heladeria
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            panel1 = new Panel();
            panel2 = new Panel();
            textBox7 = new TextBox();
            groupBox2 = new GroupBox();
            dgvUltimasVentas = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colUsuario = new DataGridViewTextBoxColumn();
            colRol = new DataGridViewTextBoxColumn();
            colEstado = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            iconButton11 = new FontAwesome.Sharp.IconButton();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
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
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1100, 729);
            panel2.TabIndex = 1;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI Light", 12F);
            textBox7.Location = new Point(876, 395);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = " Buscar usuario...";
            textBox7.Size = new Size(206, 29);
            textBox7.TabIndex = 29;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvUltimasVentas);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(6, 417);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1082, 300);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de Usuarios";
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
            dgvUltimasVentas.Columns.AddRange(new DataGridViewColumn[] { colID, colNombre, colUsuario, colRol, colEstado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(250, 238, 218);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(65, 36, 2);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUltimasVentas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUltimasVentas.Location = new Point(14, 28);
            dgvUltimasVentas.Name = "dgvUltimasVentas";
            dgvUltimasVentas.ReadOnly = true;
            dgvUltimasVentas.RowHeadersVisible = false;
            dgvUltimasVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUltimasVentas.Size = new Size(1062, 255);
            dgvUltimasVentas.TabIndex = 28;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colID.FillWeight = 203.045685F;
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Width = 80;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNombre.FillWeight = 103.325485F;
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 220;
            // 
            // colUsuario
            // 
            colUsuario.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colUsuario.FillWeight = 167.295044F;
            colUsuario.HeaderText = "Usuario";
            colUsuario.Name = "colUsuario";
            colUsuario.ReadOnly = true;
            colUsuario.Width = 150;
            // 
            // colRol
            // 
            colRol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colRol.FillWeight = 18.00486F;
            colRol.HeaderText = "Rol";
            colRol.Name = "colRol";
            colRol.ReadOnly = true;
            colRol.Resizable = DataGridViewTriState.True;
            colRol.Width = 60;
            // 
            // colEstado
            // 
            colEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colEstado.FillWeight = 8.328922F;
            colEstado.HeaderText = "Estado";
            colEstado.Name = "colEstado";
            colEstado.ReadOnly = true;
            colEstado.Width = 200;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(iconButton11);
            groupBox1.Controls.Add(iconButton8);
            groupBox1.Controls.Add(iconButton5);
            groupBox1.Controls.Add(iconButton4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label12);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(6, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1082, 377);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Usuario";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Light", 12F);
            textBox4.Location = new Point(166, 259);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = " Ingrese estado...";
            textBox4.Size = new Size(394, 29);
            textBox4.TabIndex = 32;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Light", 12F);
            textBox5.Location = new Point(166, 211);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = " Ingrese su puesto de trabajo...";
            textBox5.Size = new Size(394, 29);
            textBox5.TabIndex = 31;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI Light", 12F);
            textBox6.Location = new Point(166, 165);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = " Ingrese su contraseña...";
            textBox6.Size = new Size(394, 29);
            textBox6.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(14, 262);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 29;
            label3.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(14, 214);
            label4.Name = "label4";
            label4.Size = new Size(39, 21);
            label4.TabIndex = 28;
            label4.Text = "Rol:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(6, 168);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 27;
            label5.Text = "Contraseña:";
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
            iconButton11.Location = new Point(461, 301);
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
            iconButton8.Location = new Point(316, 301);
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
            iconButton5.Location = new Point(166, 301);
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
            iconButton4.Location = new Point(18, 301);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(125, 50);
            iconButton4.TabIndex = 12;
            iconButton4.Text = "Ingresar";
            iconButton4.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Light", 12F);
            textBox3.Location = new Point(166, 122);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = " Ingrese su usuario...";
            textBox3.Size = new Size(394, 29);
            textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Light", 12F);
            textBox2.Location = new Point(166, 74);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = " Ingrese su nombre completo...";
            textBox2.Size = new Size(394, 29);
            textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Light", 12F);
            textBox1.Location = new Point(166, 28);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Ingrese su codigo...";
            textBox1.Size = new Size(145, 29);
            textBox1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(6, 125);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 16;
            label2.Text = "Usuario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(6, 77);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
            label1.TabIndex = 15;
            label1.Text = "Nombre Completo:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(6, 31);
            label12.Name = "label12";
            label12.Size = new Size(94, 21);
            label12.TabIndex = 14;
            label12.Text = "ID Usuario:";
            label12.TextAlign = ContentAlignment.BottomRight;
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
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuarios";
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

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label3;
        private Label label4;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButton11;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label12;
        private TextBox textBox7;
        private GroupBox groupBox2;
        private DataGridView dgvUltimasVentas;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colRol;
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