using Heladeria.DAL;
using Heladeria.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Heladeria.BLL
{
    public class UsuarioBLL
    {
        public bool IniciarSesion(Usuario usuario)
        {
            UsuarioDAL userDAL = new UsuarioDAL();

            if (string.IsNullOrWhiteSpace(usuario.Nombre_Usuario))
            {
                throw new Exception("Ingrese el usuario");
            }

            if (string.IsNullOrWhiteSpace(usuario.Clave))
            {
                throw new Exception("Ingrese la clave");
            }
            return userDAL.ValidarLoging(usuario);
            
        }
            UsuarioDAL dal = new UsuarioDAL();

            public void Insertar(Usuario u) => dal.InsertarUsuario(u);
            public void Editar(Usuario u) => dal.EditarUsuario(u);
            public void Eliminar(int id) => dal.EliminarUsuario(id);
            public DataTable Mostrar() => dal.MostrarUsuarios();
    }
}
