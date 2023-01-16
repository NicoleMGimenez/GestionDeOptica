namespace Vistas
{
    partial class ListadoVentaForm
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
            this.tablaVentas = new System.Windows.Forms.DataGridView();
            this.viewVentaClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opticaDataSet = new Vistas.opticaDataSet();
            this.view_VentaClientesTableAdapter = new Vistas.opticaDataSetTableAdapters.View_VentaClientesTableAdapter();
            this.cargarClientes = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.buttonBuscarC = new System.Windows.Forms.Button();
            this.radioCliente = new System.Windows.Forms.RadioButton();
            this.radioFecha = new System.Windows.Forms.RadioButton();
            this.dateDes = new System.Windows.Forms.DateTimePicker();
            this.dateHas = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewVentaClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaVentas
            // 
            this.tablaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVentas.Location = new System.Drawing.Point(126, 72);
            this.tablaVentas.Name = "tablaVentas";
            this.tablaVentas.Size = new System.Drawing.Size(447, 232);
            this.tablaVentas.TabIndex = 0;
            this.tablaVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaVentas_CellClick);
         
            // 
            // viewVentaClientesBindingSource
            // 
            this.viewVentaClientesBindingSource.DataMember = "View_VentaClientes";
            this.viewVentaClientesBindingSource.DataSource = this.opticaDataSet;
            // 
            // opticaDataSet
            // 
            this.opticaDataSet.DataSetName = "opticaDataSet";
            this.opticaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_VentaClientesTableAdapter
            // 
            this.view_VentaClientesTableAdapter.ClearBeforeFill = true;
            // 
            // cargarClientes
            // 
            this.cargarClientes.FormattingEnabled = true;
            this.cargarClientes.Location = new System.Drawing.Point(85, 31);
            this.cargarClientes.Name = "cargarClientes";
            this.cargarClientes.Size = new System.Drawing.Size(121, 21);
            this.cargarClientes.TabIndex = 1;
            this.cargarClientes.Visible = false;
            this.cargarClientes.SelectedIndexChanged += new System.EventHandler(this.cargarClientes_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(37, 34);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.Visible = false;
            // 
            // buttonBuscarC
            // 
            this.buttonBuscarC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBuscarC.Location = new System.Drawing.Point(481, 310);
            this.buttonBuscarC.Name = "buttonBuscarC";
            this.buttonBuscarC.Size = new System.Drawing.Size(92, 23);
            this.buttonBuscarC.TabIndex = 3;
            this.buttonBuscarC.Text = "Buscar Ventas";
            this.buttonBuscarC.UseVisualStyleBackColor = true;
            this.buttonBuscarC.Click += new System.EventHandler(this.buttonBuscarC_Click);
            // 
            // radioCliente
            // 
            this.radioCliente.AutoSize = true;
            this.radioCliente.Location = new System.Drawing.Point(7, 75);
            this.radioCliente.Name = "radioCliente";
            this.radioCliente.Size = new System.Drawing.Size(111, 17);
            this.radioCliente.TabIndex = 4;
            this.radioCliente.TabStop = true;
            this.radioCliente.Text = "Buscar por Cliente";
            this.radioCliente.UseVisualStyleBackColor = true;
            this.radioCliente.Click += new System.EventHandler(this.radioCliente_Click);
            // 
            // radioFecha
            // 
            this.radioFecha.AutoSize = true;
            this.radioFecha.Location = new System.Drawing.Point(7, 98);
            this.radioFecha.Name = "radioFecha";
            this.radioFecha.Size = new System.Drawing.Size(109, 17);
            this.radioFecha.TabIndex = 5;
            this.radioFecha.TabStop = true;
            this.radioFecha.Text = "Buscar por Fecha";
            this.radioFecha.UseVisualStyleBackColor = true;
            this.radioFecha.Click += new System.EventHandler(this.radioFecha_Click);
            // 
            // dateDes
            // 
            this.dateDes.Location = new System.Drawing.Point(85, 32);
            this.dateDes.Name = "dateDes";
            this.dateDes.Size = new System.Drawing.Size(198, 20);
            this.dateDes.TabIndex = 6;
            this.dateDes.Visible = false;
            // 
            // dateHas
            // 
            this.dateHas.Location = new System.Drawing.Point(289, 32);
            this.dateHas.Name = "dateHas";
            this.dateHas.Size = new System.Drawing.Size(212, 20);
            this.dateHas.TabIndex = 7;
            this.dateHas.Visible = false;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(171, 10);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(44, 13);
            this.lblDesde.TabIndex = 8;
            this.lblDesde.Text = "Desde: ";
            this.lblDesde.Visible = false;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(383, 10);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(41, 13);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta: ";
            this.lblHasta.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(406, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cantidad de ventas";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(26, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 13);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lineShape7
            // 
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 25;
            this.lineShape7.X2 = 104;
            this.lineShape7.Y1 = 301;
            this.lineShape7.Y2 = 301;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape7});
            this.shapeContainer1.Size = new System.Drawing.Size(585, 342);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // ListadoVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(585, 342);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dateHas);
            this.Controls.Add(this.dateDes);
            this.Controls.Add(this.radioFecha);
            this.Controls.Add(this.radioCliente);
            this.Controls.Add(this.buttonBuscarC);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cargarClientes);
            this.Controls.Add(this.tablaVentas);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoVentaForm";
            this.Text = "ListadoVentaForm";
            this.Load += new System.EventHandler(this.ListadoVentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewVentaClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaVentas;
        private opticaDataSet opticaDataSet;
        private System.Windows.Forms.BindingSource viewVentaClientesBindingSource;
        private opticaDataSetTableAdapters.View_VentaClientesTableAdapter view_VentaClientesTableAdapter;
        private System.Windows.Forms.ComboBox cargarClientes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button buttonBuscarC;
        private System.Windows.Forms.RadioButton radioCliente;
        private System.Windows.Forms.RadioButton radioFecha;
        private System.Windows.Forms.DateTimePicker dateDes;
        private System.Windows.Forms.DateTimePicker dateHas;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}