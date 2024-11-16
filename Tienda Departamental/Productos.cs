using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tienda_Departamental.Clases;

namespace Tienda_Departamental
{
    public partial class Productos : Form
    {
        public List<ProductoComprado> carritoCompras = new List<ProductoComprado>();
        public Productos()
        {
            InitializeComponent();
            CargarProductosFalsos();
            carritoCompras = new List<ProductoComprado>();

            // Cargar productos y suscribir al evento
            CargarProductosFalsos();

        }

        public void CargarProductosFalsos()
        {
            var productos = new List<UserControl1>
                {
                   new UserControl1
                    {
                        Id = 1,
                        NombreProducto = "Televisión",
                        Descripcion = "Televisión LED de 50 pulgadas, resolución 4K.",
                        Precio = 15000,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\tele.jpg")
                    },
                    new UserControl1
                    {
                        Id = 2,
                        NombreProducto = "Sofá",
                        Descripcion = "Sofá de 3 plazas, cómodo y moderno.",
                        Precio = 8000,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\sofa.jpg")
                    },
                    new UserControl1
                    {
                        Id = 3,
                        NombreProducto = "Cama",
                        Descripcion = "Cama matrimonial con colchón ortopédico.",
                        Precio = 12000,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\cama.png")
                    },
                    new UserControl1
                    {
                        Id = 4,
                        NombreProducto = "Estufa",
                        Descripcion = "Estufa de 6 quemadores con horno eléctrico.",
                        Precio = 10000,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\estufa.png")
                    },
                    new UserControl1
                    {
                        Id = 5,
                        NombreProducto = "Laptop",
                        Descripcion = "Laptop con procesador Intel i7, 16GB RAM, 512GB SSD.",
                        Precio = 22000,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\lap.jpg")
                    },
                    new UserControl1
                    {
                        Id = 6,
                        NombreProducto = "Refrigerador",
                        Descripcion = "Refrigerador de 20 pies cúbicos, doble puerta.",
                        Precio = 18000,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\refri.png")
                    },
                    new UserControl1
                    {
                        Id = 7,
                        NombreProducto = "Batidora",
                        Descripcion = "Batidora de mano con múltiples velocidades y accesorios.",
                        Precio = 900,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\batidora.jpg")
                    },
                    new UserControl1
                    {
                        Id = 8,
                        NombreProducto = "Plancha para Cabello",
                        Descripcion = "Plancha de cabello con placas de cerámica y temperatura ajustable.",
                        Precio = 1200,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\planchacabello.jpg")
                    },
                    new UserControl1
                    {
                        Id = 9,
                        NombreProducto = "Cafetera",
                        Descripcion = "Cafetera de cápsulas compatible con múltiples sabores.",
                        Precio = 2500,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\cafetera.jpg")
                    },
                    new UserControl1
                    {
                        Id = 10,
                        NombreProducto = "Aspiradora",
                        Descripcion = "Aspiradora portátil sin bolsa, ideal para alfombras y pisos.",
                        Precio = 1800,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\aspiradora.jpg")
                    },
                    new UserControl1
                    {
                        Id = 11,
                        NombreProducto = "Microondas",
                        Descripcion = "Microondas de 20L con función de descongelado.",
                        Precio = 1200,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\micro.jpg")
                    },
                    new UserControl1
                    {
                        Id = 12,
                        NombreProducto = "Plancha",
                        Descripcion = "Plancha a vapor con control de temperatura ajustable.",
                        Precio = 650,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\plancha.jpg")
                    },
                    new UserControl1
                    {
                        Id = 13,
                        NombreProducto = "Horno Tostador",
                        Descripcion = "Horno eléctrico con capacidad para 4 rebanadas.",
                        Precio = 1300,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\hronotostador.jpg")
                    },
                    new UserControl1
                    {
                        Id = 14,
                        NombreProducto = "Juego de Ollas",
                        Descripcion = "Juego de 10 piezas de acero inoxidable.",
                        Precio = 3200,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\ollas.jpg")
                    },
                    new UserControl1
                    {
                        Id = 15,
                        NombreProducto = "Ventilador de Piso",
                        Descripcion = "Ventilador de piso oscilante de tres velocidades.",
                        Precio = 850,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\ventilador.jpg")
                    },
                    new UserControl1
                    {
                        Id = 16,
                        NombreProducto = "Freidora de Aire",
                        Descripcion = "Freidora sin aceite con capacidad de 3.5L.",
                        Precio = 2300,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\freidora.jpg")
                    },
                    new UserControl1
                    {
                        Id = 17,
                        NombreProducto = "Parrilla Eléctrica",
                        Descripcion = "Parrilla con termostato ajustable.",
                        Precio = 1500,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\parrilla.jpg")
                    },
                    new UserControl1
                    {
                        Id = 18,
                        NombreProducto = "Silla Ergonómica",
                        Descripcion = "Silla de oficina ergonómica con soporte lumbar.",
                        Precio = 2800,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\sillaergo.jpg")
                    },
                     new UserControl1
                    {
                        Id = 14,
                        NombreProducto = "Juego de Ollas",
                        Descripcion = "Juego de 10 piezas de acero inoxidable.",
                        Precio = 3200,
                        ImgProducto = Image.FromFile("C:\\Users\\abdie\\Documents\\Tarea de mi Amor\\Noveno semestre\\Tienda Departamental\\Tienda Departamental\\ProductosImage\\ollas.jpg")
                    },
        };

            
            foreach (var producto in productos)
            {
                MostrarProdcutosPanel.Controls.Add(producto);
                //productoControl.AgregarAlCarrito += ProductoControl_AgregarAlCarrito;  // Suscribirse al evento
                //MostrarProdcutosPanel.Controls.Add(productoControl);  // Agregar al panel de productos
            }
        }
        public void ProductoControl_AgregarAlCarrito(object sender, ProductoComprado producto)
        {
            // Agregar el producto a la lista del carrito
            carritoCompras.Add(producto);

            // (Opcional) Mostrar mensaje de confirmación al usuario
            MessageBox.Show($"{producto.Nombre} agregado al carrito.");
        }
    }

}
