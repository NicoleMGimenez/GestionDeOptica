using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class MenuOperadorForm : Form
    {
        public MenuOperadorForm() { 
        
        }

        public MenuOperadorForm(Usuario user)
        {
            InitializeComponent();
            labelUserConectado.Text = user.NombreUsuario;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cargarFormulario(object formulario)
        {
            if (this.panelForm.Controls.Count > 0) // se pregunta si existe algun control en el interior del panel
                this.panelForm.Controls.RemoveAt(0); // si es verdadero lo eliminamos

            Form f = formulario as Form;

            f.TopLevel = false; // decimos que es un formulario secundario
            f.Dock = DockStyle.Fill; // que ocupe todo el espacio del panel
            this.panelForm.Controls.Add(f); // se agrega el formulario dentro del panel
            this.panelForm.Tag = f; // establecemos la instancia como contenedor de datos del panel
            f.Show();

        }

        private void buttonCli_Click(object sender, EventArgs e)
        {
            cargarFormulario(new ClienteForm());
        }

        private void buttonCargarVenta_Click(object sender, EventArgs e)
        {
            cargarFormulario(new btnSeleccionarCliente());
            //cargarFormulario(new VentaForm());
        }

        private void buttonListarVentas_Click(object sender, EventArgs e)
        {
            cargarFormulario(new ListadoVentaForm());
        }

        private void buttonListarProd_Click(object sender, EventArgs e)
        {
            cargarFormulario(new ListadoProductoForm());
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }


    }
}
