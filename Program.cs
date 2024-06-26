using reto_couplers;

class Program
{
    static void Main()
    {
        Cliente cliente = new Cliente("Juan Pérez", new Direccion("123 Calle Principal", "Ciudad"));
        Pedido pedido = new Pedido { Cliente = cliente };
        pedido.AgregarProducto(new Producto("Laptop", 1000));
        pedido.AgregarProducto(new Producto("Mouse", 20));
        pedido.GenerarFactura();
    }
}