using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
    public class Conexion
    {
       
      
        private SqlConnection Cone = new SqlConnection("Data Source=.;Initial Catalog=Ferreteria_Topos;Integrated Security=True");
        public SqlConnection AbrirConexion()
        {
            if (Cone.State == ConnectionState.Closed)
                Cone.Open();
            return Cone;
        }
        public SqlConnection CerrarConexion()
        {
            if (Cone.State == ConnectionState.Open)
                Cone.Close();
            return Cone;
        }
    }
}
