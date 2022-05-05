using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaEntidades.Cache;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            LoadUserData();
            mostrarFormulario(new frmAlmacen());                

        }
        /*Código para poder arrastar frm*/
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            fullScreen(); 
        }
        public void LoadUserData()
        {
            lblNombre.Text = CacheInicioSesion.Nombre.ToUpper();
            lblCargo.Text = CacheInicioSesion.Cargo.ToUpper();
        }
        public void fullScreen()
        {
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            informationView frm = new informationView("¿ESTAS SEGURO DE QUE DESEAS SALIR?");
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public void seleccionarBotones(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            btnAlmacenes.Textcolor = Color.WhiteSmoke;
            btnEmpresas.Textcolor = Color.WhiteSmoke;
            btnProductos.Textcolor = Color.WhiteSmoke;
            btnMovimientos.Textcolor = Color.WhiteSmoke;
            btnCerrarSesion.Textcolor = Color.WhiteSmoke;

            sender.selected = true;

            if (sender.selected)
            {
                sender.Textcolor = Color.FromArgb(98, 195, 148);
            }
        }

        public void arrowGuide(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            arrow.Top = sender.Top;
        }

        private void btnAlmacenes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "ALMACENES";
            seleccionarBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            arrowGuide((Bunifu.Framework.UI.BunifuFlatButton)sender);
            mostrarFormulario(new frmAlmacen());
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            if (CacheInicioSesion.Cargo != "usuario")
            {
                lblTitulo.Text = "EMPRESAS";
                seleccionarBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
                arrowGuide((Bunifu.Framework.UI.BunifuFlatButton)sender);
                mostrarFormulario(new frmEmpresa());
            }
            else
                MessageBox.Show("No tienes los suficientes privilegios para poder ver esta sección");
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (CacheInicioSesion.Cargo != "usuario")
            {
                lblTitulo.Text = "PRODUCTOS";
                seleccionarBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
                arrowGuide((Bunifu.Framework.UI.BunifuFlatButton)sender);
                mostrarFormulario(new frmProducto());
            }
            else
                MessageBox.Show("No tienes los suficientes privilegios para poder ver esta sección");
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "MOVIMIENTOS";
            seleccionarBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
            arrowGuide((Bunifu.Framework.UI.BunifuFlatButton)sender);
            mostrarFormulario(new frmMovimiento());
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (CacheInicioSesion.Cargo != "usuario")
            {
                lblTitulo.Text = "REPORTES";
                seleccionarBotones((Bunifu.Framework.UI.BunifuFlatButton)sender);
                arrowGuide((Bunifu.Framework.UI.BunifuFlatButton)sender);
                mostrarFormulario(new frmReporte());
            }
            else
                MessageBox.Show("No tienes los suficientes privilegios para poder ver esta sección");
            
        }
        private Form FormActive = null;

        private void mostrarFormulario(Form FormHijo)
        {
            if (FormActive != null)
                FormActive.Close();
            FormActive = FormHijo;

            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            wrapper.Controls.Add(FormHijo);
            wrapper.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            informationView frm = new informationView("¿ESTAS SEGURO DE CERRAR SESIÓN?");
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                //this.Close();
                this.Hide();
                frmLogin log = new frmLogin();
                log.Show();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


    }
}
