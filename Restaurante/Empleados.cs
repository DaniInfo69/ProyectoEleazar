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

            comando = new SqlCommand(" SELECT IdEmpleado, P.Puesto, Nombre, Apellidos, Telefono, Email FROM Empleados as E inner join Puestos as P on P.IdPuesto = E.IdPuesto", conexion);

            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Empleados", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            //Nombre del text boton
            txtIdEmpleado.Text = total.ToString();

            lector = comando.ExecuteReader();

            while (lector.Read())//dgv DATAGRIDVIEW
                dgvEmpleados.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString());
            lector.Close();

            //Llenar el combo box
            comando = new SqlCommand("Select Puesto From Puestos", conexion);
            lector = comando.ExecuteReader();
            while (lector.Read())
                cboPuesto.Items.Add(lector["Puesto"].ToString());

            conexion.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String IdPuesto = txIdPuesto.Text;
            String Nombre = txtNombre.Text;
            String Apellidos = txtApellidos.Text;
            String Telefono = txtTelefono.Text;
            String Email = txtEmail.Text;

            conexion.Open();
            //Esto sirve para hacer la insercion de Datos
            comando = new SqlCommand("Insert into Empleados (IdPuesto, Nombre, Apellidos, Telefono, Email) values " +
                "('" + IdPuesto + "' , '" + Nombre + "' , '" + Apellidos + "' , '" + Telefono + "', '" + Email + "')", conexion);
            comando.ExecuteNonQuery();

            //Esto sirve para consultar los datos y llenar la tabla
            comando = new SqlCommand(" SELECT IdEmpleado, P.Puesto, Nombre, Apellidos, Telefono, Email FROM Empleados as E inner join Puestos as P on P.IdPuesto = E.IdPuesto", conexion);

            //Actualice el ID cada que grabe
            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Empleados", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            txtIdEmpleado.Text = total.ToString();

            lector = comando.ExecuteReader();

            dgvEmpleados.Rows.Clear();//Limpiar datagrid no se repeitan datos
            while (lector.Read())
                dgvEmpleados.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString());


            conexion.Close();

            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            cboPuesto.Text = "";
            txIdPuesto.Text = "";
        }

        private void cboPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();

            comando = new SqlCommand("Select IdPuesto From Puestos where Puesto ='" + cboPuesto.Text + "'", conexion);
            lector = comando.ExecuteReader();
            while (lector.Read())
                txIdPuesto.Text = lector["IdPuesto"].ToString();

            conexion.Close();
        }
        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];

                // Obtener los valores de las celdas
                txtIdEmpleado.Text = row.Cells[0].Value.ToString();
                cboPuesto.Text = row.Cells[1].Value.ToString();
                txtNombre.Text = row.Cells[2].Value.ToString();
                txtApellidos.Text = row.Cells[3].Value.ToString();
                txtTelefono.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();


                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            String ID = txtIdEmpleado.Text;

            String IdPuesto = txIdPuesto.Text;
            String Nombre = txtNombre.Text;
            String Apellidos = txtApellidos.Text;
            String Telefono = txtTelefono.Text;
            String Email = txtEmail.Text;
            string cadena = "Update Empleados set IdPuesto ='" + IdPuesto + "', Nombre ='" + Nombre + "', Apellidos ='" + Apellidos + "', " +
                           "Telefono ='" + Telefono + "', Email ='" + Email + "' WHERE IdEmpleado =" + Convert.ToInt32(ID);
            MessageBox.Show(cadena);

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();

            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Empleados", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            //Nombre del text boton
            txtIdEmpleado.Text = total.ToString();

            MessageBox.Show("Los datos se modificaron correctamente");
            dgvEmpleados.Rows.Clear();
            SqlCommand comandoLector = new SqlCommand("SELECT IdEmpleado, P.Puesto, Nombre, Apellidos, Telefono, Email FROM Empleados as E inner join Puestos as P on P.IdPuesto = E.IdPuesto", conexion);
            SqlDataReader lector;
            lector = comandoLector.ExecuteReader();

            while (lector.Read())
                dgvEmpleados.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString());


            conexion.Close();

            clean();
        }

        public void clean()
        {
            txtIdEmpleado.Text = "";
            cboPuesto.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txIdPuesto.Text = "";

            btnCancelar.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}
