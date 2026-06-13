using System;
using System.Collections.Generic;
using System.Text;

namespace Heladeria.Entidades
{
    public class Producto
    {
        public int ID_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public decimal Precio_Base { get; set; }
        public int Stock { get; set; }

        public DateTime Fecha_Caducidad {  get; set; }
    }
}
