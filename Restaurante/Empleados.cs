using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server = LocalHost; database=Restaurante; integrated security = true");
        SqlCommand comando = new SqlCommand("");
        SqlDataReader lector;


        //Doble click al fondo para crear
        private void Empleados_Load(object sender, EventArgs e)
        {
            conexion.Open();

            comando = new SqlCommand(" SELECT * FROM Empleados", conexion);

            //
            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Empleados", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            //Nombre del text boton
            txIdEmpleado.Text = total.ToString();

            lector = comando.ExecuteReader();

            while (lector.Read())//dgv DATAGRIDVIEW
                dgvEmpleados.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString());


            conexion.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ////     variable    nombre del textbox
            //string nombre = txnombre.text;
            //string telefono = txtelefono.text;
            //string colonia = txcolonia.text;
            //string domicilio = txdomicilioc.text;
            //string cp = txcp.text;                               hacer   ctrl + k + c     desahacer ctrl + k + u




        }
    }
}
