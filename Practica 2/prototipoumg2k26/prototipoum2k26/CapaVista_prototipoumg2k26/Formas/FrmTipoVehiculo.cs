using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_prototipoumg2k26;

namespace CapaVista_prototipoumg2k26.Formas
{
    public partial class FrmTipoVehiculo : Form
    {
        private ModeloTipoVehiculo tipoVehiculo = new ModeloTipoVehiculo();
        public FrmTipoVehiculo()
        {
            InitializeComponent();
            panIngresoDatos.Enabled = false;
        }

        private void FrmTipoVehiculo_Load(object sender, EventArgs e)
        {
            listaTipoVehiculo();
            comboI1.llenarCombo("tipo_vehiculo", "id_tipo_vehiculo", "nombre_tipo_vehiculo", false); 
        }
        private void listaTipoVehiculo()
        {
            try
            {
                dgvTipoVehiculo.DataSource = tipoVehiculo.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvTipoVehiculo.DataSource = tipoVehiculo.FindbyId(txtSearch.Text);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvTipoVehiculo.DataSource = tipoVehiculo.FindbyId(txtSearch.Text);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            tipoVehiculo.Nombre = txtNombre.Text;
            tipoVehiculo.Descripcion = txtDescripcion.Text;
            bool valido = new Ayudas.ValidacionDatos(tipoVehiculo).Validar();
            if (valido == true)
            {
                string resultado = tipoVehiculo.GrabarCambios();
                MessageBox.Show(resultado);
                listaTipoVehiculo();
                Reinicio();
            }
        }
        private void Reinicio()
        {
            panIngresoDatos.Enabled = false;
            txtNombre.Clear();
            txtDescripcion.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panIngresoDatos.Enabled = true;
            tipoVehiculo.Estado = EstadoEntidad.Added;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTipoVehiculo.SelectedRows.Count > 0)
            {
                panIngresoDatos.Enabled = true;
                tipoVehiculo.Estado = EstadoEntidad.Modified;
                tipoVehiculo.IdPK = Convert.ToInt32(dgvTipoVehiculo.CurrentRow.Cells[0].Value);
                txtNombre.Text = dgvTipoVehiculo.CurrentRow.Cells[1].Value.ToString();
                txtDescripcion.Text = dgvTipoVehiculo.CurrentRow.Cells[2].Value.ToString();
            }
            else MessageBox.Show("Seleccione una fila");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvTipoVehiculo.SelectedRows.Count > 0)
            {
                tipoVehiculo.Estado = EstadoEntidad.Deleted;
                tipoVehiculo.IdPK = Convert.ToInt32(dgvTipoVehiculo.CurrentRow.Cells[0].Value);
                string resultado = tipoVehiculo.GrabarCambios();
                MessageBox.Show(resultado);
                listaTipoVehiculo();
            }
            else MessageBox.Show("Seleccione una fila");
        }

    }
}