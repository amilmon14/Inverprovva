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
    public partial class OrdenPedido : Form
    {
        string nombre;
        string apellido;
        
        public OrdenPedido()
        {
            InitializeComponent();
             this.ordenTableAdapter.Fill(inverprova2DataSet.Orden, OrdenPedidoF.id);
        }
        public static int? valor = 0;
        public static string nom = Form1.nombre;

        public static string noms = Form1.apellido;
        QueriesTableAdapter n = new QueriesTableAdapter();


        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
          
        }

        private void OrdenPedido_Load(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
             OrdenPedidoF l = new OrdenPedidoF();
            if (l.ShowDialog() == DialogResult.OK)
            {
               
               n.Orden(OrdenPedidoF.id);
                
                this.ordenTableAdapter.Fill(inverprova2DataSet.Orden, OrdenPedidoF.id);
                textBox2.Text = Convert.ToString(n.Orden2(OrdenPedidoF.Cli));
                textBox1.Text = OrdenPedidoF.id.ToString();
                textBox3.Text = Convert.ToString(n.Orden2(OrdenPedidoF.Cli));
        }
     }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
           
        
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No se permiten campos vacios");

            }
            else
            {
                n.Validar_Compra(Convert.ToInt32(textBox1.Text), ref valor);

                if (valor == 0)
                {
                    string proveedor = null;
                    string producto = null;
                    int cant = 0;
                    double precio = 0;
                    foreach (DataGridViewRow row in ordenDataGridView.Rows)
                    {
                        proveedor = row.Cells[1].Value.ToString();
                        producto = row.Cells[2].Value.ToString();
                        cant = Convert.ToInt32(row.Cells[3].Value.ToString());
                        precio = Convert.ToDouble(row.Cells[4].Value.ToString());

                        n.insert_act(Convert.ToInt64(textBox1.Text), proveedor, Convert.ToDateTime(dateTimePicker1.Value), Convert.ToDateTime(dateTimePicker2.Value));
                        n.detalle_Compra(Convert.ToInt64(textBox1.Text), producto, cant, precio, proveedor);


                    }

                    MessageBox.Show("Datos Guardados Correctamente", "Afirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    textBox1.Clear();

                    textBox2.Clear();
                    textBox3.Clear();
                    this.Dispose();
                    OrdenPedido m = new OrdenPedido();
                    m.Show();
                    ordenDataGridView.DataSource = null;
                    // ordenDataGridView.DataSource = n.Orden(Convert.ToInt64(Form19.id));
                    //ordenDataGridView.Update();
                    //this.Dispose();


                }
                else
                    MessageBox.Show("Ya se encuentra una factura con estos datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
                    
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            cobrador tm = new cobrador(nombre, apellido);
            tm.Show();
        }
}
}
    