namespace Inverprova
{
    partial class BusquedaEmpleados
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
            this.inverprova2DataSet = new Inverprova.Inverprova2DataSet();
            this.buscarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscarTableAdapter = new Inverprova.Inverprova2DataSetTableAdapters.BuscarTableAdapter();
            this.tableAdapterManager = new Inverprova.Inverprova2DataSetTableAdapters.TableAdapterManager();
            this.buscarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inverprova2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inverprova2DataSet
            // 
            this.inverprova2DataSet.DataSetName = "Inverprova2DataSet";
            this.inverprova2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarBindingSource
            // 
            this.buscarBindingSource.DataMember = "Buscar";
            this.buscarBindingSource.DataSource = this.inverprova2DataSet;
            // 
            // buscarTableAdapter
            // 
            this.buscarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DepositosTableAdapter = null;
            this.tableAdapterManager.Detalle_FacturaTableAdapter = null;
            this.tableAdapterManager.Detalle_OrdenTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.Estado_CuentaTableAdapter = null;
            this.tableAdapterManager.Estado_FacturaTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.ProDuctosTableAdapter = null;
            this.tableAdapterManager.ProveedorTableAdapter = null;
            this.tableAdapterManager.RecibosTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.Tipo_CompraTableAdapter = null;
            this.tableAdapterManager.Tipo_DocumentoTableAdapter = null;
            this.tableAdapterManager.Tipo_PagoTableAdapter = null;
            this.tableAdapterManager.Tipo_ReciboTableAdapter = null;
            this.tableAdapterManager.Tipo_TransaccionTableAdapter = null;
            this.tableAdapterManager.TransaccionesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Inverprova.Inverprova2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buscarDataGridView
            // 
            this.buscarDataGridView.AutoGenerateColumns = false;
            this.buscarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buscarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.buscarDataGridView.DataSource = this.buscarBindingSource;
            this.buscarDataGridView.Location = new System.Drawing.Point(29, 195);
            this.buscarDataGridView.Name = "buscarDataGridView";
            this.buscarDataGridView.Size = new System.Drawing.Size(1023, 220);
            this.buscarDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo_empleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "codigo_empleado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_empleado";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre_empleado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellido_empleado";
            this.dataGridViewTextBoxColumn3.HeaderText = "apellido_empleado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "direccion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fechanac_empleado";
            this.dataGridViewTextBoxColumn6.HeaderText = "fechanac_empleado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fechacontra_empleado";
            this.dataGridViewTextBoxColumn7.HeaderText = "fechacontra_empleado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "rol_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "rol_id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "usuario";
            this.dataGridViewTextBoxColumn9.HeaderText = "usuario";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Column1";
            this.dataGridViewTextBoxColumn10.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mostrar Todos",
            "Nombre",
            "Id"});
            this.comboBox1.Location = new System.Drawing.Point(96, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(204, 149);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(226, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 44);
            this.button2.TabIndex = 55;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BusquedaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buscarDataGridView);
            this.Name = "BusquedaEmpleados";
            this.Text = "BusquedaEmpleados";
            this.Load += new System.EventHandler(this.BusquedaEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inverprova2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Inverprova2DataSet inverprova2DataSet;
        private System.Windows.Forms.BindingSource buscarBindingSource;
        private Inverprova2DataSetTableAdapters.BuscarTableAdapter buscarTableAdapter;
        private Inverprova2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView buscarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}