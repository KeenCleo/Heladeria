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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Fecha_Menu_Principal_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
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
    }
}
