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
            cmd.CommandText = "SELECT ID_Producto, Nombre_Producto, Stock, Precio_Base FROM Producto";
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
            cmd.CommandText = "INSERT INTO Producto (Nombre_Producto, Stock, Precio_Base, Fecha_Caducidad) VALUES (@Nombre_Producto,@Stock,@Precio_Base, @Fecha_Caducidad)";
            
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
            cmd.CommandText = "UPDATE PRODUCTO SET Nombre_Producto = @Nombre_Producto, Stock = @Stock, Precio_Base = @Precio_Base, Fecha_Caducidad = @Fecha_Caducidad WHERE ID_Producto = @ID_Producto";
            cmd.Parameters.AddWithValue("@ID_Producto", producto.ID_Producto);
            cmd.Parameters.AddWithValue("@Nombre_Producto", producto.Nombre_Producto);
            cmd.Parameters.AddWithValue("@Stock", producto.Stock);
            cmd.Parameters.AddWithValue("@Precio_Base", producto.Precio_Base);
            cmd.Parameters.AddWithValue("@Fecha_Caducidad", producto.Fecha_Caducidad);
            cmd.ExecuteNonQuery();
            cone.CerrarConexion();
        }
        public void EliminarProducto(int idseleccionado)
        {
            Conexion cone = new Conexion();
            SqlCommand cmd= new SqlCommand();
            cmd.Connection = cone.AbrirConexion();

            cmd.CommandText = "DELETE FROM PRODUCTO WHERE ID_Producto =  @ID_Producto";
            cmd.Parameters.AddWithValue("@ID_Producto", idseleccionado);

            cmd.ExecuteNonQuery();
            cone.CerrarConexion();
        }
        public DataTable BuscarProducto(string nombre) 
        {
            DataTable dt = new DataTable();
            Conexion con = new Conexion();
            SqlCommand cmd= new SqlCommand();

            cmd.Connection=con.AbrirConexion();
            cmd.CommandText = "SELECT ID_Producto , Nombre_Producto, Stock , Precio_Base, Fecha_Caducidad FROM Producto WHERE Nombre_Producto LIKE @TEXT";
            cmd.Parameters.AddWithValue("@TEXT", "%" + nombre + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.CerrarConexion();
            return dt;

        }
        public DataTable MostrarInventario()
        {
            Conexion con = new Conexion();

            SqlDataAdapter da = new SqlDataAdapter(@"
        SELECT 
            Nombre_Producto,
            Stock
        FROM Producto
    ", con.AbrirConexion());

            DataTable dt = new DataTable();
            da.Fill(dt);

            con.CerrarConexion();

            return dt;
        }


    }
}
