using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeDatos;
using CapaDeModelo;
using CapaDeNegocio;

namespace CapaDePresentacion
{
    public partial class FormAccidente : Form
    {
        Accidente accidente;
        Empleado empleado;
        public FormAccidente()
        {
            InitializeComponent();
            Conexion.obtenerConexion();
        }

        public void Captura()
        {
            accidente = new Accidente();
            accidente.CodigoAccidente = txtCodigoAccidente.Text;
            accidente.CedulaEmpleado = Convert.ToInt32(txtCedula.Text);
            accidente.Gravedad = cmbGravedad.SelectedItem.ToString();
            accidente.Fecha_evento = cmbAnioE.SelectedItem.ToString() + '-' + cmbMesE.SelectedItem.ToString() + '-' +
                cmbDiaE.SelectedItem.ToString();
            accidente.Sitio_accidente = txtSitio.Text;
            accidente.Tipo_accidente = cmbTipo.SelectedItem.ToString();
            accidente.Lesion_accidente = cmbLesion.SelectedItem.ToString();
            accidente.Parte_afectada = cmbParteAfectada.SelectedItem.ToString();
            accidente.Agente = cmbAgente.SelectedItem.ToString();
            accidente.Mecanismo = cmbMecanismo.SelectedItem.ToString();
            accidente.Descripcion = txtDescripcion.Text;
            accidente.Incapacidad = cmbIncapacidad.SelectedItem.ToString();
            accidente.Dias_incapacidad = Convert.ToInt32(cmbDiasIncapacidad.SelectedItem.ToString());
        }

        public void Guardar()
        {
            int cedula = Convert.ToInt32(txtCedula.Text);
            Captura();
            AccidenteController.InsertarAccidente(accidente, cedula);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txtCedula.Text);
            empleado = EmpleadoController.BuscarEmpleado(cedula);
            if(empleado != null)
            {
                string codigo = txtCodigoAccidente.Text;
                accidente = AccidenteController.BuscarAccidente(codigo);
                if (accidente == null)
                {
                    Guardar();
                }
                else
                {
                    MessageBox.Show("Accidente ya existe, verificar codigo del accidente");
                }
            }
            else
            {
                MessageBox.Show("Empleado no existe, verificar cedula del empleado");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
