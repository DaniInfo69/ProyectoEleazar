using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
           Clientes clientes = new Clientes(); 
            clientes.ShowDialog();
        }

        private void btEmpleados_Click(object sender, EventArgs e)
        {
            Empleados empleados = new Empleados();
            empleados.ShowDialog();
        }

        private void btComandas_Click(object sender, EventArgs e)
        {
            Comandas comandas = new Comandas();
            comandas.ShowDialog();
        }

        private void btPuestos_Click(object sender, EventArgs e)
        {
            Puestos puestos = new Puestos();
            puestos.ShowDialog();
        }
    }
}
