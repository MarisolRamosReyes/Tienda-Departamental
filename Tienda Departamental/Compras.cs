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
using Tienda_Departamental.Clases;

namespace Tienda_Departamental
{
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void Compras_Load(object sender, EventArgs e)
        {
            //DateTime fechaActual = DateTime.Now;
            //List<Products> products = new List<Products>
            //{
            //    new Products { Nombre = "Televisor 4K", Categoria = "Electrónica", Precio = 799.99m, Stock = 20, Marca = "Samsung", Descripcion = "Televisor 4K UHD, 55 pulgadas", Proximo = fechaActual.AddDays(-5) },
            //    new Products { Nombre = "Sofá Cama", Categoria = "Muebles", Precio = 399.99m, Stock = 15, Marca = "IKEA", Descripcion = "Sofá cama de 3 plazas, color gris", Proximo = fechaActual.AddDays(10) },
            //    new Products { Nombre = "Refrigerador No Frost", Categoria = "Electrodomésticos", Precio = 599.99m, Stock = 10, Marca = "Whirlpool", Descripcion = "Refrigerador de 22 pies cúbicos", Proximo = fechaActual.AddDays(-15) },
            //    new Products { Nombre = "Camiseta de Algodón", Categoria = "Ropa", Precio = 19.99m, Stock = 100, Marca = "Nike", Descripcion = "Camiseta de algodón, talla M", Proximo = fechaActual.AddDays(5) },
            //    new Products { Nombre = "Juego de Sábanas", Categoria = "Hogar", Precio = 49.99m, Stock = 80, Marca = "Conforama", Descripcion = "Juego de sábanas, tamaño Queen, color blanco", Proximo = fechaActual.AddDays(-3) },
            //    new Products { Nombre = "Zapatos Deportivos", Categoria = "Calzado", Precio = 69.99m, Stock = 60, Marca = "Adidas", Descripcion = "Zapatos deportivos, talla 42, color negro", Proximo = fechaActual.AddDays(2) },
            //    new Products { Nombre = "Batería Externa", Categoria = "Accesorios", Precio = 29.99m, Stock = 150, Marca = "Anker", Descripcion = "Batería externa de 10000mAh", Proximo = fechaActual.AddDays(30) }
            //};
            //dataGridView1.DataSource = products;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Compras_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            base.OnMouseDown(e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}


