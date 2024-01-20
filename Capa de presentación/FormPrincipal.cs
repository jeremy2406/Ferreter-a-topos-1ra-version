using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Capa_Negocio;
using Capa_Común.Cache;

namespace Capa_de_presentación
{
    public partial class Formprincipal : Form
    {

        public Formprincipal()
        {
            InitializeComponent();

        }
        // Comandos para el movimiento de la pestaña
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //
        private void Bars_Click(object sender, EventArgs e)
        {
            if (Menuvertical.Width == 353)
            {
                Menuvertical.Width = 80;
            }
            else
                Menuvertical.Width = 353;


        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Expandir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Quitar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Barratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenChildForm(object Formhijo)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();

        }
        private void btnclientes_Click(object sender, EventArgs e)
        {
            // OpenChildForm(new Todos_clientes());
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            // OpenChildForm(new Productos());
        }

        private void btninventario_Click(object sender, EventArgs e)
        {
            // OpenChildForm(new Inventario());
        }

        private void btnestadisticas_Click(object sender, EventArgs e)
        {
            // OpenChildForm(new Estadisticas());
        }

        private void btnproveedores_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Proveedores());
        }

        private void btncerrarsesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de cerrar sesión?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
        private void CargarDatos()
        {
            lblnombre.Text = InicioSesionUsuario.Nombre_Empleado + "," + InicioSesionUsuario.Apellido_Empleado;
            lblposicion.Text = InicioSesionUsuario.Posición;
            lblGmail.Text = InicioSesionUsuario.Gmail_Empleado;
        }

        private void Formprincipal_Load(object sender, EventArgs e)
        {
            CargarDatos();
            if (InicioSesionUsuario.Posición == Posiciones.Empleado)
            {
                btninformes.Enabled = false;
            }
        }
    }


}
