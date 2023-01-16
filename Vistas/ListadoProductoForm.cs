using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;
using System.Data.SqlClient;

namespace Vistas
{
    public partial class ListadoProductoForm : Form
    {
        TrabajarVenta trabajarV = new TrabajarVenta();
        string idCli;
        int cont = 0;

        public ListadoProductoForm()
        {
            InitializeComponent();
        }

        private void load_combo_clientes()
        {
            SqlConnection cn = new SqlConnection(Vistas.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ds.Tables[0].Columns.Add("NombreCompleto", typeof(string), "Cli_Nombre+', ' +Cli_Apellido");
            cargarClientes.DisplayMember = "NombreCompleto";
            cargarClientes.ValueMember = "Cli_DNI";
            cargarClientes.DataSource = ds.Tables[0];
        }

        private void ListadoProductoForm_Load(object sender, EventArgs e)
        {
            load_combo_clientes();
            int cantProductos = tablaProduct.Rows.Count - 1;
            textBox1.Text = cantProductos.ToString(); 
        }

        private void cargarClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cont != 0)
            {

                idCli = (string)cargarClientes.SelectedValue;
                trabajarV.Listar_VentaCliente(idCli);
            }
            cont++;
        }

        private void radioCliente_Click(object sender, EventArgs e)
        {
            radioFecha.Checked = false;
            cargarClientes.Visible = true;
            lblCliente.Visible = true;
            lblDesde.Visible = false;
            lblHasta.Visible = false;
            dateDesde.Visible = false;
            dateHasta.Visible = false;
        }

        private void radioFecha_Click(object sender, EventArgs e)
        {
            radioCliente.Checked = false;
            lblDesde.Visible = true;
            lblHasta.Visible = true;
            dateDesde.Visible = true;
            dateHasta.Visible = true;
            cargarClientes.Visible = false;
            lblCliente.Visible = false;
        }

        private void buttonBusq_Click(object sender, EventArgs e)
        {
            if (radioCliente.Checked == true)
            {
                tablaProduct.DataSource = trabajarV.Listar_ProductoCliente((string)cargarClientes.SelectedValue);
            }
            else if (radioFecha.Checked == true)
            {
                tablaProduct.DataSource = trabajarV.buscarProd_PorFecha(dateDesde.Value, dateHasta.Value);
            }
            int cantProductos = tablaProduct.Rows.Count - 1;
            textBox1.Text = cantProductos.ToString(); 
        }

    }
}
