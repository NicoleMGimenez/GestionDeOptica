using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasesBase;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class TrabajarOS
    {
        public int get_cantidad_OS(string OS_CUIT)
        {
            int cantidad_OS; 
            
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "contar_OS"; 
	        cmd.CommandType = CommandType.StoredProcedure; 
	        cmd.Connection = cnn; 

	        //Parametro de Entrada: 
            cmd.Parameters.AddWithValue("@OS_CUIT", OS_CUIT); 
	
	        //Parametro de Salida: 
	        cmd.Parameters.Add("@count_OS", SqlDbType.Int);
            cmd.Parameters["@count_OS"].Direction = ParameterDirection.Output; 

	        cnn.Open(); 
	        cmd.ExecuteNonQuery(); 
	        cnn.Close(); 

	        //Obtener el valor
            cantidad_OS = (int)cmd.Parameters["@count_OS"].Value;

            return cantidad_OS; 
	
        }

        public DataTable listar_OS()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
      
            cmd.CommandText = "SELECT * FROM ObraSocial";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable listar_clientes_OS(string cuit)
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            
            cmd.CommandText = "listar_clientes_OS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cuit", cuit);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void agregar_os(ObraSocial os)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "cargarOS";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cuit", os.Cuit);
            cmd.Parameters.AddWithValue("@razon", os.RazonSocial);
            cmd.Parameters.AddWithValue("@direccion", os.Direccion);
            cmd.Parameters.AddWithValue("@telefono", os.Telefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            cmd.Parameters.Clear();
        }

        public Boolean OSEntabla(string cuit)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
            SqlCommand cmd = new SqlCommand();
            Boolean aux;
            cmd.Connection = cnn;
            cmd.CommandText = "cuitRepetido";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cuit", cuit);
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
    }
}
