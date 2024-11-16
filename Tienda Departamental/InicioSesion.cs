using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;
using Tienda_Departamental.Clases;
using System.IO;


namespace Tienda_Departamental
{
    public partial class InicioSesion : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private List<Users> Usuarios = new List<Users>();
        
        public InicioSesion()
        {
            InitializeComponent();
            CargarUsuariosDesdeArchivo();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Red400,
                Primary.Red400,
                Primary.Grey500,
                Accent.Red200,
                TextShade.WHITE
            );
        }
        public void CargarUsuariosDesdeArchivo()
        {
            string rutaArchivo = @"C:\Users\abdie\Documents\Tarea de mi Amor\Noveno semestre\Tienda Departamental\Tienda Departamental\Registros\usuarios.txt";

            if (File.Exists(rutaArchivo))
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);
                foreach (string linea in lineas.Skip(1))
                {
                    string[] datos = linea.Split(',');
                    if (datos.Length == 4)
                    {
                        Users usuario = new Users
                        {
                            Nombre = datos[0],
                            Usuario = datos[1],
                            Correo = datos[2],
                            Contraseña = datos[3]
                        };
                        Usuarios.Add(usuario);
                    }
                }
            }
        }
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            ValidarCredenciales();
        }
         private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SalirForm confirmExit = new SalirForm("¿Estás seguro de que deseas salir?");
            confirmExit.ShowDialog();

            if (confirmExit.IsConfirmed)
            {
                Environment.Exit(0);
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUser registrouser = new RegistroUser(Usuarios);
            registrouser.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contrsenatext_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserText_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialDivider1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Hide();
        }

        private void contrsenatext_Enter(object sender, EventArgs e)
        {

        }

        private void contrsenatext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarCredenciales();
                e.SuppressKeyPress = true;
            }
        }

        private void UserText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarCredenciales();
                e.SuppressKeyPress = true;
            }
        }
        private void ValidarCredenciales()
        {
            string usuarioIngresado = UserText.Text;
            string contrasenaIngresada = contrsenatext.Text;

            bool usuarioValido = Usuarios.Any(u => u.Usuario == usuarioIngresado && u.Contraseña == contrasenaIngresada);

            if (usuarioValido)
            {
                Loading loading = new Loading(Usuarios);
                loading.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Intente nuevamente.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
