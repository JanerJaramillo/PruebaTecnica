using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeModelo
{
    public class Accidente
    {
        private int idAccidente;
        private string codigoAccidente;
        private string gravedad;
        private string fecha_evento;
        private string sitio_accidente;
        private string tipo_accidente;
        private string lesion_accidente;
        private string parte_afectada;
        private string agente;
        private string mecanismo;
        private string descripcion;
        private string incapacidad;
        private int dias_incapacidad;
        private int idEmpleado;
        private int cedulaEmpleado;

        public int IdAccidente { get => idAccidente; set => idAccidente = value; }
        public string CodigoAccidente { get => codigoAccidente; set => codigoAccidente = value; }
        public string Gravedad { get => gravedad; set => gravedad = value; }
        public string Fecha_evento { get => fecha_evento; set => fecha_evento = value; }
        public string Sitio_accidente { get => sitio_accidente; set => sitio_accidente = value; }
        public string Tipo_accidente { get => tipo_accidente; set => tipo_accidente = value; }
        public string Lesion_accidente { get => lesion_accidente; set => lesion_accidente = value; }
        public string Parte_afectada { get => parte_afectada; set => parte_afectada = value; }
        public string Agente { get => agente; set => agente = value; }
        public string Mecanismo { get => mecanismo; set => mecanismo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Incapacidad { get => incapacidad; set => incapacidad = value; }
        public int Dias_incapacidad { get => dias_incapacidad; set => dias_incapacidad = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public int CedulaEmpleado { get => cedulaEmpleado; set => cedulaEmpleado = value; }
    }
}
