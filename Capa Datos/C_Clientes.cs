using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Capa_Datos
{
    public class C_Clientes

    {
        //Clases 
        private Conexion Cone = new Conexion();
        SqlDataReader? leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        
        //Mostrar los clientes en el Datagridview
        public DataTable Mostrar()
        {

            comando.Connection = Cone.AbrirConexion();
            comando.CommandText = "MostrarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Cone.CerrarConexion();
            return tabla;

        }

        //Insertar los datos
        public void Insertar(int ID_Cliente,string Nombre_cliente, string Apellido_cliente, int Edad_cliente, string Telefono_cliente, string Correo_cliente, string Direccion_cliente, int Cedula_cliente)
        {
            comando.Connection = Cone.AbrirConexion();
            comando.CommandText = "InsertarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", ID_Cliente);
            comando.Parameters.AddWithValue("@nombre", Nombre_cliente);
            comando.Parameters.AddWithValue("@Apellido", Apellido_cliente);
            comando.Parameters.AddWithValue("@Edad", Edad_cliente);
            comando.Parameters.AddWithValue("@Telefono", Telefono_cliente);
            comando.Parameters.AddWithValue("@Correo", Correo_cliente);
            comando.Parameters.AddWithValue("@Direccion", Direccion_cliente);
            comando.Parameters.AddWithValue("Cedula", Cedula_cliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            Cone.CerrarConexion();
        }

        //Editar los datos
        public void Editar(int ID_Cliente, string Nombre_cliente, string Apellido_cliente, int Edad_cliente, string Telefono_cliente, string Correo_cliente, string Direccion_cliente, int Cedula_cliente)
        {
            comando.Connection = Cone.AbrirConexion();
            comando.CommandText = "EditarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", ID_Cliente);
            comando.Parameters.AddWithValue("@nombre", Nombre_cliente);
            comando.Parameters.AddWithValue("@Apellido", Apellido_cliente);
            comando.Parameters.AddWithValue("@Edad", Edad_cliente);
            comando.Parameters.AddWithValue("@Telefono", Telefono_cliente);
            comando.Parameters.AddWithValue("@Correo", Correo_cliente);
            comando.Parameters.AddWithValue("@Direccion", Direccion_cliente);
            comando.Parameters.AddWithValue("Cedula", Cedula_cliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            Cone.CerrarConexion();
        }

        //Todavia no funciona
        public void Codigo(int ID_Cliente)
        {
            comando.Connection = Cone.AbrirConexion();
            comando.CommandText = "Siguientenumero";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", ID_Cliente);
            comando.ExecuteNonQuery();
            Cone.CerrarConexion();
           
        }
         //Eliminar Clientes
         public void Eliminar(int ID_Cliente)
        {
            comando.Connection = Cone.AbrirConexion();
            comando.CommandText = "EliminarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@ID", ID_Cliente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            Cone.CerrarConexion();
         }

       
    }


}
