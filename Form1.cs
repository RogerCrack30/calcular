using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            Sumar suma = new Sumar();
            txtResultado.Text = suma.operar(int.Parse(txtV1.Text), int.Parse(txtV2.Text)).ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            Restar resta = new Restar();
            txtResultado.Text = resta.operar(int.Parse(txtV1.Text), int.Parse(txtV2.Text)).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Multiplicar multiplica = new Multiplicar();
            txtResultado.Text = multiplica.operar(int.Parse(txtV1.Text), int.Parse(txtV2.Text)).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtV1.Clear();
            txtV2.Clear();
            txtResultado.Clear();
        }
    }
}
