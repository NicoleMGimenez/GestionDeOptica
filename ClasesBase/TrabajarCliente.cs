using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    public class TrabajarCliente
    {
        SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
        SqlCommand cmd = new SqlCommand();

        public DataTable listar_clientes()
        {
            cmd.CommandText = "SELECT ";
            cmd.CommandText += "Cli_DNI as 'Nº de Documento', ";
            cmd.CommandText += "Cli_Apellido as 'Apellido', ";
            cmd.CommandText += "Cli_Nombre as 'Nombre', ";
            cmd.CommandText += "Cli_Direccion as 'Direccion', ";
            cmd.CommandText += "Cli_NroCarnet as 'Nº de Carnet', ";
            cmd.CommandText += "OS_CUIT as 'Cuit Obra Social'";
            cmd.CommandText += "FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable listar_OS()
        {

            //SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            cmd.CommandText = "SELECT * FROM ObraSocial";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void cargar_cliente(Cliente clienteN)
        {
            cmd.CommandText = "INSERT INTO Cliente(Cli_DNI, Cli_Apellido, Cli_Nombre, Cli_Direccion, Cli_NroCarnet, OS_Cuit) values (@dni, @ape, @nom, @dire, @nroc, @oscuit)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", clienteN.DNI);
            cmd.Parameters.AddWithValue("@ape", clienteN.Apellido);
            cmd.Parameters.AddWithValue("@nom", clienteN.Nombre);
            cmd.Parameters.AddWithValue("@dire", clienteN.Direccion);
            cmd.Parameters.AddWithValue("@nroc", clienteN.NumeroCarnet);
            cmd.Parameters.AddWithValue("@oscuit", clienteN.Cuit);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            cmd.Parameters.Clear();
        }

        public void actualizar_cliente(Cliente clienteN)
        {
            cmd.CommandText = "UPDATE Cliente SET Cli_Apellido = @ape, Cli_Nombre = @nom, Cli_Direccion = @dire, Cli_NroCarnet = @nroc, OS_Cuit = @oscuit ";
            cmd.CommandText += "WHERE ";
            cmd.CommandText += "Cli_DNI LIKE @dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", clienteN.DNI);
            cmd.Parameters.AddWithValue("@ape", clienteN.Apellido);
            cmd.Parameters.AddWithValue("@nom", clienteN.Nombre);
            cmd.Parameters.AddWithValue("@dire", clienteN.Direccion);
            cmd.Parameters.AddWithValue("@nroc", clienteN.NumeroCarnet);
            cmd.Parameters.AddWithValue("@oscuit", clienteN.Cuit);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            cmd.Parameters.Clear();
        }

        public DataTable buscar_cliente_nombre(string nombre, string dni)
        {
            cmd.CommandText = "SELECT * FROM Cliente ";
            // buscamos por nombre con el operador like
            cmd.CommandText += "WHERE ";
            cmd.CommandText += "Cli_DNI LIKE @dni AND Cli_Nombre LIKE @nom ";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
           
            cmd.Parameters.AddWithValue("@nom", "%" + nombre + "%");
            cmd.Parameters.AddWithValue("@dni", "%" + dni + "%");
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Parameters.Clear();
            return dt;
        }

        public DataTable buscar_cliente_avan(string nombre, string dni, string apellido)
        {
            cmd.CommandText = "SELECT * FROM Cliente ";
            // buscamos por nombre con el operador like
            cmd.CommandText += "WHERE ";
            cmd.CommandText += "Cli_DNI LIKE @dni AND Cli_Nombre LIKE @nom AND CLI_Apellido LIKE @ape";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nom", "%" + nombre + "%");
            cmd.Parameters.AddWithValue("@dni", "%" + dni + "%");
            cmd.Parameters.AddWithValue("@ape", "%" + apellido + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Parameters.Clear();
            return dt;
        }


        public void eliminar_cliente(string dni)
        {
            cmd.CommandText = "DELETE FROM Cliente ";
            cmd.CommandText += "WHERE ";
            cmd.CommandText += "Cli_DNI LIKE @dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            cmd.Parameters.Clear();
        }

        public DataTable ordenar_apellido()
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand.Connection = cnn;
            da.SelectCommand.CommandText = "ordenarApellido";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ListarCliente_apellido () { 
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.SelectCommand.Connection = cnn;
        da.SelectCommand.CommandText = "ListarApellido";
        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
        }


        public DataTable ListarCliente_carnet()
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand.Connection = cnn;
            da.SelectCommand.CommandText = "ListarCarnet";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ListarCliente_DNI()
        {
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.SelectCommand.Connection = cnn;
            da.SelectCommand.CommandText = "ListarDNI";
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string obtenerDNI(string dni)
        {
            string retorno;
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT * FROM Cliente WHERE Cli_DNI = @dni ";
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                retorno = dr.GetString(0);
                return retorno;
            }
            else
            {
                cnn.Close();
                cmd.Parameters.Clear();
                return null;
            }

        }

        public Cliente obtenerCliente(string dni)
        {
            Cliente cli = new Cliente();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT * FROM Cliente WHERE Cli_DNI = @dni";
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.CommandType = CommandType.Text;
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                cli.DNI = dr.GetString(0);
                cli.Apellido = dr.GetString(1);
                cli.Nombre = dr.GetString(2);
                cli.Direccion = dr.GetString(3);
                cli.NumeroCarnet = dr.GetString(4);
                cli.Cuit = dr.GetString(5);
                cnn.Close();
                cmd.Parameters.Clear();
                return cli;
            }
            else
            {
                cnn.Close();
                cmd.Parameters.Clear();
                return null;
            }

        }
    }
}
