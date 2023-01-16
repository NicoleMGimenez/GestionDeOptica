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
    public partial class ClienteForm : Form
    {
        TrabajarCliente trabajarC = new TrabajarCliente();
        public ClienteForm()
        {
            InitializeComponent(); 
        }

        private void cleanFields()
        {
            textDni.Text = "";
            textNom.Text = "";
            textApe.Text = "";
            textDire.Text = "";
            cargarOS.SelectedValue = 1;
            textNroCarnet.Text = "";
            textBuscarClienteDNI.Text = "";
            textBuscarClienteNom.Text = "";
            textDni.ReadOnly = false;
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            load_clientes();
            load_obraSocial();
        }

        private void load_clientes()
        {
            tablaClientes.DataSource = trabajarC.listar_clientes();
        }

        private void load_obraSocial()
        {
            cargarOS.DisplayMember = "OS_RazonSocial";
            cargarOS.ValueMember = "OS_CUIT";
            cargarOS.DataSource = trabajarC.listar_OS();
        }

        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {
            Cliente clienteN = new Cliente();
            clienteN.DNI = textDni.Text;
            clienteN.Apellido = textApe.Text;
            clienteN.Nombre = textNom.Text;
            clienteN.Direccion = textDire.Text;
            clienteN.NumeroCarnet = textNroCarnet.Text;
            clienteN.Cuit = (string)cargarOS.SelectedValue;

            if (buttonGuardarCliente.Text == "Guardar")
            {

                trabajarC.cargar_cliente(clienteN);
                load_clientes();
                cleanFields();

            }
            else if (buttonGuardarCliente.Text == "Modificar")
            {
                trabajarC.actualizar_cliente(clienteN);
                load_clientes();
                cleanFields();
            }
        }

        private void textDni_Enter(object sender, EventArgs e)
        {

        }

        private void textApe_Enter(object sender, EventArgs e)
        {

        }

        private void textNom_Enter(object sender, EventArgs e)
        {

        }

        private void textDire_Enter(object sender, EventArgs e)
        {

        }

        private void textCuit_Enter(object sender, EventArgs e)
        {

        }

        private void textNroCarnet_Enter(object sender, EventArgs e)
        {

        }

        private void tablaClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaClientes.CurrentRow != null)
            {
                textDni.Text = tablaClientes.CurrentRow.Cells["Nº de Documento"].Value.ToString();
                textApe.Text = tablaClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                textNom.Text = tablaClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                textDire.Text = tablaClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                textNroCarnet.Text = tablaClientes.CurrentRow.Cells["Nº de Carnet"].Value.ToString();
                cargarOS.SelectedValue = tablaClientes.CurrentRow.Cells["Cuit Obra Social"].Value.ToString();

                buttonGuardarCliente.Text = "Modificar";
                buttonEliminar.Visible = true;
                textDni.ReadOnly = true;
            }
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            if (textBuscarClienteNom.Text != "" && textBuscarClienteDNI.Text != "")
            {
                tablaClientes.DataSource = trabajarC.buscar_cliente_nombre(textBuscarClienteNom.Text, textBuscarClienteDNI.Text);

            }
            else if (textBuscarClienteNom.Text != "")
            {
                tablaClientes.DataSource = trabajarC.buscar_cliente_nombre(textBuscarClienteNom.Text, textBuscarClienteDNI.Text);
            }
            else if (textBuscarClienteDNI.Text != "")
            {
                tablaClientes.DataSource = trabajarC.buscar_cliente_nombre(textBuscarClienteNom.Text, textBuscarClienteDNI.Text);
            }
            else
            {
                load_clientes();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string identificador = (string)tablaClientes.CurrentRow.Cells["Nº de Documento"].Value;
            trabajarC.eliminar_cliente(identificador);
            load_clientes();
            cleanFields();
        }

        private void buttonRecargar_Click(object sender, EventArgs e)
        {
            load_clientes();
            buttonGuardarCliente.Text= "Guardar";
            cleanFields();
        }

        private void btnOrdenarApellido_Click(object sender, EventArgs e)
        {
            tablaClientes.DataSource = trabajarC.ordenar_apellido();

        }

    }
}
