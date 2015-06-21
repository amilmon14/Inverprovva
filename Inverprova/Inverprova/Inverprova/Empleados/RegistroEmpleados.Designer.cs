namespace Inverprova
{
    partial class RegistroEmpleados
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
            this.dtContrato = new System.Windows.Forms.DateTimePicker();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cargo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtContrato
            // 
            this.dtContrato.Location = new System.Drawing.Point(267, 327);
            this.dtContrato.Name = "dtContrato";
            this.dtContrato.Size = new System.Drawing.Size(196, 20);
            this.dtContrato.TabIndex = 87;
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.Location = new System.Drawing.Point(267, 292);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(196, 20);
            this.dtNacimiento.TabIndex = 86;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(427, 256);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 85;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(267, 255);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Mask = "0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ResetOnSpace = false;
            this.txtTelefono.Size = new System.Drawing.Size(196, 20);
            this.txtTelefono.TabIndex = 67;
            this.txtTelefono.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(467, 435);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 18);
            this.checkBox1.TabIndex = 80;
            this.checkBox1.Text = "Mostrar Contraseña";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(268, 107);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(196, 20);
            this.txtCodigo.TabIndex = 84;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Maroon;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(134, 109);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 15);
            this.label11.TabIndex = 83;
            this.label11.Text = "Código Empleado";
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(283, 466);
            this.Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(91, 29);
            this.Buscar.TabIndex = 78;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Maroon;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(134, 297);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 15);
            this.label10.TabIndex = 82;
            this.label10.Text = "Fecha de Nacimiento";
            // 
            // Salir
            // 
            this.Salir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(466, 466);
            this.Salir.Margin = new System.Windows.Forms.Padding(2);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(91, 29);
            this.Salir.TabIndex = 79;
            this.Salir.Text = "Menú";
            this.Salir.UseVisualStyleBackColor = true;
            // 
            // Guardar
            // 
            this.Guardar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(52, 466);
            this.Guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(91, 29);
            this.Guardar.TabIndex = 74;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.Location = new System.Drawing.Point(156, 466);
            this.Actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(91, 29);
            this.Actualizar.TabIndex = 75;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(72, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 19);
            this.label9.TabIndex = 81;
            this.label9.Text = "Registro de Empleados";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(267, 433);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.MaxLength = 8;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(196, 20);
            this.txtContraseña.TabIndex = 73;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            this.txtContraseña.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtContraseña_MouseDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(267, 397);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.MaxLength = 13;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(196, 20);
            this.txtUsuario.TabIndex = 72;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtUsuario_MouseDown);
            // 
            // cargo
            // 
            this.cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cargo.FormattingEnabled = true;
            this.cargo.Location = new System.Drawing.Point(267, 361);
            this.cargo.Margin = new System.Windows.Forms.Padding(2);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(196, 21);
            this.cargo.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Maroon;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(134, 435);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 77;
            this.label8.Text = "Contraseña";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(267, 221);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(196, 20);
            this.txtDireccion.TabIndex = 66;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(268, 183);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(196, 20);
            this.txtApellido.TabIndex = 64;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            this.txtApellido.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtApellido_MouseDown);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(267, 145);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(196, 20);
            this.txtNombre.TabIndex = 61;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtNombre_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Maroon;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(134, 399);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 70;
            this.label7.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Maroon;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(134, 363);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 15);
            this.label6.TabIndex = 69;
            this.label6.Text = "Rol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(134, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 68;
            this.label5.Text = "Fecha de Contrato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(134, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 65;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(134, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 63;
            this.label3.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(134, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(134, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nombre";
            // 
            // RegistroEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 591);
            this.Controls.Add(this.dtContrato);
            this.Controls.Add(this.dtNacimiento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cargo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroEmpleados";
            this.Text = "RegistroEmpleados";
            this.Load += new System.EventHandler(this.RegistroEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtContrato;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.ComboBox cargo;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}