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
            clearData(false);
            cargarCombos();
            cargarIdComanda();
            MessageBox.Show("Comanda registrada correctamente");
        }

        private void clearData(bool decicion)
        {
            txtIdComanda.Text = string.Empty;
            txtSubtotal.Text = string.Empty;
            txtIVA.Text = string.Empty;
            txtTotal.Text = string.Empty;
            txtIdCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtColonia.Text = string.Empty;
            txtDomicilioC.Text = string.Empty;
            txtIdEmpleado.Text = string.Empty;
            txtNombreEmpleado.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtPuesto.Text = string.Empty;
            txtIdMenu.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            cboNombreEmpleado.Text = string.Empty;
            cboNombreCliente.Text = string.Empty;
            cboDescripcion.Text = string.Empty;
            cboClientesOcupados.Text = string.Empty;
            dgvComandas1.Rows.Clear();

            if (decicion)
            {
                txtNombreEmpleado.Visible = true;
                txtNombreCliente.Visible = true;
                cboNombreCliente.Visible = false;
                cboNombreEmpleado.Visible = false;
            }
            else
            {
                txtNombreEmpleado.Visible = false;
                txtNombreCliente.Visible = false;
                cboNombreCliente.Visible = true;
                cboNombreEmpleado.Visible = true;
            }

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
                MessageBox.Show("Insert into DetalleComanda values('" + IdComanda + "', '" + IdMenu + "', '" + Cantidad + "', '" + Precio + "')");

                comando = new SqlCommand("Insert into DetalleComanda values('" + IdComanda + "', '" + IdMenu + "', '" + Cantidad + "', '" + Precio + "')", conexion);
                comando.ExecuteNonQuery();
                conexion.Close();

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
            consultarOcupado(nombre);
            cboNombreCliente.Text = string.Empty;
            HabilitarMenu();
            btnPagar.Enabled = true;
            btnCancelar.Enabled = true;
            btnRegistrar.Enabled = false;
        }

        private void consultarOcupado(string nombre)
        {
            clearData(true);
            conexion.Open();
            comando = new SqlCommand("select Co.IdComanda, Co.Subtotal, Co.IVA, Co.Total, Co.IdCliente, Cl.Nombre, Cl.Colonia, Cl.DomicilioCliente, " +
                "Co.IdEmpleado, Em.Nombre, Em.Apellidos, Pu.Puesto " +
                "from Comandas as Co " +
                "inner join Clientes as Cl on Co.IdCliente = Cl.IdCliente " +
                "inner join Empleados as Em on Em.IdEmpleado = Co.IdEmpleado " +
                "inner join Puestos as Pu on Pu.IdPuesto = Em.IdPuesto " +
                "where Cl.Nombre = '" + nombre + "' and Co.Estado = 'A'", conexion);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                txtIdComanda.Text = lector[0].ToString();
                txtSubtotal.Text = lector[1].ToString();
                txtIVA.Text = lector[2].ToString();
                txtTotal.Text = lector[3].ToString();
                txtIdCliente.Text = lector[4].ToString();
                txtNombreCliente.Text = lector[5].ToString();
                txtColonia.Text = lector[6].ToString();
                txtDomicilioC.Text = lector[7].ToString();
                txtIdEmpleado.Text = lector[8].ToString();
                txtNombreEmpleado.Text = lector[9].ToString();
                txtApellidos.Text = lector[10].ToString();
                txtPuesto.Text = lector[11].ToString();
            }
            
            conexion.Close();

            consultarDetalleComanda(nombre);
        }

        private void consultarDetalleComanda(string nombre)
        {
            conexion.Open();
            comando = new SqlCommand("select Co.IdComanda, Dc.IdMenu, Me.Descripcion, Dc.Cantidad, Dc.Precio " +
                "from Comandas as Co " +
                "inner join DetalleComanda as Dc on Dc.IdComanda = Co.IdComanda " +
                "inner join Clientes as Cl on Co.IdCliente = Cl.IdCliente " +
                "inner join Menu as Me on Me.IdMenu = Dc.IdMenu " +
                "where Cl.Nombre = '" + nombre + "' and Co.Estado = 'A'", conexion);
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                double importe = Convert.ToDouble(lector.GetValue(3)) * Convert.ToDouble(lector.GetValue(4));
                dgvComandas1.Rows.Add(lector.GetValue(0).ToString(), lector.GetValue(1).ToString(), lector.GetValue(2).ToString(), lector.GetValue(3).ToString(), lector.GetValue(4).ToString(), importe);

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

            clearData(false);
            cargarCombos();
            cargarIdComanda();
            btnCancelar.Enabled = false;
            btnPagar.Enabled = false;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            MessageBox.Show("La Comanda de " + cboClientesOcupados.Text + " ah sido Pagada");

            comando = new SqlCommand("Update Clientes set Estado = 'L' Where Nombre = '" + cboClientesOcupados.Text + "'", conexion);
            comando.ExecuteNonQuery();

            comando = new SqlCommand("Update Comandas set Estado = 'P' Where IdComanda = " + Convert.ToInt32(txtIdComanda.Text) + "", conexion);
            comando.ExecuteNonQuery();

            conexion.Close();

            clearData(false);
            cargarCombos();
            cargarIdComanda();
            btnCancelar.Enabled = false;
            btnPagar.Enabled = false;
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ConsultaComandas frmConsultaComandas = new ConsultaComandas();
            frmConsultaComandas.ShowDialog();
        }
    }
}
