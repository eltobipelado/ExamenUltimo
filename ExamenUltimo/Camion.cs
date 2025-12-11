using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUltimo
{
    public class Camion: Vehiculo
    {
        public int NumeroEjes { get; set; }
        public int PesoMaximo { get; set; }
        public override int CostoDiario()
        {
            return 2500;
        }
    }
}
