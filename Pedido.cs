using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_couplers
{
    // Feature Envy y Message Chains: La clase Pedido accede directamente a los detalles del Cliente y Producto
    public class Pedido
    {
        public Cliente Cliente { get; set; }
        public List<Producto> Productos { get; set; } = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public void GenerarFactura()
        {
            Console.WriteLine($"Factura para {Cliente.Nombre}:");
            decimal total = 0;
            foreach (var producto in Productos)
            {
                Console.WriteLine($"{producto.Nombre} - ${producto.Precio}");
                total += producto.Precio;
            }
            Console.WriteLine($"Total: ${total}");
            Console.WriteLine($"Dirección de envío: {Cliente.Direccion.Calle}, {Cliente.Direccion.Ciudad}");
        }
    }
}
