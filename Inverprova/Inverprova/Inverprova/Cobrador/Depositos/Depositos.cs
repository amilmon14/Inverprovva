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
    public partial class Depositos : Form
    {
        public Depositos()
        {
            InitializeComponent();
        }

        QueriesTableAdapter mostrar = new QueriesTableAdapter();

        string nombre = Form1.nombre;
        string apellido = Form1.apellido;

        private void Depositos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DepositoCliente l = new DepositoCliente();
            if (l.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = DepositoCliente.nombre;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != "" && textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {

                mostrar.Ins_Deposito(textBox4.Text, dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt64(textBox2.Text), cobrador.h, Convert.ToDouble(textBox3.Text), DepositoCliente.id);
                MessageBox.Show("Datos ingresados correctamente");
                textBox2.Clear();
                textBox1.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
                MessageBox.Show("Ingrese todo los campos");
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            cobrador tm = new cobrador(nombre, apellido);
            tm.Show();
        }
    }
}
