using CapaDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using CapaDatos;
using MySql.Data.MySqlClient;
using CapaNegocio;

namespace InmobiliariaApp
{
    public partial class MainForm : Form
    {
        private List<Casa> casas;
        public Conexion mConexion;
        public MainForm()
        {
            InitializeComponent();
            casas = new List<Casa>();
            mConexion = new Conexion();

            CargarCasasDesdeBaseDeDatos();
        }

        private void btnAgregarCasa_Click(object sender, EventArgs e)
        {
            // Obtener datos de la casa desde los controles de la interfaz
            string direccion = txtDireccion.Text;
            decimal precio;
            bool disponible = chkDisponible.Checked;
            DateTime fechaConstruccion = dtpFechaConstruccion.Value;

            if (string.IsNullOrWhiteSpace(direccion))
            {
                MessageBox.Show("La dirección no puede estar vacía.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido mayor que cero.");
                return;
            }

            // Crear objeto Casa
            Casa nuevaCasa = new Casa(direccion, precio, disponible, fechaConstruccion);

            // Crear instancia de AdminisCasa
            AdminisCasa adminisCasa = new AdminisCasa();

            // Llamar al método abmAgregarCasa para guardar la casa en la base de datos
            int filasAfectadas = adminisCasa.abmAgregarCasa("Agregar", nuevaCasa);

            if (filasAfectadas > 0)
            {
                // Éxito: la casa se guardó en la base de datos
                MessageBox.Show("La casa se guardó correctamente en la base de datos.");

                // Agregar la nueva casa a la lista local
                casas.Add(nuevaCasa);

                // Actualizar la lista de casas en la interfaz
                ActualizarListaCasas();
            }
            else
            {
                // Error: no se pudo guardar la casa en la base de datos
                MessageBox.Show("Error al guardar la casa en la base de datos.");
            }

            // Limpiar los controles de entrada
            LimpiarCamposCasa();
        }

        private void CargarCasasDesdeBaseDeDatos()
        {
            try
            {
                AdminisCasa adminisCasa = new AdminisCasa();
                casas = adminisCasa.ObtenerCasasDesdeBaseDeDatos();

                // Actualizar la lista en la interfaz con las casas cargadas
                ActualizarListaCasas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las casas desde la base de datos: " + ex.Message);
            }
        }

        private void ActualizarListaCasas()
        {
            // Limpiar la lista de casas en la interfaz
            lstCasas.Items.Clear();

            // Agregar las casas a la lista en la interfaz
            foreach (Casa casa in casas)
            {
                lstCasas.Items.Add(casa.Direccion);
            }
        }

        private void LimpiarCamposCasa()
        {
            txtDireccion.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            chkDisponible.Checked = false;
            dtpFechaConstruccion.Value = DateTime.Now;
        }

        private void lstCasas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el �ndice seleccionado de la lista de casas
            int indiceSeleccionado = lstCasas.SelectedIndex;

            if (indiceSeleccionado >= 0 && indiceSeleccionado < casas.Count)
            {
                // Obtener la casa seleccionada
                Casa casaSeleccionada = casas[indiceSeleccionado];

                // Mostrar los detalles de la casa en los controles de la interfaz
                txtDireccionDetalle.Text = casaSeleccionada.Direccion;
                txtPrecioDetalle.Text = casaSeleccionada.Precio.ToString();
                chkDisponibleDetalle.Checked = casaSeleccionada.Disponible;
                dtpFechaConstruccionDetalle.Value = casaSeleccionada.FechaConstruccion;
            }
        }

    }
}