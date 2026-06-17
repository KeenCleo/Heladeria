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
    public partial class FrmClientes : Form
    {
        ClienteBLL clienteBLL = new ClienteBLL();
        private int idClienteSeleccionado = 0;
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void CargarClientes()
        {
            ClienteBLL clienteBLL = new ClienteBLL();
            dgvClientes.DataSource = clienteBLL.MostrarClientes();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nombre = txtNombreCliente.Text;
                cliente.Telefono = txtTelefonoCliente.Text;
                cliente.Direccion = txtDireccionCliente.Text;

                ClienteBLL clienteBLL = new ClienteBLL();

                clienteBLL.InsertarCliente(cliente);

                CargarClientes();

                MessageBox.Show("Cliente Guardado Correctamente");

                txtDireccionCliente.Clear();
                txtNombreCliente.Clear();
                txtTelefonoCliente.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dgvUltimasVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idClienteSeleccionado = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["ID_Cliente"].Value);

                txtNombreCliente.Text =
                dgvClientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                txtTelefonoCliente.Text =
                dgvClientes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();

                txtDireccionCliente.Text =
                dgvClientes.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.ID_Cliente = idClienteSeleccionado;
            cliente.Nombre = txtNombreCliente.Text;
            cliente.Telefono = txtTelefonoCliente.Text;
            cliente.Direccion = txtDireccionCliente.Text;

            ClienteBLL clienteBLL = new ClienteBLL();

            clienteBLL.EditarCliente(cliente);

            MessageBox.Show("Cliente actualizado");

            CargarClientes();



        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione al cliemte que desea eliminar ");
                    return;
                }


                int fila = dgvClientes.CurrentRow.Index;
                int Id_Cliente = Convert.ToInt32(dgvClientes.Rows[fila].Cells["ID_Cliente"].Value);

                DialogResult resultado = MessageBox.Show("Seguro que desea Eliminar Al clientye?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    ClienteBLL clienteBLL = new ClienteBLL();
                    clienteBLL.EliminarCliente(Id_Cliente);
                    MessageBox.Show("Cliente Eliminado Correctamente");
                    CargarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            CargarClientes();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteBLL clienteBLL = new ClienteBLL();
                dgvClientes.DataSource = clienteBLL.BuscarCLiente(txtBuscar.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            CargarClientes();
        }

        
    }
}

