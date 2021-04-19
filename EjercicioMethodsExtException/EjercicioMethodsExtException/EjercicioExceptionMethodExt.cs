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

        private void btnDividir_Click(object sender, EventArgs e)
        {
            float dividendo = float.Parse(txtDividendo.Text);
            float divisor = float.Parse(txtDivisor.Text);
            try
            {
                float cociente = dividendo / divisor;
                txtCociente.Text = cociente.ToString();
                MessageBox.Show("La operación fue realizada con éxito");

            }

            catch (FormatException) 
            {
                MessageBox.Show("Los valores ingresado no cumplen con el formato indicado, verifique que sean valores númericos!!!");
            }

            catch (DivideByZeroException)
            {
                MessageBox.Show("Error: No se puede dividir por cero");
            }


        }










    }
}
