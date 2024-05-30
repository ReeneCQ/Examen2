using Examen2;

internal class Program
{
    private static void Main(string[] args)
    {
        //EXAMEN02
        {
            IProveedor proveedorElectronica = new ProveedorElectronica();
            IProveedor proveedorRopa = new ProveedorRopa();

            GestorPedidos gestorPedidos = new GestorPedidos();

            Pedido pedidoElectronica = new Pedido("Electronicos");
            Pedido pedidoRopa = new Pedido("Ropa");

            gestorPedidos.EnviarPedidoSegunTipoProducto(pedidoElectronica, proveedorElectronica);
            gestorPedidos.EnviarPedidoSegunTipoProducto(pedidoRopa, proveedorRopa);
        }
    }
}
