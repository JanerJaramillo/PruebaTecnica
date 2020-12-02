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
    public partial class FormEmpleado : Form
    {
        Empleado empleado;
        public FormEmpleado()
        {
            InitializeComponent();
            Conexion.obtenerConexion();
            CargarDatos();
        }

        public void Nuevo()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtArea.Clear();
        }

        public void columnsTable()
        {
            dtgEmpleado.Columns["idEmpleado"].Visible = false;
        }

        public void CargarDatos()
        {
            dtgEmpleado.DataSource = null;
            dtgEmpleado.DataSource = EmpleadoController.ListarEmpleado();
            columnsTable();
        }

        public void Captura()
        {
            empleado = new Empleado();
            empleado.Cedula = Convert.ToInt32(txtCedula.Text);
            empleado.Nombre = txtNombre.Text;
            empleado.Correo = txtCorreo.Text;
            empleado.FechaNacimiento = cmbAnioF.SelectedItem.ToString() + '-' + cmbMesF.SelectedItem.ToString() + '-' + cmbDiaF.SelectedItem.ToString();
            empleado.Sexo = cmbSexo.SelectedItem.ToString();
            empleado.AreaTrabajo = txtArea.Text;
            empleado.Cargo = txtCargo.Text;
            empleado.FechaIngreso = cmbAnio.SelectedItem.ToString() + '-' + cmbMes.SelectedItem.ToString() + '-' +
                cmbDia.SelectedItem.ToString();
        }

        public void Guardar()
        {
            Captura();
            EmpleadoController.InsertarEmpleado(empleado);
            CargarDatos();
            Nuevo();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int cedula = Convert.ToInt32(txtCedula.Text);
            empleado = EmpleadoController.BuscarEmpleado(cedula);
            if (empleado == null)
            {
                Guardar();
            }
            else
            {
                MessageBox.Show("Empleado ya existe");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
    }
}
