using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUltimo
{
    public class Camioneta: Vehiculo
    {
        public int CapacidadCarga { get; set; }
        public bool Es4x4 { get; set; }
        public override int CostoDiario()
        {
            return 1500;
        }
    }
}
