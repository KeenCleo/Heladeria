using Heladeria.BLL;
using Heladeria.DAL;
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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        public void CargarDash()
        {
            VentasBLL ventaBLL = new VentasBLL();
            ProductosBLL productoBLL = new ProductosBLL();
            ClienteBLL clienteBLL = new ClienteBLL();

            lblVentasHoy.Text = ventaBLL.VentasHoy().ToString();
            lblDineroHoy.Text = ventaBLL.TotalDineroHoy().ToString();
            dgvVentasDelMes.DataSource = ventaBLL.VentasDelMes();

            DataTable dt = productoBLL.ProductoMasVendido();

            if (dt.Rows.Count > 0)
            {
                lblProductoTop.Text = dt.Rows[0]["Nombre_Producto"].ToString();

            }
            lblClientes.Text = clienteBLL.TotalClientes().ToString();
            lblStock.Text = productoBLL.TotalStock().ToString();

        }
        public void CargarDashboard()
        {
            VentasBLL ventaBLL = new VentasBLL();
            ClienteBLL clienteBLL = new ClienteBLL();
            ProductosBLL productoBLL = new ProductosBLL();

            lblVentasHoy.Text = ventaBLL.VentasHoy().ToString();
            lblDineroHoy.Text = ventaBLL.TotalDineroHoy().ToString("0.00");
            lblClientes.Text = clienteBLL.TotalClientes().ToString();
            lblStock.Text = productoBLL.TotalStock().ToString();

            dgvVentasDelMes.DataSource = ventaBLL.VentasDelMes();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Fecha_Menu_Principal_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_BienvenidoUsuario.Text = Sesion.Nombre_Completo.ToString();

            CargarDash();
            CargarDashboard();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Fecha_Menu_Principal.Text = DateTime.Now.ToLongDateString();
            lbl_Hora_MenuPrincipal.Text = DateTime.Now.ToString("HH:mm:ss");
        }



        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_FrmPrincipal_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿ Desea salir del sistema ?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btn_irVenta_frmPrincipal_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();
            frm.ShowDialog();

        }

        private void btn_irProducto_frmPrincipal_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.ShowDialog();


        }

        private void btn_IrCliente_frmPrincipal_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.ShowDialog();

        }

        private void btn_IrInventario_frmPrincipal_Click(object sender, EventArgs e)
        {
            FrmInventarios frm = new FrmInventarios();
            frm.ShowDialog();

        }

        private void btn_IrUsuarios_frmPrincipal_Click(object sender, EventArgs e)
        {
            FrmUsuarios frm = new FrmUsuarios();
            frm.ShowDialog();

        }

        private void lblProductoTop_Click(object sender, EventArgs e)
        {

        }

        private void lblDineroHoy_Click(object sender, EventArgs e)
        {

        }
    }
}
