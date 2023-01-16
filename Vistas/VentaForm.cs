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
    public partial class VentaForm : Form
    {

        TrabajarVenta trabajarV = new TrabajarVenta();
        TrabajarCarrito trabajarCarrito = new TrabajarCarrito();
        Producto producto = new Producto();
        decimal total = 0;
        decimal parcial = 0;
        int contador=0;
        Boolean crearVenta = false;
        Boolean cantidadElegida = false;

        public VentaForm(Cliente cli)
        {
            InitializeComponent();
            trabajarCarrito.borrarCarrito();
            textBox1.Text = cli.Nombre+" "+cli.Apellido;
            label3.Text = cli.DNI;
        }

        private void cleanFields()
        {
            textCodProd.Text = "";
            textPrecio.Text = "";
            cantProd.Value = 1;
            textTotal.Text = "";
            dgvCarrito.DataSource = trabajarCarrito.borrarCarrito();
            parcial = 0;
            total = 0;
        }

        private void textCodProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {
            //total = precio producto
            textTotal.Text = textPrecio.Text;
        }

        private void textCant_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTotal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void VentaForm_Load(object sender, EventArgs e)
        {
            load_combo_productos();
            textPrecio.Text = Convert.ToString(parcial);
        }

       
        private void load_combo_productos()
        {
            cargarProd.DisplayMember = "Prod_Descripcion";
            cargarProd.ValueMember = "Prod_Codigo";
            cargarProd.DataSource = trabajarV.listar_productos();
        }

        private void dateTimeVenta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardarVenta_Click(object sender, EventArgs e)
        {
            dateTimeVenta.Visible = true;
            cleanFields();
            this.Hide();
        }

        private void textDetalle_Enter(object sender, EventArgs e)
        {

        }

        private void detalleNro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cantProd_ValueChanged(object sender, EventArgs e)
        {
            //parcial = (producto.Precio * cantProd.Value);
            //textPrecio.Text = Convert.ToString(parcial);
            cantProd.Minimum = 1;
            cantidadElegida = true;
            Buscar_producto();
            parcial = (producto.Precio * cantProd.Value);
            textPrecio.Text = Convert.ToString(parcial);
        }


        private void Buscar_producto() {

            string codigo = Convert.ToString(cargarProd.SelectedValue);
            producto = trabajarV.obtener_producto(codigo);
            parcial = producto.Precio * cantProd.Value;
            textPrecio.Text = Convert.ToString(producto.Precio);
        
        }

        private void cargarProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (contador != 0 && textPrecio != null)
            {
                Buscar_producto();
            }

            contador++;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cantidadElegida == true)
            {

                Buscar_producto();
                //nos fijamos si el producto ya existe en el carrito, en caso de que exista solo debemos actualizar su cantidad, si este no existe debemos crearlo y sumarlo al carrito :))
                if (trabajarCarrito.existeEnCarrito(producto.Descripcion) == false)
                {
                dgvCarrito.DataSource = trabajarCarrito.agregarAlCarrito(producto.Descripcion, producto.Precio, cantProd.Value);
                }
                else
                {//en este caso si existe asi que traemos su cantidad desde la tabla, y le sumamos la que ingreso el empleado 
                    decimal cantVieja, cantNueva;
                    cantVieja = trabajarCarrito.obtenerCantidad(producto.Descripcion);
                    cantNueva = cantVieja + cantProd.Value;
                    //con la nueva cantidad editamos en el carrito la cantidad y estaria terminado el proceso ??
                    dgvCarrito.DataSource = trabajarCarrito.modificarCarrito(producto.Descripcion, cantNueva);
                }
                if (crearVenta == false)
                {
                    Venta ven = new Venta();

                    ven.VentaFecha = dateTimeVenta.Value;
                    ven.CliDNI = label3.Text;

                    trabajarV.cargar_venta(ven);
                    crearVenta = true;
                }

                //creamos el detalle de venta del producto(falta cambiar logica)
                    VentaDetalle venDetalle = new VentaDetalle();
                    venDetalle.Precio = Convert.ToString(producto.Precio);
                    venDetalle.CodigoProd = Convert.ToString(cargarProd.SelectedValue);
                    venDetalle.Cantidad = cantProd.Value;
                    venDetalle.Total = Convert.ToString(parcial);
                    trabajarV.cargar_ventaDetalle(venDetalle);


            }
            else {
                textAlertaCant.Visible = true;
            }

            //hacemos los ajustes visuales 
            total = total + parcial;
            textTotal.Text = Convert.ToString(total);
            dateTimeVenta.Visible = false;
        

        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



  
 
    }
}
