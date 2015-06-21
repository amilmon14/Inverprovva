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
    public partial class Facturacion : Form
    {

        double descuento;
        int estado;
        public static Int64? xx = 0;
        DataGridViewRow rows;

        public static int? valor = 0;
        public static Int64? aa = 0;
        public static Int64? val = 0;
        public static Int64? yy = 0;

        public static int dato = 0;
        QueriesTableAdapter mostrar = new QueriesTableAdapter();
        Int64 j = Form1.b;
        //string x = Form10.a;
        //string y = Form10.b;

        BindingList<ProDuctos> listapro = new BindingList<ProDuctos>();
        public class ProDuctos
        {
            int ID;
            string NOMBRE;
            double Precio;
            int Cant;
            int Prove;

            public ProDuctos(int id, string nombre, double precio, int cant, int prove)
            {
                this.ID = id;
                this.NOMBRE = nombre;
                this.Precio = precio;
                this.Cant = cant;
                this.Prove = prove;

            }
            public int n1 { get { return ID; } set { ID = value; } }
            public string n2 { get { return NOMBRE; } set { NOMBRE = value; } }
            public double n3 { get { return Precio; } set { Precio = value; } }
            public int n4 { get { return Cant; } set { Cant = value; } }
            public int n5 { get { return Prove; } set { Prove = value; } }

        }
        public void cargargrilla()
        {



            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = listapro;

            dataGridView1.Columns[0].DataPropertyName = "n1";
            dataGridView1.Columns[1].DataPropertyName = "n2";
            dataGridView1.Columns[2].DataPropertyName = "n3";
            dataGridView1.Columns[3].DataPropertyName = "n4";
            dataGridView1.Columns[4].DataPropertyName = "n5";

        }






        public Facturacion(Int64 ids)
        {
            InitializeComponent();
            this.ids = ids;
        }
        Int64 ids;
        private void Facturacion_Load(object sender, EventArgs e)
        {
            textBox3.Text = ids.ToString();
            mostrar.fac(ref xx);
            label13.Text = xx.ToString();
           dateTimePicker1.MinDate = DateTime.Today;
         dateTimePicker1.MaxDate = DateTime.Today;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double subtotal = 0;
            if (dataGridView1.RowCount != 0)
            {
                if (dataGridView1.Rows[0].Selected == false)
                {
                    int fil = dataGridView1.CurrentRow.Index;
                    dataGridView1.Rows.RemoveAt(fil);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        //subtotal = (Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value));
                        row.Cells[5].Value = (Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value));
                        subtotal += Convert.ToDouble(row.Cells[5].Value);
                    }
                    label6.Text = Convert.ToString(subtotal);
                    label7.Text = Convert.ToString(subtotal * 0.15);
                    //    label10.Text = Convert.ToString(subtotal * descuento);
                    label11.Text = Convert.ToString(subtotal * descuento);
                    label8.Text = Convert.ToString((subtotal += Convert.ToDouble(label7.Text)) - Convert.ToDouble(label11.Text));
                }

                else
                    MessageBox.Show("No a seleccionado ningun producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No hay ningun dato en la Factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form13 w = new Form13();
            //w.Show();
            //this.Hide();
            ProductoF l = new ProductoF();
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("debe seleccionar un tipo de pago");

            }



            else
            {
                int f = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    f = Convert.ToInt32(row.Cells[0].Value);

                }


                if (l.ShowDialog() == DialogResult.OK)
                {

                    if (f == ProductoF.id)
                    {
                        MessageBox.Show("Este Producto Ya se encuentra en la lista");

                    }



                    else if (f != ProductoF.id)
                    {
                        listapro.Add(new ProDuctos(Convert.ToInt32(ProductoF.id), ProductoF.Nombre, ProductoF.Precio, ProductoF.cant, ProductoF.Prov));


                        cargargrilla();
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = listapro;
                        dataGridView1.Update();

                    }


                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ClientesF l = new ClientesF();
            if (l.ShowDialog() == DialogResult.OK)
            {
                //new Form3().Show();
                textBox1.Text = ClientesF.Nomb;
                textBox2.Text = ClientesF.Dir;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // mostrar.Validar_Fact(21, ref valor);
            int cantidad12 = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                cantidad12 = Convert.ToInt32(row.Cells[3].Value);
            }
            mostrar.ver(Convert.ToInt64(ClientesF.Cog), ref yy);
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                MessageBox.Show("Seleccione tipo de pago");

            }
            else if (cantidad12 == 0)
            {

                MessageBox.Show("Debe Ingresar una cantidad");

            }
            else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("No se permiten campos Vacios");
            }
            else if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("debe de agregar un producto");
            }
            else if (yy == 3)
            {
                mostrar.verificar(Convert.ToInt64(ClientesF.Cog), ref yy);
                MessageBox.Show(" Lo sentimos, ud ya cuenta con tres facturas pendientes");

            }





            else
            {
                mostrar.ca(ref aa);
                mostrar.llenar_Factura(Convert.ToInt64(ClientesF.Cog), Convert.ToInt64(estado), Convert.ToInt64(textBox3.Text), 1, Convert.ToDouble(label11.Text
                    ), Convert.ToDateTime(dateTimePicker1.Value), Convert.ToDouble(label7.Text));
                mostrar.num(ref val);
                int IP = 0;
                string Nombre = null;
                int cantidad1 = 0;
                double precio = 0;
                int proveedor = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    IP = Convert.ToInt32(row.Cells[0].Value);
                    Nombre = row.Cells[1].Value.ToString();
                    cantidad1 = Convert.ToInt32(row.Cells[3].Value);
                    precio = Convert.ToDouble(row.Cells[2].Value);
                    proveedor = Convert.ToInt32(row.Cells[4].Value);
                    mostrar.llenar_Detalle(val, IP, cantidad1, precio, proveedor, cantidad1 * precio);



                }
                MessageBox.Show("Datos Guardados Correctamente", "Afirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox1.Clear();
                textBox2.Clear();
                ;
                // label13.Text = "";

                Facturacion ss = new Facturacion(ids);
                this.Dispose();
                ss.Show();

                dataGridView1.DataSource = null;

            }


        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double subtotal = 0;
            double subtotal1 = 0;
            double subTotal = 0;
            double subtotaL = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //subtotal = (Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value));
                row.Cells[5].Value = (Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value));
                subtotal += Convert.ToDouble(row.Cells[5].Value);
            }
            subtotal1 = subtotal;
            label6.Text = subtotal1.ToString("0.00");
            subTotal = subtotal * 0.15;
            label7.Text = subTotal.ToString("0.00");
            //    label10.Text = Convert.ToString(subtotal * descuento);
            label11.Text = Convert.ToString(subtotal * descuento);
            subtotaL = (subtotal += Convert.ToDouble(label7.Text)) - Convert.ToDouble(label11.Text);
            label8.Text = subtotaL.ToString("0.00");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                estado = 2;
                descuento = 0.05;
            }

            else
            {
                checkBox2.Checked = false;
                estado = 1;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                estado = 1;
                // descuento =1;
            }

            else
            {
                checkBox1.Checked = false;
                estado = 2;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }

}