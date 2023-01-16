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
    public partial class ProductoForm : Form
    {
        TrabajarVenta trabajarV = new TrabajarVenta();
        
        public ProductoForm()
        {
            InitializeComponent();
            
        }

        private void cleanFields()
        {
            textCod.Text = "";
            textCat.Text = "";
            textDescrip.Text = "";
            precioProd.Value = 0;
            
        }

        private void buttonAceptar_Click(object sender, EventArgs e) // trabajo en dos capas, mover a trabajarVenta
        {
            Producto prod = new Producto();
            prod.Codigo = textCod.Text;
            prod.Categoria = textCat.Text;
            prod.Descripcion = textDescrip.Text;
            prod.Precio = precioProd.Value;
            if (buttonAceptar.Text == "Guardar")
            {   //nos encargamos de ver que no comparta el codigo con otro producto de tabla 
                if (trabajarV.ProductoEntabla(prod.Codigo) == false)
                {
                    alertaCodigo.Visible = false;
                    trabajarV.agregar_producto(prod);
                    load_productos();
                    cleanFields();
                }
                else
                {//si si existe en tabla de informa por un label
                    alertaCodigo.Visible = true;
                    textCod.Text = "";
                }
                
            }
            else if (buttonAceptar.Text == "Modificar")
            {
                trabajarV.actualizar_producto(prod);
                load_productos();
                cleanFields();
            }
            

        }

        private void ProductoForm_Load(object sender, EventArgs e)
        {
            load_productos();
        }

        private void load_productos()
        {
            tablaProductos.DataSource = trabajarV.listar_productos();
        }


        private void opcDescrip_Click(object sender, EventArgs e)
        {
            opcDescrip.Checked = true;
            opcCategoria.Checked = false;
            tablaProductos.DataSource = trabajarV.ListarProd_Descripcion();
        }

        private void opcCategoria_Click(object sender, EventArgs e)
        {
            opcDescrip.Checked = false;
            opcCategoria.Checked = true;
            tablaProductos.DataSource = trabajarV.ListarProd_categoria();
        }

        //private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (tablaProductos.CurrentRow != null)
        //    {
        //        //puede cambiar todos los campos menos el codigo :) para evitar probelmas

        //        textCod.Text = tablaProductos.CurrentRow.Cells["Prod_Codigo"].Value.ToString();
        //        textCod.ReadOnly = true;
        //        textCat.Text = tablaProductos.CurrentRow.Cells["Prod_Categoria"].Value.ToString();
        //        textDescrip.Text = tablaProductos.CurrentRow.Cells["Prod_Descripcion"].Value.ToString();
        //        precioProd.Value = (decimal)tablaProductos.CurrentRow.Cells["Prod_Precio"].Value;

        //        buttonAceptar.Text = "Modificar";
        //        buttonEliminar.Visible = true;
        //    }
        //}

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string codigoIden = (string)tablaProductos.CurrentRow.Cells["Prod_Codigo"].Value;
            trabajarV.eliminar_producto(codigoIden);
            load_productos();
            cleanFields();
            buttonAceptar.Text = "Guardar";
        }

        private void buttonRecargar_Click(object sender, EventArgs e)
        {
            load_productos();
            buttonAceptar.Text="Guardar";
            alertaCodigo.Visible = false;
            cleanFields();
        }

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaProductos.CurrentRow != null)
            {
                //puede cambiar todos los campos menos el codigo :) para evitar probelmas

                textCod.Text = tablaProductos.CurrentRow.Cells["Prod_Codigo"].Value.ToString();
                textCod.ReadOnly = true;
                textCat.Text = tablaProductos.CurrentRow.Cells["Prod_Categoria"].Value.ToString();
                textDescrip.Text = tablaProductos.CurrentRow.Cells["Prod_Descripcion"].Value.ToString();
                precioProd.Value = (decimal)tablaProductos.CurrentRow.Cells["Prod_Precio"].Value;

                buttonAceptar.Text = "Modificar";
                buttonEliminar.Visible = true;
            }
        }
        
    }
}
