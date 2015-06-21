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
    public partial class cobrador : Form
    {
        public cobrador(string nombre, string apellido)
        {
            InitializeComponent();
            this.nombre = nombre;
            this.apellido = apellido;
        }
         string nombre;
        string apellido;
        public static int h = Convert.ToInt16(Form1.id);
        private void cobrador_Load(object sender, EventArgs e)
        {
            label1.Text = "Bienvenido(a) " + nombre + " " + apellido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            OrdenPedido m = new OrdenPedido();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Depositos n = new Depositos();
            n.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cobros n = new Cobros();
            n.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
