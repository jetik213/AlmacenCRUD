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
    public partial class frmProducto : Form
    {
        N_Producto negocio = new N_Producto();
        E_Producto entidades = new E_Producto();

        private string idproducto;
        private bool actualizar = false;
        public frmProducto()
        {
            InitializeComponent();
            MostrarTablaProducto("");
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            EsconderAnchoColumna();
        }

        public void EsconderAnchoColumna()
        {
            //Modifica el ancho de la columna
            dgProducto.ClearSelection();
            dgProducto.Columns[0].Visible = false;
            dgProducto.Columns[1].Width = 60;
            dgProducto.Columns[2].Width = 100;
            dgProducto.Columns[3].Width = 60;
            dgProducto.Columns[4].Width = 40;
            dgProducto.Columns[5].Width = 100;
            dgProducto.Columns[6].Width = 70;
            dgProducto.Columns[7].Width = 150;
            txtCodigo.Enabled = false;
        }
        public void MostrarTablaProducto(string buscar)
        {
            N_Producto negocios = new N_Producto();
            dgProducto.DataSource = negocios.ListarProductos(buscar);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarTablaProducto(txtBuscar.Text);
        }

        private void cerrarFrmEmpresa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarCampos()
        {
            actualizar = false;
            txtCodigo.Text = "";
            txtProducto.Text = "";
            txtOrigen.Text = "";
            //cboEstado.Text = "";
            txtEmpaque.Text = "";
            txtAbreviatura.Text = "";
            txtObs.Text = "";
            txtCodigo.Focus();
        }
        private void filaSeleccionada()
        {
            idproducto = dgProducto.CurrentRow.Cells[0].Value.ToString();
            txtCodigo.Text = dgProducto.CurrentRow.Cells[1].Value.ToString();
            txtProducto.Text = dgProducto.CurrentRow.Cells[2].Value.ToString();
            txtOrigen.Text = dgProducto.CurrentRow.Cells[3].Value.ToString();
            //cboEstado.Text = dgProducto.CurrentRow.Cells[4].Value.ToString();
            txtEmpaque.Text = dgProducto.CurrentRow.Cells[5].Value.ToString();
            txtAbreviatura.Text = dgProducto.CurrentRow.Cells[6].Value.ToString();
            txtObs.Text = dgProducto.CurrentRow.Cells[7].Value.ToString();

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgProducto.SelectedRows.Count > 0)
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
                    entidades.NombreProducto = txtProducto.Text;
                    entidades.OrigenProducto = txtOrigen.Text;
                    entidades.EstadoProducto = 0;
                    entidades.EmpaqueProducto = txtEmpaque.Text;
                    entidades.AbreviaturaProducto = txtAbreviatura.Text;
                    entidades.ObsProducto = txtObs.Text;

                    negocio.CreandoProducto(entidades);

                    successView.confirmForm("PRODUCTO GUARDADO");
                    MostrarTablaProducto("");
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
                    entidades.IdProducto = Convert.ToInt32(idproducto);
                    entidades.NombreProducto = txtProducto.Text;
                    entidades.OrigenProducto = txtOrigen.Text;
                    entidades.EstadoProducto = 0;
                    entidades.EmpaqueProducto = txtEmpaque.Text;
                    entidades.AbreviaturaProducto = txtAbreviatura.Text;
                    entidades.ObsProducto = txtObs.Text;

                    negocio.EditandoProducto(entidades);

                    successView.confirmForm("PRODUCTO EDITADO");
                    MostrarTablaProducto("");
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
                    entidades.IdProducto = Convert.ToInt32(dgProducto.CurrentRow.Cells[0].Value.ToString());
                    negocio.EliminandoProducto(entidades);

                    successView.confirmForm("CATEGORIA ELIMINADA");
                    MostrarTablaProducto("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}