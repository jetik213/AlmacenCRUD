using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using System.Runtime.InteropServices;//importamos libreria para poder arrastrar el frm
using CapaEntidades.Cache;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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
        public void fullScreen()
        {
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void salir_Click(object sender, EventArgs e)
        {
            informationView frm = new informationView("¿ESTAS SEGURO DE QUE DESEAS SALIR?");
            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Usuario")
            {
                if(txtPass.Text != "Contraseña")
                {
                    N_Login n_Login = new N_Login();
                    E_Login e_Login = new E_Login();
                    e_Login.LoginUsuario = txtUsuario.Text;
                    e_Login.ClaveUsuario = txtPass.Text;
                    var validLogin = n_Login.LoginUser(e_Login);
                    if (validLogin == true)
                    {
                        frmPrincipal mainMenu = new frmPrincipal();
                        successView.confirmForm("¡BIENVENIDO " + CacheInicioSesion.Nombre.ToUpper() + "!");
                        mainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        msjError("Usuario o Contraseña incorrecta");
                        txtPass.Clear();
                        txtUsuario.Focus();
                    }
                } else msjError("Ingresa tu contraseña");
            }
            else msjError("Ingresa el nombre de usuario");
        }
        private void msjError(String msj)
        {
            lblMensajeError.Text = msj;
            lblMensajeError.Visible = true;
            errorImage.Visible = true;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Evento para arrastrar el mouse en las zonas
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void imageVirtualLogistic_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /*
        //Método para cerrar sesión del frmPrincipal
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Clear();
            txtPass.Clear();
            lblMensajeError.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }*/
    }
}
