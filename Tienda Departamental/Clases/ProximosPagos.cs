﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Departamental.Clases
{
    internal class ProximosPagos
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public string Marca { get; set; }
        public DateTime Proximo { get; set; }
    }
}