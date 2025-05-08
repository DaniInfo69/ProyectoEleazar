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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server = LocalHost; database=Restaurante; integrated security = true");
        SqlCommand comando = new SqlCommand("");
        SqlDataReader lector;

        private void Menu_Load(object sender, EventArgs e)
        {
            conexion.Open();

            comando = new SqlCommand(" SELECT * FROM Menu", conexion);


            //Auto
            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Menu", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            //Nombre del text boton
            txtIdMenu.Text = total.ToString();

            lector = comando.ExecuteReader();

            while (lector.Read())
                dgvMenu.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString());

            conexion.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String Descripcion = txtDescripcion.Text;
            String Precio = txtPrecio.Text;

            conexion.Open();

            //Esto sirve para hacer la insercion de Datos
            comando = new SqlCommand("Insert into Menu (Descripcion, Precio) values " +
                "('" + Descripcion + "' , '" + Precio + "')", conexion);
            comando.ExecuteNonQuery();

            //Esto sirve para consultar los datos y llenar la tabla
            comando = new SqlCommand(" SELECT * FROM Menu", conexion);
            
            //Actualice el ID cada que grabe
            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Menu", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            txtIdMenu.Text = total.ToString();

            lector = comando.ExecuteReader();
            dgvMenu.Rows.Clear();
            while (lector.Read())
                dgvMenu.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString());
            
            //Limpiar los textBox
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            conexion.Close();
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgvMenu.Rows[e.RowIndex];

                // Obtener los valores de las celdas
                txtIdMenu.Text = row.Cells[0].Value.ToString();
                txtDescripcion.Text = row.Cells[1].Value.ToString();
                txtPrecio.Text = row.Cells[2].Value.ToString();

                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            String ID = txtIdMenu.Text;
            String Descripcion = txtDescripcion.Text;
            String Precio = txtPrecio.Text;
            string cadena = "Update Menu set Descripcion ='" + Descripcion + "', Precio ='" + Precio + "' WHERE IdMenu =" + Convert.ToInt32(ID);

            MessageBox.Show(cadena);

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();

            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Menu", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            //Nombre del text boton
            txtIdMenu.Text = total.ToString();

            MessageBox.Show("Los datos se modificaron correctamente");
            dgvMenu.Rows.Clear();
            SqlCommand comandoLector = new SqlCommand("Select * from Menu", conexion);
            SqlDataReader lector;
            lector = comandoLector.ExecuteReader();

            while (lector.Read())
                dgvMenu.Rows.Add(lector.GetValue(0),
                lector.GetValue(1), lector.GetValue(2));

            conexion.Close();

            clean();
        }

        public void clean()
        {
            txtPrecio.Text = "";
            txtDescripcion.Text = "";

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
