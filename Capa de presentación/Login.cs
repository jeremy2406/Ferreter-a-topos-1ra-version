using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_de_presentación
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Usuario")
            {
                txtusuario.Text = "";

            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "Usuario";
            }
        }

        private void txtcontraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "Contraseña")
            {
                txtcontraseña.Text = "";
                txtcontraseña.UseSystemPasswordChar = true;

            }
        }

        private void txtcontraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "Contraseña";
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void txtingrsar_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text != "Usuario")
            {
              if(txtcontraseña.Text != "Contraseña")
                {
                    CN_Usuario CN_Usuario = new CN_Usuario();
                    if (CN_Usuario.LoginUser(txtusuario.Text, txtcontraseña.Text) == true)
                    {
                        Formprincipal Principal = new Formprincipal();
                        Principal.Show();
                        Principal.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        MSGerror("Usuario o contraseña incorrectos");
                        txtusuario.Focus();
                        txtcontraseña.Text= "Contraseña";
                    }
                }
                else
                {
                    MSGerror("Ingrese una contraseña");
                }
            }
            else
            {
                MSGerror("Ingrese un usario");
            }
        }
        private void MSGerror(String msg)
        {
            lblerror.Text = "  " + msg;
            lblerror.Visible = true;
        }

        private void CerrarSesion(Object sender, FormClosedEventArgs e)
        {
            txtusuario.Text = "Usuario";
            txtcontraseña.Text = "Contraseña";
            txtcontraseña.UseSystemPasswordChar = false;
            lblerror.Visible = false;
            this.Show();
           // txtusuario.Focus();
        }
    }
}
