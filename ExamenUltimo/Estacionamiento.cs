using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenUltimo
{
    public class Estacionamiento 
    {
        public List<Vehiculo> Vehiculos { get; set; } = new();
        public void AgregarVehiculo (Vehiculo vehiculo)
        {
            Vehiculos.Add(vehiculo);
        }
        public void ListarVehiculos()
        {
            foreach (var vehiculos in Vehiculos)
            {
                Console.WriteLine($"ID: {vehiculos.ID}, Dueño:");
            }
        }
    }
}
