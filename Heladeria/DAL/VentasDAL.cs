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

            cmd.CommandText =
            "SELECT ISNULL(MAX(ID_Venta),0)+1 FROM Venta";

            int factura =
            Convert.ToInt32(cmd.ExecuteScalar());

            con.CerrarConexion();

            return factura;

        }
        public DataTable CargarClientes()
        {
            DataTable dt = new DataTable();

            Conexion con = new Conexion();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con.AbrirConexion();

            cmd.CommandText = "SELECT ID_Cliente, Nombre FROM Cliente";

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

            cmd.CommandText = "SELECT ID_Producto, Nombre_Producto, Precio_Base,Stock FROM Producto";

            SqlDataAdapter da =
            new SqlDataAdapter(cmd);

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
            cmd.CommandText = "SELECT *FROM Producto WHERE ID_Producto=@ID";
            cmd.Parameters.AddWithValue("@ID", ID_Producto);

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

            cmd.CommandText = "INSERT INTO Venta(Fecha, Total,Metodo_Pago, ID_Cliente, ID_Usuario) VALUES (@Fecha, @Total, @MetodoPago, @IDCliente, @IDUsuario); SELECT SCOPE_IDENTITY();";

            cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);

            cmd.Parameters.AddWithValue("@Total", venta.Total);

            cmd.Parameters.AddWithValue("@MetodoPago", venta.Metodo_Pago);

            cmd.Parameters.AddWithValue("@IDCliente", venta.ID_Cliente);

            cmd.Parameters.AddWithValue("@IDUsuario", venta.ID_Usuario);

            int idVenta = Convert.ToInt32(cmd.ExecuteScalar());

            con.CerrarConexion();

            return idVenta;
        }
        public void GuardarDetalleVenta(Detalle_Venta detalle)
        {
            Conexion con = new Conexion();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con.AbrirConexion();

            cmd.CommandText = "INSERT INTO Detalle_Venta ( Cantidad, Sub_Total, ID_Venta, ID_Producto) VALUES ( @Cantidad,  @SubTotal, @ID_Venta,@IDProducto)";

            cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);

            cmd.Parameters.AddWithValue("@SubTotal", detalle.Sub_Total);

            cmd.Parameters.AddWithValue("@ID_Venta", detalle.ID_Venta);

            cmd.Parameters.AddWithValue("@IDProducto", detalle.ID_Producto);

            cmd.ExecuteNonQuery();

            con.CerrarConexion();
        }
        public void ActualizarStock(int ID_Producto, int cantidad)
        {
            Conexion con = new Conexion();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = con.AbrirConexion();

            cmd.CommandText = "UPDATE Producto SET Stock = Stock - @Cantidad WHERE ID_Producto=@ID";



            cmd.Parameters.AddWithValue("@Cantidad", cantidad);

            cmd.Parameters.AddWithValue("@ID", ID_Producto);

            cmd.ExecuteNonQuery();

            con.CerrarConexion();
        }

        /*public DataTable MostrarVentas(string numerofactura)
        {

        }
        public DataTable MostrarUltimasVentas()
        {

        }*/
    }
}
