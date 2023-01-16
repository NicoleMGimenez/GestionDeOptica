namespace Vistas
{
    partial class btnSeleccionarCliente
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
            this.OrdDni = new System.Windows.Forms.Button();
            this.OrdCarnet = new System.Windows.Forms.Button();
            this.OrdApellido = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.opticaDataSet1 = new Vistas.opticaDataSet1();
            this.clienteTableAdapter = new Vistas.opticaDataSet1TableAdapters.ClienteTableAdapter();
            this.textnom = new System.Windows.Forms.TextBox();
            this.textape = new System.Windows.Forms.TextBox();
            this.BusquedaAvan = new System.Windows.Forms.Button();
            this.textDNI = new System.Windows.Forms.TextBox();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.labelNom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdDni
            // 
            this.OrdDni.AutoSize = true;
            this.OrdDni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrdDni.Location = new System.Drawing.Point(423, 61);
            this.OrdDni.Name = "OrdDni";
            this.OrdDni.Size = new System.Drawing.Size(148, 25);
            this.OrdDni.TabIndex = 0;
            this.OrdDni.Text = "Ordenar por DNI";
            this.OrdDni.UseVisualStyleBackColor = true;
            this.OrdDni.Click += new System.EventHandler(this.OrdDni_Click);
            // 
            // OrdCarnet
            // 
            this.OrdCarnet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrdCarnet.Location = new System.Drawing.Point(423, 138);
            this.OrdCarnet.Name = "OrdCarnet";
            this.OrdCarnet.Size = new System.Drawing.Size(148, 23);
            this.OrdCarnet.TabIndex = 1;
            this.OrdCarnet.Text = "Ordenar por Nro Carnet";
            this.OrdCarnet.UseVisualStyleBackColor = true;
            this.OrdCarnet.Click += new System.EventHandler(this.OrdCarnet_Click);
            // 
            // OrdApellido
            // 
            this.OrdApellido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrdApellido.Location = new System.Drawing.Point(423, 100);
            this.OrdApellido.Name = "OrdApellido";
            this.OrdApellido.Size = new System.Drawing.Size(148, 23);
            this.OrdApellido.TabIndex = 2;
            this.OrdApellido.Text = "Ordenar por Apellido";
            this.OrdApellido.UseVisualStyleBackColor = true;
            this.OrdApellido.Click += new System.EventHandler(this.OrdApellido_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 272);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.opticaDataSet1;
            // 
            // opticaDataSet1
            // 
            this.opticaDataSet1.DataSetName = "opticaDataSet1";
            this.opticaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // textnom
            // 
            this.textnom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textnom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textnom.Location = new System.Drawing.Point(22, 28);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(100, 13);
            this.textnom.TabIndex = 4;
            // 
            // textape
            // 
            this.textape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textape.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textape.Location = new System.Drawing.Point(141, 27);
            this.textape.Name = "textape";
            this.textape.Size = new System.Drawing.Size(100, 13);
            this.textape.TabIndex = 5;
            // 
            // BusquedaAvan
            // 
            this.BusquedaAvan.BackColor = System.Drawing.Color.Silver;
            this.BusquedaAvan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BusquedaAvan.Location = new System.Drawing.Point(425, 23);
            this.BusquedaAvan.Name = "BusquedaAvan";
            this.BusquedaAvan.Size = new System.Drawing.Size(146, 23);
            this.BusquedaAvan.TabIndex = 7;
            this.BusquedaAvan.Text = "Buscar Cliente";
            this.BusquedaAvan.UseVisualStyleBackColor = false;
            this.BusquedaAvan.Click += new System.EventHandler(this.BusquedaAvan_Click);
            // 
            // textDNI
            // 
            this.textDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.textDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDNI.Location = new System.Drawing.Point(261, 27);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(100, 13);
            this.textDNI.TabIndex = 8;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 22;
            this.lineShape3.X2 = 121;
            this.lineShape3.Y1 = 43;
            this.lineShape3.Y2 = 43;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1,
            this.lineShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(585, 342);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 260;
            this.lineShape2.X2 = 360;
            this.lineShape2.Y1 = 43;
            this.lineShape2.Y2 = 43;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 140;
            this.lineShape1.X2 = 238;
            this.lineShape1.Y1 = 43;
            this.lineShape1.Y2 = 43;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(19, 9);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(44, 13);
            this.labelNom.TabIndex = 10;
            this.labelNom.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "DNI";
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.BackColor = System.Drawing.Color.Silver;
            this.btn_seleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_seleccionar.Location = new System.Drawing.Point(425, 307);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(148, 23);
            this.btn_seleccionar.TabIndex = 13;
            this.btn_seleccionar.Text = "Seleccionar Cliente";
            this.btn_seleccionar.UseVisualStyleBackColor = false;
            this.btn_seleccionar.Visible = false;
            this.btn_seleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeleccionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(166)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(585, 342);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.BusquedaAvan);
            this.Controls.Add(this.textape);
            this.Controls.Add(this.textnom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OrdApellido);
            this.Controls.Add(this.OrdCarnet);
            this.Controls.Add(this.OrdDni);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "btnSeleccionarCliente";
            this.Text = "buscarCliente";
            this.Load += new System.EventHandler(this.buscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrdDni;
        private System.Windows.Forms.Button OrdCarnet;
        private System.Windows.Forms.Button OrdApellido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private opticaDataSet1 opticaDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private opticaDataSet1TableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.TextBox textape;
        private System.Windows.Forms.Button BusquedaAvan;
        private System.Windows.Forms.TextBox textDNI;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_seleccionar;
    }
}