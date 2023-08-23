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
    public partial class validaciones : Form
    {
        private object txtLetra;

        public validaciones()
        {
            InitializeComponent();
        }

        private void Validar_Click(object sender, EventArgs e)
        {
            string numero = numeroBox.Text;
            string letra = letraCaracterBox.Text;


            if (string.IsNullOrEmpty(letra)) 
                string.IsNullOrWhiteSpace(letra);

                    {
                MessageBox.Show("Escribe texto");
            }

            if (!int.TryParse(numero, out int n))
            {
                MessageBox.Show("no es un numero");
            }
            else
            {
                MessageBox.Show("Es un numero!");
            }
        }
    }
}
