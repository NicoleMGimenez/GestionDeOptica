namespace Vistas
{
    partial class ProductoForm
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
            this.labelCat = new System.Windows.Forms.Label();
            this.labelDes = new System.Windows.Forms.Label();
            this.labelPre = new System.Windows.Forms.Label();
            this.textCat = new System.Windows.Forms.TextBox();
            this.textDescrip = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tablaProductos = new System.Windows.Forms.DataGridView();
            this.labelOrdenar = new System.Windows.Forms.Label();
            this.opcDescrip = new System.Windows.Forms.RadioButton();
            this.opcCategoria = new System.Windows.Forms.RadioButton();
            this.precioProd = new System.Windows.Forms.NumericUpDown();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.textCod = new System.Windows.Forms.TextBox();
            this.buttonRecargar = new System.Windows.Forms.Button();
            this.alertaCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioProd)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.labelCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelCliente.Location = new System.Drawing.Point(27, 20);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(182, 24);
            this.labelCliente.TabIndex = 5;
            this.labelCliente.Text = "Gestión de Producto";
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCat.Location = new System.Drawing.Point(39, 122);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(60, 15);
            this.labelCat.TabIndex = 15;
            this.labelCat.Text = "Categoria";
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDes.Location = new System.Drawing.Point(39, 179);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(72, 15);
            this.labelDes.TabIndex = 16;
            this.labelDes.Text = "Descripcion";
            // 
            // labelPre
            // 
            this.labelPre.AutoSize = true;
            this.labelPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPre.Location = new System.Drawing.Point(39, 229);
            this.labelPre.Name = "labelPre";
            this.labelPre.Size = new System.Drawing.Size(42, 15);
            this.labelPre.TabIndex = 17;
            this.labelPre.Text = "Precio";
            // 
            // textCat
            // 
            this.textCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCat.ForeColor = System.Drawing.Color.Black;
            this.textCat.Location = new System.Drawing.Point(40, 144);
            this.textCat.Name = "textCat";
            this.textCat.Size = new System.Drawing.Size(153, 13);
            this.textCat.TabIndex = 19;
            // 
            // textDescrip
            // 
            this.textDescrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textDescrip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescrip.ForeColor = System.Drawing.Color.Black;
            this.textDescrip.Location = new System.Drawing.Point(38, 199);
            this.textDescrip.Name = "textDescrip";
            this.textDescrip.Size = new System.Drawing.Size(155, 13);
            this.textDescrip.TabIndex = 20;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.Silver;
            this.buttonAceptar.FlatAppearance.BorderSize = 0;
            this.buttonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonAceptar.Location = new System.Drawing.Point(69, 290);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(84, 23);
            this.buttonAceptar.TabIndex = 22;
            this.buttonAceptar.Text = "Guardar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape3,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(585, 342);
            this.shapeContainer1.TabIndex = 23;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 39;
            this.lineShape1.X2 = 192;
            this.lineShape1.Y1 = 110;
            this.lineShape1.Y2 = 110;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 39;
            this.lineShape3.X2 = 193;
            this.lineShape3.Y1 = 217;
            this.lineShape3.Y2 = 217;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 39;
            this.lineShape2.X2 = 193;
            this.lineShape2.Y1 = 162;
            this.lineShape2.Y2 = 162;
            // 
            // tablaProductos
            // 
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Location = new System.Drawing.Point(230, 74);
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.Size = new System.Drawing.Size(343, 195);
            this.tablaProductos.TabIndex = 24;
            this.tablaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaProductos_CellContentClick);
            // 
            // labelOrdenar
            // 
            this.labelOrdenar.AutoSize = true;
            this.labelOrdenar.Location = new System.Drawing.Point(233, 49);
            this.labelOrdenar.Name = "labelOrdenar";
            this.labelOrdenar.Size = new System.Drawing.Size(66, 13);
            this.labelOrdenar.TabIndex = 25;
            this.labelOrdenar.Text = "Ordenar por:";
            // 
            // opcDescrip
            // 
            this.opcDescrip.AutoSize = true;
            this.opcDescrip.Location = new System.Drawing.Point(305, 47);
            this.opcDescrip.Name = "opcDescrip";
            this.opcDescrip.Size = new System.Drawing.Size(81, 17);
            this.opcDescrip.TabIndex = 26;
            this.opcDescrip.TabStop = true;
            this.opcDescrip.Text = "Descripcion";
            this.opcDescrip.UseVisualStyleBackColor = true;
            this.opcDescrip.Click += new System.EventHandler(this.opcDescrip_Click);
            // 
            // opcCategoria
            // 
            this.opcCategoria.AutoSize = true;
            this.opcCategoria.Location = new System.Drawing.Point(392, 47);
            this.opcCategoria.Name = "opcCategoria";
            this.opcCategoria.Size = new System.Drawing.Size(70, 17);
            this.opcCategoria.TabIndex = 27;
            this.opcCategoria.TabStop = true;
            this.opcCategoria.Text = "Categoria";
            this.opcCategoria.UseVisualStyleBackColor = true;
            this.opcCategoria.Click += new System.EventHandler(this.opcCategoria_Click);
            // 
            // precioProd
            // 
            this.precioProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.precioProd.Location = new System.Drawing.Point(38, 249);
            this.precioProd.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.precioProd.Name = "precioProd";
            this.precioProd.Size = new System.Drawing.Size(154, 20);
            this.precioProd.TabIndex = 28;
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
            this.buttonEliminar.Location = new System.Drawing.Point(502, 279);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(71, 23);
            this.buttonEliminar.TabIndex = 33;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Visible = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(39, 74);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 34;
            this.lblCod.Text = "Codigo";
            // 
            // textCod
            // 
            this.textCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textCod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCod.ForeColor = System.Drawing.Color.Black;
            this.textCod.Location = new System.Drawing.Point(41, 92);
            this.textCod.Name = "textCod";
            this.textCod.Size = new System.Drawing.Size(152, 13);
            this.textCod.TabIndex = 35;
            // 
            // buttonRecargar
            // 
            this.buttonRecargar.BackColor = System.Drawing.Color.Silver;
            this.buttonRecargar.FlatAppearance.BorderSize = 0;
            this.buttonRecargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonRecargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonRecargar.Location = new System.Drawing.Point(230, 279);
            this.buttonRecargar.Name = "buttonRecargar";
            this.buttonRecargar.Size = new System.Drawing.Size(79, 23);
            this.buttonRecargar.TabIndex = 36;
            this.buttonRecargar.Text = "Recargar";
            this.buttonRecargar.UseVisualStyleBackColor = false;
            this.buttonRecargar.Click += new System.EventHandler(this.buttonRecargar_Click);
            // 
            // alertaCodigo
            // 
            this.alertaCodigo.AutoSize = true;
            this.alertaCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.alertaCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.alertaCodigo.ForeColor = System.Drawing.Color.White;
            this.alertaCodigo.Location = new System.Drawing.Point(50, 51);
            this.alertaCodigo.Name = "alertaCodigo";
            this.alertaCodigo.Size = new System.Drawing.Size(132, 13);
            this.alertaCodigo.TabIndex = 37;
            this.alertaCodigo.Text = "El codigo ya fue registrado";
            this.alertaCodigo.Visible = false;
            // 
            // ProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(585, 342);
            this.Controls.Add(this.alertaCodigo);
            this.Controls.Add(this.buttonRecargar);
            this.Controls.Add(this.textCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.precioProd);
            this.Controls.Add(this.opcCategoria);
            this.Controls.Add(this.opcDescrip);
            this.Controls.Add(this.labelOrdenar);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textDescrip);
            this.Controls.Add(this.textCat);
            this.Controls.Add(this.labelPre);
            this.Controls.Add(this.labelDes);
            this.Controls.Add(this.labelCat);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductoForm";
            this.Text = "ProductoForm";
            this.Load += new System.EventHandler(this.ProductoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precioProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.Label labelPre;
        private System.Windows.Forms.TextBox textCat;
        private System.Windows.Forms.TextBox textDescrip;
        private System.Windows.Forms.Button buttonAceptar;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.DataGridView tablaProductos;
        private System.Windows.Forms.Label labelOrdenar;
        private System.Windows.Forms.RadioButton opcDescrip;
        private System.Windows.Forms.RadioButton opcCategoria;
        private System.Windows.Forms.NumericUpDown precioProd;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox textCod;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button buttonRecargar;
        private System.Windows.Forms.Label alertaCodigo;
    }
}

