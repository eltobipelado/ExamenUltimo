using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUltimo
{
    public class Bicicleta: Vehiculo
    {
        public string Tipo { get; set; }
        public string MaterialCuadro { get; set; }
        public override int CostoDiario()
        {
            return 200;
        }
    }
}
