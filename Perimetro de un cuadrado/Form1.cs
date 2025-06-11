using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimetro_de_un_cuadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLado.Clear();
            txtPerimetro.Clear();
        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnperimetro_Click(object sender, EventArgs e)
        {
            double lados,perimetro;
            lados = double.Parse(txtLado.Text); 
            perimetro =  4 * lados;
            txtPerimetro.Text = perimetro.ToString();   

        }
    }
}
