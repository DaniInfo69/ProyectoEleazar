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
    public partial class Comandas : Form
    {
        public Comandas()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server = LocalHost; database=Restaurante; integrated security = true");
        SqlCommand comando = new SqlCommand("");
        SqlDataReader lector;

        private void Comandas_Load(object sender, EventArgs e)
        {
            cargarCombos();
            cargarIdComanda();
        }

        private void cargarIdComanda()
        {
            conexion.Open();
            comando = new SqlCommand("Select COUNT(*) From Comandas", conexion);
            int total = 0;
            total = Convert.ToInt32(comando.ExecuteScalar()) + 1;
            txtIdComanda.Text = Convert.ToString(total);

            conexion.Close();
        }

        private void cargarCombos()
        {
            conexion.Open();
            cboNombreCliente.Items.Clear();
            cboNombreEmpleado.Items.Clear();
            cboDescripcion.Items.Clear();

            comando = new SqlCommand("Select Nombre From Clientes Where Estado = 'L'", conexion);
            lector = comando.ExecuteReader();
            while (lector.Read())
                cboNombreCliente.Items.Add(lector["Nombre"].ToString());

            lector.Close();
            comando = new SqlCommand("Select Nombre From Empleados", conexion);
            lector = comando.ExecuteReader();
            while (lector.Read())
                cboNombreEmpleado.Items.Add(lector["Nombre"].ToString());

            lector.Close();
            comando = new SqlCommand("Select Descripcion From Menu", conexion);
            lector = comando.ExecuteReader();
            while (lector.Read())
                cboDescripcion.Items.Add(lector["Descripcion"].ToString());


            conexion.Close();
            cargarClientesOcupados();
        }

        private void cargarClientesOcupados()
        {
            conexion.Open();
            cboClientesOcupados.Items.Clear();
            comando = new SqlCommand("Select Nombre From Clientes Where Estado = 'O'", conexion);
            lector = comando.ExecuteReader();
            while (lector.Read())
                cboClientesOcupados.Items.Add(lector["Nombre"].ToString());

            conexion.Close();
        }

        private void cboNombreEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();

            comando = new SqlCommand("SELECT IdEmpleado, P.Puesto, Apellidos " +
                "FROM Empleados as E inner join Puestos as P on P.IdPuesto = E.IdPuesto where Nombre ='" + cboNombreEmpleado.Text + "'", conexion);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                txtIdEmpleado.Text = lector["IdEmpleado"].ToString();
                txtApellidos.Text = lector["Apellidos"].ToString();
                txtPuesto.Text = lector["Puesto"].ToString();
            }

            conexion.Close();
            HabilitarMenu();
        }

        private void HabilitarMenu()
        {
            if (!string.IsNullOrWhiteSpace(txtIdEmpleado.Text) && !string.IsNullOrWhiteSpace(txtIdCliente.Text))
            {
                cboDescripcion.Enabled = true;
            }
            else
            {
                cboDescripcion.Enabled = false;
            }
        }

        private void cboDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            comando = new SqlCommand("SELECT IdMenu, Precio FROM Menu where Descripcion = '" + cboDescripcion.Text + "'", conexion);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                txtIdMenu.Text = lector[0].ToString();
                txtPrecio.Text = lector[1].ToString();
            }

            conexion.Close();

            HabilitarAgregar(true);
        }

        private void cboNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = cboNombreCliente.Text;
            ConsultarCliente(nombre);
            HabilitarMenu();
        }

        private void ConsultarCliente(string Nombre)
        {
            conexion.Open();

            comando = new SqlCommand("SELECT IdCliente, Colonia, DomicilioCliente FROM Clientes where Nombre = '" + Nombre + "'", conexion);

            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                txtIdCliente.Text = lector[0].ToString();
                txtColonia.Text = lector[1].ToString();
                txtDomicilioC.Text = lector[2].ToString();
            }

            conexion.Close();
        }

        private void HabilitarAgregar(bool a)
        {
            if (!a)
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int decicion = 0;
            decimal importe = Convert.ToDecimal(txtPrecio.Text);

            decimal validar = 0;

            foreach (DataGridViewRow row in dgvComandas1.Rows)
            {
                validar = Convert.ToDecimal(row.Cells["IdMenu"].Value);
                if (Convert.ToDecimal(txtIdMenu.Text) == validar)
                {
                    Decimal cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                    cantidad += 1;
                    row.Cells["Cantidad"].Value = Convert.ToString(cantidad);

                    row.Cells["Importe"].Value = Convert.ToDecimal(row.Cells["Cantidad"].Value) * Convert.ToDecimal(row.Cells["Precio"].Value);

                    decicion = 0;
                    break;
                }
                else
                    decicion = 1;
            }

            if (decicion == 1)
            {
                dgvComandas1.Rows.Add(txtIdComanda.Text, txtIdMenu.Text, cboDescripcion.Text, "1", txtPrecio.Text, importe);
            }
            calcular();
        }

        private void calcular()
        {
            decimal importe = Convert.ToDecimal(txtPrecio.Text);

            decimal iva = 16, subTotal = 0, total = 0;
            foreach (DataGridViewRow row in dgvComandas1.Rows)
            {
                subTotal += Convert.ToDecimal(row.Cells["Importe"].Value);
            }
            iva = (iva * subTotal) / 100;
            total = subTotal + iva;

            txtSubtotal.Text = subTotal.ToString();
            txtIVA.Text = iva.ToString();
            txtTotal.Text = total.ToString();
            btnRegistrar.Enabled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            grabarComanda();
        }

        //Comandas A = Activas, P = Pagadas , C = Canceladas
        public void grabarComanda()
        {
            conexion.Open();

            comando = new SqlCommand("Insert into Comandas (IdEmpleado, IdCliente, Fecha, Subtotal, IVA, Total, Estado) values ("
                + Convert.ToInt32(txtIdEmpleado.Text) + " , "
                + Convert.ToInt32(txtIdCliente.Text) + " , '"
                + dtpFecha.Text + "' , "
                + Convert.ToDecimal(txtSubtotal.Text) + " , "
                + Convert.ToDecimal(txtIVA.Text) + " , "
                + Convert.ToDecimal(txtTotal.Text) + " , "
                + "'A')", conexion);
            comando.ExecuteNonQuery();

            conexion.Close();

            grabarDetalle();
            modificarEstadoCliente();
        }

        public void grabarDetalle()
        {
            try
            {

                foreach (DataGridViewRow row in dgvComandas1.Rows)
                {
                    if (string.IsNullOrEmpty(Convert.ToString(row.Cells["IdComanda"].Value)))
                    {
                        break;
                    }
                    conexion.Open();

                    comando.Parameters.Clear();
                    string IdComanda = Convert.ToString(row.Cells["IdComanda"].Value);
                    string IdMenu = Convert.ToString(row.Cells["IdMenu"].Value);
                    string Cantidad = Convert.ToString(row.Cells["Cantidad"].Value);
                    string Precio = Convert.ToString(row.Cells["Precio"].Value);

                    comando = new SqlCommand("Insert into DetalleComanda values('" + IdComanda + "', '" + IdMenu + "', '" + Cantidad + "', '" + Precio + "')", conexion);
                    comando.ExecuteNonQuery();
                    conexion.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al grabar el detalle de la comanda: " + ex.Message);
            }


        }

        private void modificarEstadoCliente()
        {
            conexion.Open();

            comando = new SqlCommand("Update Clientes set Estado = 'O' Where IdCliente = '" + txtIdCliente.Text + "'", conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        private void cboClientesOcupados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = cboClientesOcupados.Text;
            ConsultarCliente(nombre);
            consultarIdOcupado(nombre);
            cboNombreCliente.Text = string.Empty;
            HabilitarMenu();
            btnPagar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void consultarIdOcupado(string nombre)
        {
            conexion.Open();
            comando = new SqlCommand("SELECT Co.IdComanda FROM Comandas as Co inner join Clientes as Cl on Cl.IdCliente = Co.IdEmpleado where Co.Estado = 'A' and Cl.Nombre = '" + nombre + "'", conexion);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                txtIdComanda.Text = lector[0].ToString();
            }
            conexion.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("La Comanda de " + cboClientesOcupados.Text + " ah sido cancelada");

            comando = new SqlCommand("Update Clientes set Estado = 'L' Where Nombre = '" + cboClientesOcupados.Text + "'", conexion);
            comando.ExecuteNonQuery();

            comando = new SqlCommand("Update Comandas set Estado = 'C' Where IdComanda = " + Convert.ToInt32(txtIdComanda.Text) + "", conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("La Comanda de " + cboClientesOcupados.Text + " ah sido cancelada");

            comando = new SqlCommand("Update Clientes set Estado = 'L' Where Nombre = '" + cboClientesOcupados.Text + "'", conexion);
            comando.ExecuteNonQuery();

            comando = new SqlCommand("Update Comandas set Estado = 'P' Where IdComanda = " + Convert.ToInt32(txtIdComanda.Text) + "", conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ConsultaComandas frmConsultaComandas = new ConsultaComandas();
            frmConsultaComandas.ShowDialog();
        }
    }
}
