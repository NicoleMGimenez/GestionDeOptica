namespace Vistas
{
    partial class VentaForm
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
            this.labelVenta = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.dateTimeVenta = new System.Windows.Forms.DateTimePicker();
            this.labelfechaVenta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cantProd = new System.Windows.Forms.NumericUpDown();
            this.cargarProd = new System.Windows.Forms.ComboBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textCodProd = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.buttonGuardarVenta = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textAlertaCant = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVenta
            // 
            this.labelVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVenta.AutoSize = true;
            this.labelVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelVenta.Location = new System.Drawing.Point(165, 9);
            this.labelVenta.Name = "labelVenta";
            this.labelVenta.Size = new System.Drawing.Size(178, 25);
            this.labelVenta.TabIndex = 24;
            this.labelVenta.Text = "Gestión de Venta";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(6, 23);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(39, 13);
            this.labelCliente.TabIndex = 25;
            this.labelCliente.Text = "Cliente";
            // 
            // dateTimeVenta
            // 
            this.dateTimeVenta.Location = new System.Drawing.Point(9, 79);
            this.dateTimeVenta.Name = "dateTimeVenta";
            this.dateTimeVenta.Size = new System.Drawing.Size(292, 20);
            this.dateTimeVenta.TabIndex = 27;
            this.dateTimeVenta.ValueChanged += new System.EventHandler(this.dateTimeVenta_ValueChanged);
            // 
            // labelfechaVenta
            // 
            this.labelfechaVenta.AutoSize = true;
            this.labelfechaVenta.Location = new System.Drawing.Point(6, 63);
            this.labelfechaVenta.Name = "labelfechaVenta";
            this.labelfechaVenta.Size = new System.Drawing.Size(94, 13);
            this.labelfechaVenta.TabIndex = 28;
            this.labelfechaVenta.Text = "Fecha de la Venta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelCliente);
            this.groupBox1.Controls.Add(this.labelfechaVenta);
            this.groupBox1.Controls.Add(this.dateTimeVenta);
            this.groupBox1.Location = new System.Drawing.Point(110, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 111);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cantProd);
            this.groupBox2.Controls.Add(this.cargarProd);
            this.groupBox2.Controls.Add(this.textPrecio);
            this.groupBox2.Controls.Add(this.textCodProd);
            this.groupBox2.Controls.Add(this.lblCantidad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.shapeContainer1);
            this.groupBox2.Location = new System.Drawing.Point(110, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 102);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            // 
            // cantProd
            // 
            this.cantProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.cantProd.Location = new System.Drawing.Point(60, 70);
            this.cantProd.Name = "cantProd";
            this.cantProd.Size = new System.Drawing.Size(120, 20);
            this.cantProd.TabIndex = 36;
            this.cantProd.ValueChanged += new System.EventHandler(this.cantProd_ValueChanged);
            // 
            // cargarProd
            // 
            this.cargarProd.FormattingEnabled = true;
            this.cargarProd.Location = new System.Drawing.Point(60, 16);
            this.cargarProd.Name = "cargarProd";
            this.cargarProd.Size = new System.Drawing.Size(241, 21);
            this.cargarProd.TabIndex = 35;
            this.cargarProd.SelectedIndexChanged += new System.EventHandler(this.cargarProd_SelectedIndexChanged);
            // 
            // textPrecio
            // 
            this.textPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecio.ForeColor = System.Drawing.Color.Black;
            this.textPrecio.Location = new System.Drawing.Point(46, 47);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.ReadOnly = true;
            this.textPrecio.Size = new System.Drawing.Size(88, 13);
            this.textPrecio.TabIndex = 32;
            this.textPrecio.Text = "(precio)";
            this.textPrecio.TextChanged += new System.EventHandler(this.textPrecio_TextChanged);
            // 
            // textCodProd
            // 
            this.textCodProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(200)))), ((int)(((byte)(141)))));
            this.textCodProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCodProd.ForeColor = System.Drawing.Color.Black;
            this.textCodProd.Location = new System.Drawing.Point(114, 20);
            this.textCodProd.Name = "textCodProd";
            this.textCodProd.Size = new System.Drawing.Size(74, 13);
            this.textCodProd.TabIndex = 31;
            this.textCodProd.TextChanged += new System.EventHandler(this.textCodProd_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(6, 74);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 28;
            this.lblCantidad.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Producto";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(301, 83);
            this.shapeContainer1.TabIndex = 30;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 43;
            this.lineShape1.X2 = 130;
            this.lineShape1.Y1 = 44;
            this.lineShape1.Y2 = 44;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Silver;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAgregar.Location = new System.Drawing.Point(196, 326);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(126, 25);
            this.btnAgregar.TabIndex = 37;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // textTotal
            // 
            this.textTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTotal.ForeColor = System.Drawing.Color.Black;
            this.textTotal.Location = new System.Drawing.Point(706, 64);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(65, 13);
            this.textTotal.TabIndex = 34;
            this.textTotal.TextChanged += new System.EventHandler(this.textTotal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Total";
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 706;
            this.lineShape4.X2 = 770;
            this.lineShape4.Y1 = 81;
            this.lineShape4.Y2 = 81;
            // 
            // buttonGuardarVenta
            // 
            this.buttonGuardarVenta.BackColor = System.Drawing.Color.Silver;
            this.buttonGuardarVenta.FlatAppearance.BorderSize = 0;
            this.buttonGuardarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonGuardarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonGuardarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuardarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonGuardarVenta.Location = new System.Drawing.Point(695, 336);
            this.buttonGuardarVenta.Name = "buttonGuardarVenta";
            this.buttonGuardarVenta.Size = new System.Drawing.Size(93, 23);
            this.buttonGuardarVenta.TabIndex = 31;
            this.buttonGuardarVenta.Text = "Guardar Venta";
            this.buttonGuardarVenta.UseVisualStyleBackColor = false;
            this.buttonGuardarVenta.Click += new System.EventHandler(this.buttonGuardarVenta_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4});
            this.shapeContainer2.Size = new System.Drawing.Size(800, 371);
            this.shapeContainer2.TabIndex = 35;
            this.shapeContainer2.TabStop = false;
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.Location = new System.Drawing.Point(457, 47);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(218, 239);
            this.dgvCarrito.TabIndex = 36;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(591, 336);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 23);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar Venta ";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // textAlertaCant
            // 
            this.textAlertaCant.AutoSize = true;
            this.textAlertaCant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.textAlertaCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textAlertaCant.ForeColor = System.Drawing.Color.White;
            this.textAlertaCant.Location = new System.Drawing.Point(167, 297);
            this.textAlertaCant.Name = "textAlertaCant";
            this.textAlertaCant.Size = new System.Drawing.Size(175, 13);
            this.textAlertaCant.TabIndex = 39;
            this.textAlertaCant.Text = "Debe elegir una cantidad mayor a 0";
            this.textAlertaCant.Visible = false;
            // 
            // VentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.textAlertaCant);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.buttonGuardarVenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.labelVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shapeContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VentaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Completar venta";
            this.Load += new System.EventHandler(this.VentaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVenta;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.DateTimePicker dateTimeVenta;
        private System.Windows.Forms.Label labelfechaVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textCodProd;
        private System.Windows.Forms.Button buttonGuardarVenta;
        private System.Windows.Forms.NumericUpDown cantProd;
        private System.Windows.Forms.ComboBox cargarProd;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label textAlertaCant;

    }
}