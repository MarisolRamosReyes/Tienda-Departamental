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
    public partial class PagosVencidos : Form
    {
        public PagosVencidos()
        {
            InitializeComponent();   
        }
        private void PagosVencidos_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            List<VencidosPagos> PagosVencidos = new List<VencidosPagos>
            {
                new VencidosPagos { Nombre = "Televisor 4K", Categoria = "Electrónica", Precio = 799.99m,Marca = "Samsung", Vencimiento = fechaActual.AddDays(-5) },
                new VencidosPagos { Nombre = "Refrigerador No Frost", Categoria = "Electrodomésticos", Precio = 599.99m, Marca = "Whirlpool", Vencimiento = fechaActual.AddDays(-15) },
                new VencidosPagos { Nombre = "Juego de Sábanas", Categoria = "Hogar", Precio = 49.99m, Marca = "Conforama", Vencimiento = fechaActual.AddDays(-3) },
            };
            dataGridView1.DataSource = PagosVencidos;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
