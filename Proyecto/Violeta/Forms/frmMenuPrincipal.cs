﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Forms;

namespace Proyecto
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Para que se genere una sola instancia o solo se cargue una vez el formulario
            //Dentro de la ventana MDI
            frmGenerarFactura generarFacturaForm = new frmGenerarFactura(); //frmGenerarFactura.ventanaGenerarFactura();

            generarFacturaForm.MdiParent = this;//Para que se contenta dentro de la plantilla MDI
            generarFacturaForm.Show(); // Muestra el formulario de generación de factura
            generarFacturaForm.BringToFront();//Para ponerla al frente de los demas formularios
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Para que se genere una sola instancia o solo se cargue una vez el formulario
            //Dentro de la ventana MDI
            frmAgregarCliente agregarClienteForm = new frmAgregarCliente();

            agregarClienteForm.MdiParent = this;
            agregarClienteForm.Show(); // Muestra el formulario de agregar cliente
            agregarClienteForm.BringToFront();
        }

        private void verHistorialDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Para que se genere una sola instancia o solo se cargue una vez el formulario
            //Dentro de la ventana MDI
            frmHistorialFacturas historialFacturasForm = new frmHistorialFacturas();

            historialFacturasForm.MdiParent = this;
            historialFacturasForm.Show();// muestra el formulario historial facturas
            historialFacturasForm.BringToFront();//Para ponerla al frente de los demas formularios
        }

        private void modificarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Para que se genere una sola instancia o solo se cargue una vez el formulario
            //Dentro de la ventana MDI
            frmModificarDatosClientes modificarDatosClientesForm = new frmModificarDatosClientes();

            modificarDatosClientesForm.MdiParent = this;
            modificarDatosClientesForm.Show(); // Abre el formulario 

            modificarDatosClientesForm.BringToFront();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Para que se genere una sola instancia o solo se cargue una vez el formulario
            //Dentro de la ventana MDI
            frmConsultarCliente consultarClienteForm = new frmConsultarCliente();

            consultarClienteForm.MdiParent = this;
            consultarClienteForm.Show();
            consultarClienteForm.BringToFront();
        }

        private void darDeBajaAClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Para que se genere una sola instancia o solo se cargue una vez el formulario
            //Dentro de la ventana MDI
            frmDarBajaCliente dardeBajaClientes = new frmDarBajaCliente();

            dardeBajaClientes.MdiParent = this;
            dardeBajaClientes.Show();
            dardeBajaClientes.BringToFront();
        }

        private void actualizarOEliminarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario
            frmActualizarEliminarFacturaErronea formActualizarEliminar = new frmActualizarEliminarFacturaErronea();
            formActualizarEliminar.MdiParent = this;

            // Muestra el formulario
            formActualizarEliminar.Show();
            formActualizarEliminar.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotificaciones formNotificaciones = new frmNotificaciones();
            formNotificaciones.MdiParent = this;

            formNotificaciones.Show();
            formNotificaciones.BringToFront();
        }
    }
}
