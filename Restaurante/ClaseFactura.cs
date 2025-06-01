using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public class ClaseFactura
    {
        public void GenerarFactura(string cliente, string empleado, DataGridView dgv, decimal subtotal, decimal iva, decimal total)
        {
            try
            {
                string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Ticket_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
                using (StreamWriter writer = new StreamWriter(ruta, false, Encoding.UTF8))
                {
                    writer.WriteLine("****** Restaurante Mi Sazón ******");
                    writer.WriteLine("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    writer.WriteLine("----------------------------------");
                    writer.WriteLine("Cliente : " + cliente);
                    writer.WriteLine("Empleado: " + empleado);
                    writer.WriteLine("----------------------------------");
                    writer.WriteLine(" Cant | Descripción        | Total");
                    writer.WriteLine("----------------------------------");

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Cells["Cantidad"].Value != null)
                        {
                            string cantidad = row.Cells["Cantidad"].Value.ToString();
                            string descripcion = row.Cells["Descripcion"].Value.ToString();
                            string importe = Convert.ToDecimal(row.Cells["Importe"].Value).ToString("C");

                            if (descripcion.Length > 18)
                                descripcion = descripcion.Substring(0, 18);

                            writer.WriteLine($"{cantidad.PadLeft(5)} | {descripcion.PadRight(18)} | {importe.PadLeft(6)}");
                        }
                    }

                    writer.WriteLine("----------------------------------");
                    writer.WriteLine($"Subtotal: {subtotal.ToString("C")}");
                    writer.WriteLine($"IVA     : {iva.ToString("C")}");
                    writer.WriteLine($"TOTAL   : {total.ToString("C")}");
                    writer.WriteLine("----------------------------------");
                    writer.WriteLine("Gracias por su visita!");
                }

                MessageBox.Show("Ticket generado en el escritorio.", "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el ticket: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
