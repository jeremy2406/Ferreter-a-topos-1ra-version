using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CN_Clientes
    {
        private C_Clientes objetoCD = new C_Clientes();
        public DataTable MostrarClient()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarClientes(string ID_Cliente, string Nombre_cliente, string Apellido_cliente, string Edad_cliente, string Telefono_cliente, string Correo_cliente, string Direccion_cliente, string Cedula_cliente)
        {
            objetoCD.Insertar( Convert.ToInt32(ID_Cliente),Nombre_cliente,  Apellido_cliente, Convert.ToInt32(Edad_cliente), Telefono_cliente,  Correo_cliente,  Direccion_cliente, Convert.ToInt32(Cedula_cliente));
        }
        public void EditarClientes(string ID_Cliente, string Nombre_cliente, string Apellido_cliente, string Edad_cliente, string Telefono_cliente, string Correo_cliente, string Direccion_cliente, string Cedula_cliente)
        {
            objetoCD.Editar(Convert.ToInt32(ID_Cliente), Nombre_cliente, Apellido_cliente, Convert.ToInt32(Edad_cliente), Telefono_cliente, Correo_cliente, Direccion_cliente, Convert.ToInt32(Cedula_cliente));
        }
        public void EliminarClientes(String ID_Cliente)
        {
            objetoCD.Eliminar(Convert.ToInt32(ID_Cliente));
        }
       public void siguientenumero(String ID_Cliente)
        {
            objetoCD.Codigo(Convert.ToInt32(ID_Cliente));
        }

    }
}
