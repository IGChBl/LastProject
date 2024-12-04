using Proyecto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmNotificaciones : Form
    {
        public frmNotificaciones()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var facturas = FacturaStorage.CargarFacturas();
            var hoy = DateTime.Now.Date;

            foreach (var factura in facturas)
            {
                if (factura.FechaCorte.Date == hoy)
                {
                    // Mostrar notificación
                    MessageBox.Show($"Hoy es la fecha de corte para la factura {factura.Numero} del cliente {factura.Cliente}.",
                                    "Notificación de Fecha de Corte",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    // Opcional: Registrar la notificación para evitar notificaciones duplicadas
                }
            }
        }

        private void frmNotificaciones_Load(object sender, EventArgs e)
        {
            timer1.Start();
            CargarNotificaciones();
        }
        private void CargarNotificaciones()
        {
            lstNotificaciones.Items.Clear(); // Limpia la lista antes de cargar
            var facturas = FacturaStorage.CargarFacturas();

            foreach (var factura in facturas)
            {
                if (factura.FechaCorte.Date == DateTime.Now.Date)
                {
                    lstNotificaciones.Items.Add($"Hoy es la fecha de corte para la factura {factura.Numero} del cliente {factura.Cliente}.");
                }
            }

            if (lstNotificaciones.Items.Count == 0)
            {
                lstNotificaciones.Items.Add("No hay notificaciones para hoy.");
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarNotificaciones();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
