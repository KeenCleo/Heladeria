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

            cmd.CommandText = "SP_MostrarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
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
            cmd.CommandText = "SP_GuardarProducto";
            cmd.CommandType = CommandType.StoredProcedure;

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
            cmd.CommandText = "SP_EditarProducto";
            cmd.CommandType = CommandType.StoredProcedure;
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

            cmd.CommandText = "SP_EliminarProducto";
            cmd.CommandType = CommandType.StoredProcedure;
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
            cmd.CommandText = "SP_BuscarProducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Texto", "%" + nombre + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.CerrarConexion();
            return dt;

        }
        public DataTable MostrarInventario()
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SP_MostrarInventario";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.CerrarConexion();
            return dt;
        }

        public DataTable ProductoMasVendido()
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SP_ProductoMasVendido";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.CerrarConexion();
            return dt;
        }
        public int TotalStock()
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SP_TotalStock";
            cmd.CommandType = CommandType.StoredProcedure;

            int total = Convert.ToInt32(cmd.ExecuteScalar());

            con.CerrarConexion();
            return total;
        }




    }
}
