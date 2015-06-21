namespace Inverprova
{
    partial class ListadoFacturas
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
            this.label9 = new System.Windows.Forms.Label();
            this.inverprova2DataSet = new Inverprova.Inverprova2DataSet();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaTableAdapter = new Inverprova.Inverprova2DataSetTableAdapters.FacturaTableAdapter();
            this.tableAdapterManager = new Inverprova.Inverprova2DataSetTableAdapters.TableAdapterManager();
            this.facturaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inverprova2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(33, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 19);
            this.label9.TabIndex = 55;
            this.label9.Text = "Lista de Facturas";
            // 
            // inverprova2DataSet
            // 
            this.inverprova2DataSet.DataSetName = "Inverprova2DataSet";
            this.inverprova2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataMember = "Factura";
            this.facturaBindingSource.DataSource = this.inverprova2DataSet;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.DepositosTableAdapter = null;
            this.tableAdapterManager.Detalle_FacturaTableAdapter = null;
            this.tableAdapterManager.Detalle_OrdenTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.Estado_CuentaTableAdapter = null;
            this.tableAdapterManager.Estado_FacturaTableAdapter = null;
            this.tableAdapterManager.FacturaTableAdapter = this.facturaTableAdapter;
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
            // facturaDataGridView
            // 
            this.facturaDataGridView.AutoGenerateColumns = false;
            this.facturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.facturaDataGridView.DataSource = this.facturaBindingSource;
            this.facturaDataGridView.Location = new System.Drawing.Point(20, 89);
            this.facturaDataGridView.Name = "facturaDataGridView";
            this.facturaDataGridView.Size = new System.Drawing.Size(843, 353);
            this.facturaDataGridView.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numero_factura";
            this.dataGridViewTextBoxColumn1.HeaderText = "Número Factura";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fecha_factura";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha Factura";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "codigo_cliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "Código Cliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "descuento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descuento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "isv";
            this.dataGridViewTextBoxColumn5.HeaderText = "ISV";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "codigo_pago";
            this.dataGridViewTextBoxColumn6.HeaderText = "Código Pago";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "codigo_vendedor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Codigo Vendedor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "codigo_estado";
            this.dataGridViewTextBoxColumn8.HeaderText = "Código Estado";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(711, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 41);
            this.button2.TabIndex = 58;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListadoFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inverprova.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 469);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.facturaDataGridView);
            this.Controls.Add(this.label9);
            this.Name = "ListadoFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado Facturas";
            this.Load += new System.EventHandler(this.ListadoFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inverprova2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private Inverprova2DataSet inverprova2DataSet;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private Inverprova2DataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private Inverprova2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView facturaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button2;
    }
}