namespace Vistas
{
    partial class ClienteForm
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
            this.labelCliente = new System.Windows.Forms.Label();
            this.textDni = new System.Windows.Forms.TextBox();
            this.textApe = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textNroCarnet = new System.Windows.Forms.TextBox();
            this.buttonGuardarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.textDire = new System.Windows.Forms.TextBox();
            this.tablaClientes = new System.Windows.Forms.DataGridView();
            this.textBuscarClienteNom = new System.Windows.Forms.TextBox();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.buttonRecargar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBuscarClienteDNI = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOrdenarApellido = new System.Windows.Forms.Button();
            this.cargarOS = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelCliente.Location = new System.Drawing.Point(28, 9);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(164, 24);
            this.labelCliente.TabIndex = 4;
            this.labelCliente.Text = "Gestión de Cliente";
            // 
            // textDni
            // 
            this.textDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDni.ForeColor = System.Drawing.Color.Black;
            this.textDni.Location = new System.Drawing.Point(33, 61);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(154, 13);
            this.textDni.TabIndex = 5;
            this.textDni.Enter += new System.EventHandler(this.textDni_Enter);
            // 
            // textApe
            // 
            this.textApe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textApe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApe.ForeColor = System.Drawing.Color.Black;
            this.textApe.Location = new System.Drawing.Point(32, 105);
            this.textApe.Name = "textApe";
            this.textApe.Size = new System.Drawing.Size(154, 13);
            this.textApe.TabIndex = 7;
            this.textApe.Enter += new System.EventHandler(this.textApe_Enter);
            // 
            // textNom
            // 
            this.textNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNom.ForeColor = System.Drawing.Color.Black;
            this.textNom.Location = new System.Drawing.Point(33, 143);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(150, 13);
            this.textNom.TabIndex = 8;
            this.textNom.Enter += new System.EventHandler(this.textNom_Enter);
            // 
            // textNroCarnet
            // 
            this.textNroCarnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textNroCarnet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNroCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNroCarnet.ForeColor = System.Drawing.Color.Black;
            this.textNroCarnet.Location = new System.Drawing.Point(31, 228);
            this.textNroCarnet.Name = "textNroCarnet";
            this.textNroCarnet.Size = new System.Drawing.Size(152, 13);
            this.textNroCarnet.TabIndex = 11;
            this.textNroCarnet.Enter += new System.EventHandler(this.textNroCarnet_Enter);
            // 
            // buttonGuardarCliente
            // 
            this.buttonGuardarCliente.BackColor = System.Drawing.Color.Silver;
            this.buttonGuardarCliente.FlatAppearance.BorderSize = 0;
            this.buttonGuardarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonGuardarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuardarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonGuardarCliente.Location = new System.Drawing.Point(66, 307);
            this.buttonGuardarCliente.Name = "buttonGuardarCliente";
            this.buttonGuardarCliente.Size = new System.Drawing.Size(84, 23);
            this.buttonGuardarCliente.TabIndex = 12;
            this.buttonGuardarCliente.Text = "Guardar";
            this.buttonGuardarCliente.UseVisualStyleBackColor = false;
            this.buttonGuardarCliente.Click += new System.EventHandler(this.buttonGuardarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(27, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(27, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(27, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(29, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "CUIT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(27, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nro Carnet";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 31;
            this.lineShape1.X2 = 187;
            this.lineShape1.Y1 = 78;
            this.lineShape1.Y2 = 78;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape8,
            this.lineShape7,
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(585, 342);
            this.shapeContainer1.TabIndex = 19;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape8
            // 
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 359;
            this.lineShape8.X2 = 482;
            this.lineShape8.Y1 = 66;
            this.lineShape8.Y2 = 66;
            // 
            // lineShape7
            // 
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 230;
            this.lineShape7.X2 = 352;
            this.lineShape7.Y1 = 67;
            this.lineShape7.Y2 = 67;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 30;
            this.lineShape5.X2 = 186;
            this.lineShape5.Y1 = 244;
            this.lineShape5.Y2 = 244;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 31;
            this.lineShape4.X2 = 187;
            this.lineShape4.Y1 = 200;
            this.lineShape4.Y2 = 200;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 31;
            this.lineShape3.X2 = 187;
            this.lineShape3.Y1 = 159;
            this.lineShape3.Y2 = 159;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 30;
            this.lineShape2.X2 = 186;
            this.lineShape2.Y1 = 121;
            this.lineShape2.Y2 = 121;
            // 
            // textDire
            // 
            this.textDire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textDire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDire.ForeColor = System.Drawing.Color.Black;
            this.textDire.Location = new System.Drawing.Point(32, 184);
            this.textDire.Name = "textDire";
            this.textDire.Size = new System.Drawing.Size(154, 13);
            this.textDire.TabIndex = 20;
            this.textDire.Enter += new System.EventHandler(this.textDire_Enter);
            // 
            // tablaClientes
            // 
            this.tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaClientes.Location = new System.Drawing.Point(230, 74);
            this.tablaClientes.Name = "tablaClientes";
            this.tablaClientes.Size = new System.Drawing.Size(343, 195);
            this.tablaClientes.TabIndex = 30;
            this.tablaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaClientes_CellClick);
            // 
            // textBuscarClienteNom
            // 
            this.textBuscarClienteNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textBuscarClienteNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBuscarClienteNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscarClienteNom.ForeColor = System.Drawing.Color.Black;
            this.textBuscarClienteNom.Location = new System.Drawing.Point(230, 51);
            this.textBuscarClienteNom.Name = "textBuscarClienteNom";
            this.textBuscarClienteNom.Size = new System.Drawing.Size(123, 13);
            this.textBuscarClienteNom.TabIndex = 31;
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.BackColor = System.Drawing.Color.Silver;
            this.buttonBuscarCliente.FlatAppearance.BorderSize = 0;
            this.buttonBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonBuscarCliente.Location = new System.Drawing.Point(492, 45);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(81, 23);
            this.buttonBuscarCliente.TabIndex = 32;
            this.buttonBuscarCliente.Text = "Buscar";
            this.buttonBuscarCliente.UseVisualStyleBackColor = false;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // buttonRecargar
            // 
            this.buttonRecargar.BackColor = System.Drawing.Color.Silver;
            this.buttonRecargar.FlatAppearance.BorderSize = 0;
            this.buttonRecargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonRecargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonRecargar.Location = new System.Drawing.Point(230, 307);
            this.buttonRecargar.Name = "buttonRecargar";
            this.buttonRecargar.Size = new System.Drawing.Size(81, 23);
            this.buttonRecargar.TabIndex = 34;
            this.buttonRecargar.Text = "Recargar";
            this.buttonRecargar.UseVisualStyleBackColor = false;
            this.buttonRecargar.Click += new System.EventHandler(this.buttonRecargar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            this.buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminar.Location = new System.Drawing.Point(502, 307);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(71, 23);
            this.buttonEliminar.TabIndex = 35;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Visible = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(227, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Nombre";
            // 
            // textBuscarClienteDNI
            // 
            this.textBuscarClienteDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textBuscarClienteDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBuscarClienteDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBuscarClienteDNI.ForeColor = System.Drawing.Color.Black;
            this.textBuscarClienteDNI.Location = new System.Drawing.Point(362, 49);
            this.textBuscarClienteDNI.Name = "textBuscarClienteDNI";
            this.textBuscarClienteDNI.Size = new System.Drawing.Size(124, 13);
            this.textBuscarClienteDNI.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(359, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "DNI";
            // 
            // btnOrdenarApellido
            // 
            this.btnOrdenarApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.btnOrdenarApellido.FlatAppearance.BorderSize = 0;
            this.btnOrdenarApellido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnOrdenarApellido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOrdenarApellido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdenarApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOrdenarApellido.Location = new System.Drawing.Point(230, 275);
            this.btnOrdenarApellido.Name = "btnOrdenarApellido";
            this.btnOrdenarApellido.Size = new System.Drawing.Size(343, 23);
            this.btnOrdenarApellido.TabIndex = 39;
            this.btnOrdenarApellido.Text = "Ordenar por apellido";
            this.btnOrdenarApellido.UseVisualStyleBackColor = false;
            this.btnOrdenarApellido.Click += new System.EventHandler(this.btnOrdenarApellido_Click);
            // 
            // cargarOS
            // 
            this.cargarOS.FormattingEnabled = true;
            this.cargarOS.Location = new System.Drawing.Point(30, 275);
            this.cargarOS.Name = "cargarOS";
            this.cargarOS.Size = new System.Drawing.Size(158, 21);
            this.cargarOS.TabIndex = 40;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(585, 342);
            this.Controls.Add(this.cargarOS);
            this.Controls.Add(this.btnOrdenarApellido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBuscarClienteDNI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonRecargar);
            this.Controls.Add(this.buttonBuscarCliente);
            this.Controls.Add(this.textBuscarClienteNom);
            this.Controls.Add(this.tablaClientes);
            this.Controls.Add(this.textDire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGuardarCliente);
            this.Controls.Add(this.textNroCarnet);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textApe);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.TextBox textApe;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textNroCarnet;
        private System.Windows.Forms.Button buttonGuardarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox textDire;
        private System.Windows.Forms.DataGridView tablaClientes;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private System.Windows.Forms.TextBox textBuscarClienteNom;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.Button buttonRecargar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label label7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private System.Windows.Forms.TextBox textBuscarClienteDNI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOrdenarApellido;
        private System.Windows.Forms.ComboBox cargarOS;
    }
}