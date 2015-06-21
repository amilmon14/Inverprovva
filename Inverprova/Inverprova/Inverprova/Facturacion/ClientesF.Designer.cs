namespace Inverprova
{
    partial class ClientesF
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.inverprova2DataSet = new Inverprova.Inverprova2DataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new Inverprova.Inverprova2DataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new Inverprova.Inverprova2DataSetTableAdapters.TableAdapterManager();
            this.clBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clTableAdapter = new Inverprova.Inverprova2DataSetTableAdapters.ClTableAdapter();
            this.clDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inverprova2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(27, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 63;
            this.label9.Text = "Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(56, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "Nombre:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(397, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 41);
            this.button1.TabIndex = 61;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 20);
            this.txtNombre.TabIndex = 59;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // inverprova2DataSet
            // 
            this.inverprova2DataSet.DataSetName = "Inverprova2DataSet";
            this.inverprova2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.inverprova2DataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.ComprasTableAdapter = null;
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
            // clBindingSource
            // 
            this.clBindingSource.DataMember = "Cl";
            this.clBindingSource.DataSource = this.inverprova2DataSet;
            // 
            // clTableAdapter
            // 
            this.clTableAdapter.ClearBeforeFill = true;
            // 
            // clDataGridView
            // 
            this.clDataGridView.AutoGenerateColumns = false;
            this.clDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.clDataGridView.DataSource = this.clBindingSource;
            this.clDataGridView.Location = new System.Drawing.Point(13, 138);
            this.clDataGridView.Name = "clDataGridView";
            this.clDataGridView.Size = new System.Drawing.Size(643, 204);
            this.clDataGridView.TabIndex = 65;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(528, 382);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 41);
            this.button2.TabIndex = 67;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codigo_cliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código Cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre_cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellido_cliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "Apellido Cliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "telefono_cliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "teléfono Cliente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "direccion_cliente";
            this.dataGridViewTextBoxColumn5.HeaderText = "Dirección Cliente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "email_cliente";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email Cliente";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ClientesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inverprova.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 453);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clDataGridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNombre);
            this.Name = "ClientesF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientesF";
            this.Load += new System.EventHandler(this.ClientesF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inverprova2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombre;
        private Inverprova2DataSet inverprova2DataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private Inverprova2DataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private Inverprova2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource clBindingSource;
        private Inverprova2DataSetTableAdapters.ClTableAdapter clTableAdapter;
        private System.Windows.Forms.DataGridView clDataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}