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
    public partial class FrmVentas : Form
    {
        private decimal totalventa = 0;
        private DataTable productos;
        private VentasBLL ventaBLL = new VentasBLL();
        private List<Detalle_Venta> detalleventa = new List<Detalle_Venta>();
        public FrmVentas()
        {
            InitializeComponent();
        }
        private void CargarVentasMes()
        {
            VentasBLL bll = new VentasBLL();
            dgvVentas.DataSource = bll.VentasDelMes();
        }
        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {

        }
        private void CargarClientes()
        {
            cmbCliente.DataSource =
            ventaBLL.CargarClientes();

            cmbCliente.DisplayMember = "Nombre";

            cmbCliente.ValueMember = "ID_Cliente";
        }
        private void CargarProductos()
        {
            productos =
            ventaBLL.CargarProductos();

            cmbProducto.DataSource = null;
            

            cmbProducto.DisplayMember =
            "Nombre_Producto";

            cmbProducto.ValueMember =
            "ID_Producto";
            cmbProducto.SelectedIndex = -1;
        }
        private void LimpiarFormulario()
        {
            dgvVentas.Rows.Clear();

            detalleventa.Clear();

            totalventa = 0;



            lblTotal.Text = "0.00";

            txtDineroRecibido.Clear();

            lblCambio.Text = "0.00";

            lblNumerodeFactura.Text =
            ventaBLL.ObtenerSiguienteFactura()
            .ToString();
        }
        private void RecalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Cells["colTotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["colTotal"].Value);
                }
            }

            lblTotal.Text = total.ToString("0.00");

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_IrInventario_frmPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarProductos();
            dtpFecha.Value = DateTime.Now;
            lblNumerodeFactura.Text = ventaBLL.ObtenerSiguienteFactura().ToString();
            txtVendedor.Text = Sesion.Nombre_Completo;

        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedValue != null &&
     cmbProducto.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                int idProducto = Convert.ToInt32(cmbProducto.SelectedValue);

                Producto producto = ventaBLL.ObtenerProductoPorId(idProducto);

                txtStock.Text = producto.Stock.ToString();
                txtPrecio.Text = producto.Precio_Base.ToString();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

            decimal precio = Convert.ToDecimal(txtPrecio.Text);

            int cantidad = Convert.ToInt32(nudCantidad.Value);

            decimal Subtotal = precio * cantidad;

            dgvVentas.Rows.Add(
                lblNumerodeFactura.Text,
                cmbProducto.Text,
                cantidad,
                dtpFecha.Text,
                cmbCliente.Text,
                txtVendedor.Text,
                Subtotal
            );

            Detalle_Venta detalle = new Detalle_Venta();

            detalle.ID_Producto =
            Convert.ToInt32(cmbProducto.SelectedValue);

            detalle.Cantidad = cantidad;

            detalle.Sub_Total = Convert.ToDouble(Subtotal);

            detalleventa.Add(detalle);

            totalventa += Subtotal;


            lblTotal.Text = totalventa.ToString("N2");
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();

            venta.Fecha = dtpFecha.Value;

            venta.Total = Convert.ToDouble(totalventa);

            venta.Metodo_Pago = cmbMetodoPago.Text;

            venta.ID_Cliente =
            Convert.ToInt32(cmbCliente.SelectedValue);

            venta.ID_Usuario = Sesion.ID_Usuario;

            int idVenta =
            ventaBLL.GuardarVenta(venta);

            foreach (Detalle_Venta detalle in detalleventa)
            {
                detalle.ID_Venta = idVenta;

                ventaBLL.GuardarDetalleVenta(detalle);

                ventaBLL.ActualizarStock(
                    detalle.ID_Producto,
                    detalle.Cantidad);
            }

            MessageBox.Show("Venta guardada correctamente");


            FrmMenuPrincipal frm = Application.OpenForms["FrmMenuPrincipal"] as FrmMenuPrincipal;

            if (frm != null)
            {
                frm.CargarDashboard();
            }

            CargarVentasMes();
            LimpiarFormulario();

        }

        private void txtDineroRecibido_TextChanged(object sender, EventArgs e)
        {
            decimal pago;

            if (decimal.TryParse(txtDineroRecibido.Text, out pago))
            {
                decimal cambio =
                pago - totalventa;

                lblCambio.Text =
                cambio.ToString("N2");
            }
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVentas.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un producto.");
                    return;
                }

                dgvVentas.Rows.RemoveAt(dgvVentas.CurrentRow.Index);

                RecalcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.ShowDialog();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.ShowDialog();
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
