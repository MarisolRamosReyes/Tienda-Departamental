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
using Microsoft.VisualBasic.ApplicationServices;
using Tienda_Departamental.Clases;
using MaterialSkin.Controls;
using MaterialSkin;
using System.IO;

namespace Tienda_Departamental
{
    public partial class RegistroUser : Form
    {
        private List<Users> Usuarios;
        public RegistroUser(List<Users> usuarios)
        {
            InitializeComponent();
            Usuarios = usuarios;
            linkLabel1.MouseEnter += linkLabel1_MouseEnter;
            linkLabel1.MouseLeave += linkLabel1_MouseLeave;
        }
        private void submitButton_Click(object sender, EventArgs e)
        {

        }
        private void GuardarUsuarioEnArchivo(Users usuario)
        {
            string rutaArchivo = @"C:\Users\abdie\Documents\Tarea de mi Amor\Noveno semestre\Tienda Departamental\Tienda Departamental\Registros\usuarios.txt";

            if (!File.Exists(rutaArchivo))
            {
                using (StreamWriter sw = File.CreateText(rutaArchivo))
                {
                    sw.WriteLine("Nombre,Usuario,Correo,Contraseña");
                }
            }
            using (StreamWriter sw = File.AppendText(rutaArchivo))
            {
                sw.WriteLine($"{usuario.Nombre},{usuario.Usuario},{usuario.Correo},{usuario.Contraseña}");
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            InicioSesion login = new InicioSesion();
            login.Show();
            this.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RegistroUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            CargarUsuariosDesdeArchivo();

            Users nuevoUsuario = new Users
            {
                Nombre = NombreText.Text,
                Usuario = UsuarioText.Text,
                Correo = CorreoText.Text,
                Contraseña = contrasenatext.Text
            };

            bool usuarioExiste = Usuarios.Any(u => u.Usuario == nuevoUsuario.Usuario);

            if (usuarioExiste)
            {
                MessageBox.Show("Este usuario ya está registrado. Intente con otro nombre de usuario.");
            }
            else
            {
                MessageBox.Show("Usuario registrado exitosamente!");
                GuardarUsuarioEnArchivo(nuevoUsuario);

                NombreText.Clear();
                UsuarioText.Clear();
                CorreoText.Clear();
                contrasenatext.Clear();

                Loading loading = new Loading(Usuarios);
                loading.Show();
                this.Hide();
            }
        }
        private void CargarUsuariosDesdeArchivo()
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicioSesion form1 = new InicioSesion();
            form1.Show();
            this.Close();
        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            linkLabel1.ForeColor = Color.FromArgb(239, 83, 80);

        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.ForeColor = Color.FromArgb(64, 64, 64);
        }
    }
}
