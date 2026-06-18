using System;
using System.Collections.Generic;
using System.Text;

namespace Heladeria.Entidades
{
    public class Venta
    {
        public int ID_Venta {  get; set; }
        public DateTime Fecha {  get; set; }
        public double Total { get; set; }
        public string Metodo_Pago { get; set; }
        public int ID_Cliente {  get; set; }
        public int ID_Usuario { get; set; }
    }
}
