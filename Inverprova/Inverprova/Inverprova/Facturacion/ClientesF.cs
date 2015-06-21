using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Inverprova.Inverprova2DataSetTableAdapters;
namespace Inverprova
{
    public partial class ClientesF : Form
    {

        public static int Cog = 0;
        public static string Nomb = null;
        public static string Dir = null;
        QueriesTableAdapter n = new QueriesTableAdapter();
       
        
        public ClientesF()
        {
            InitializeComponent();
            this.clTableAdapter.Fill(inverprova2DataSet.Cl, txtNombre.Text);
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.inverprova2DataSet);

        }

        private void ClientesF_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inverprova2DataSet.Clientes' Puede moverla o quitarla según sea necesario.
           
            clDataGridView.Refresh();
            

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
         
        }

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = txtNombre.Text.Replace("  ", " ");
            txtNombre.Select(txtNombre.Text.Length, 0);

            txtNombre.MaxLength = 30;
            
            
            n.Cl(txtNombre.Text);

            this.clTableAdapter.Fill(inverprova2DataSet.Cl, txtNombre.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cog = Convert.ToInt32(clDataGridView.CurrentRow.Cells[0].Value.ToString());
            Nomb = clDataGridView.CurrentRow.Cells[1].Value.ToString();
            Dir = clDataGridView.CurrentRow.Cells[4].Value.ToString();
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
