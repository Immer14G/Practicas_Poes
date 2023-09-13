using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace productosAgregar
{
    public partial class Form1 : Form

    {
        List<TAREAS> listaTareas = new List<TAREAS>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tareas = TareatextBox.Text;
            string nombre = NombretextBox.Text;
            string descripcion = DescripciontextBox.Text;
            DateTime fechaInicio = dateTimePicker1.Value;
            DateTime fechaVencimiento = dateTimePicker2.Value;

            
            TAREAS nuevaTarea = new TAREAS (tareas, nombre, descripcion, fechaInicio, fechaVencimiento);

          
            listaTareas.Add(nuevaTarea);

            ActualizarDataGriedview();
            limpiarControles();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            ActualizarDataGriedview();
        }
        public void ActualizarDataGriedview()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaTareas;
        }
        public void limpiarControles()
        {
            TareatextBox.Clear();
            NombretextBox.Clear();
            DescripciontextBox.Clear();
            NombretextBox.Focus();


        }
    }
}