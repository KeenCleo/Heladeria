    using Heladeria.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Heladeria.DAL
{
    public  class VentasDAL
    {
        public int ObtenerSiguienteFactura()
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SP_ObtenerSiguienteFactura";
            cmd.CommandType = CommandType.StoredProcedure;

            int factura = Convert.ToInt32(cmd.ExecuteScalar());

            con.CerrarConexion();
            return factura;

        }
        public DataTable CargarClientes()
        {
            DataTable dt = new DataTable();
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SP_CargarClientes";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            con.CerrarConexion();
            return dt;
        }
        public DataTable CargarProductos()
        {
            DataTable dt = new DataTable();
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SP_CargarProductosVenta";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            con.CerrarConexion();
            return dt;
        }

        public Producto ObtenerProductoporId(int ID_Producto)
        {
            Producto producto = new Producto();
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SP_ObtenerProductoPorId";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Producto", ID_Producto);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                producto.ID_Producto = Convert.ToInt32(dr["ID_Producto"]);
                producto.Nombre_Producto = dr["Nombre_Producto"].ToString();
                producto.Stock = Convert.ToInt32(dr["Stock"]);
                producto.Precio_Base = Convert.ToDecimal(dr["Precio_Base"]);
            }

            con.CerrarConexion();
            return producto;
        }
        public int GuardarVenta(Venta venta)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SP_GuardarVenta";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Total", venta.Total);
            cmd.Parameters.AddWithValue("@Metodo_Pago", venta.Metodo_Pago);
            cmd.Parameters.AddWithValue("@ID_Cliente", venta.ID_Cliente);
            cmd.Parameters.AddWithValue("@ID_Usuario", venta.ID_Usuario);

            int idVenta = Convert.ToInt32(cmd.ExecuteScalar());

            con.CerrarConexion();
            return idVenta;
        }
        public void GuardarDetalleVenta(Detalle_Venta detalle)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SP_GuardarDetalleVenta";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
            cmd.Parameters.AddWithValue("@Sub_Total", detalle.Sub_Total);
            cmd.Parameters.AddWithValue("@ID_Venta", detalle.ID_Venta);
            cmd.Parameters.AddWithValue("@ID_Producto", detalle.ID_Producto);

            cmd.ExecuteNonQuery();
            con.CerrarConexion();
        }
        public void ActualizarStock(int ID_Producto, int cantidad)
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SP_ActualizarStock";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_Producto", ID_Producto);
            cmd.Parameters.AddWithValue("@Cantidad", cantidad);

            cmd.ExecuteNonQuery();
            con.CerrarConexion();
        }

        public int VentasHoy()
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SP_VentasHoy";
            cmd.CommandType = CommandType.StoredProcedure;

            int total = Convert.ToInt32(cmd.ExecuteScalar());

            con.CerrarConexion();
            return total;
        }

        public decimal TotalDineroHoy()
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SP_TotalDineroHoy";
            cmd.CommandType = CommandType.StoredProcedure;

            decimal total = Convert.ToDecimal(cmd.ExecuteScalar());

            con.CerrarConexion();
            return total;
        }

        public DataTable VentasDelMes()
        {
            Conexion con = new Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.AbrirConexion();
            cmd.CommandText = "SP_VentasDelMes";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.CerrarConexion();
            return dt;
        }



    }

    
}
