using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto_couplers
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }

        public Direccion(string calle, string ciudad)
        {
            Calle = calle;
            Ciudad = ciudad;
        }
    }
}
