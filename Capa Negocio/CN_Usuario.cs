using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Común.Cache;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CN_Usuario
    {
        CD_Usuario CD_Usuario = new CD_Usuario();
        public bool LoginUser(string Usuario, string Contraseña)
        {
            return CD_Usuario.Login(Usuario, Contraseña);
        }
        public void Privilegios()
        {
            if (InicioSesionUsuario.Posición == Posiciones.Jefe)
            {

            }
            if (InicioSesionUsuario.Posición == Posiciones.Empleado)
            {

            }
        }
    }
}
