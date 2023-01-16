namespace Vistas
{
    partial class UserForm
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
            this.cargarRoles = new System.Windows.Forms.ComboBox();
            this.textRol = new System.Windows.Forms.Label();
            this.labelNyA = new System.Windows.Forms.Label();
            this.labelUserN = new System.Windows.Forms.Label();
            this.labelContra = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.textNyA = new System.Windows.Forms.TextBox();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.textUserN = new System.Windows.Forms.TextBox();
            this.textContra = new System.Windows.Forms.TextBox();
            this.tablaUsuarios = new System.Windows.Forms.DataGridView();
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.buttonBusqueda = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonRecargar = new System.Windows.Forms.Button();
            this.alertaU = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // cargarRoles
            // 
            this.cargarRoles.FormattingEnabled = true;
            this.cargarRoles.Location = new System.Drawing.Point(52, 87);
            this.cargarRoles.Name = "cargarRoles";
            this.cargarRoles.Size = new System.Drawing.Size(136, 21);
            this.cargarRoles.TabIndex = 0;
            // 
            // textRol
            // 
            this.textRol.AutoSize = true;
            this.textRol.Location = new System.Drawing.Point(51, 69);
            this.textRol.Name = "textRol";
            this.textRol.Size = new System.Drawing.Size(23, 13);
            this.textRol.TabIndex = 1;
            this.textRol.Text = "Rol";
            // 
            // labelNyA
            // 
            this.labelNyA.AutoSize = true;
            this.labelNyA.Location = new System.Drawing.Point(50, 116);
            this.labelNyA.Name = "labelNyA";
            this.labelNyA.Size = new System.Drawing.Size(92, 13);
            this.labelNyA.TabIndex = 2;
            this.labelNyA.Text = "Nombre y Apellido";
            // 
            // labelUserN
            // 
            this.labelUserN.AutoSize = true;
            this.labelUserN.Location = new System.Drawing.Point(50, 166);
            this.labelUserN.Name = "labelUserN";
            this.labelUserN.Size = new System.Drawing.Size(96, 13);
            this.labelUserN.TabIndex = 3;
            this.labelUserN.Text = "Nombre de usuario";
            // 
            // labelContra
            // 
            this.labelContra.AutoSize = true;
            this.labelContra.Location = new System.Drawing.Point(50, 216);
            this.labelContra.Name = "labelContra";
            this.labelContra.Size = new System.Drawing.Size(61, 13);
            this.labelContra.TabIndex = 4;
            this.labelContra.Text = "Contraseña";
            // 
            // labelCliente
            // 
            this.labelCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelCliente.Location = new System.Drawing.Point(38, 22);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(170, 24);
            this.labelCliente.TabIndex = 23;
            this.labelCliente.Text = "Gestión de Usuario";
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.BackColor = System.Drawing.Color.Silver;
            this.buttonSaveUser.FlatAppearance.BorderSize = 0;
            this.buttonSaveUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonSaveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonSaveUser.Location = new System.Drawing.Point(79, 275);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(84, 23);
            this.buttonSaveUser.TabIndex = 24;
            this.buttonSaveUser.Text = "Guardar";
            this.buttonSaveUser.UseVisualStyleBackColor = false;
            this.buttonSaveUser.Click += new System.EventHandler(this.buttonSaveUser_Click);
            // 
            // textNyA
            // 
            this.textNyA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textNyA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNyA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNyA.ForeColor = System.Drawing.Color.Black;
            this.textNyA.Location = new System.Drawing.Point(55, 136);
            this.textNyA.Name = "textNyA";
            this.textNyA.Size = new System.Drawing.Size(136, 13);
            this.textNyA.TabIndex = 25;
            this.textNyA.Enter += new System.EventHandler(this.textNyA_Enter);
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 53;
            this.lineShape2.X2 = 190;
            this.lineShape2.Y1 = 153;
            this.lineShape2.Y2 = 153;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(585, 342);
            this.shapeContainer1.TabIndex = 26;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 237;
            this.lineShape4.X2 = 493;
            this.lineShape4.Y1 = 64;
            this.lineShape4.Y2 = 64;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 53;
            this.lineShape3.X2 = 190;
            this.lineShape3.Y1 = 252;
            this.lineShape3.Y2 = 252;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 53;
            this.lineShape1.X2 = 190;
            this.lineShape1.Y1 = 203;
            this.lineShape1.Y2 = 203;
            // 
            // textUserN
            // 
            this.textUserN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textUserN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUserN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserN.ForeColor = System.Drawing.Color.Black;
            this.textUserN.Location = new System.Drawing.Point(54, 187);
            this.textUserN.Name = "textUserN";
            this.textUserN.Size = new System.Drawing.Size(137, 13);
            this.textUserN.TabIndex = 27;
            this.textUserN.Enter += new System.EventHandler(this.textUserN_Enter);
            // 
            // textContra
            // 
            this.textContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContra.ForeColor = System.Drawing.Color.Black;
            this.textContra.Location = new System.Drawing.Point(52, 236);
            this.textContra.Name = "textContra";
            this.textContra.Size = new System.Drawing.Size(139, 13);
            this.textContra.TabIndex = 28;
            this.textContra.Enter += new System.EventHandler(this.textContra_Enter);
            // 
            // tablaUsuarios
            // 
            this.tablaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaUsuarios.Location = new System.Drawing.Point(230, 74);
            this.tablaUsuarios.Name = "tablaUsuarios";
            this.tablaUsuarios.Size = new System.Drawing.Size(343, 195);
            this.tablaUsuarios.TabIndex = 29;
            this.tablaUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaUsuarios_CellClick);
          
            // 
            // textBusqueda
            // 
            this.textBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBusqueda.ForeColor = System.Drawing.Color.Black;
            this.textBusqueda.Location = new System.Drawing.Point(237, 49);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(259, 13);
            this.textBusqueda.TabIndex = 30;
            this.textBusqueda.Enter += new System.EventHandler(this.textBusqueda_Enter);
            // 
            // buttonBusqueda
            // 
            this.buttonBusqueda.BackColor = System.Drawing.Color.Silver;
            this.buttonBusqueda.FlatAppearance.BorderSize = 0;
            this.buttonBusqueda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonBusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonBusqueda.Location = new System.Drawing.Point(502, 42);
            this.buttonBusqueda.Name = "buttonBusqueda";
            this.buttonBusqueda.Size = new System.Drawing.Size(71, 23);
            this.buttonBusqueda.TabIndex = 31;
            this.buttonBusqueda.Text = "Buscar";
            this.buttonBusqueda.UseVisualStyleBackColor = false;
            this.buttonBusqueda.Click += new System.EventHandler(this.buttonBusqueda_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminar.Location = new System.Drawing.Point(502, 275);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(71, 23);
            this.buttonEliminar.TabIndex = 32;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Visible = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonRecargar
            // 
            this.buttonRecargar.BackColor = System.Drawing.Color.Silver;
            this.buttonRecargar.FlatAppearance.BorderSize = 0;
            this.buttonRecargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonRecargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonRecargar.Location = new System.Drawing.Point(230, 275);
            this.buttonRecargar.Name = "buttonRecargar";
            this.buttonRecargar.Size = new System.Drawing.Size(71, 23);
            this.buttonRecargar.TabIndex = 33;
            this.buttonRecargar.Text = "Recargar";
            this.buttonRecargar.UseVisualStyleBackColor = false;
            this.buttonRecargar.Click += new System.EventHandler(this.buttonRecargar_Click);
            // 
            // alertaU
            // 
            this.alertaU.AutoSize = true;
            this.alertaU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.alertaU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.alertaU.ForeColor = System.Drawing.Color.White;
            this.alertaU.Location = new System.Drawing.Point(323, 305);
            this.alertaU.Name = "alertaU";
            this.alertaU.Size = new System.Drawing.Size(173, 13);
            this.alertaU.TabIndex = 38;
            this.alertaU.Text = "No puede eliminar tdos los usuarios";
            this.alertaU.Visible = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(585, 342);
            this.Controls.Add(this.alertaU);
            this.Controls.Add(this.buttonRecargar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonBusqueda);
            this.Controls.Add(this.textBusqueda);
            this.Controls.Add(this.tablaUsuarios);
            this.Controls.Add(this.textContra);
            this.Controls.Add(this.textUserN);
            this.Controls.Add(this.textNyA);
            this.Controls.Add(this.buttonSaveUser);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelContra);
            this.Controls.Add(this.labelUserN);
            this.Controls.Add(this.labelNyA);
            this.Controls.Add(this.textRol);
            this.Controls.Add(this.cargarRoles);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cargarRoles;
        private System.Windows.Forms.Label textRol;
        private System.Windows.Forms.Label labelNyA;
        private System.Windows.Forms.Label labelUserN;
        private System.Windows.Forms.Label labelContra;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Button buttonSaveUser;
        private System.Windows.Forms.TextBox textNyA;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox textUserN;
        private System.Windows.Forms.TextBox textContra;
        private System.Windows.Forms.DataGridView tablaUsuarios;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.Button buttonBusqueda;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonRecargar;
        private System.Windows.Forms.Label alertaU;
    }
}