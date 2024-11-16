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
    public partial class MostrarProductos : UserControl
    {
        private int id = 0;
        private string descripcion = "Descripción del producto";
        public MostrarProductos()
        {
            InitializeComponent();
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public Image ImgProducto
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
        public string NombreProducto
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public int Precio
        {
            get { return int.Parse(label2.Text); }
            set { label2.Text = value.ToString(); }
        }
       
    }
}
