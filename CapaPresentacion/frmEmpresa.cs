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
    public partial class frmEmpresa : Form
    {
        N_Empresa negocio = new N_Empresa();
        E_Empresa entidades = new E_Empresa();

        private string idempresa;
        private bool actualizar = false;
        public frmEmpresa()
        {
            InitializeComponent();
            MostrarTablaEmpresa("");
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            EsconderAnchoColumna();
        }

        public void EsconderAnchoColumna()
        {
            dgEmpresa.ClearSelection();
            dgEmpresa.Columns[0].Visible = false;
            dgEmpresa.Columns[1].Width = 60;
            dgEmpresa.Columns[2].Width = 80;
            dgEmpresa.Columns[3].Width = 120;
            dgEmpresa.Columns[4].Width = 200;
            txtCodigo.Enabled = false;
        }

        public void MostrarTablaEmpresa(string buscar)
        {
            N_Empresa negocios = new N_Empresa();
            dgEmpresa.DataSource = negocios.ListaEmpresas(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarTablaEmpresa(txtBuscar.Text);
        }

        private void cerrarFrmEmpresa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarCampos()
        {
            actualizar = false;
            txtCodigo.Text = "";
            txtRuc.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtObs.Text = "";
            txtNombre.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtRuc.Enabled = false;
            if (dgEmpresa.SelectedRows.Count > 0)
            {
                actualizar = true;
                idempresa = dgEmpresa.CurrentRow.Cells[0].Value.ToString();
                txtCodigo.Text = dgEmpresa.CurrentRow.Cells[1].Value.ToString();
                txtRuc.Text = dgEmpresa.CurrentRow.Cells[2].Value.ToString();
                txtNombre.Text = dgEmpresa.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = dgEmpresa.CurrentRow.Cells[4].Value.ToString();
                txtObs.Text = dgEmpresa.CurrentRow.Cells[5].Value.ToString();
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
                    if (txtNombre.Text == "" || txtDireccion.Text == "")
                    {
                        MessageBox.Show("No se pudo guardar el registro");
                    }
                    else
                    {
                        entidades.RucEmpresa = txtRuc.Text;
                        entidades.NombreEmpresa = txtNombre.Text;
                        entidades.DireccionEmpresa = txtDireccion.Text;
                        entidades.ObsEmpresa = txtObs.Text;

                        negocio.CreandoEmpresa(entidades);

                        successView.confirmForm("EMPRESA GUARDADA");
                        MostrarTablaEmpresa("");
                        limpiarCampos();
                    }
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
                    entidades.IdEmpresa = Convert.ToInt32(idempresa);
                    entidades.RucEmpresa = txtRuc.Text;
                    entidades.NombreEmpresa = txtNombre.Text;
                    entidades.DireccionEmpresa = txtDireccion.Text;
                    entidades.ObsEmpresa = txtObs.Text;

                    negocio.EditandoEmpresa(entidades);

                    successView.confirmForm("EMPRESA EDITADA");
                    MostrarTablaEmpresa("");
                    limpiarCampos();
                    actualizar = false;
                    txtRuc.Enabled = true;
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
                    entidades.IdEmpresa = Convert.ToInt32(dgEmpresa.CurrentRow.Cells[0].Value.ToString());
                    negocio.EliminandoEmpresa(entidades);

                    successView.confirmForm("CATEGORIA ELIMINADA");
                    MostrarTablaEmpresa("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}