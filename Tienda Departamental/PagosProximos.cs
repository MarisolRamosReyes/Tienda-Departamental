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

namespace Tienda_Departamental
{
    public partial class PagosProximos : Form
    {
        public PagosProximos()
        {
            InitializeComponent();
        }

        private void PagosProximos_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            List<ProximosPagos> PagosVencidos = new List<ProximosPagos>
            {
                new ProximosPagos { Nombre = "Sofá Cama", Categoria = "Muebles", Precio = 399.99m,  Marca = "IKEA",Proximo = fechaActual.AddDays(10) },
               
                new ProximosPagos { Nombre = "Camiseta de Algodón", Categoria = "Ropa", Precio = 19.99m, Marca = "Nike", Proximo = fechaActual.AddDays(5) },
                
                new ProximosPagos { Nombre = "Zapatos Deportivos", Categoria = "Calzado", Precio = 69.99m, Marca = "Adidas", Proximo = fechaActual.AddDays(2) },
                new ProximosPagos { Nombre = "Batería Externa", Categoria = "Accesorios", Precio = 29.99m, Marca = "Anker", Proximo = fechaActual.AddDays(30) }


               
            };
            dataGridView1.DataSource = PagosVencidos;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
