using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeModelo
{
    public class Empleado
    {
        private int idEmpleado;
        private int cedula;
        private string nombre;
        private string correo;
        private string fechaNacimiento;
        private string sexo;
        private string areaTrabajo;
        private string cargo;
        private string fechaIngreso;

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string AreaTrabajo { get => areaTrabajo; set => areaTrabajo = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    }
}
