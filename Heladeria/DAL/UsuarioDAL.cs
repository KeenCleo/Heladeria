using Heladeria.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
            cmd.CommandText = "SP_ValidarLogin";
            cmd.CommandType= CommandType.StoredProcedure;

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

          conexion.CerrarConexion();
        }
        public void InsertarUsuario(Usuario u)
        
        {
            SqlCommand cmd = new SqlCommand("SP_InsertarUsuario", conexion.AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Nombre_Completo", u.Nombre_Completo);
            cmd.Parameters.AddWithValue("@Nombre_Usuario", u.Nombre_Usuario);
            cmd.Parameters.AddWithValue("@Clave", u.Clave);
            cmd.Parameters.AddWithValue("@Cargo", u.Cargo);
            cmd.Parameters.AddWithValue("@Estado", u.Estado);

            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
        public void EditarUsuario(Usuario u)
        {
            SqlCommand cmd = new SqlCommand(@"
        UPDATE Usuario SET
        Nombre_Completo=@Nombre_Completo,
        Nombre_Usuario=@Nombre_Usuario,
        Clave=@Clave,
        Cargo=@Cargo,
        Estado=@Estado
        WHERE ID_Usuario=@ID_Usuario", conexion.AbrirConexion());

            cmd.Parameters.AddWithValue("@ID_Usuario", u.ID_Usuario);
            cmd.Parameters.AddWithValue("@Nombre_Completo", u.Nombre_Completo);
            cmd.Parameters.AddWithValue("@Nombre_Usuario", u.Nombre_Usuario);
            cmd.Parameters.AddWithValue("@Clave", u.Clave);
            cmd.Parameters.AddWithValue("@Cargo", u.Cargo);
            cmd.Parameters.AddWithValue("@Estado", u.Estado);

            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarUsuario(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE ID_Usuario=@ID_Usuario", conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@ID_Usuario", id);

            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public DataTable MostrarUsuarios()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Usuario", conexion.AbrirConexion());

            DataTable dt = new DataTable();
            da.Fill(dt);

            conexion.CerrarConexion();
            return dt;
        }
    }
}
