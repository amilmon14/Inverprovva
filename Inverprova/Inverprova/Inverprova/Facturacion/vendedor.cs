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
    public partial class vendedor : Form
    {
        public vendedor(string nom, string ape, Int64 a)
        {
            InitializeComponent();
            this.nom = nom;
            this.ape = ape;
            this.a = a;
        }

        string nom;
        string ape;
        Int64 a;
        private void vendedor_Load(object sender, EventArgs e)
        {
            label1.Text = nom + " " + ape;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facturacion nm = new Facturacion(a);
            nm.Show();
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
