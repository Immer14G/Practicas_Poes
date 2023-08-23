using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaN2.EjerciciosPractica2
{
    public partial class ejercicio2 : Form
    {
        Calculadora objeto1 =new Calculadora(5,6);

       
        public ejercicio2()
        {
            InitializeComponent();
        }

        private void bttLanzar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(objeto1.Suma().ToString());
            MessageBox.Show(objeto1.Resta().ToString());
            MessageBox.Show(objeto1.Multiplicacion().ToString());
            MessageBox.Show(objeto1.Division().ToString());
        }
    }
}
