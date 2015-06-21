namespace Inverprova
{
    partial class OrdenPedidoF
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cargar_FactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inverprova2DataSet = new Inverprova.Inverprova2DataSet();
            this.cargar_FactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cargar_FactTableAdapter = new Inverprova.Inverprova2DataSetTableAdapters.cargar_FactTableAdapter();
            this.tableAdapterManager = new Inverprova.Inverprova2DataSetTableAdapters.TableAdapterManager();
            this.cargar_FactDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cargar_FactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inverprova2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargar_FactBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargar_FactDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(31, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Lista de Facturas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Número de Factura";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(705, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(705, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 21;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cargar_FactBindingSource
            // 
            this.cargar_FactBindingSource.DataMember = "cargar_Fact";
            // 
            // inverprova2DataSet
            // 
            this.inverprova2DataSet.DataSetName = "Inverprova2DataSet";
            this.inverprova2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cargar_FactBindingSource1
            // 
            this.cargar_FactBindingSource1.DataMember = "cargar_Fact";
            this.cargar_FactBindingSource1.DataSource = this.inverprova2DataSet;
            // 
            // cargar_FactTableAdapter
            // 
            this.cargar_FactTableAdapter.ClearBeforeFill = true;
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
            // cargar_FactDataGridView
            // 
            this.cargar_FactDataGridView.AutoGenerateColumns = false;
            this.cargar_FactDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cargar_FactDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.cargar_FactDataGridView.DataSource = this.cargar_FactBindingSource1;
            this.cargar_FactDataGridView.Location = new System.Drawing.Point(26, 156);
            this.cargar_FactDataGridView.Name = "cargar_FactDataGridView";
            this.cargar_FactDataGridView.Size = new System.Drawing.Size(846, 323);
            this.cargar_FactDataGridView.TabIndex = 25;
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
            this.dataGridViewTextBoxColumn7.HeaderText = "Código Vendedor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "codigo_estado";
            this.dataGridViewTextBoxColumn8.HeaderText = "Código Estado";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // OrdenPedidoF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inverprova.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 510);
            this.ControlBox = false;
            this.Controls.Add(this.cargar_FactDataGridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "OrdenPedidoF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden Pedido Factura";
            this.Load += new System.EventHandler(this.OrdenPedidoF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cargar_FactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inverprova2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargar_FactBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargar_FactDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource cargar_FactBindingSource;
        private Inverprova2DataSet inverprova2DataSet;
        private System.Windows.Forms.BindingSource cargar_FactBindingSource1;
        private Inverprova2DataSetTableAdapters.cargar_FactTableAdapter cargar_FactTableAdapter;
        private Inverprova2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cargar_FactDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}