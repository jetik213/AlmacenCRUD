namespace CapaPresentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.wrapper = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.btnReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.arrow = new System.Windows.Forms.PictureBox();
            this.btnCerrarSesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMovimientos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmpresas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAlmacenes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // wrapper
            // 
            this.wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(238)))));
            this.wrapper.Location = new System.Drawing.Point(347, 64);
            this.wrapper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wrapper.Name = "wrapper";
            this.wrapper.Size = new System.Drawing.Size(1403, 807);
            this.wrapper.TabIndex = 1;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(64)))), ((int)(((byte)(85)))));
            this.sidebar.Controls.Add(this.btnReportes);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.arrow);
            this.sidebar.Controls.Add(this.btnCerrarSesion);
            this.sidebar.Controls.Add(this.btnMovimientos);
            this.sidebar.Controls.Add(this.btnProductos);
            this.sidebar.Controls.Add(this.btnEmpresas);
            this.sidebar.Controls.Add(this.btnAlmacenes);
            this.sidebar.Controls.Add(this.pictureBox1);
            this.sidebar.Controls.Add(this.label1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(347, 871);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblCargo);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(21, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 243);
            this.panel1.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(4, 198);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(289, 30);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "NOMBRE";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCargo
            // 
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(8, 17);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(285, 30);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "ADMINISTRADOR";
            this.lblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIRTUAL LOGISTIC";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(161)))));
            this.header.Controls.Add(this.lblTitulo);
            this.header.Controls.Add(this.btnMinimizar);
            this.header.Controls.Add(this.exit);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(347, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1402, 64);
            this.header.TabIndex = 1;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(25, 18);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(146, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "ALMACENES";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1315, 14);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 30);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1359, 14);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(29, 30);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Active = false;
            this.btnReportes.Activecolor = System.Drawing.Color.Transparent;
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.BorderRadius = 0;
            this.btnReportes.ButtonText = "       REPORTES";
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.DisabledColor = System.Drawing.Color.Gray;
            this.btnReportes.ForeColor = System.Drawing.Color.Gray;
            this.btnReportes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReportes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReportes.Iconimage")));
            this.btnReportes.Iconimage_right = null;
            this.btnReportes.Iconimage_right_Selected = null;
            this.btnReportes.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnReportes.Iconimage_Selected")));
            this.btnReportes.IconMarginLeft = 0;
            this.btnReportes.IconMarginRight = 0;
            this.btnReportes.IconRightVisible = true;
            this.btnReportes.IconRightZoom = 0D;
            this.btnReportes.IconVisible = true;
            this.btnReportes.IconZoom = 60D;
            this.btnReportes.IsTab = true;
            this.btnReportes.Location = new System.Drawing.Point(21, 662);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(5);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnReportes.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnReportes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReportes.selected = false;
            this.btnReportes.Size = new System.Drawing.Size(252, 57);
            this.btnReportes.TabIndex = 12;
            this.btnReportes.Text = "       REPORTES";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnReportes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(85, 60);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // arrow
            // 
            this.arrow.Image = ((System.Drawing.Image)(resources.GetObject("arrow.Image")));
            this.arrow.Location = new System.Drawing.Point(296, 364);
            this.arrow.Margin = new System.Windows.Forms.Padding(4);
            this.arrow.Name = "arrow";
            this.arrow.Size = new System.Drawing.Size(51, 57);
            this.arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow.TabIndex = 10;
            this.arrow.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Active = false;
            this.btnCerrarSesion.Activecolor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarSesion.BorderRadius = 0;
            this.btnCerrarSesion.ButtonText = "       CERRAR SESIÓN";
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.DisabledColor = System.Drawing.Color.Gray;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Gray;
            this.btnCerrarSesion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Iconimage")));
            this.btnCerrarSesion.Iconimage_right = null;
            this.btnCerrarSesion.Iconimage_right_Selected = null;
            this.btnCerrarSesion.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Iconimage_Selected")));
            this.btnCerrarSesion.IconMarginLeft = 0;
            this.btnCerrarSesion.IconMarginRight = 0;
            this.btnCerrarSesion.IconRightVisible = true;
            this.btnCerrarSesion.IconRightZoom = 0D;
            this.btnCerrarSesion.IconVisible = true;
            this.btnCerrarSesion.IconZoom = 60D;
            this.btnCerrarSesion.IsTab = true;
            this.btnCerrarSesion.Location = new System.Drawing.Point(21, 772);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(5);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCerrarSesion.selected = false;
            this.btnCerrarSesion.Size = new System.Drawing.Size(252, 57);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "       CERRAR SESIÓN";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnCerrarSesion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.Active = false;
            this.btnMovimientos.Activecolor = System.Drawing.Color.Transparent;
            this.btnMovimientos.BackColor = System.Drawing.Color.Transparent;
            this.btnMovimientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMovimientos.BorderRadius = 0;
            this.btnMovimientos.ButtonText = "       MOVIMIENTOS";
            this.btnMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovimientos.DisabledColor = System.Drawing.Color.Gray;
            this.btnMovimientos.ForeColor = System.Drawing.Color.Gray;
            this.btnMovimientos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMovimientos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMovimientos.Iconimage")));
            this.btnMovimientos.Iconimage_right = null;
            this.btnMovimientos.Iconimage_right_Selected = null;
            this.btnMovimientos.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnMovimientos.Iconimage_Selected")));
            this.btnMovimientos.IconMarginLeft = 0;
            this.btnMovimientos.IconMarginRight = 0;
            this.btnMovimientos.IconRightVisible = true;
            this.btnMovimientos.IconRightZoom = 0D;
            this.btnMovimientos.IconVisible = true;
            this.btnMovimientos.IconZoom = 60D;
            this.btnMovimientos.IsTab = true;
            this.btnMovimientos.Location = new System.Drawing.Point(21, 585);
            this.btnMovimientos.Margin = new System.Windows.Forms.Padding(5);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMovimientos.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnMovimientos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMovimientos.selected = false;
            this.btnMovimientos.Size = new System.Drawing.Size(252, 57);
            this.btnMovimientos.TabIndex = 8;
            this.btnMovimientos.Text = "       MOVIMIENTOS";
            this.btnMovimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimientos.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnMovimientos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimientos.Click += new System.EventHandler(this.btnMovimientos_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Active = false;
            this.btnProductos.Activecolor = System.Drawing.Color.Transparent;
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductos.BorderRadius = 0;
            this.btnProductos.ButtonText = "       PRODUCTOS";
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.DisabledColor = System.Drawing.Color.Gray;
            this.btnProductos.ForeColor = System.Drawing.Color.Gray;
            this.btnProductos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProductos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProductos.Iconimage")));
            this.btnProductos.Iconimage_right = null;
            this.btnProductos.Iconimage_right_Selected = null;
            this.btnProductos.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnProductos.Iconimage_Selected")));
            this.btnProductos.IconMarginLeft = 0;
            this.btnProductos.IconMarginRight = 0;
            this.btnProductos.IconRightVisible = true;
            this.btnProductos.IconRightZoom = 0D;
            this.btnProductos.IconVisible = true;
            this.btnProductos.IconZoom = 60D;
            this.btnProductos.IsTab = true;
            this.btnProductos.Location = new System.Drawing.Point(16, 508);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(5);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProductos.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnProductos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProductos.selected = false;
            this.btnProductos.Size = new System.Drawing.Size(252, 57);
            this.btnProductos.TabIndex = 7;
            this.btnProductos.Text = "       PRODUCTOS";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnProductos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnEmpresas
            // 
            this.btnEmpresas.Active = false;
            this.btnEmpresas.Activecolor = System.Drawing.Color.Transparent;
            this.btnEmpresas.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpresas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpresas.BorderRadius = 0;
            this.btnEmpresas.ButtonText = "       EMPRESAS";
            this.btnEmpresas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresas.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmpresas.ForeColor = System.Drawing.Color.Gray;
            this.btnEmpresas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmpresas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmpresas.Iconimage")));
            this.btnEmpresas.Iconimage_right = null;
            this.btnEmpresas.Iconimage_right_Selected = null;
            this.btnEmpresas.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnEmpresas.Iconimage_Selected")));
            this.btnEmpresas.IconMarginLeft = 0;
            this.btnEmpresas.IconMarginRight = 0;
            this.btnEmpresas.IconRightVisible = true;
            this.btnEmpresas.IconRightZoom = 0D;
            this.btnEmpresas.IconVisible = true;
            this.btnEmpresas.IconZoom = 60D;
            this.btnEmpresas.IsTab = true;
            this.btnEmpresas.Location = new System.Drawing.Point(21, 431);
            this.btnEmpresas.Margin = new System.Windows.Forms.Padding(5);
            this.btnEmpresas.Name = "btnEmpresas";
            this.btnEmpresas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEmpresas.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEmpresas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmpresas.selected = false;
            this.btnEmpresas.Size = new System.Drawing.Size(252, 57);
            this.btnEmpresas.TabIndex = 6;
            this.btnEmpresas.Text = "       EMPRESAS";
            this.btnEmpresas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresas.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnEmpresas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresas.Click += new System.EventHandler(this.btnEmpresas_Click);
            // 
            // btnAlmacenes
            // 
            this.btnAlmacenes.Active = false;
            this.btnAlmacenes.Activecolor = System.Drawing.Color.Transparent;
            this.btnAlmacenes.BackColor = System.Drawing.Color.Transparent;
            this.btnAlmacenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlmacenes.BorderRadius = 0;
            this.btnAlmacenes.ButtonText = "       ALMACENES";
            this.btnAlmacenes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlmacenes.DisabledColor = System.Drawing.Color.Gray;
            this.btnAlmacenes.ForeColor = System.Drawing.Color.Gray;
            this.btnAlmacenes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAlmacenes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAlmacenes.Iconimage")));
            this.btnAlmacenes.Iconimage_right = null;
            this.btnAlmacenes.Iconimage_right_Selected = null;
            this.btnAlmacenes.Iconimage_Selected = global::CapaPresentacion.Properties.Resources.iconboxgreen;
            this.btnAlmacenes.IconMarginLeft = 0;
            this.btnAlmacenes.IconMarginRight = 0;
            this.btnAlmacenes.IconRightVisible = true;
            this.btnAlmacenes.IconRightZoom = 0D;
            this.btnAlmacenes.IconVisible = true;
            this.btnAlmacenes.IconZoom = 60D;
            this.btnAlmacenes.IsTab = true;
            this.btnAlmacenes.Location = new System.Drawing.Point(21, 364);
            this.btnAlmacenes.Margin = new System.Windows.Forms.Padding(5);
            this.btnAlmacenes.Name = "btnAlmacenes";
            this.btnAlmacenes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAlmacenes.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAlmacenes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAlmacenes.selected = false;
            this.btnAlmacenes.Size = new System.Drawing.Size(252, 57);
            this.btnAlmacenes.TabIndex = 5;
            this.btnAlmacenes.Text = "       ALMACENES";
            this.btnAlmacenes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlmacenes.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btnAlmacenes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlmacenes.Click += new System.EventHandler(this.btnAlmacenes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.ld_logo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(64)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1749, 871);
            this.Controls.Add(this.header);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.wrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel wrapper;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAlmacenes;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.PictureBox arrow;
        private Bunifu.Framework.UI.BunifuFlatButton btnCerrarSesion;
        private Bunifu.Framework.UI.BunifuFlatButton btnMovimientos;
        private Bunifu.Framework.UI.BunifuFlatButton btnProductos;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmpresas;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombre;
        private Bunifu.Framework.UI.BunifuFlatButton btnReportes;
    }
}