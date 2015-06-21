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
namespace Inverprova
{
    public partial class Cobros : Form
    {
        public static Int64? h;
        public static Int64? x;
        public static double? e;

        string nombre = Form1.nombre;
        string apellido = Form1.apellido;

        QueriesTableAdapter mostrar = new QueriesTableAdapter();
        public Cobros()
        {
            InitializeComponent();
            this.hTableAdapter.Fill(this.inverprova2DataSet.h, txtNombre.Text);
            

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.hTableAdapter.Fill(this.inverprova2DataSet.h, nombreToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void Cobros_Load(object sender, EventArgs e)
        {
            hDataGridView.Refresh();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = txtNombre.Text.Replace("  ", " ");
            txtNombre.Select(txtNombre.Text.Length, 0);

            txtNombre.MaxLength = 30;
            mostrar.h(txtNombre.Text);
            this.hTableAdapter.Fill(this.inverprova2DataSet.h, txtNombre.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            cobrador tm = new cobrador(nombre, apellido);
            tm.Show();
        }
    }
}
