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
    public partial class CreditoAprobado : Form
    {
        public CreditoAprobado(int numero)
        {
            InitializeComponent();
            
            int resultado = numero + 3000;
            CreditoA.Text = resultado.ToString();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            int nuevoCredito = Convert.ToInt32(CreditoA.Text); 

            
            MenuPrincipal menuForm = Application.OpenForms.OfType<MenuPrincipal>().FirstOrDefault();

            if (menuForm != null)
            {
                menuForm.ActualizarCredito(nuevoCredito);
            }
            //if (solicitarCreditoForm != null)
            //{
            //    solicitarCreditoForm.Close(); 
            //}
            this.Close();
        }
    }
}
