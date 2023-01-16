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
    public partial class UserForm : Form
    {

        TrabajarUsuario trabajarU= new TrabajarUsuario();
        public UserForm()
        {
            InitializeComponent();
        }

        private void cleanFields()
        {
            textUserN.Text = "";
            textContra.Text = "";
            textNyA.Text = "";
            textBusqueda.Text = "";
            cargarRoles.SelectedValue = 1;

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            load_combo_roles();
            load_usuarios();
        }

        private void load_combo_roles()
        {
            cargarRoles.DisplayMember = "rol_descripcion";
            cargarRoles.ValueMember = "rol_codigo";
            cargarRoles.DataSource = trabajarU.listar_roles();
        }

        private void load_usuarios() {
            tablaUsuarios.DataSource = trabajarU.listar_usuarios();
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            Usuario userN = new Usuario();
            userN.Rol = (int)cargarRoles.SelectedValue;
            userN.NombreUsuario = textUserN.Text;
            userN.Contraseña = textContra.Text;
            userN.ApellidoNombre = textNyA.Text;

            if (buttonSaveUser.Text == "Guardar"){
            
                trabajarU.cargar_usuario(userN);
                load_usuarios();
                cleanFields();

             } else if (buttonSaveUser.Text == "Modificar"){

                 userN.Id = (int)tablaUsuarios.CurrentRow.Cells["Id"].Value;
                 trabajarU.actualizar_usuario(userN);
                 load_usuarios();
                 cleanFields();
             }
            

        }

        private void textNyA_Enter(object sender, EventArgs e)
        {

        }

        private void textUserN_Enter(object sender, EventArgs e)
        {

        }

        private void textContra_Enter(object sender, EventArgs e)
        {

        }

        private void textBusqueda_Enter(object sender, EventArgs e)
        {

        }

        private void buttonBusqueda_Click(object sender, EventArgs e)
        {
            if (textBusqueda.Text != "")
            {
                tablaUsuarios.DataSource = trabajarU.buscar_usuario_nombre(textBusqueda.Text, false);
                
            }
            else
            {
                load_usuarios();
            }
        }

        private void tablaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaUsuarios.CurrentRow != null)
            {

                cargarRoles.SelectedValue = trabajarU.buscarRol(Convert.ToString(tablaUsuarios.CurrentRow.Cells["rol"].Value));

                textNyA.Text = tablaUsuarios.CurrentRow.Cells["nombre y apellido"].Value.ToString();
                textUserN.Text = tablaUsuarios.CurrentRow.Cells["username"].Value.ToString();
                textContra.Text = tablaUsuarios.CurrentRow.Cells["password"].Value.ToString();

                buttonSaveUser.Text = "Modificar";
                buttonEliminar.Visible = true;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int cantU = tablaUsuarios.Rows.Count - 1;
            if (cantU <= 1)
            {
                alertaU.Visible = true;
            }
            else {
                int identificador = (int)tablaUsuarios.CurrentRow.Cells["Id"].Value;
                trabajarU.eliminar_usuario(identificador);
                load_usuarios();
                cleanFields();           
            }

            
        }

        private void buttonRecargar_Click(object sender, EventArgs e)
        {
            load_usuarios();
            buttonSaveUser.Text = "Guardar";
            cleanFields();
        }






    }
}
