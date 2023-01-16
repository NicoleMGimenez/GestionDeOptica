namespace Vistas
{
    partial class ListadoProductoForm
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
            this.components = new System.ComponentModel.Container();
            this.tablaProduct = new System.Windows.Forms.DataGridView();
            this.prodCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venNroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewProductoClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opticaDataSetProd = new Vistas.opticaDataSetProd();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cargarClientes = new System.Windows.Forms.ComboBox();
            this.buttonBusq = new System.Windows.Forms.Button();
            this.radioCliente = new System.Windows.Forms.RadioButton();
            this.radioFecha = new System.Windows.Forms.RadioButton();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dateDesde = new System.Windows.Forms.DateTimePicker();
            this.dateHasta = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.view_ProductoClienteTableAdapter = new Vistas.opticaDataSetProdTableAdapters.View_ProductoClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductoClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSetProd)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaProduct
            // 
            this.tablaProduct.AutoGenerateColumns = false;
            this.tablaProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodCategoriaDataGridViewTextBoxColumn,
            this.prodCodigoDataGridViewTextBoxColumn,
            this.venNroDataGridViewTextBoxColumn,
            this.venFechaDataGridViewTextBoxColumn});
            this.tablaProduct.DataSource = this.viewProductoClienteBindingSource;
            this.tablaProduct.Location = new System.Drawing.Point(127, 72);
            this.tablaProduct.Name = "tablaProduct";
            this.tablaProduct.Size = new System.Drawing.Size(442, 233);
            this.tablaProduct.TabIndex = 0;
            // 
            // prodCategoriaDataGridViewTextBoxColumn
            // 
            this.prodCategoriaDataGridViewTextBoxColumn.DataPropertyName = "Prod_Categoria";
            this.prodCategoriaDataGridViewTextBoxColumn.HeaderText = "Producto Comprado";
            this.prodCategoriaDataGridViewTextBoxColumn.Name = "prodCategoriaDataGridViewTextBoxColumn";
            // 
            // prodCodigoDataGridViewTextBoxColumn
            // 
            this.prodCodigoDataGridViewTextBoxColumn.DataPropertyName = "Prod_Codigo";
            this.prodCodigoDataGridViewTextBoxColumn.HeaderText = "Codigo del Producto";
            this.prodCodigoDataGridViewTextBoxColumn.Name = "prodCodigoDataGridViewTextBoxColumn";
            // 
            // venNroDataGridViewTextBoxColumn
            // 
            this.venNroDataGridViewTextBoxColumn.DataPropertyName = "Ven_Nro";
            this.venNroDataGridViewTextBoxColumn.HeaderText = "Venta Nro";
            this.venNroDataGridViewTextBoxColumn.Name = "venNroDataGridViewTextBoxColumn";
            // 
            // venFechaDataGridViewTextBoxColumn
            // 
            this.venFechaDataGridViewTextBoxColumn.DataPropertyName = "Ven_Fecha";
            this.venFechaDataGridViewTextBoxColumn.HeaderText = "Fecha de la Venta";
            this.venFechaDataGridViewTextBoxColumn.Name = "venFechaDataGridViewTextBoxColumn";
            // 
            // viewProductoClienteBindingSource
            // 
            this.viewProductoClienteBindingSource.DataMember = "View_ProductoCliente";
            this.viewProductoClienteBindingSource.DataSource = this.opticaDataSetProd;
            // 
            // opticaDataSetProd
            // 
            this.opticaDataSetProd.DataSetName = "opticaDataSetProd";
            this.opticaDataSetProd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(37, 30);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.Visible = false;
            // 
            // cargarClientes
            // 
            this.cargarClientes.FormattingEnabled = true;
            this.cargarClientes.Location = new System.Drawing.Point(85, 27);
            this.cargarClientes.Name = "cargarClientes";
            this.cargarClientes.Size = new System.Drawing.Size(155, 21);
            this.cargarClientes.TabIndex = 4;
            this.cargarClientes.Visible = false;
            this.cargarClientes.SelectedIndexChanged += new System.EventHandler(this.cargarClientes_SelectedIndexChanged);
            // 
            // buttonBusq
            // 
            this.buttonBusq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.buttonBusq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBusq.Location = new System.Drawing.Point(462, 311);
            this.buttonBusq.Name = "buttonBusq";
            this.buttonBusq.Size = new System.Drawing.Size(107, 23);
            this.buttonBusq.TabIndex = 5;
            this.buttonBusq.Text = "Buscar Productos";
            this.buttonBusq.UseVisualStyleBackColor = false;
            this.buttonBusq.Click += new System.EventHandler(this.buttonBusq_Click);
            // 
            // radioCliente
            // 
            this.radioCliente.AutoSize = true;
            this.radioCliente.Location = new System.Drawing.Point(12, 75);
            this.radioCliente.Name = "radioCliente";
            this.radioCliente.Size = new System.Drawing.Size(111, 17);
            this.radioCliente.TabIndex = 6;
            this.radioCliente.TabStop = true;
            this.radioCliente.Text = "Buscar por Cliente";
            this.radioCliente.UseVisualStyleBackColor = true;
            this.radioCliente.Click += new System.EventHandler(this.radioCliente_Click);
            // 
            // radioFecha
            // 
            this.radioFecha.AutoSize = true;
            this.radioFecha.Location = new System.Drawing.Point(12, 98);
            this.radioFecha.Name = "radioFecha";
            this.radioFecha.Size = new System.Drawing.Size(109, 17);
            this.radioFecha.TabIndex = 7;
            this.radioFecha.TabStop = true;
            this.radioFecha.Text = "Buscar por Fecha";
            this.radioFecha.UseVisualStyleBackColor = true;
            this.radioFecha.Click += new System.EventHandler(this.radioFecha_Click);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(162, 9);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(44, 13);
            this.lblDesde.TabIndex = 9;
            this.lblDesde.Text = "Desde: ";
            this.lblDesde.Visible = false;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(376, 9);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(41, 13);
            this.lblHasta.TabIndex = 10;
            this.lblHasta.Text = "Hasta: ";
            this.lblHasta.Visible = false;
            // 
            // dateDesde
            // 
            this.dateDesde.Location = new System.Drawing.Point(85, 28);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(201, 20);
            this.dateDesde.TabIndex = 11;
            this.dateDesde.Visible = false;
            // 
            // dateHasta
            // 
            this.dateHasta.Location = new System.Drawing.Point(308, 28);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(200, 20);
            this.dateHasta.TabIndex = 12;
            this.dateHasta.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(20, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 13);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Productos Vendidos";
            // 
            // lineShape7
            // 
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 21;
            this.lineShape7.X2 = 105;
            this.lineShape7.Y1 = 296;
            this.lineShape7.Y2 = 296;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape7});
            this.shapeContainer1.Size = new System.Drawing.Size(585, 342);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // view_ProductoClienteTableAdapter
            // 
            this.view_ProductoClienteTableAdapter.ClearBeforeFill = true;
            // 
            // ListadoProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(585, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateHasta);
            this.Controls.Add(this.dateDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.radioFecha);
            this.Controls.Add(this.radioCliente);
            this.Controls.Add(this.buttonBusq);
            this.Controls.Add(this.cargarClientes);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.tablaProduct);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoProductoForm";
            this.Text = "ListadoProductoForm";
            this.Load += new System.EventHandler(this.ListadoProductoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewProductoClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSetProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaProduct;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cargarClientes;
        private System.Windows.Forms.Button buttonBusq;
        private System.Windows.Forms.RadioButton radioCliente;
        private System.Windows.Forms.RadioButton radioFecha;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dateDesde;
        private System.Windows.Forms.DateTimePicker dateHasta;
        private opticaDataSetProd opticaDataSetProd;
        private System.Windows.Forms.BindingSource viewProductoClienteBindingSource;
        private opticaDataSetProdTableAdapters.View_ProductoClienteTableAdapter view_ProductoClienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venNroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn venFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}