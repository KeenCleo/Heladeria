using Heladeria.DAL;
using Heladeria.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Heladeria.BLL
{
    internal class ProductosBLL
    {
        public DataTable MostrarProducto() 
        {
            ProductosDAL productosDAL = new ProductosDAL();
            return productosDAL.MostrarProductos();

        }

        public void GuardarProducto(Producto producto)
        {
            ProductosDAL productosDAL = new ProductosDAL();
            productosDAL.GuardarProducto(producto);
        }

        public void EditarProducto(Producto producto)
        {
            ProductosDAL productosDAL = new ProductosDAL();
            productosDAL.EditarProducto(producto);  
        }

        public void EliminarProducto(int idProductoSeleccionado)
        {
            Producto producto = new Producto();
            ProductosDAL productosDAL = new ProductosDAL();
            productosDAL.EliminarProducto(idProductoSeleccionado);
        }

        public DataTable BuscarProductos(string nombre)
        {
            ProductosDAL productosDAL = new ProductosDAL();

            return productosDAL.BuscarProducto(nombre);
        }
        public DataTable MostrarInventario()
        {
            ProductosDAL dal = new ProductosDAL();
            DataTable dt = dal.MostrarInventario();

            
            dt.Columns.Add("Estado");

            foreach (DataRow row in dt.Rows)
            {
                int stock = Convert.ToInt32(row["Stock"]);

                if (stock <= 5)
                    row["Estado"] = "Bajo";
                else if (stock <= 15)
                    row["Estado"] = "Medio";
                else
                    row["Estado"] = "Alto";
            }

            return dt;
        }

    }
}
