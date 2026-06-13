using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Heladeria.DAL
{
    public class Conexion
    {
       private  SqlConnection cone=new SqlConnection("server=DESKTOP-GLNLBIV;Database=DB_Heladeria_july;Integrated Security=True;TrustServerCertificate=True");

        public SqlConnection AbrirConexion()
        {
            if (cone.State == System.Data.ConnectionState.Closed) cone.Open();
            return cone;
        }
        public SqlConnection CerrarConexion()
        {
            if ( cone.State == System.Data.ConnectionState.Closed  ) cone.Open();
            return cone;
        }
    }
}
