using Heladeria.DAL;
using Heladeria.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Heladeria.BLL
{
    public class VentasBLL
    {
        public int ObtenerSiguienteFactura()
        {
            VentasDAL ventaDAL = new VentasDAL();

            return ventaDAL.ObtenerSiguienteFactura();
        }

        public DataTable CargarClientes()
        {
            VentasDAL ventaDAL = new VentasDAL();

            return ventaDAL.CargarClientes();
        }

        public DataTable CargarProductos()
        {
          VentasDAL ventaDAL = new VentasDAL();

          return ventaDAL.CargarProductos();
        }

        public Producto ObtenerProductoPorId(int idProducto)
        {
            VentasDAL ventaDAL = new VentasDAL();

            return ventaDAL.ObtenerProductoporId(idProducto);
        }



        public int GuardarVenta(Venta venta)
        {
            VentasDAL ventaDAL = new VentasDAL();

            return ventaDAL.GuardarVenta(venta);
        }

        public void GuardarDetalleVenta(Detalle_Venta detalle)
        {
            VentasDAL ventaDAL = new VentasDAL();

            ventaDAL.GuardarDetalleVenta(detalle);
        }

        public void ActualizarStock(int idProducto, int cantidad)
        {
            VentasDAL ventaDAL = new VentasDAL();

           ventaDAL.ActualizarStock(idProducto, cantidad);
        }

        public int VentasHoy()
        {
            VentasDAL ventaDAL = new VentasDAL();
            return ventaDAL.VentasHoy();
        }

        public decimal TotalDineroHoy()
        {
            VentasDAL ventaDAL = new VentasDAL();
            return ventaDAL.TotalDineroHoy();
        }

        public DataTable VentasDelMes()
        {
            VentasDAL ventaDAL = new VentasDAL();
            return ventaDAL.VentasDelMes();
        }

        


    }
}
