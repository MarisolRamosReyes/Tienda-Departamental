using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Departamental
{
    public partial class SolicitarCredito : Form
    {
        int numero;
        public SolicitarCredito(int numero)
        {
            InitializeComponent();
            Nombre.TextChanged += CamposLlenos;
            ApellidoPaterno.TextChanged += CamposLlenos;
            ApellidoMaterno.TextChanged += CamposLlenos;
            Telefono.TextChanged += CamposLlenos;
            Dirección.TextChanged += CamposLlenos;
            Correo.TextChanged += CamposLlenos;
            SalarioMinimoNeto.TextChanged += CamposLlenos;
            rutaPDFSeleccionado = string.Empty;
            rutaImagenSeleccionada = string.Empty;
            this.numero = numero;
            CreditoInicial.Text = numero.ToString();
        }
        private void CamposLlenos(object sender, EventArgs e)
        {
            // Comprueba si todos los campos y variables están llenos
            bool todosLlenos = !string.IsNullOrWhiteSpace(Nombre.Text) &&
                               !string.IsNullOrWhiteSpace(ApellidoPaterno.Text) &&
                               !string.IsNullOrWhiteSpace(ApellidoMaterno.Text) &&
                               !string.IsNullOrWhiteSpace(Telefono.Text) &&
                               !string.IsNullOrWhiteSpace(Dirección.Text) &&
                               !string.IsNullOrWhiteSpace(Correo.Text) &&
                               !string.IsNullOrWhiteSpace(SalarioMinimoNeto.Text) &&
                               !string.IsNullOrWhiteSpace(rutaPDFSeleccionado) &&
                               !string.IsNullOrWhiteSpace(rutaImagenSeleccionada)
                               ;

            // Activa o desactiva el botón según el resultado
            guardarcredito.Enabled = todosLlenos;
           
        }
        private void SolicitarCredito_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string rutaImagenSeleccionada;
        private void materialButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\abdie\Documents\Tarea de mi Amor\Noveno semestre\Tienda Departamental\Tienda Departamental\Imagenes",
                Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Seleccione una imagen"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaImagenSeleccionada = openFileDialog.FileName;
                CamposLlenos(null, null);
                pictureBox1.Image = Image.FromFile(rutaImagenSeleccionada);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private string rutaPDFSeleccionado;
        private void materialButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\abdie\Documents\Tarea de mi Amor\Noveno semestre\Tienda Departamental\Tienda Departamental\Documentos",
                Filter = "Archivos PDF|*.pdf",
                Title = "Seleccione un archivo PDF"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Guardar la ruta completa del PDF en la variable
                rutaPDFSeleccionado = openFileDialog.FileName;
                CamposLlenos(null, null);
                // Obtener solo el nombre del archivo y mostrarlo en el Label
                NombrePDF.Text = System.IO.Path.GetFileName(rutaPDFSeleccionado);
            }
        }

        private void ApellidoMaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            CreditoAprobado creditoAprobado = new CreditoAprobado(numero);
            creditoAprobado.Show(); 
        }
    }
}
