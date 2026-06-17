using Heladeria.DAL;
using Heladeria.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

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

        public void EliminarProducto(Producto producto)
        {
            ProductosDAL productosDAL = new ProductosDAL();
            productosDAL.EliminarProducto(producto);
        }
    }
}
