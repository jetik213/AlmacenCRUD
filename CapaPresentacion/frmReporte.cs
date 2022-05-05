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
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'DataSetDB.INV_MOVIMIENTO' Puede moverla o quitarla según sea necesario.
            this.INV_MOVIMIENTOTableAdapter.Fill(this.DataSetDB.INV_MOVIMIENTO);
            // TODO: esta línea de código carga datos en la tabla 'DataSetDB.INV_PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.INV_PRODUCTOTableAdapter.Fill(this.DataSetDB.INV_PRODUCTO);
            // TODO: esta línea de código carga datos en la tabla 'DataSetDB.INV_ALMACEN' Puede moverla o quitarla según sea necesario.
            this.INV_ALMACENTableAdapter.Fill(this.DataSetDB.INV_ALMACEN);
            // TODO: esta línea de código carga datos en la tabla 'DataSetDB.INV_EMPRESA' Puede moverla o quitarla según sea necesario.
            this.INV_EMPRESATableAdapter.Fill(this.DataSetDB.INV_EMPRESA);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}