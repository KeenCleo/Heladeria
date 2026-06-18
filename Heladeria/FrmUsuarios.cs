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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        private void CargarUsuarios()
        {
            UsuarioBLL bll = new UsuarioBLL();
            dgvUsuarios.DataSource = bll.Mostrar();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();

            u.Nombre_Completo = txtNombreCompleto.Text;
            u.Nombre_Usuario = txtNombreUsuario.Text;
            u.Clave = txtContraseña.Text;
            u.Cargo = cmbCargo.Text;
            u.Estado = Convert.ToBoolean(cmbEstado.Text == "Activo" ? 1 : 0);

            UsuarioBLL bll = new UsuarioBLL();
            bll.Insertar(u);

            MessageBox.Show("Usuario guardado");

            CargarUsuarios();

        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            (dgvUsuarios.DataSource as DataTable).DefaultView.RowFilter =
      $"NombreUsuario LIKE '%{txtBuscar.Text}%'";
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();

            u.ID_Usuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
            u.Nombre_Completo = txtNombreCompleto.Text;
            u.Nombre_Usuario = txtNombreUsuario.Text;
            u.Clave = txtContraseña.Text;
            u.Cargo = cmbCargo.Text;
            u.Estado = Convert.ToBoolean(cmbEstado.Text == "Activo" ? 1 : 0);

            UsuarioBLL bll = new UsuarioBLL();
            bll.Editar(u);

            MessageBox.Show("Usuario actualizado");

            CargarUsuarios();

        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);

            UsuarioBLL bll = new UsuarioBLL();
            bll.Eliminar(id);

            MessageBox.Show("Usuario eliminado");

            CargarUsuarios();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
    }
}
