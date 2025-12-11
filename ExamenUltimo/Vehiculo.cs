using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUltimo
{
    public class Vehiculo
    {
        public int ID { get; set; }
        public string Dueño { get; set; }
        public abstract int CostoDiario();
    }
}
