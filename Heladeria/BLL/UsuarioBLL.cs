using Heladeria.DAL;
using Heladeria.Entidades;
using System;
using System.Collections.Generic;
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
    }
}
