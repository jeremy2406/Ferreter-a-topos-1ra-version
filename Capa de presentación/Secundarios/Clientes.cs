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

namespace Capa_de_presentación.Secundarios
{
    public partial class Clientes : Form
    {
        CN_Clientes objectCN = new CN_Clientes();
        double val = 0;
        private string? ID_Cliente = null;
        private bool EditarClient = false;


        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            //codigo();
            
         
        }
        //Mostrar datos del datagridview
        private void MostrarClientes()
        {
            CN_Clientes objeto = new CN_Clientes();
            dataGridView1.DataSource = objeto.MostrarClient();
        }
        //Guardar datos
        private void btnguardar_Click(object sender, EventArgs e)
        {
            //Parte para guardar los datos 
            if (EditarClient == false)
            {
                try
                {
                    objectCN.InsertarClientes(txtid.Text, txtnombre.Text, txtapellido.Text, txtedad.Text, txttelefono.Text, txtcorreo.Text, txtdireccion.Text, txtcedula.Text);
                    MessageBox.Show("se insertó correctamente");
                    MostrarClientes();
                    limpiarForm();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //Parte para guardar los datos editados
            if (EditarClient == true)
            {
                try
                {
                    objectCN.EditarClientes(txtid.Text, txtnombre.Text, txtapellido.Text, txtedad.Text, txttelefono.Text, txtcorreo.Text, txtdireccion.Text, txtcedula.Text);
                    MessageBox.Show("se edito correctamente");
                    MostrarClientes();
                    limpiarForm();
                    EditarClient = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudieron editar los datos por: " + ex);
                }
            }
        }

        //boton para seleccionar los datos del datagrid, para editarlos
        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EditarClient = true;
                ID_Cliente = dataGridView1.CurrentRow.Cells["ID_Cliente"].Value.ToString();
                txtnombre.Text = dataGridView1.CurrentRow.Cells["Nombre_cliente"].Value.ToString();
                txtapellido.Text = dataGridView1.CurrentRow.Cells["Apellido_cliente"].Value.ToString();
                txtedad.Text = dataGridView1.CurrentRow.Cells["Edad_cliente"].Value.ToString();
                txttelefono.Text = dataGridView1.CurrentRow.Cells["Telefono_cliente"].Value.ToString();
                txtcorreo.Text = dataGridView1.CurrentRow.Cells["Correo_cliente"].Value.ToString();
                txtdireccion.Text = dataGridView1.CurrentRow.Cells["Direccion_cliente"].Value.ToString();
                txtcedula.Text = dataGridView1.CurrentRow.Cells["Cedula_cliente"].Value.ToString();

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        //boton para quitar los datos de los textbox una vez editados o guardados
        private void limpiarForm()
        {
            txtid.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtedad.Text = "";
            txttelefono.Text = "";
            txtcorreo.Text = "";
            txtdireccion.Text = "";
            txtcedula.Text = "";

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ID_Cliente = dataGridView1.CurrentRow.Cells["ID_Cliente"].Value.ToString();
                objectCN.EliminarClientes(ID_Cliente);
                MessageBox.Show("Eliminado correctamente");
                MostrarClientes();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

      private void codigo()
        {
            objectCN.siguientenumero(txtid.Text);
           
        }

        //Silver Lake Blue #778DA9
        //Platinum #E0E1DD
        //YInMn Blue #415A77
        //Oxford Blue #1B263B
        //Rich black #0D1B2A


    }

}
