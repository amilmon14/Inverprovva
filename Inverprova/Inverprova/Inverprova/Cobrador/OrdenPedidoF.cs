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
    public partial class OrdenPedidoF : Form
    {
        public OrdenPedidoF()
        {
            InitializeComponent();
        }
         QueriesTableAdapter mostrar = new QueriesTableAdapter();
        public static int id = 0;
        public static Int64 Cli = 0;

        private void OrdenPedidoF_Load(object sender, EventArgs e)
        {

            cargar_FactDataGridView.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(cargar_FactDataGridView.CurrentRow.Cells[0].Value.ToString());
            Cli = Convert.ToInt64(cargar_FactDataGridView.CurrentRow.Cells[2].Value.ToString());
            DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                //textBox1.Text = Convert.ToString(0);
                mostrar.cargar_Fact(0);
                
                this.cargar_FactTableAdapter.Fill(inverprova2DataSet.cargar_Fact, 0);
            }
            else
            //if (textBox1.Text != "")
            {
                mostrar.cargar_Fact(Convert.ToInt64(textBox1.Text));
                this.cargar_FactTableAdapter.Fill(inverprova2DataSet.cargar_Fact, Convert.ToInt32(textBox1.Text));
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
