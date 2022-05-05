using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmAlmacen : Form
    {
        N_Almacen negocio = new N_Almacen();
        E_Almacen entidades = new E_Almacen();

        private string idalmacen;
        private bool actualizar = false;
        public frmAlmacen()
        {
            InitializeComponent();
            MostrarTablaAlmacen("");

        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            EsconderAnchoColumna();
        }

        public void EsconderAnchoColumna()
        {
            //Modifica el ancho de la columna
            dgAlmacen.ClearSelection();
            dgAlmacen.Columns[0].Visible = false;
            dgAlmacen.Columns[1].Width = 48;
            dgAlmacen.Columns[2].Width = 70;
            dgAlmacen.Columns[3].Width = 80;
            dgAlmacen.Columns[4].Width = 216;
            dgAlmacen.Columns[5].Width = 60;
            dgAlmacen.Columns[6].Width = 96;
            txtCodigo.Enabled = false;

        }

        public void MostrarTablaAlmacen(string buscar)
        {
            N_Almacen negocios = new N_Almacen();
            dgAlmacen.DataSource = negocios.ListarAlmacen(buscar);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarTablaAlmacen(txtBuscar.Text);
        }

        private void cerrarFrmEmpresa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarCampos()
        {
            actualizar = false;
            txtCodigo.Text = "";
            txtAlmacen.Text = "";
            txtUbicacion.Text = "";
            txtDireccion.Text = "";
            txtCapacidad.Text = "";
            txtObs.Text = "";
            txtAlmacen.Focus();
        }

        private void filaSeleccionada()
        {
            idalmacen = dgAlmacen.CurrentRow.Cells[0].Value.ToString();
            txtCodigo.Text = dgAlmacen.CurrentRow.Cells[1].Value.ToString();
            txtAlmacen.Text = dgAlmacen.CurrentRow.Cells[2].Value.ToString();
            txtUbicacion.Text = dgAlmacen.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = dgAlmacen.CurrentRow.Cells[4].Value.ToString();
            txtCapacidad.Text = dgAlmacen.CurrentRow.Cells[5].Value.ToString();
            txtObs.Text = dgAlmacen.CurrentRow.Cells[6].Value.ToString();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            if (dgAlmacen.SelectedRows.Count > 0)
            {
                actualizar = true;
                filaSeleccionada();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea editar");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (actualizar == false)
            {
                try
                {
                    entidades.NombreAlmacen = txtAlmacen.Text;
                    entidades.UbicacionAlmacen = txtUbicacion.Text;
                    entidades.DireccionAlmacen = txtDireccion.Text;
                    entidades.CapacidadAlmacen = Convert.ToInt32(txtCapacidad.Text);
                    entidades.ObsAlmacen = txtObs.Text;

                    negocio.CreandoAlmacen(entidades);

                    successView.confirmForm("ALMACEN GUARDADO");
                    MostrarTablaAlmacen("");
                    limpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo guardar el registro " + ex);
                }
            }
            if (actualizar == true)
            {
                try
                {
                    entidades.IdAlmacen = Convert.ToInt32(idalmacen);
                    entidades.NombreAlmacen = txtAlmacen.Text;
                    entidades.UbicacionAlmacen = txtUbicacion.Text;
                    entidades.DireccionAlmacen = txtDireccion.Text;
                    entidades.CapacidadAlmacen = Convert.ToInt32(txtCapacidad.Text);
                    entidades.ObsAlmacen = txtObs.Text;

                    negocio.EditandoAlamcen(entidades);

                    successView.confirmForm("ALMACEN EDITADO");
                    MostrarTablaAlmacen("");
                    limpiarCampos();
                    actualizar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el registro " + ex);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = new DialogResult();
                informationView frm = new informationView("ESTAS SEGURO QUE DESEAS REALIZAR ESTA ACCION");
                result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    entidades.IdAlmacen = Convert.ToInt32(dgAlmacen.CurrentRow.Cells[0].Value.ToString());
                    negocio.EliminandoAlmacen(entidades);

                    successView.confirmForm("CATEGORIA ELIMINADA");
                    MostrarTablaAlmacen("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void dgAlmacen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //filaSeleccionada();
        }
    }
}