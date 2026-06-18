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
        public void InsertarUsuario(Usuario u)
        
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Usuario(Nombre_Completo,Nombre_Usuario,Clave,Cargo,Estado) VALUES (@Nombre_Completo,@Nombre_Usuario,@Clave,@Cargo,@Estado)", conexion.AbrirConexion());

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
        NombreCompleto=@NombreCompleto,
        NombreUsuario=@NombreUsuario,
        Clave=@Clave,
        Rol=@Rol,
        Estado=@Estado
        WHERE IdUsuario=@IdUsuario", conexion.AbrirConexion());

            cmd.Parameters.AddWithValue("@IdUsuario", u.ID_Usuario);
            cmd.Parameters.AddWithValue("@NombreCompleto", u.Nombre_Completo);
            cmd.Parameters.AddWithValue("@NombreUsuario", u.Nombre_Usuario);
            cmd.Parameters.AddWithValue("@Clave", u.Clave);
            cmd.Parameters.AddWithValue("@Rol", u.Cargo);
            cmd.Parameters.AddWithValue("@Estado", u.Estado);

            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarUsuario(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE IdUsuario=@id", conexion.AbrirConexion());
            cmd.Parameters.AddWithValue("@id", id);

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
