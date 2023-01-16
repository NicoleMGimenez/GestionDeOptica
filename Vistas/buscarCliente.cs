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
    public partial class btnSeleccionarCliente : Form
    {   
        TrabajarCliente trabjarC = new TrabajarCliente();
        public btnSeleccionarCliente()
        {
            InitializeComponent();
        }

        private void buscarCliente_Load(object sender, EventArgs e)
        {
            load_clientes();
        }

        private void load_clientes(){
            dataGridView1.DataSource= trabjarC.ListarCliente_DNI();
        }

        private void OrdDni_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = trabjarC.ListarCliente_DNI();
        }

        private void OrdCarnet_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = trabjarC.ListarCliente_carnet();
        }

        private void OrdApellido_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = trabjarC.ListarCliente_apellido();
        }

        private void BusquedaAvan_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = trabjarC.buscar_cliente_avan(textnom.Text, textDNI.Text, textape.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_seleccionar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string dni = dataGridView1.CurrentRow.Cells["Cli_DNI"].Value.ToString();
                Cliente cli = new Cliente();
                cli = trabjarC.obtenerCliente(dni);
                this.Hide();
                MenuOperadorForm menu = new MenuOperadorForm();
                menu.Hide();
                VentaForm venta = new VentaForm(cli);
                venta.Show();
                
            }
        }


        

    }
}
