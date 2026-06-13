using System;
using System.Collections.Generic;
using System.Text;

namespace Heladeria.Entidades
{
    public  class Usuario
    {
        public int ID_Usuario {  get; set; }
        public string Nombre_Completo { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Cargo {  get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        public string Clave { get; set; }

    }
}
