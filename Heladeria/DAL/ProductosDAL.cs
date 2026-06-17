using Heladeria.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Heladeria.DAL
{
    public class ProductosDAL
    {
        public DataTable MostrarProductos()
        {
            Conexion con = new Conexion();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SELECT ID_Producto, Nombre, Stock, Precio FROM Producto";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.CerrarConexion();
            return dt;
        }
        public void GuardarProducto(Producto producto) 
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "INSERT INTO Producto (Nombre_Producto, Stock, Precio_Base, Fecha_Caducidad) VALUES (@Nombre_Producto,@Stock,@Precio_Base, @Fecha_Caducidad";
            
            cmd.Parameters.AddWithValue ("@Nombre_Producto", producto.Nombre_Producto);
            cmd.Parameters.AddWithValue("@Stock", producto.Stock);
            cmd.Parameters.AddWithValue("@Precio_Base", producto.Precio_Base);
            cmd.Parameters.AddWithValue("@Fecha_Caducidad", producto.Fecha_Caducidad);

            cmd.ExecuteNonQuery();

            con.CerrarConexion();   
        }


        
        public void EditarProducto(Producto producto)
        {
            Conexion cone= new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cone.AbrirConexion();
            cmd.CommandText = "UPDATE PRODUCTO SED Nombre_Producto = @Nombre_Producto, Stock = @Stock, Precio_Base = @Precio_Base, Fecha_Caducidad = @Fecha_Caducidad WHERE ID_Producto = @ID_Producto";
            cmd.Parameters.AddWithValue("@ID_Producto", producto.ID_Producto);
            cmd.Parameters.AddWithValue("@Nombre_Producto", producto.Nombre_Producto);
            cmd.Parameters.AddWithValue("@Stock", producto.Stock);
            cmd.Parameters.AddWithValue("@Precio_Base", producto.Precio_Base);
            cmd.Parameters.AddWithValue("@Fecha_Caducidad", producto.Fecha_Caducidad);
            cmd.ExecuteNonQuery();
            cone.CerrarConexion();
        }
        public void EliminarProducto(Producto producto)
        {
            Conexion cone = new Conexion();
            SqlCommand cmd= new SqlCommand();
            cmd.Connection = cone.AbrirConexion();

            cmd.CommandText = "DELETE FROM PRODUCTO WHERE ID_Producto =  @ID_Producto";
            cmd.Parameters.AddWithValue("@ID_Producto", producto.ID_Producto);

            cmd.ExecuteNonQuery();
            cone.CerrarConexion();
        }
        public DataTable BuscarProducto(String Nombre) 
        {
            DataTable dt = new DataTable();
            Conexion con = new Conexion();
            SqlCommand cmd= new SqlCommand();

            cmd.Connection=con.AbrirConexion();
            cmd.CommandText = "SELECT ID_Producto , Nombre_Producto, Stock , Preccio_Basse, Fecha_Caducidad FROM Producto WHERE Nombre_Producto LIKE @TEXT";
            cmd.Parameters.AddWithValue("@TEXT", "%" + Nombre + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.CerrarConexion();
            return dt;

        }
    }
}
