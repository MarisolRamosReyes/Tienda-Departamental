using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Departamental
{
    public partial class SalirForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public bool IsConfirmed { get; private set; }
        public SalirForm(string mensaje)
        {
            InitializeComponent();
            labelmensaje.Text = mensaje;
        }

        private void btnsi_Click(object sender, EventArgs e)
        {
            IsConfirmed = true;
            this.Close();
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            IsConfirmed = false;
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
