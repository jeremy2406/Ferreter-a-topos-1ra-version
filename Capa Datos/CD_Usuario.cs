using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Capa_Común;
using Capa_Común.Cache;

namespace Capa_Datos
{
    public class CD_Usuario:Conexion
    {
        public bool Login(string Usuario, string Contraseña)
        {
            using(var comando = new SqlCommand())
            {
                comando.Connection = AbrirConexion();
                comando.CommandText = "Select * from Usuarios where Nombre_Usuario = @Usuario and Contraseña =@Contraseña;";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@Usuario", Usuario);
                comando.Parameters.AddWithValue("@Contraseña",Contraseña);
                comando.CommandType = CommandType.Text;
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        InicioSesionUsuario.ID_Usuario = reader.GetInt32(0);
                        InicioSesionUsuario.Nombre_Empleado = reader.GetString(3);
                        InicioSesionUsuario.Apellido_Empleado = reader.GetString(4);
                        InicioSesionUsuario.Posición = reader.GetString(5);
                        InicioSesionUsuario.Gmail_Empleado = reader.GetString(6);

                    }
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
        }
        public void Privilegios()
        {
            if(InicioSesionUsuario.Posición == Posiciones.Jefe)
            {

            }
            if (InicioSesionUsuario.Posición == Posiciones.Empleado)
            {

            }
        }
    }
}
