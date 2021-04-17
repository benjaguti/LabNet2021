using EjercicioPoo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPoo
{
    public partial class FrmVisualizaciónTrans : Form
    {
        public FrmVisualizaciónTrans()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        List<Transporte> transporte = new List<Transporte>
            {
                new Avion("Avion","Boeing 747", 20),
                new Avion("Avion","Airbus A350",25),
                new Avion("Avion","Airbus A380",24),
                new Avion("Avion","Boeing 737",29),
                new Avion("Avion","Boeing 747",45),
                new Automovil("Auto","Mercedez benz", 3),
                new Automovil("Auto","Audi",2),
                new Automovil("Auto","Ford",3),
                new Automovil("Auto","Fiat",4),
                new Automovil("Auto","Renault",1)
            };



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvTransporte.DataSource = transporte;
        }

        private void btnAviones_Click(object sender, EventArgs e)
        {
            List<Transporte> aviones = new List<Transporte>();

            foreach (var item in transporte)
            {
                if (item.TipoTransporte.Equals("Avion"))
                {
                    aviones.Add(item);
                }
            }

            dgvTransporte.DataSource = aviones;

        }

        private void btnMostrarAutos_Click(object sender, EventArgs e)
        {
            List<Transporte> autos = new List<Transporte>();

            foreach (var item in transporte)
            {
                if (item.TipoTransporte.Equals("Auto"))
                {
                    autos.Add(item);
                }
            }

            dgvTransporte.DataSource = autos;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
        }
    }
}
