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
    public partial class ConsultaComandas : Form
    {
        public ConsultaComandas()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=LocalHost; database=Restaurante; integrated security=true");
        SqlCommand comando = new SqlCommand("");
        SqlDataReader lector;

        private void ConsultaComandas_Load(object sender, EventArgs e)
        {
            consultarPagCan("G");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtnPagadas_CheckedChanged(object sender, EventArgs e)
        {
            consultarPagCan("P");
        }

        private void rbtnCanceladas_CheckedChanged(object sender, EventArgs e)
        {
            consultarPagCan("C");
        }
        private void rbtnActivas_CheckedChanged(object sender, EventArgs e)
        {
            consultarPagCan("A");
        }
       private void rbtnGeneral_CheckedChanged(object sender, EventArgs e)
        {
            consultarPagCan("G");
        }

        private void consultarPagCan(string Estado)
        {
            conexion.Open();
            dgvComanda.Rows.Clear();
            cboIdComanda.Items.Clear();
            if (Estado == "G")
            {
                comando = new SqlCommand("Select C.IdComanda, E.Nombre, C.Fecha, C.Subtotal, C.IVA, C.Total, C.Estado From Comandas as C inner join Empleados as E on E.IdEmpleado = C.IdEmpleado", conexion);
            }
            else
            {
                comando = new SqlCommand("Select C.IdComanda, E.Nombre, C.Fecha, C.Subtotal, C.IVA, C.Total, C.Estado From Comandas as C inner join Empleados as E on E.IdEmpleado = C.IdEmpleado Where C.Estado = '" + Estado + "'", conexion);
            }
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                dgvComanda.Rows.Add(lector[0].ToString(), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(), lector[4].ToString(), lector[5].ToString(), lector[6].ToString());
                cboIdComanda.Items.Add(lector[0].ToString());
            }

            conexion.Close();
        }


        private void cboIdComanda_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();

            dgvDetalleComanda.Rows.Clear();
            comando = new SqlCommand("Select D.IdComanda, D.IdMenu, M.Descripcion, D.Cantidad, D.Precio, D.Cantidad * D.Precio as Importe From DetalleComanda as D inner join Menu as M on M.IdMenu = D.IdMenu inner join Comandas as C on C.IdComanda = D.IdComanda where C.IdComanda = " + Convert.ToInt32(cboIdComanda.Text), conexion);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                dgvDetalleComanda.Rows.Add(lector[0].ToString(), lector[1].ToString(), lector[2].ToString(), lector[3].ToString(), lector[4].ToString(), lector[5].ToString());
            }

            conexion.Close();
        }



 
    }
}
