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
    public partial class ObraSocialForm : Form
    {
        TrabajarVenta trabajarV = new TrabajarVenta();
        TrabajarOS trabajarO = new TrabajarOS();
        int cont = 0; 
        private List<ObraSocial> Obras;
        public ObraSocialForm()
        {
            InitializeComponent();
            Obras = new List<ObraSocial>();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ObraSocial os = new ObraSocial();
            os.Cuit = textBox1.Text;
            os.RazonSocial = textRazon.Text;
            os.Direccion = textDir.Text;
            os.Telefono = textTel.Text;

            if (buttonAceptar.Text == "Guardar")
            {   
                if (trabajarO.OSEntabla(os.Cuit) == false)
                {
                    alertaCodigo.Visible = false;
                    trabajarO.agregar_os(os);
                    load_obras();
                    cleanFields();
                }
                else
                {//si si existe en tabla de informa por un label
                    alertaCodigo.Visible = true;
                    textBox1.Text = "";
                }
            }
        }

        private void AddObraSocial(ObraSocial obraSocial)
        {
            Obras.Add(obraSocial);
        }

        private void cleanFields()
        {
            textBox1.Text = "";
            textRazon.Text = "";
            textDir.Text = "";
            textTel.Text = "";
            cantClientes.Text = "";

        }

        private void ObraSocialForm_Load(object sender, EventArgs e)
        {
            load_obras();
            load_OS();
        }

        private void load_obras()
        {
            tablaOS.DataSource = trabajarV.listar_obrasocial();
        }


        private void load_OS()
        {
            comboBox1.DisplayMember = "OS_RazonSocial";
            comboBox1.ValueMember = "OS_CUIT";
            comboBox1.DataSource = trabajarO.listar_OS();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cont != 0){
                tablaOS.DataSource = trabajarO.listar_clientes_OS(Convert.ToString(comboBox1.SelectedValue));
            }
            cont++;
             
        }

        //private void mostrarCantidad_Click(object sender, EventArgs e)
        //{
        //    string cuit = (string)comboBox1.SelectedValue;

        //    int count_OS = trabajarO.get_cantidad_OS(cuit);

        //    cantClientes.Text = count_OS.ToString();

        //}

        private void mostrarCantidad_Click(object sender, EventArgs e)
        {
            int cantidad = tablaOS.Rows.Count - 1; 
            cantClientes.Text = cantidad.ToString();
        }

        private void buttonRecargar_Click(object sender, EventArgs e)
        {
            load_obras();
            alertaCodigo.Visible = false;
            cleanFields();
        }
        
    }
}
