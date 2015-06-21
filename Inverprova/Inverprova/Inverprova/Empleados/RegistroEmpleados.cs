using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inverprova.Inverprova2DataSetTableAdapters;
using System.IO;

namespace Inverprova
{
    public partial class RegistroEmpleados : Form
    {
        public RegistroEmpleados()
        {
            InitializeComponent();
        }

        QueriesTableAdapter ss = new QueriesTableAdapter();

        Validacion v = new Validacion();
       
        private void Guardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtUsuario.Text == "" || txtContraseña.Text == "")
            {


                MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ss.AgregarE(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, Convert.ToString(dtNacimiento.Value), Convert.ToString(dtContrato.Value), Convert.ToInt64(cargo.SelectedValue), txtUsuario.Text, txtContraseña.Text);
                MessageBox.Show("Datos Guardados Correctamente");
                limpiar();

            }
        }
       

        private void RegistroEmpleados_Load(object sender, EventArgs e)
        {
            cargo.DataSource = Empleados.ObtenerRoles();
            cargo.DisplayMember = "Nombre";
            cargo.ValueMember = "Id";
            Actualizar.Enabled = false;

        
        }

        void limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            dtNacimiento.ResetText();
            dtContrato.ResetText();
            /*  cargo.ResetText();*/
            txtUsuario.Clear();
            txtContraseña.Clear();
            
        }

        private void Buscar_Click(object sender, EventArgs e)
        {

            BusquedaEmpleados l = new BusquedaEmpleados();
            if (l.ShowDialog() == DialogResult.OK)
            {
                //new Form3().Show();
                txtCodigo.Text = Convert.ToString(BusquedaEmpleados.Cog);
                txtNombre.Text = BusquedaEmpleados.Nomb;
                txtApellido.Text = BusquedaEmpleados.ape;
                txtDireccion.Text = BusquedaEmpleados.Dir;
                txtTelefono.Text = BusquedaEmpleados.telef;
                txtUsuario.Text = BusquedaEmpleados.usuario;
                txtContraseña.Text = BusquedaEmpleados.contra;
                dtNacimiento.Value = Convert.ToDateTime(BusquedaEmpleados.fechaN);
                   dtContrato.Value = Convert.ToDateTime(BusquedaEmpleados.fechaC);
                   cargo.SelectedValue = BusquedaEmpleados.Carg;
                   Guardar.Enabled = false;
                   Actualizar.Enabled = true;
            }
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtUsuario.Text == "" || txtContraseña.Text == "")
            {


                MessageBox.Show("Debe llenar todos los Campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                ss.Actualizar(Convert.ToInt64(txtCodigo.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, Convert.ToString(dtNacimiento.Value), Convert.ToString(dtContrato.Value), Convert.ToInt64(cargo.SelectedValue), txtUsuario.Text, txtContraseña.Text);
                MessageBox.Show("Datos Actualizados Correctamente");
                limpiar();
                Guardar.Enabled = true;
                Actualizar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = txtNombre.Text.Replace("  ", " ");
            txtNombre.Select(txtNombre.Text.Length, 0);

            txtNombre.MaxLength = 30;
        }

        private void txtNombre_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("No se puede utilizar el boton derecho");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);


            if (e.KeyChar == 8)
            { e.Handled = false; }

            if (txtNombre.Text.Length == 0)
            { e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0]; }


            if (txtNombre.Text == "")
            {
                if (e.KeyChar == 32)
                    e.Handled = true;


            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            txtApellido.Text = txtApellido.Text.Replace("  ", " ");
            txtApellido.Select(txtApellido.Text.Length, 0);

            txtApellido.MaxLength = 30;
        }

        private void txtApellido_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("No se puede utilizar el boton derecho");
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            v.SoloLetras(e);


            if (e.KeyChar == 8)
            { e.Handled = false; }

            if (txtApellido.Text.Length == 0)
            { e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0]; }


            if (txtApellido.Text == "")
            {
                if (e.KeyChar == 32)
                    e.Handled = true;


            }
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtDireccion.Text = txtDireccion.Text.Replace("  ", " ");
            txtDireccion.Select(txtDireccion.Text.Length, 0);

            txtDireccion.MaxLength = 60;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = txtUsuario.Text.Replace("  ", " ");
            txtUsuario.Select(txtUsuario.Text.Length, 0);

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                if (e.KeyChar == 32)
                    e.Handled = true;

            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57/*Admite los numeros del 0 al 9*/|| e.KeyChar == 8/* codigo ascii del backspace*/)
            {

                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void txtUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("No se puede utilizar el boton derecho");
            }
        }

        private void txtContraseña_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("No se puede utilizar el boton derecho");
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                if (e.KeyChar == 32)
                    e.Handled = true;

            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57/*Admite los numeros del 0 al 9*/|| e.KeyChar == 8/* codigo ascii del backspace*/)
            {

                e.Handled = false;
            }
            else if ((e.KeyChar >= 65 && e.KeyChar <= 90)
                || (e.KeyChar >= 97 && e.KeyChar <= 122)
                || e.KeyChar == 8 || e.KeyChar == 'ñ' || e.KeyChar == 'Ñ')
            {
                e.Handled = false;

            }
            else e.Handled = true;
        }
    }
}
