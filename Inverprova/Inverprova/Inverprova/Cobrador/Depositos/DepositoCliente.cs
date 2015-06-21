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
    public partial class DepositoCliente : Form

    {

        public static Int64 id = 0;
        public static string nombre = null;
        public DepositoCliente()
        {
            InitializeComponent();
        }

        private void DepositoCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inverprova2DataSet.Clie' Puede moverla o quitarla según sea necesario.
            this.clieTableAdapter.Fill(this.inverprova2DataSet.Clie);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            id = Convert.ToInt64(clieDataGridView.CurrentRow.Cells[0].Value.ToString());
            nombre = clieDataGridView.CurrentRow.Cells[1].Value.ToString();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void clieDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
