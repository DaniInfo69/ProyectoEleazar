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
    public partial class Puestos : Form
    {
        public Puestos()
        {
            InitializeComponent();
        }


        SqlConnection conexion = new SqlConnection("server = LocalHost; database=Restaurante; integrated security = true");
        SqlCommand comando = new SqlCommand("");
        SqlDataReader lector;

        private void Puestos_Load(object sender, EventArgs e)
        {
            conexion.Open();

            comando = new SqlCommand(" SELECT * FROM Puestos", conexion);


            //Auto
            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Puestos", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            //Nombre del text
            txtIdPuesto.Text = total.ToString();

            lector = comando.ExecuteReader();

            while (lector.Read())
                dgvPuestos.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString());



            conexion.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Puesto = txtPuesto.Text;
            conexion.Open();
            //Esto sirve para hacer la insercion de Datos
            comando = new SqlCommand("Insert into Puestos (Puesto) values " +
                "('" + Puesto + "')", conexion);
            comando.ExecuteNonQuery();

            //Esto sirve para consultar los datos y llenar la tabla
            comando = new SqlCommand(" SELECT * FROM Puestos", conexion);


            //Actualice el ID cada que grabe
            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Puestos", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            //Nombre del text boton
            txtIdPuesto.Text = total.ToString();

            lector = comando.ExecuteReader();

            dgvPuestos.Rows.Clear();//Limpiar datagrid no se repeitan datos
            while (lector.Read())
                dgvPuestos.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString());


            conexion.Close();

            txtPuesto.Text = "";
        }
    }
}
