using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2
{
    public class Proveedor
    {
    }

    public class ProveedorElectronica : IProveedor
    {
        public void EnviarPedido(Pedido pedido)
        {
            Console.WriteLine("Enviando pedido de productos electronicos al proveedor A.");
        }
    }

    public class ProveedorRopa : IProveedor
    {
        public void EnviarPedido(Pedido pedido)
        {
            Console.WriteLine("Enviando pedido de productos de ropa al proveedor B.");
        }
    }
}
