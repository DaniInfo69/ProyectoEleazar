using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server = LocalHost; database=Restaurante; integrated security = true");
        SqlCommand comando = new SqlCommand("");
        SqlDataReader lector;


        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.Open();

            comando = new SqlCommand(" SELECT * FROM Clientes", conexion);


            //Auto
            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Clientes", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            //Nombre del text boton
            txIdCliente.Text = total.ToString();

            lector = comando.ExecuteReader();

            while (lector.Read())
                dgvClientes.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString());



            conexion.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String Nombre = txNombre.Text;
            String Telefono = txTelefono.Text;
            String Colonia = txColonia.Text;
            String Domicilio = txDomicilioC.Text;
            String CP = txCP.Text;
            conexion.Open();
            //Esto sirve para hacer la insercion de Datos
            comando = new SqlCommand("Insert into Clientes (Nombre, Telefono, Colonia, DomicilioCliente, CP) values " +
                "('" + Nombre + "' , '" + Telefono + "' , '" + Colonia + "' , '" + Domicilio + "', '" + CP + "')", conexion);
            comando.ExecuteNonQuery();

            //Esto sirve para consultar los datos y llenar la tabla
            comando = new SqlCommand(" SELECT * FROM Clientes", conexion);


            //Actualice el ID cada que grabe
            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Clientes", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            txIdCliente.Text = total.ToString();

            lector = comando.ExecuteReader();

            dgvClientes.Rows.Clear();//Limpiar datagrid no se repeitan datos
            while (lector.Read())
                dgvClientes.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString());


            conexion.Close();
            //Click al boton, para que se limpien los datos que escribi
            txTelefono.Text = " ";
            txDomicilioC.Text = " ";
            txNombre.Text = " ";
            txColonia.Text = " ";
            txCP.Text = " ";
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                // Obtener los valores de las celdas
                txIdCliente.Text = row.Cells[0].Value.ToString();
                txNombre.Text = row.Cells[1].Value.ToString();
                txTelefono.Text = row.Cells[2].Value.ToString();
                txColonia.Text = row.Cells[3].Value.ToString();
                txDomicilioC.Text = row.Cells[4].Value.ToString();
                txCP.Text = row.Cells[5].Value.ToString();

                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            String ID = txIdCliente.Text;
            String Nombre = txNombre.Text;
            String Telefono = txTelefono.Text;
            String Colonia = txColonia.Text;
            String Domicilio = txDomicilioC.Text;
            String CP = txCP.Text;
            string cadena = "Update Clientes set Nombre ='" + Nombre + "', Telefono ='" + Telefono + "', " +
                "Colonia ='" + Colonia + "', DomicilioCliente ='" + Domicilio + "', CP ='" + CP + 
                "' WHERE IdCliente =" + Convert.ToInt32(ID);

            MessageBox.Show(cadena);

            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();

            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Clientes", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            //Nombre del text boton
            txIdCliente.Text = total.ToString();

            MessageBox.Show("Los datos se modificaron correctamente");
            dgvClientes.Rows.Clear();
            SqlCommand comandoLector = new SqlCommand("Select * from Clientes", conexion);
            SqlDataReader lector;
            lector = comandoLector.ExecuteReader();

            while (lector.Read())
                dgvClientes.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), lector.GetValue(5).ToString());


            conexion.Close();

            clean();
        }

        public void clean()
        {
            txIdCliente.Text = "";
            txNombre.Text = "";
            txTelefono.Text = "";
            txColonia.Text = "";
            txDomicilioC.Text = "";
            txCP.Text = "";

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
