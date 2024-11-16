using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Departamental.Clases
{
    public class ProductoComprado
    {
        public int Id { get; set; }            
        public string Nombre { get; set; }      
        public int Cantidad { get; set; }       
        public decimal Precio { get; set; }     
        public decimal Total => Cantidad * Precio;  
    }
}
