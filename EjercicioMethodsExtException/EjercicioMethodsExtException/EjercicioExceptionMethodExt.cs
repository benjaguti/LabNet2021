using EjercicioMethodsExtException.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EjercicioMethodsExtException
{
    public partial class EjercicioExceptionMethodExt : Form
    {
        public EjercicioExceptionMethodExt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

            try
            {
                // se uso valores en int ya que al calcular la división por float da infinito.
                int dividendo = int.Parse(txtValorDiv.Text);
                int cociente = dividendo / 0;
                txtSolucion.Text = cociente.ToString();
                MessageBox.Show("Se realizó la división con Exito!");
            }

            catch (FormatException)
            {
                MessageBox.Show("Los valores ingresado no cumplen con el formato indicado. \nVerifique que sean valores númericos enteros!!!");
            }

            catch (DivideByZeroException)
            {
                MessageBox.Show("Error: No se puede dividir por cero");
            }

            finally 
            {
                MessageBox.Show("La operación ha terminado");
            }
        }


        private void btnDividir_Click(object sender, EventArgs e)
        {

            try
            {

                int dividendo = int.Parse(txtDividendo.Text);
                int divisor = int.Parse(txtDivisor.Text);
                float cociente = dividendo / divisor;
                txtCociente.Text = cociente.ToString();
                MessageBox.Show("Se realizó la división con Exito!");

            }

            catch (FormatException ex) 
            {
                MessageBox.Show(ex + "\n\nLos valores ingresado no cumplen con el formato indicado, verifique que sean valores númericos!!!");
            }

            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex + "\n\nSolo Chuck Norris divide por cero!\nError: No se puede dividir por cero");
            }


        }


        
        private void btnFormatoExc_Click(object sender, EventArgs e)
        {
            
            try
            {
                int numero = int.Parse(txtLetra.Text);
                numero.MultiplicarPorQuince();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "\n\nTipo de excepcion: ExceptionFormat" );
            }
        }
    }
}
