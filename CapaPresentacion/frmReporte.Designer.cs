namespace CapaPresentacion
{
    partial class frmReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetDB = new CapaPresentacion.DataSetDB();
            this.INV_ALMACENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.INV_ALMACENTableAdapter = new CapaPresentacion.DataSetDBTableAdapters.INV_ALMACENTableAdapter();
            this.INV_EMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.INV_EMPRESATableAdapter = new CapaPresentacion.DataSetDBTableAdapters.INV_EMPRESATableAdapter();
            this.INV_MOVIMIENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.INV_MOVIMIENTOTableAdapter = new CapaPresentacion.DataSetDBTableAdapters.INV_MOVIMIENTOTableAdapter();
            this.INV_PRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.INV_PRODUCTOTableAdapter = new CapaPresentacion.DataSetDBTableAdapters.INV_PRODUCTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INV_ALMACENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INV_EMPRESABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INV_MOVIMIENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.INV_PRODUCTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.INV_ALMACENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportAlmacen.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 28);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(679, 349);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.INV_EMPRESABindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportEmpresa.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(708, 28);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(684, 349);
            this.reportViewer2.TabIndex = 1;
            // 
            // reportViewer3
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.INV_MOVIMIENTOBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportMovimiento.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(2, 408);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(679, 365);
            this.reportViewer3.TabIndex = 2;
            // 
            // reportViewer4
            // 
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.INV_PRODUCTOBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "CapaPresentacion.ReportProducto.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(708, 408);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(684, 365);
            this.reportViewer4.TabIndex = 3;
            // 
            // DataSetDB
            // 
            this.DataSetDB.DataSetName = "DataSetDB";
            this.DataSetDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // INV_ALMACENBindingSource
            // 
            this.INV_ALMACENBindingSource.DataMember = "INV_ALMACEN";
            this.INV_ALMACENBindingSource.DataSource = this.DataSetDB;
            // 
            // INV_ALMACENTableAdapter
            // 
            this.INV_ALMACENTableAdapter.ClearBeforeFill = true;
            // 
            // INV_EMPRESABindingSource
            // 
            this.INV_EMPRESABindingSource.DataMember = "INV_EMPRESA";
            this.INV_EMPRESABindingSource.DataSource = this.DataSetDB;
            // 
            // INV_EMPRESATableAdapter
            // 
            this.INV_EMPRESATableAdapter.ClearBeforeFill = true;
            // 
            // INV_MOVIMIENTOBindingSource
            // 
            this.INV_MOVIMIENTOBindingSource.DataMember = "INV_MOVIMIENTO";
            this.INV_MOVIMIENTOBindingSource.DataSource = this.DataSetDB;
            // 
            // INV_MOVIMIENTOTableAdapter
            // 
            this.INV_MOVIMIENTOTableAdapter.ClearBeforeFill = true;
            // 
            // INV_PRODUCTOBindingSource
            // 
            this.INV_PRODUCTOBindingSource.DataMember = "INV_PRODUCTO";
            this.INV_PRODUCTOBindingSource.DataSource = this.DataSetDB;
            // 
            // INV_PRODUCTOTableAdapter
            // 
            this.INV_PRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1395, 1045);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlmacen";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INV_ALMACENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INV_EMPRESABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INV_MOVIMIENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.INV_PRODUCTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource INV_ALMACENBindingSource;
        private DataSetDB DataSetDB;
        private DataSetDBTableAdapters.INV_ALMACENTableAdapter INV_ALMACENTableAdapter;
        private System.Windows.Forms.BindingSource INV_EMPRESABindingSource;
        private DataSetDBTableAdapters.INV_EMPRESATableAdapter INV_EMPRESATableAdapter;
        private System.Windows.Forms.BindingSource INV_MOVIMIENTOBindingSource;
        private DataSetDBTableAdapters.INV_MOVIMIENTOTableAdapter INV_MOVIMIENTOTableAdapter;
        private System.Windows.Forms.BindingSource INV_PRODUCTOBindingSource;
        private DataSetDBTableAdapters.INV_PRODUCTOTableAdapter INV_PRODUCTOTableAdapter;
    }
}