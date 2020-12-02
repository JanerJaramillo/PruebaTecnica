using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using CapaDeModelo;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CapaDeNegocio
{
    public class EmpleadoController
    {
        public static string SQL;

        public static void InsertarEmpleado(Empleado empleado)
        {
            MySqlCommand comando = new MySqlCommand(string.Format("insert into empleado(cedula,nombre,correo,fecha_nacimiento," +
                "sexo,area_trabajo,cargo,fecha_ingreso)values({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                empleado.Cedula, empleado.Nombre, empleado.Correo, empleado.FechaNacimiento, empleado.Sexo, empleado.AreaTrabajo, 
                empleado.Cargo, empleado.FechaIngreso), Conexion.obtenerConexion());
            comando.ExecuteNonQuery();
            if (comando != null)
            {
                MessageBox.Show("Empleado Guardado");
            }
            else
            {
                MessageBox.Show("Error al Guardar");
            }
        }

        public static List<Empleado> ListarEmpleado()
        {
            List<Empleado> empleado = new List<Empleado>();
            SQL = "Select * from empleado";
            MySqlDataReader req = Conexion.Query(SQL);
            while (req.Read())
            {
                Empleado ob = new Empleado();
                ob.Cedula = req.GetInt32("cedula");
                ob.Nombre = req["nombre"].ToString();
                ob.Correo = req["correo"].ToString();
                ob.FechaNacimiento = req["fecha_nacimiento"].ToString();
                ob.Sexo = req["sexo"].ToString();
                ob.AreaTrabajo = req["area_trabajo"].ToString();
                ob.Cargo = req["cargo"].ToString();
                ob.FechaIngreso = req["fecha_ingreso"].ToString();
                empleado.Add(ob);
            }
            req.Close();
            return empleado;
        }

        public static Empleado BuscarEmpleado(int cedula)
        {
            SQL = "Select * from empleado where cedula ='" + cedula + "'";
            MySqlDataReader req = Conexion.Query(SQL);
            Empleado ob = null;
            if (req.Read())
            {
                ob = new Empleado();
                ob.Cedula = req.GetInt32("cedula");
            }
            req.Close();
            return ob;
        }
    }
}
