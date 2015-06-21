using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inverprova
{
    class Validacion
    {
        public void SoloLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = true;


                }

                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {


            }
        }
        public void Solo(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;


                }

                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = true;

                }

                else if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;

                }
            }
            catch (Exception ex)
            {


            }
        }



        public void SoloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;


                }
                else if (char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {


            }
        }
        public void clickderecho(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("No se puede utilizar el boton derecho");
            }

        }

        public void hola(KeyEventArgs e)
        {


        }

        public static bool ValidarCampoDecimal(TextBox maskedtextbox1)
        {
            try
            {
                decimal d = Convert.ToDecimal(maskedtextbox1.Text);
                return true;
            }
            catch (Exception ex)
            {
                maskedtextbox1.Text = "";
                maskedtextbox1.Select(0, maskedtextbox1.Text.Length);
                return false;
            }
        }

    }
}
