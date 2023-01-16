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
    public partial class LoginForm : Form
    {
        TrabajarUsuario trabajarU = new TrabajarUsuario();
        public LoginForm()
        {
            InitializeComponent();
            
        }

        //crear los perfiles de usuarios

      
        private void textUser_Enter(object sender, EventArgs e)
        {
            if (textUser.Text == "Usuario")
            {
                textUser.Text = "";
                textUser.ForeColor = Color.Black;
                labelMsj.Visible = false;
            }
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            if (textUser.Text == "")
            {
                textUser.Text = "Usuario";
                textUser.ForeColor = Color.Black;
            }
        }

        private void textPass_Enter(object sender, EventArgs e)
        {
            if (textPass.Text == "Password")
            {
                textPass.Text = "";
                textPass.ForeColor = Color.Black;
                labelMsj.Visible = false;
            }
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            if (textPass.Text == "")
            {
                textPass.Text = "Password";
                textPass.ForeColor = Color.Black;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Usuario Uactual = new Usuario();
            Uactual = trabajarU.login(textUser.Text, textPass.Text);
            if (Uactual != null)
            {
                login(Uactual);

            }
            else {
                labelMsj.Visible = true;
            }
        }

        public void login(Usuario user) {
            if (user.Rol==3)
            {
                MenuForm menu = new MenuForm(user);
                this.Hide();
                menu.Show();
            }
            if (user.Rol == 2) {
            MenuOperadorForm menu = new MenuOperadorForm(user);
            this.Hide();
            menu.Show();
            }
            if (user.Rol == 1)
            {
                MenuAdministradorForm menu = new MenuAdministradorForm(user);
                this.Hide();
                menu.Show();
            }
 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_MouseHover(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.LightGray;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.Green;
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {
            textPass.PasswordChar = '*';
        }

    }
}