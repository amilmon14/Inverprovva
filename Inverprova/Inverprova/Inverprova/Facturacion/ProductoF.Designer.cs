namespace Inverprova
{
    partial class ProductoF
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
            this.button2 = new System.Windows.Forms.Button();
            this.inverprova2DataSet = new Inverprova.Inverprova2DataSet();
            this.proDuctosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proDuctosTableAdapter = new Inverprova.Inverprova2DataSetTableAdapters.ProDuctosTableAdapter();
            this.tableAdapterManager = new Inverprova.Inverprova2DataSetTableAdapters.TableAdapterManager();
            this.proDuctosDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inverprova2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proDuctosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proDuctosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(39, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 56;
            this.label9.Text = "Productos";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(543, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 40);
            this.button2.TabIndex = 54;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inverprova2DataSet
            // 
            this.inverprova2DataSet.DataSetName = "Inverprova2DataSet";
            this.inverprova2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proDuctosBindingSource
            // 
            this.proDuctosBindingSource.DataMember = "ProDuctos";
            this.proDuctosBindingSource.DataSource = this.inverprova2DataSet;
            // 
            // proDuctosTableAdapter
            // 
            this.proDuctosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FacturaTableAdapter = null;
            this.tableAdapterManager.ProDuctosTableAdapter = this.proDuctosTableAdapter;
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
            // proDuctosDataGridView
            // 
            this.proDuctosDataGridView.AutoGenerateColumns = false;
            this.proDuctosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proDuctosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.proDuctosDataGridView.DataSource = this.proDuctosBindingSource;
            this.proDuctosDataGridView.Location = new System.Drawing.Point(26, 158);
            this.proDuctosDataGridView.Name = "proDuctosDataGridView";
            this.proDuctosDataGridView.Size = new System.Drawing.Size(644, 285);
            this.proDuctosDataGridView.TabIndex = 57;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(543, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 59;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo_producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descripcion_producto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripción Producto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "codigo_proveedor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Código Proveedor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "precioVenta_producto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio Venta";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "precioCompra_producto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Precio Compra";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ProductoF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inverprova.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 475);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.proDuctosDataGridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Name = "ProductoF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto Factura";
            this.Load += new System.EventHandler(this.ProductoF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inverprova2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proDuctosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proDuctosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private Inverprova2DataSet inverprova2DataSet;
        private System.Windows.Forms.BindingSource proDuctosBindingSource;
        private Inverprova2DataSetTableAdapters.ProDuctosTableAdapter proDuctosTableAdapter;
        private Inverprova2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView proDuctosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
    }
}