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
            comando = new SqlCommand("Insert into Clientes(Nombre, Telefono, Colonia, DomicilioCliente, CP) values " +
                "('" + Nombre + "' , '" + Telefono + "' , '" + Colonia + "' , '" + Domicilio + "', '" + CP + "')", conexion);
            comando.ExecuteNonQuery();

            //Esto sirve para consultar los datos y llenar la tabla
            comando = new SqlCommand(" SELECT * FROM Clientes", conexion);


            //Actualice el ID cada que grabe
            SqlCommand comandoContador = new SqlCommand("Select COUNT(*) from Clientes", conexion);
            int total = 0;
            total = Convert.ToInt32(comandoContador.ExecuteScalar()) + 1;
            //Nombre del text boton
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


    }
}
