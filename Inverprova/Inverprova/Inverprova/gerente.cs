using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inverprova
{
    public partial class gerente : Form
    {
        public gerente(string nombre , string apellido)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.apellido = apellido;
        }
        string nombre;
        string apellido;
        private void gerente_Load(object sender, EventArgs e)
        {

            label1.Text = "Bienvenido" + " " + nombre + " " + apellido;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes fm = new Clientes();
            fm.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Proveedores wm = new Proveedores();
            wm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           RegistroEmpleados wm = new RegistroEmpleados();
            wm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos sm = new Productos();
            sm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListadoFacturas mm = new ListadoFacturas();
            mm.Show();
            
        }
    }
}
