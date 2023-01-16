using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {

        SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.conexion);
        SqlCommand cmd = new SqlCommand();

        public DataTable listar_roles()
        {

            //SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            cmd.CommandText = "SELECT * FROM roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public Usuario login(String username, String pass) {
            Usuario user = new Usuario();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT * FROM usuario WHERE Usu_NombreUsuario = @user AND Usu_Contrasenia = @pass ";
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@pass", pass);
                cmd.CommandType = CommandType.Text;
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    user.Id =  dr.GetInt32(0);
                    user.Contraseña = pass;
                    user.NombreUsuario = username;
                    user.ApellidoNombre = dr.GetString(3);
                    user.Rol = dr.GetInt32(4);
                    cnn.Close();
                    cmd.Parameters.Clear();
                    return user;
                }
                else {
                    cnn.Close();
                    cmd.Parameters.Clear();
                    return null; }
                             
        }

        public void cargar_usuario(Usuario user) {
            cmd.CommandText = "INSERT INTO usuario(Usu_NombreUsuario, Usu_Contrasenia, Usu_ApellidoNombre, Rol_Codigo) values (@usern, @contr, @nomape, @rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            
            cmd.Parameters.AddWithValue("@usern", user.NombreUsuario);
            cmd.Parameters.AddWithValue("@contr", user.Contraseña);
            cmd.Parameters.AddWithValue("@nomape", user.ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", user.Rol);
  
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            cmd.Parameters.Clear();
        }

        public void actualizar_usuario(Usuario user) {
            cmd.CommandText = "UPDATE Usuario SET Usu_NombreUsuario = @usern, Usu_Contrasenia = @contr, Usu_ApellidoNombre = @nomape, Rol_Codigo = @rol ";
            cmd.CommandText += "WHERE ";
            cmd.CommandText += "Usu_ID LIKE @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usern", user.NombreUsuario);
            cmd.Parameters.AddWithValue("@contr", user.Contraseña);
            cmd.Parameters.AddWithValue("@nomape", user.ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", user.Rol);
            cmd.Parameters.AddWithValue("@id", user.Id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            cmd.Parameters.Clear();
        }

        public DataTable listar_usuarios(){
            cmd.CommandText = "SELECT ";
            cmd.CommandText += "usu_id as 'id', ";
            cmd.CommandText += "usu_nombreusuario as 'username', ";
            cmd.CommandText += "usu_contrasenia as 'password', ";
            cmd.CommandText += "usu_apellidonombre as 'nombre y apellido', ";
            cmd.CommandText += "Rol_Descripcion as 'rol' ";
            cmd.CommandText += "FROM Usuario ";
            cmd.CommandText += "INNER JOIN Roles ON (Roles.Rol_Codigo=Usuario.Rol_Codigo)";
            
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        


        public DataTable buscar_usuario_nombre(string patron, Boolean exacto)
        {
            //cmd.CommandText = "SELECT * FROM Usuario ";
            cmd.CommandText = "SELECT ";
            cmd.CommandText += "Usu_Id as 'id', ";
            cmd.CommandText += "Usu_NombreUsuario as 'username', ";
            cmd.CommandText += "Usu_Contrasenia as 'password', ";
            cmd.CommandText += "Usu_ApellidoNombre as 'nombre y apellido', ";
            cmd.CommandText += "U.Rol_Codigo as 'rol' ";
            cmd.CommandText += "FROM Usuario as U ";
            cmd.CommandText += "LEFT JOIN Roles as R ON (U.Rol_Codigo=R.Rol_Codigo) ";
            //error preguntar profe
            // buscamos por nombre con el operador like
            cmd.CommandText += "WHERE ";
            cmd.CommandText += "Usu_NombreUsuario LIKE @pattern";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            if (exacto == false)
            {
                cmd.Parameters.AddWithValue("@pattern", "%" + patron + "%");
            }
            else {
                cmd.Parameters.AddWithValue("@pattern", patron);
            }
            

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmd.Parameters.Clear();
            return dt;
        }

        public void eliminar_usuario(int id)
        {
            cmd.CommandText = "DELETE FROM Usuario ";
            cmd.CommandText += "WHERE ";
            cmd.CommandText += "Usu_ID LIKE @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", id);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            cmd.Parameters.Clear();
        }

        public int buscarRol(string nombreR)
        {
            int aux = 0;
            cmd.CommandText = "obtenerRolxNombre";
            cmd.Parameters.AddWithValue("@descripcion", nombreR);
            cmd.CommandType = CommandType.StoredProcedure;
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                aux = dr.GetInt32(0);
                cmd.Parameters.Clear();
                cnn.Close();
                return aux;
            }
            else
            {
                cmd.Parameters.Clear();
                cnn.Close();
                return -1;
            }
        }
    }
}
