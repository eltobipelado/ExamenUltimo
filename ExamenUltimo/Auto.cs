using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUltimo
{
    public class Auto: Vehiculo
    {
        public int CantidadPuertas {  get; set; }
        public string Combustible { get; set; }
        public override int CostoDiario()
        {
            return 1000;
        }
    }
}
