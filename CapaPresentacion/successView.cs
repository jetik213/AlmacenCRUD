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
    public partial class successView : Form
    {
        public successView(string mensaje)
        {
            InitializeComponent();
            lblMessage.Text = mensaje;
        }
        private void successView_Load(object sender, EventArgs e)
        {
            formFade.ShowAsyc(this);
        }
        public static void confirmForm(string mensaje)
        {
            successView frm = new successView(mensaje);
            frm.ShowDialog();
        }
        private void closeSuccess_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
