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
    public partial class BusquedaEmpleados : Form
    {
        public BusquedaEmpleados()
        {
            InitializeComponent();
            this.buscarTableAdapter.Fill(inverprova2DataSet.Buscar, comboBox1.SelectedIndex, textBox1.Text);
        }

        QueriesTableAdapter n = new QueriesTableAdapter();
        public static int Cog = 0;
        public static string Nomb = null;
        public static string ape = null;
        public static string Dir = null;
        public static string usuario = null;
        public static string contra = null;
        public static string telef = null;
        public static string fechaN = null;
        public static string fechaC = null;
        public static Int64 Carg = 0;
        
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.buscarTableAdapter.Fill(this.inverprova2DataSet.Buscar, new System.Nullable<int>(((int)(System.Convert.ChangeType(numToolStripTextBox.Text, typeof(int))))), busquedaToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void BusquedaEmpleados_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n.Buscar(comboBox1.SelectedIndex, textBox1.Text);
            this.buscarTableAdapter.Fill(inverprova2DataSet.Buscar, comboBox1.SelectedIndex, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cog = Convert.ToInt32(buscarDataGridView.CurrentRow.Cells[0].Value.ToString());
            Nomb = buscarDataGridView.CurrentRow.Cells[1].Value.ToString();
            ape = buscarDataGridView.CurrentRow.Cells[2].Value.ToString();

            Dir = buscarDataGridView.CurrentRow.Cells[3].Value.ToString();
            telef = buscarDataGridView.CurrentRow.Cells[4].Value.ToString();
            fechaN = buscarDataGridView.CurrentRow.Cells[5].Value.ToString();
            fechaC = buscarDataGridView.CurrentRow.Cells[6].Value.ToString();
            Carg = Convert.ToInt64(buscarDataGridView.CurrentRow.Cells[7].Value.ToString());
            usuario = buscarDataGridView.CurrentRow.Cells[8].Value.ToString();
            contra = buscarDataGridView.CurrentRow.Cells[9].Value.ToString();
            
            DialogResult = DialogResult.OK;
         
        }
    }
}
