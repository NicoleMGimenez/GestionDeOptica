namespace Vistas
{
    partial class MenuAdministradorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAdministradorForm));
            this.panelForm = new System.Windows.Forms.Panel();
            this.buttonPro = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelUserConectado = new System.Windows.Forms.Label();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelForm
            // 
            this.panelForm.Location = new System.Drawing.Point(209, 12);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(585, 342);
            this.panelForm.TabIndex = 10;
            // 
            // buttonPro
            // 
            this.buttonPro.BackColor = System.Drawing.Color.Silver;
            this.buttonPro.FlatAppearance.BorderSize = 0;
            this.buttonPro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonPro.Location = new System.Drawing.Point(24, 55);
            this.buttonPro.Name = "buttonPro";
            this.buttonPro.Size = new System.Drawing.Size(138, 23);
            this.buttonPro.TabIndex = 6;
            this.buttonPro.Text = "Productos";
            this.buttonPro.UseVisualStyleBackColor = false;
            this.buttonPro.Click += new System.EventHandler(this.buttonPro_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // labelUserConectado
            // 
            this.labelUserConectado.AutoSize = true;
            this.labelUserConectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserConectado.Location = new System.Drawing.Point(52, 13);
            this.labelUserConectado.Name = "labelUserConectado";
            this.labelUserConectado.Size = new System.Drawing.Size(48, 15);
            this.labelUserConectado.TabIndex = 9;
            this.labelUserConectado.Text = "usuario";
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.Color.Silver;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonUser.Location = new System.Drawing.Point(24, 93);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(138, 23);
            this.buttonUser.TabIndex = 10;
            this.buttonUser.Text = "Usuarios";
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonLogOut.Location = new System.Drawing.Point(24, 330);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(138, 23);
            this.buttonLogOut.TabIndex = 35;
            this.buttonLogOut.Text = "Cerrar Sesión";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Controls.Add(this.buttonUser);
            this.panel1.Controls.Add(this.labelUserConectado);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.buttonPro);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 365);
            this.panel1.TabIndex = 1;
            // 
            // MenuAdministradorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(205)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(816, 366);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MenuAdministradorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Button buttonPro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelUserConectado;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panel1;

    }
}