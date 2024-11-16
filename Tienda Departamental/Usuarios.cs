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
using Tienda_Departamental.Clases;
using System.IO;

namespace Tienda_Departamental
{
    public partial class Usuarios : Form
    {
        private List<Users> Usuario; // Declaramos el campo privado aquí

        public Usuarios() // Constructor sin parámetros
        {
            InitializeComponent();

            // Cargamos la lista de usuarios desde el archivo
            Usuario = CargarUsuariosDesdeArchivo();

            // Configuramos el DataGridView para mostrar los usuarios
            DataGridView dataGridView1 = new DataGridView
            {
                DataSource = Usuario,
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            Controls.Add(dataGridView1);
        }

        private List<Users> CargarUsuariosDesdeArchivo()
        {
            List<Users> usuarios = new List<Users>();
            string rutaArchivo = @"C:\Users\abdie\Documents\Tarea de mi Amor\Noveno semestre\Tienda Departamental\Tienda Departamental\Registros\usuarios.txt";

            try
            {
                if (File.Exists(rutaArchivo))
                {
                    // Leer todas las líneas del archivo, omitiendo la primera (encabezado)
                    string[] lineas = File.ReadAllLines(rutaArchivo).Skip(1).ToArray();
                    foreach (var line in lineas)
                    {
                        Users usuario = DeserializarUsuario(line);
                        if (usuario != null) // Asegúrate de que el usuario no sea nulo
                        {
                            usuarios.Add(usuario);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El archivo de usuarios no se encuentra en la ruta especificada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }

            return usuarios;
        }


        private Users DeserializarUsuario(string line)
        {
            var datos = line.Split(',');
            return new Users
            {
                Nombre = datos[0],
                Usuario = datos[1],
                Correo = datos[2],
                Contraseña = datos[3]
            };
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InicioSesion form1 = new InicioSesion();
            form1.Show();
            this.Close();
        }

        private void btnclosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
