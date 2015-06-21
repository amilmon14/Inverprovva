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
 
    public partial class Form1 : Form
    {

        public Form1()
        {
            
            InitializeComponent();

        }
        int contador = 0;
        
       public static int? cargo = 0;
        QueriesTableAdapter nuevo = new QueriesTableAdapter();
        public static string nombre;
        public static int? id;
        public static string apellido;
        public static Int64? a;
        public static Int64 b;
        int cont;
        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                 
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Es necesario que ingrese el usuario");
                limpiar();
            }
            else if (txtContraseña.Text == "")
            {
                MessageBox.Show("Es necesario que ingrese la contraseña");
                limpiar();
            }
            else
            {
               // nuevo.loginx (txtUsuario.Text, txtContraseña.Text, ref cargo, ref nombre, ref id , ref apellido,ref a);
                nuevo.loginx(txtUsuario.Text, txtContraseña.Text, ref cargo, ref nombre, ref id, ref apellido, ref a);
                

                if (cargo == null)
                {
                    MessageBox.Show("Usuario o Contraseña incorrectas");

                    contador++;
                    if (contador == 3)
                    {
                        nuevo.contra(txtUsuario.Text, txtContraseña.Text); 
                    //    button1.Enabled = false;
                      
                    MessageBox.Show("Ha intentado mas de tres veces , intentelo luego");
                    
                    }
                    limpiar();
                  
                }
                else if (cargo == 1)
                {
                    this.Hide();
                    new gerente(nombre , apellido).Show();

                    limpiar();

                }
                else if (cargo == 10002)
                {
                    this.Hide();
                    b = Convert.ToInt64( a);

                    new vendedor(nombre, apellido, b).Show();

                }
                else if(cargo ==10004)
                {
                    this.Hide();

                    new cobrador(nombre, apellido).Show();

                }
            }
        }

        void limpiar()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtUsuario.Focus();

        }
        }


    }

