using Heladeria.BLL;
using Heladeria.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Heladeria
{
    public partial class FrmProductos : Form
    {
        private int idProductoSeleccionado = 0;
        public void CargarProductos()
        {
            ProductosBLL productosBLL = new ProductosBLL();
            dgvProductos.DataSource = productosBLL.MostrarProducto();
        }
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            ProductosBLL productosBLL = new ProductosBLL();

            dgvProductos.DataSource =
                productosBLL.BuscarProductos(txtBuscar.Text);
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre_Producto = txtNombre.Text;
            producto.Precio_Base = decimal.Parse(txtPrecio.Text);
            producto.Stock = int.Parse(txtStock.Text);
            producto.Fecha_Caducidad = dtpFecha.Value;
            ProductosBLL productosBLL = new ProductosBLL();

            productosBLL.GuardarProducto(producto);
            MessageBox.Show("Producto guardado exitosamente.");
            CargarProductos();

            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {

            Producto producto = new Producto();
            producto.ID_Producto = idProductoSeleccionado;

            producto.Nombre_Producto = txtNombre.Text;
            producto.Stock = Convert.ToInt32((txtStock.Text));
            producto.Precio_Base = decimal.Parse(txtPrecio.Text);
            producto.Fecha_Caducidad = dtpFecha.Value;

            ProductosBLL productosBLL = new ProductosBLL();
            productosBLL.EditarProducto(producto);

            MessageBox.Show("Producto editado exitosamente.");
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            CargarProductos();



        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
                return;
            }
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ProductosBLL ProductoBll = new ProductosBLL();
                ProductoBll.EliminarProducto(idProductoSeleccionado);
                MessageBox.Show("Producto eliminado exitosamente.");
                txtNombre.Clear();
                txtPrecio.Clear();
                txtStock.Clear();
                CargarProductos();
                idProductoSeleccionado = 0;
            }


        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idProductoSeleccionado = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["ID_Producto"].Value);

                txtNombre.Text = dgvProductos.Rows[e.RowIndex].Cells["Nombre_Producto"].Value.ToString();

                txtStock.Text = dgvProductos.Rows[e.RowIndex].Cells["Stock"].Value.ToString();

                txtPrecio.Text = dgvProductos.Rows[e.RowIndex].Cells["Precio_Base"].Value.ToString();
            }
        }
    }
}
