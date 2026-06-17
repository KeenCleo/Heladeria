using Heladeria.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Security.Policy;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Heladeria.DAL
{
    public class ClienteDAL
    {
        public void InsertarCliente(Cliente cliente )
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection=con.AbrirConexion();

            cmd.CommandText = "INSERT INTO Cliente (Nombre, Telefono , Direccion) VALUES (@Nombre, @Telefono,@Direccion);";

            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);

            cmd.ExecuteNonQuery();

            con.CerrarConexion();

        }

        public void EditarCliente(Cliente cliente)
        {
            Conexion con =new Conexion();
            SqlCommand cmd =new SqlCommand();

            cmd.Connection= con.AbrirConexion();

            cmd.CommandText = "UPDATE Cliente SET Nombre=@Nombre, Telefono=@Telefono, Direccion = @Direccion WHERE ID_Cliente=@ID_Cliente; ";
            cmd.Parameters.AddWithValue("@Nombre ", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Telefono ", cliente.Telefono);
            cmd.Parameters.AddWithValue("@Direccion ", cliente.Direccion);
            cmd.Parameters.AddWithValue("ID_Cliente ", cliente.ID_Cliente);

            cmd.ExecuteNonQuery();
            con.CerrarConexion();

        }
        public void EliminarCliente(int idcliente)
        {
            Conexion con = new Conexion();

            SqlCommand cmd = new SqlCommand();
            Cliente cliente = new Cliente();
            cliente.ID_Cliente = idcliente;

            cmd.Connection = con.AbrirConexion();

            cmd.CommandText = "DELETE FROM Cliente WHERE ID_Cliente = @idcliente";

            cmd.Parameters.AddWithValue("@idcliente", cliente.ID_Cliente);

            cmd.ExecuteNonQuery();

            con.CerrarConexion();

        }

        public DataTable MostrarCliente()
        {
            Conexion con = new Conexion();
           
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cliente", con.AbrirConexion());

            DataTable dt = new DataTable();
            da.Fill(dt);

            con.CerrarConexion();

            return dt;


        }

        public DataTable BuscarCliente(string texto)
        {
            Conexion con =new Conexion();
            SqlDataAdapter dap = new SqlDataAdapter();
            DataTable tabla = new DataTable();

            SqlCommand cmd =new SqlCommand();

            cmd.Connection=con.AbrirConexion();

            cmd.CommandText = @"SELECT * 
                        FROM Cliente 
                        WHERE Nombre LIKE @Texto";

            cmd.Parameters.AddWithValue("@Texto", "%" + texto + "%");

            dap.SelectCommand = cmd;
            dap.Fill(tabla);

            con.CerrarConexion();

            return tabla;

        }
    }
}
