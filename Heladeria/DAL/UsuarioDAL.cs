using Heladeria.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Heladeria.DAL
{
    public  class UsuarioDAL
    {
        Conexion conexion = new Conexion();

        public bool ValidarLoging(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand();
          
            cmd.Connection=conexion.AbrirConexion();
            cmd.CommandText = "SELECT * FROM USUARIO WHERE Nombre_Usuario=@usuario AND Clave=@clave AND Estado=1";

            cmd.Parameters.AddWithValue("@usuario",usuario.Nombre_Usuario);
            cmd.Parameters.AddWithValue("@clave", usuario.Clave);
           
            SqlDataReader reader= cmd.ExecuteReader();

            if (reader.Read())
            {
                Sesion.ID_Usuario = Convert.ToInt32(reader["ID_Usuario"]);

                Sesion.Nombre_Completo =
                reader["Nombre_Completo"].ToString();
                return true;
            }
            else
            {
                return false;
            }

            cmd.Connection=conexion.CerrarConexion();
          

        }
    }
}
