using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class TrabajarVenta
    {
        SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
        SqlCommand cmd = new SqlCommand();

        public DataTable listar_clientes()
        {

            cmd.CommandText = "SELECT * FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public Boolean ProductoEntabla(string codigo)
        {
            Boolean aux;
            cmd.Connection = cnn;
            cmd.CommandText = "ProductoxCodigo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                aux = true;
            }
            else { aux = false; }
            cnn.Close();
            cmd.Parameters.Clear();
            return aux;
        }

        public DataTable listar_productos()
        {

            cmd.CommandText = "SELECT * FROM Producto";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable listar_obrasocial()
        {

            cmd.CommandText = "SELECT * FROM ObraSocial";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void cargar_venta(Venta ven)
        {
            cmd.CommandText = "INSERT INTO Venta( Ven_Fecha, Cli_DNI) values (@fecha, @dni )";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            
            cmd.Parameters.AddWithValue("@fecha", ven.VentaFecha);
            cmd.Parameters.AddWithValue("@dni", ven.CliDNI);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            cmd.Parameters.Clear();

        }

        public void cargar_ventaDetalle(VentaDetalle venDetalle)
        {
            int aux;
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = "SELECT TOP 1 * FROM Venta ORDER BY Ven_Nro DESC";
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = cnn;
            cnn.Open();
            SqlDataReader dr = cmd1.ExecuteReader();
            
            if (dr.Read())
            {
                aux = dr.GetInt32(0);
                cnn.Close();
                cmd.Parameters.Clear();
            }
            else
            {
                aux = 0;
                cnn.Close();
                cmd.Parameters.Clear();
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand.Connection = cnn;
            da.SelectCommand.CommandText = "cargarDetalleVenta";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@venta", aux);
            cmd.Parameters.AddWithValue("@producto",venDetalle.CodigoProd);
            cmd.Parameters.AddWithValue("@precio", venDetalle.Precio);
            cmd.Parameters.AddWithValue("@cantidad", venDetalle.Cantidad);
            cmd.Parameters.AddWithValue("@total", venDetalle.Total);

            DataTable dt = new DataTable();

            da.Fill(dt);
        }

        public DataTable listar_ventas()
        {
            cmd.CommandText = "SELECT ";
            cmd.CommandText += "Ven_Nro as 'Venta Nº', ";
            cmd.CommandText += "Ven_Fecha as 'Fecha de la venta', ";
            cmd.CommandText += "Cli_DNI as 'DNI del comprador'";
            cmd.CommandText += "FROM Venta";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public Producto obtener_producto(string codigo)
        {
            Producto prod = new Producto();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT * FROM Producto WHERE Prod_Codigo = @cod ";
            cmd.Parameters.AddWithValue("@cod", codigo);
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                prod.Codigo = dr.GetString(0);
                prod.Categoria = dr.GetString(1);
                prod.Descripcion = dr.GetString(2);
                prod.Precio = dr.GetDecimal(3);
                cnn.Close();
                cmd.Parameters.Clear();
                return prod;
            }
            else {
                cnn.Close();
                cmd.Parameters.Clear();
                return null; 
            }
            
        }

        public DataTable ListarProd_categoria()
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand.Connection = cnn;
            da.SelectCommand.CommandText = "OrdernarProCategoria";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ListarProd_Descripcion()
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand.Connection = cnn;
            da.SelectCommand.CommandText = "OrdenarProdDescripcion";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void agregar_producto(Producto prod)
        {
            cmd.Connection = cnn;
            cmd.CommandText = "cargarProducto";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigo", prod.Codigo);
            cmd.Parameters.AddWithValue("@categoria", prod.Categoria);
            cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
            cmd.Parameters.AddWithValue("@precio", prod.Precio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            cmd.Parameters.Clear();
        }

        public void actualizar_producto(Producto prod)
        {
            cmd.Connection = cnn;
            cmd.CommandText = "editarProducto";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigo", prod.Codigo);
            cmd.Parameters.AddWithValue("@categoria", prod.Categoria);
            cmd.Parameters.AddWithValue("@descripcion", prod.Descripcion);
            cmd.Parameters.AddWithValue("@precio", prod.Precio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            cmd.Parameters.Clear();
        }

        public void eliminar_producto(string cod)
        {
            cmd.Connection = cnn;
            cmd.CommandText = "eliminarProducto";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigo", cod);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            cmd.Parameters.Clear();
        }

        public DataTable Listar_VentaCliente(string dni)
        {

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = cnn;
            cmd.CommandText = "seleccionarDniVista";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dni", dni);

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Parameters.Clear();
            return dt;

        }

        public DataTable buscar_PorFecha(DateTime fechaD, DateTime fechaH)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = cnn;
            cmd.CommandText = "buscarVentaFecha";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fechaD", fechaD);
            cmd.Parameters.AddWithValue("@fechaH", fechaH);

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Parameters.Clear();
            return dt;
        }

        public DataTable Listar_ProductoCliente(string dni)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = cnn;
            cmd.CommandText = "seleccionarDniVista2";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dni", dni);

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Parameters.Clear();
            return dt;
        }

        public DataTable buscarProd_PorFecha(DateTime fechaD, DateTime fechaH)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = cnn;
            cmd.CommandText = "buscarProductoFecha";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fechaD", fechaD);
            cmd.Parameters.AddWithValue("@fechaH", fechaH);

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Parameters.Clear();
            return dt;
        }

        public void borrar_venta(int borrado){
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = cnn;
            cmd.CommandText = "borrar_venta";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idVenta", borrado);

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Parameters.Clear();
        }

        public DataTable listar_ventas_view()
        {

            cmd.CommandText = "SELECT * FROM View_VentaClientes";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
