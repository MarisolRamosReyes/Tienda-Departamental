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
using System.IO;
using Tienda_Departamental.Clases;

namespace Tienda_Departamental
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            customizeDesing();

        }
        private void customizeDesing()
        {
            panel1.Visible = false;
            panel2.Visible = false;

            //..
        }
        private void hideSubMenu()
        {
            if (panel1.Visible ==true)
            {
                panel1.Visible = false;
            }
            if (panel2.Visible ==true) 
            {
                panel2.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu) 
        {
            if (subMenu.Visible ==false) 
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);  
        }

        private void btnSolicitarCredito_Click(object sender, EventArgs e)
        {
            openChildFrom(new SolicitarCredito(numero));
            hideSubMenu();
        }

        private void btnAumentoCredito_Click(object sender, EventArgs e)
        {
            openChildFrom(new AumentoCredito(numero));
            hideSubMenu();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }

        private void btnPagosVencidos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildFrom(new PagosVencidos());

        }

        private void btnPagosProximos_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            openChildFrom(new PagosProximos());
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void MenuPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            openChildFrom(new Compras());
            hideSubMenu();
        }
        private Form activeFrom =null;
        private void openChildFrom(Form childFrom)
        {
            if (activeFrom != null)
            {
                activeFrom.Close();
            }
            activeFrom = childFrom;

            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;

            if (panelChildFrom != null)
            {
                panelChildFrom.Controls.Add(childFrom);
                panelChildFrom.Tag = childFrom;
                childFrom.BringToFront();
                childFrom.Show();
            }
            else
            {
                MessageBox.Show("El panel panelChildFrom no está inicializado.");
            }
        }

        private void panelChildFrom_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panelChildFrom_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openChildFrom(new Usuarios());
            
        }
        int numero = 0;
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            CreditoInicial.Text = numero.ToString();
            if (numero <= 3000)
            {
                btnAumentoCredito.Visible = false;
                btnSolicitarCredito.Visible = true;
            }
        }

        public void ActualizarCredito(int nuevoCredito)
        {
            numero = nuevoCredito;
            CreditoInicial.Text = numero.ToString();

            if (numero >= 3000)
            {
                btnAumentoCredito.Visible = true;
                btnSolicitarCredito.Visible = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SalirForm confirmExit = new SalirForm("¿Estás seguro de que deseas salir?");
            confirmExit.ShowDialog();

            if (confirmExit.IsConfirmed)
            {
                InicioSesion login = new InicioSesion();
                login.Show();
                this.Close();
            }
        }

        private void panelChildFrom_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            openChildFrom(new Productos());
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
