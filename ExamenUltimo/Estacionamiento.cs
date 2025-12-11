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
            foreach (var vehiculo in Vehiculos)
            {
                Console.WriteLine($"ID: {vehiculo.ID}, Dueño: {vehiculo.Dueño}");

                if (vehiculo is Auto auto)
                {
                    Console.WriteLine($"Cantidad de Puetas: {auto.CantidadPuertas}, Combustible: {auto.Combustible}");
                }
                else if (vehiculo is Camioneta camioneta)
                {
                    Console.WriteLine($"Capacidad De Carga: {camioneta.CapacidadCarga}, 4x4: {camioneta.Es4x4}");
                }
                else if (vehiculo is Moto moto)
                {
                    Console.WriteLine($"Cilindrada: {moto.Cilindrada}, Tipo: {moto.Tipo}");
                }
                else if (vehiculo is Bicicleta bicicleta)
                {
                    Console.WriteLine($"Tipo: {bicicleta.Tipo}, Material del Cuadro: {bicicleta.MaterialCuadro}");
                }
                else if (vehiculo is Camion camion)
                {
                    Console.WriteLine($"Numero de Ejes: {camion.NumeroEjes}, Peso Maximo: {camion.PesoMaximo}");
                }
            }

        }
        public int Facturacion()
        {
            int total = 0;
            foreach (var v in Vehiculos)
            {
                total += v.CostoDiario();
            }
            return total;
        }
    }
}
