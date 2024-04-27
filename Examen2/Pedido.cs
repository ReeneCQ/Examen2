using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    public class Pedido
    {
        public string TipoProducto { get; set; }

        public Pedido(string tipoProducto)
        {
            TipoProducto = tipoProducto;
        }
    }
}
