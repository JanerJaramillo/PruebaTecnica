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
    public class AccidenteController
    {
        public static string SQL;

        public static int ValidarEmpleado(int cedula)
        {
            int idEmpleado = 0;
            SQL = "select idEmpleado from empleado where cedula='" + cedula + "'";
            MySqlDataReader req = Conexion.Query(SQL);
            if (req.Read())
            {
                idEmpleado = req.GetInt32("idEmpleado");
            }
            else
            {
                MessageBox.Show("Cedula no existe");
            }
            req.Close();
            return idEmpleado;
        }

        public static void InsertarAccidente(Accidente accidente, int idEmpleado)
        {
            MySqlCommand comando = new MySqlCommand(string.Format("insert into accidente(codigo,gravedad,fecha_evento," +
                "sitio_accidente,tipo_accidente,lesion_accidente,parte_afectada,agente,mecanismo,descripcion,incapacidad," +
                "dias_incapacidad,idEmpleado)values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',{11}," +
                "{12})", accidente.CodigoAccidente, accidente.Gravedad, accidente.Fecha_evento, accidente.Sitio_accidente,
                accidente.Tipo_accidente, accidente.Lesion_accidente, accidente.Parte_afectada, accidente.Agente, 
                accidente.Mecanismo, accidente.Descripcion, accidente.Incapacidad, accidente.Dias_incapacidad, 
                ValidarEmpleado(idEmpleado)), Conexion.obtenerConexion());
            comando.ExecuteNonQuery();
            if (comando != null)
            {
                MessageBox.Show("Accidente del empleado Registrado");
            }
            else
            {
                MessageBox.Show("Error al Guardar");
            }
        }

        public static Accidente BuscarAccidente(string codigo)
        {
            SQL = "Select * from accidente where codigo ='" + codigo + "'";
            MySqlDataReader req = Conexion.Query(SQL);
            Accidente ob = null;
            if (req.Read())
            {
                ob = new Accidente();
                ob.CodigoAccidente = req["codigo"].ToString();
            }
            req.Close();
            return ob;
        }
    }
}
