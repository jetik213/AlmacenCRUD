using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades.Cache;

namespace CapaPresentacion
{
    public partial class frmMovimiento : Form
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        N_Movimiento negocio = new N_Movimiento();
        E_Movimiento entidades = new E_Movimiento();
        ArrayList listaMovimiento = new ArrayList();
        int num = 0;
        DataTable Almacen()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from inv_almacen", conexion);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;
        }
        DataTable Producto()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from inv_producto", conexion);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;
        }
        /*DataTable Usuario()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from inv_usuarios", conexion);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;
        }*/
        DataTable Empresa()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from inv_empresa", conexion);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;
        }
        public frmMovimiento()
        {
            InitializeComponent();
        }
        private void frmMovimiento_Load(object sender, EventArgs e)
        {
            //EsconderAnchoColumna();
            
            cboProducto.DataSource = Producto();
            cboProducto.DisplayMember = "nombre_producto";
            cboProducto.ValueMember = "id_producto";

            cboAlmacen.DataSource = Almacen();
            cboAlmacen.DisplayMember = "nombre_almacen";
            cboAlmacen.ValueMember = "id_almacen";

            cboEmpresa.DataSource = Empresa();
            cboEmpresa.DisplayMember = "empresa";
            cboEmpresa.ValueMember = "id_empresa";

            /*cboUsuario.DataSource = Usuario();
            cboUsuario.DisplayMember = "nombre";
            cboUsuario.ValueMember = "id_usuario";*/
        }
        private void limpiarCampos()
        {
            txtCantidad.Text = "";
            txtGuiaTransporte.Text = "";
            txtObs.Text = "";
            cboAlmacen.SelectedIndex = 0;
            cboProducto.SelectedIndex = 0;
            cboEmpresa.SelectedIndex = 0;
            //cboUsuario.SelectedIndex = 0;
            cboAlmacen.Focus();
        }

        public void EsconderAnchoColumna()
        {
            //Modifica el ancho de la columna
            dgMovimiento.ClearSelection();
            dgMovimiento.ColumnCount = 11;
            //dgMovimiento.Columns[0].Width = 60;
            dgMovimiento.Columns[1].Visible = false;
            //dgMovimiento.Columns[2].Width = 60;
            dgMovimiento.Columns[3].Visible = false;
            //dgMovimiento.Columns[4].Width = 60;
            dgMovimiento.Columns[5].Visible = false;
           //dgMovimiento.Columns[6].Width = 60;
            dgMovimiento.Columns[7].Visible = false;
            /*dgMovimiento.Columns[8].Width = 60;
            dgMovimiento.Columns[9].Width = 60;
            dgMovimiento.Columns[10].Width = 60;
            dgMovimiento.Columns[11].Width = 60;*/
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            E_Mov enti = new E_Mov();
            num++;
            enti.IdMov = num;
            enti.IdAlmacen = Int32.Parse(cboAlmacen.SelectedValue.ToString());
            enti.NomAlmacen = cboAlmacen.Text;
            enti.IdEmpresa = Int32.Parse(cboEmpresa.SelectedValue.ToString());
            enti.NomEmpresa = cboEmpresa.Text;
            enti.IdUsuario = CacheInicioSesion.IdUsuario;
            enti.NomUsuario = CacheInicioSesion.Nombre;
            /*
            enti.IdUsuario = Int32.Parse(cboUsuario.SelectedValue.ToString());
            enti.NomUsuario = cboUsuario.Text;*/
            enti.IdProducto = Int32.Parse(cboProducto.SelectedValue.ToString());
            enti.NomProducto = cboProducto.Text;
            enti.Cantidad = txtCantidad.Text;
            enti.Guia = txtGuiaTransporte.Text;
            enti.ObsMov = txtObs.Text;

            listaMovimiento.Add(enti);
            dgMovimiento.DataSource = null;
            dgMovimiento.DataSource = listaMovimiento;

            limpiarCampos();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            foreach (E_Mov mov in listaMovimiento)
            {
                if (mov.IdMov == Int32.Parse(lblID.Text))
                {
                    var index = listaMovimiento.IndexOf(mov);
                    E_Mov enti = new E_Mov();
                    enti.IdMov = int.Parse(lblID.Text);
                    enti.IdAlmacen = Int32.Parse(cboAlmacen.SelectedValue.ToString());
                    enti.NomAlmacen = cboAlmacen.Text;
                    enti.IdEmpresa = Int32.Parse(cboEmpresa.SelectedValue.ToString());
                    enti.NomEmpresa = cboEmpresa.Text;
                    enti.IdUsuario = CacheInicioSesion.IdUsuario;
                    enti.NomUsuario = CacheInicioSesion.Nombre;
                    /*
                    enti.IdUsuario = Int32.Parse(cboUsuario.SelectedValue.ToString());
                    enti.NomUsuario = cboUsuario.Text;*/
                    enti.IdProducto = Int32.Parse(cboProducto.SelectedValue.ToString());
                    enti.NomProducto = cboProducto.Text;
                    enti.Cantidad = txtCantidad.Text;
                    enti.Guia = txtGuiaTransporte.Text;
                    enti.ObsMov = txtObs.Text;

                    listaMovimiento[index] = enti;
                    dgMovimiento.DataSource = null;
                    dgMovimiento.DataSource = listaMovimiento;

                    limpiarCampos();

                    return;
                }
            }
            MessageBox.Show("NO EXISTE EL NÚMERO DE SERIE, INGRESE OTRO");
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (E_Mov mov in listaMovimiento)
            {
                if (mov.IdMov == Int32.Parse(lblID.Text))
                {
                    listaMovimiento.Remove(mov);
                    break;
                }
            }
            dgMovimiento.DataSource = null;
            dgMovimiento.DataSource = listaMovimiento;

            limpiarCampos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<E_Movimiento> objDetail = new List<E_Movimiento>();
            foreach (DataGridViewRow dgvRow in dgMovimiento.Rows)
            {

                var detail = new E_Movimiento()
                {
                    /*orderid = codOrden,
                    productid = 2,
                    unidPrecio = 3,
                    cantidad = 4,
                    descuento = 5*/

                    IdAlmacen = Int32.Parse(dgvRow.Cells[1].Value.ToString()),
                    IdProducto = Int32.Parse(dgvRow.Cells[3].Value.ToString()),
                    IdUsuario = CacheInicioSesion.IdUsuario,
                    //IdUsuario = Int32.Parse(dgvRow.Cells[5].Value.ToString()),
                    IdEmpresa = Int32.Parse(dgvRow.Cells[7].Value.ToString()),
                    Cantidad = dgvRow.Cells[9].Value.ToString(),
                    Guia = dgvRow.Cells[10].Value.ToString(),
                    ObsMov = dgvRow.Cells[11].Value.ToString()
                };
                objDetail.Add(detail);
            }

            N_Movimiento negocio = new N_Movimiento();
            negocio.add_MultipleStatements(objDetail);
            MessageBox.Show("Los datos del detalle de la orden se insertaron correctamente");
        }

        private void dgMovimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView temp = (DataGridView)sender;
            if (temp.CurrentRow == null)
                return;
            lblID.Text = dgMovimiento.CurrentRow.Cells[0].Value.ToString();
            cboAlmacen.Text = dgMovimiento.CurrentRow.Cells[2].Value.ToString();
            cboProducto.Text = dgMovimiento.CurrentRow.Cells[4].Value.ToString();
            //cboUsuario.Text = dgMovimiento.CurrentRow.Cells[6].Value.ToString();
            cboEmpresa.Text = dgMovimiento.CurrentRow.Cells[8].Value.ToString();
            txtCantidad.Text = dgMovimiento.CurrentRow.Cells[9].Value.ToString();
            txtGuiaTransporte.Text = dgMovimiento.CurrentRow.Cells[10].Value.ToString();
            txtObs.Text = dgMovimiento.CurrentRow.Cells[11].Value.ToString();
        }
    }
}