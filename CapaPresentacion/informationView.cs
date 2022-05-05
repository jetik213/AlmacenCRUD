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
    public partial class informationView : Form
    {
        public informationView(string message)
        {
            InitializeComponent();
            lblMensaje.Text = message;
        }

        private void successView_Load(object sender, EventArgs e)
        {
            formFade.ShowAsyc(this);
        }

        public static void confirmForm(string message)
        {
            successView frm = new successView(message);
            frm.ShowDialog();
        }
        private void btnSuccess_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
    }
}
