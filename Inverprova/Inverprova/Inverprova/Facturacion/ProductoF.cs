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
    public partial class ProductoF : Form
    {
        public static int? id = 0;
        public static string Nombre = null;
        public static double Precio = 0;
        public static int cant;
        public static int Prov = 0;

        public ProductoF()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(proDuctosDataGridView.CurrentRow.Cells[0].Value.ToString());
            Nombre = proDuctosDataGridView.CurrentRow.Cells[1].Value.ToString();
            Precio = Convert.ToDouble(proDuctosDataGridView.CurrentRow.Cells[4].Value.ToString());
            //cant = Convert.ToInt32(textBox2.Text);
            Prov = Convert.ToInt32(proDuctosDataGridView.CurrentRow.Cells[3].Value.ToString());
            DialogResult = DialogResult.OK;
        }

        private void proDuctosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proDuctosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inverprova2DataSet);

        }

        private void ProductoF_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inverprova2DataSet.ProDuctos' Puede moverla o quitarla según sea necesario.
            this.proDuctosTableAdapter.Fill(this.inverprova2DataSet.ProDuctos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
