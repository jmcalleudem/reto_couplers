using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_couplers
{
    // Inappropriate Intimacy: La clase Cliente expone demasiados detalles de su estructura interna
    public class Cliente
    {
        public string Nombre { get; set; }
        public Direccion Direccion { get; set; }

        public Cliente(string nombre, Direccion direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }
    }
}
