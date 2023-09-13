﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasLibrary
{
    public class Tareas
    {

        public string tarea { get; set; }

        public string Nombre { get; set; }

        public string descripcion { get; set; }

        public DateTime fechaInicio { get; set; }

        public DateTime fechaVencimiento { get; set; }

        public void agregarTarea(string _tarea, string _nombre, string _descripcion, DateTime _fechaInicio, DateTime _fechaVencimiento)
        {
            tarea = _tarea;
            Nombre = _nombre;
            descripcion = _descripcion;
            fechaInicio = _fechaInicio;
            fechaVencimiento = _fechaVencimiento;
        }
    }
}
