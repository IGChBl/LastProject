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

namespace Proyecto.Forms
{
    public partial class frmActualizaDatosFactura : Form
    {
        public frmActualizaDatosFactura()
        {
            InitializeComponent();
           

        }
        // Agregar una propiedad pública para recibir el nombre del cliente
        public string NombreCliente
        {
            set
            {
                txtCliente.Text = value; // txtCliente debe ser el TextBox donde se muestra el nombre del cliente
            }
        }
        public List<string[]> DatosFactura { get; set; } // Listado de datos de la factura
        private void frmActualizaDatosFactura_Load(object sender, EventArgs e)
        {
            if (DatosFactura != null && DatosFactura.Count > 0)
            {
                // Configurar columnas del DataGridView
                dgvFecha.ColumnCount = 5;
                dgvFecha.Columns[0].Name = "Numero";
                dgvFecha.Columns[1].Name = "Cliente";
                dgvFecha.Columns[2].Name = "Fecha";
                dgvFecha.Columns[3].Name = "Total";
                dgvFecha.Columns[4].Name = "Fecha de Corte";
                dgvFecha.Rows.Clear(); // Limpia cualquier fila existente
                foreach (var fila in DatosFactura)
                {
                    dgvFecha.Rows.Add(fila); // Agrega cada fila recibida
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que la fecha seleccionada no esté vacía
            DateTime nuevaFecha = dtpFecha.Value;

            // Cargar las facturas desde el almacenamiento
            var facturas = FacturaStorage.CargarFacturas();

            // Depurar cuántas facturas se cargaron
            MessageBox.Show($"Total de facturas cargadas: {facturas.Count}", "Depuración");

            // Obtener el número de factura desde DatosFactura
            var numeroFactura = DatosFactura[0][0]?.ToString(); // Validación de nulo y conversión a string

            // Depurar el valor de DatosFactura[0][0]
            MessageBox.Show(numeroFactura, "Valor de DatosFactura[0][0]");

            // Verificar que el número de factura no sea nulo
            if (string.IsNullOrEmpty(numeroFactura))
            {
                MessageBox.Show("El número de factura no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar la factura seleccionada por su número
            var factura = facturas.FirstOrDefault(f => f.Numero == numeroFactura);

            if (factura != null)
            {
                // Actualizar la fecha de la factura
                factura.Fecha = nuevaFecha;

                // Guardar las facturas actualizadas en el sistema
                FacturaStorage.GuardarFacturas(facturas);

                // Mostrar mensaje de confirmación
                MessageBox.Show("La fecha de la factura ha sido actualizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el formulario actual
                this.Close();
            }
            else
            {
                // Mostrar mensaje de error si no se encuentra la factura
                MessageBox.Show("No se pudo encontrar la factura para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Validar que la fecha seleccionada no esté vacía
            DateTime nuevaFecha = dtpFecha.Value;

            // Cargar las facturas desde el almacenamiento
            var facturas = FacturaStorage.CargarFacturas();

            // Depurar cuántas facturas se cargaron
            MessageBox.Show($"Total de facturas cargadas: {facturas.Count}", "Depuración");

            // Obtener el número de factura desde DatosFactura
            var numeroFactura = DatosFactura[0][0]?.ToString(); // Validación de nulo y conversión a string

            // Depurar el valor de DatosFactura[0][0]
            MessageBox.Show(numeroFactura, "Valor de DatosFactura[0][0]");

            // Verificar que el número de factura no sea nulo
            if (string.IsNullOrEmpty(numeroFactura))
            {
                MessageBox.Show("El número de factura no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buscar la factura seleccionada por su número
            var factura = facturas.FirstOrDefault(f => f.Numero == numeroFactura);

            if (factura != null)
            {
                // Actualizar la fecha de la factura
                factura.Fecha = nuevaFecha;

                // Guardar las facturas actualizadas en el sistema
                FacturaStorage.GuardarFacturas(facturas);

                // Mostrar mensaje de confirmación
                MessageBox.Show("La fecha de la factura ha sido actualizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el formulario actual
                this.Close();
            }
            else
            {
                // Mostrar mensaje de error si no se encuentra la factura
                MessageBox.Show("No se pudo encontrar la factura para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
