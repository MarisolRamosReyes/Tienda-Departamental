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
    public partial class AumentoCredito : Form
    {
        int numero;
        public AumentoCredito(int numero)
        {
            InitializeComponent();
            SalarioMinimoNeto.TextChanged += CamposLlenos;
            this.numero = numero;
            CreditoInicial.Text = numero.ToString();
        }

        private void AumentoCredito_Load(object sender, EventArgs e)
        {

        }
        private void CamposLlenos(object sender, EventArgs e)
        {
            // Comprueba si todos los campos y variables están llenos
            bool todosLlenos = !string.IsNullOrWhiteSpace(SalarioMinimoNeto.Text) &&
                               !string.IsNullOrWhiteSpace(rutaPDFSeleccionado) &&
                               !string.IsNullOrWhiteSpace(rutaImagenSeleccionada)
                               ;

            // Activa o desactiva el botón según el resultado
            guardarcredito.Enabled = todosLlenos;

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
                
                rutaPDFSeleccionado = openFileDialog.FileName;
                CamposLlenos(null, null);
                NombrePDF.Text = System.IO.Path.GetFileName(rutaPDFSeleccionado);
            }
        }

        private void guardarcredito_Click(object sender, EventArgs e)
        {
            CreditoAprobado creditoAprobado = new CreditoAprobado(numero);
            creditoAprobado.Show();
        }
    }
}
