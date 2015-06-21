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
    public partial class ListadoFacturas : Form
    {
        public ListadoFacturas()
        {
            InitializeComponent();
        }

        private void facturaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facturaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inverprova2DataSet);

        }

        private void ListadoFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inverprova2DataSet.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.inverprova2DataSet.Factura);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
