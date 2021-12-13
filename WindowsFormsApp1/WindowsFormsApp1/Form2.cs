using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Observer;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Bateria unaBateria;
        public Form2()
        {
            InitializeComponent();
            unaBateria = new Bateria();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            vistaObservador1.bateria = unaBateria;
            unaBateria.Suscribirse(vistaObservador1);

            vistaObservador2.bateria = unaBateria;
            unaBateria.Suscribirse(vistaObservador2);

            vistaObservador3.bateria = unaBateria;
            unaBateria.Suscribirse(vistaObservador3);
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            unaBateria.Desuscribirse(vistaObservador1);
            unaBateria.Desuscribirse(vistaObservador2);
            unaBateria.Desuscribirse(vistaObservador3);
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            unaBateria.Cargar();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            unaBateria.ConsumirEnergia();
        }
    }
}
