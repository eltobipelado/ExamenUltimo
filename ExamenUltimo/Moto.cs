using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUltimo
{
    public class Moto: Vehiculo
    {
        public int Cilindrada { get; set; }
        public string Tipo { get; set; }
        public override int CostoDiario()
        {
            return 600;
        }
    }
}
