using System;
using System.Collections.Generic;
using System.Text;

namespace Heladeria.Entidades
{
    public  class Detalle_Venta
    {
        public int ID_Detalle_Venta {  get; set; }
        public int Cantidad { get; set; }
        public double Sub_Total {  get; set; }
        public int ID_Venta { get; set; }
        public int ID_Producto {  get; set; }
    }
}
