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
    public partial class ListadoVentaForm : Form
    {
        TrabajarVenta trabajarV = new TrabajarVenta();
        string idCli;
        int cont = 0;
        public ListadoVentaForm()
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

        private void ListadoVentaForm_Load(object sender, EventArgs e)
        {
            load_combo_clientes();
            tablaVentas.DataSource = trabajarV.listar_ventas_view();
            int cantVentas = tablaVentas.Rows.Count - 1;
            textBox1.Text = cantVentas.ToString(); 
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

        private void buttonBuscarC_Click(object sender, EventArgs e)
        {
            if (radioCliente.Checked==true){
                tablaVentas.DataSource = trabajarV.Listar_VentaCliente((string)cargarClientes.SelectedValue);
            }
            else if(radioFecha.Checked==true){
                tablaVentas.DataSource = trabajarV.buscar_PorFecha(dateDes.Value, dateHas.Value);
            }

            int cantVentas = tablaVentas.Rows.Count - 1;
            textBox1.Text = cantVentas.ToString(); 
            
        }

        private void radioCliente_Click(object sender, EventArgs e)
        {
            radioFecha.Checked = false;
            cargarClientes.Visible = true;
            lblCliente.Visible = true;
            lblDesde.Visible = false;
            lblHasta.Visible = false;
            dateDes.Visible = false;
            dateHas.Visible = false;
        }

        private void radioFecha_Click(object sender, EventArgs e)
        {
            radioCliente.Checked = false;
            lblDesde.Visible = true;
            lblHasta.Visible = true;
            dateDes.Visible = true;
            dateHas.Visible = true;
            cargarClientes.Visible = false;
            lblCliente.Visible = false;
        }

        private void tablaVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Visible = true; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tablaVentas.CurrentRow != null)
            {
                trabajarV.borrar_venta(Convert.ToInt32(tablaVentas.CurrentRow.Cells["Ven_Nro"].Value.ToString().TrimEnd()));
                var result = MessageBox.Show("La venta ha sido eliminada correctamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                tablaVentas.DataSource = trabajarV.listar_ventas_view(); 
            }
        }
        
    }
}
