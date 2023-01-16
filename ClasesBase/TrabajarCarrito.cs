using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class TrabajarCarrito
    {
        SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
        SqlCommand cmd = new SqlCommand();
        public DataTable agregarAlCarrito(string descripcion, decimal precio, decimal cantidad)
        {

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = cnn;
            cmd.CommandText = "SumarCarrito";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@precio", precio);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Parameters.Clear();

            da = new SqlDataAdapter(cmd);
            cmd.Connection = cnn;
            cmd.CommandText = "mostrarCarrito";
            cmd.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;

        }
        public DataTable borrarCarrito()
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.Connection = cnn;
            cmd.CommandText = "BorrarCarrito";
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Parameters.Clear();
            da = new SqlDataAdapter(cmd);
            cmd.Connection = cnn;
            cmd.CommandText = "mostrarCarrito";
            cmd.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;
        }
        public Boolean existeEnCarrito(string nombre)
        {
            Boolean aux;
            cmd.Connection = cnn;
            cmd.CommandText = "conseguirCantidadCarrito";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@descripcion", nombre);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                aux = true;
            }
            else
            {
                aux = false;
            }
            cnn.Close();
            cmd.Parameters.Clear();

            return aux;
        }
        public decimal obtenerCantidad(string nombre)
        {
            decimal aux;
            cmd.Connection = cnn;
            cmd.CommandText = "conseguirCantidadCarrito";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@descripcion", nombre);
            cnn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {

                aux = dr.GetDecimal(0);
            }
            else
            {
                aux = -1;
            }
            cnn.Close();
            cmd.Parameters.Clear();

            return aux;

        }
        public DataTable modificarCarrito(string descripcion, decimal cantidad)
        {

            cmd.CommandText = "editarCarrito";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@descripcion", descripcion);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            cmd.Parameters.Clear();
            da = new SqlDataAdapter(cmd);
            cmd.Connection = cnn;
            cmd.CommandText = "mostrarCarrito";
            cmd.CommandType = CommandType.StoredProcedure;
            da.Fill(dt);
            return dt;

        }
    }
}
