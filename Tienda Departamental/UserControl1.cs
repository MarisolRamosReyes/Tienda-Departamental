using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tienda_Departamental.Clases;


namespace Tienda_Departamental
{
    public partial class UserControl1 : UserControl
    {
        // Evento para enviar la información del producto al hacer clic en "Comprar"
        public event EventHandler<ProductoEventArgs> ComprarProducto;

        private int id = 0;
        private int cantidad = 1; // Inicializamos en 1 por defecto
        private string descripcion = "Descripción del producto";

        public UserControl1()
        {
            InitializeComponent();
            // Asignar eventos a los botones
            buttonIncrementar.Click += new EventHandler(ButtonIncrementar_Click);
            buttonDecrementar.Click += new EventHandler(ButtonDecrementar_Click);
            buttonComprar.Click += new EventHandler(buttonComprar_Click_1); // Evento para el botón "Comprar"
            labelCantidad.Text = cantidad.ToString(); // Mostrar cantidad inicial
        }

        // Propiedad para la cantidad de productos
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value >= 1) // Se asegura que no sea menor a 1
                {
                    cantidad = value;
                    labelCantidad.Text = cantidad.ToString();
                }
            }
        }

        // Método para incrementar la cantidad
        private void ButtonIncrementar_Click(object sender, EventArgs e)
        {
            Cantidad++;
        }

        // Método para disminuir la cantidad
        private void ButtonDecrementar_Click(object sender, EventArgs e)
        {
            if (Cantidad > 1) // Limitar para que no baje de 1
            {
                Cantidad--;
            }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                label3.Text = value;
                label3.Size = new Size(141, 41);
                label3.MaximumSize = new Size(141, 41);
                label3.TextAlign = ContentAlignment.TopLeft;
            }
        }

        public Image ImgProducto
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string NombreProducto
        {
            get { return label1.Text; }
            set
            {
                label1.Text = value;
                label1.Size = new Size(141, 41);
                label1.MaximumSize = new Size(141, 41);
                label1.TextAlign = ContentAlignment.TopLeft;
            }
        }

        public int Precio
        {
            get { return int.Parse(label2.Text, NumberStyles.Currency, CultureInfo.CurrentCulture); }
            set { label2.Text = value.ToString("C", CultureInfo.GetCultureInfo("es-MX")); }
        }

        // Método para manejar el clic en el botón "Comprar"
        //private void ButtonComprar_Click(object sender, EventArgs e)
        //{
        //    // Disparar el evento "ComprarProducto" y pasar los detalles del producto
        //    ComprarProducto?.Invoke(this, new ProductoEventArgs(Id, NombreProducto, Precio, Cantidad));
        //}

        private void buttonComprar_Click_1(object sender, EventArgs e)
        {
            ProductoComprado productoComprado = new ProductoComprado
            {
                Id = this.Id,
                Nombre = this.NombreProducto,
                Precio = this.Precio,
                Cantidad = this.Cantidad
            };

            // Agregarlo a la lista de compras del formulario principal
            Productos productosform = (Productos)this.FindForm();
            productosform.carritoCompras.Add(productoComprado);
        }
    }

    // Clase para enviar los detalles del producto en el evento
    public class ProductoEventArgs : EventArgs
    {
        public int Id { get; }
        public string NombreProducto { get; }
        public int Precio { get; }
        public int Cantidad { get; }

        public ProductoEventArgs(int id, string nombreProducto, int precio, int cantidad)
        {
            Id = id;
            NombreProducto = nombreProducto;
            Precio = precio;
            Cantidad = cantidad;
        }
    }
}
