using Heladeria.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Heladeria
{
    public partial class FrmInventarios : Form
    {
        public FrmInventarios()
        {
            InitializeComponent();
        }
        private void CargarInventario()
        {
            ProductosBLL bll = new ProductosBLL();
            dgvInventario.DataSource = bll.MostrarInventario();
        }

        private void FrmInventarios_Load(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void iconButton12_Click(object sender, EventArgs e)
        { 
        }
            private void btnBuscar_Click(object sender, EventArgs e)
        {
            ProductosBLL bll = new ProductosBLL();
            DataTable dt = bll.MostrarInventario();

            DataView dv = dt.DefaultView;
            dv.RowFilter = $"NombreProducto LIKE '%{txtBuscar.Text}%'";

            dgvInventario.DataSource = dv;
        }
       
    }
    
}
