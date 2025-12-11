using ExamenUltimo;
using System.Data.SqlTypes;
using System;

Estacionamiento estacionamiento = new Estacionamiento();
int opcion;
do
{
    Console.WriteLine("1. Agregar Vehiculo");
    Console.WriteLine("2. Lsitar Vehiculo");
    Console.WriteLine("3. Facturacion Diaria");
    Console.WriteLine("4. Salir");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            AgregarVehiculo(estacionamiento);
            break;
        case 2:
            estacionamiento.ListarVehiculos();
            break;
        case 3:
            Console.WriteLine($"Facturacion Diaria: {estacionamiento.Facturacion()}");
            break;
    }
} while (opcion != 4);
void AgregarVehiculo(Estacionamiento estacionamiento)
{
    Console.WriteLine("Seleccione un tipo de vechiculo: ");
    Console.WriteLine("1. Auto");
    Console.WriteLine("2. Camioneta");
    Console.WriteLine("3. Moto");
    Console.WriteLine("4. Bicicleta");
    Console.WriteLine("5. Camion");

    int tipo = int.Parse(Console.ReadLine());
    Vehiculo vehiculo = null;

    switch (tipo)
    {
        case 1:
            vehiculo = new Auto();
            break;
        case 2:
            vehiculo = new Camioneta();
            break;
        case 3:
            vehiculo = new Moto();
            break;
        case 4:
            vehiculo = new Bicicleta();
            break;
        case 5:
            vehiculo = new Camion();
            break;
    }
    Console.WriteLine("ID: ");
    vehiculo.ID = int.Parse(Console.ReadLine());

    Console.WriteLine("Dueño: ");
    vehiculo.Dueño = Console.ReadLine();

    if (vehiculo is Auto auto)
    {
        Console.WriteLine("Puertas: ");
        auto.CantidadPuertas = int.Parse(Console.ReadLine());
        Console.WriteLine("Combustible: ");
        auto.Combustible = (Console.ReadLine());
    }
    else if (vehiculo is Camioneta camioneta)
    {
        Console.WriteLine("Carga: ");
        camioneta.CapacidadCarga = int.Parse(Console.ReadLine());
        Console.WriteLine("4x4: ");
        camioneta.Es4x4 = bool.Parse(Console.ReadLine());
    }
    else if (vehiculo is Moto moto) 
    {
        Console.WriteLine("Cilindrada: ");
        moto.Cilindrada = int.Parse(Console.ReadLine());
        Console.WriteLine("Tipo: ");
        moto.Tipo = Console.ReadLine();
    }
    else if (vehiculo is Bicicleta bicicleta)
    {
        Console.WriteLine("Tipo: ");
        bicicleta.Tipo = Console.ReadLine();
        Console.WriteLine("Material del Cuadro: ");
        bicicleta.MaterialCuadro = Console.ReadLine();
    }
    else if (vehiculo is Camion camion)
    {
        Console.WriteLine("Numero de Eje: ");
        camion.NumeroEjes = int.Parse(Console.ReadLine());
        Console.WriteLine("Peso Maximo: ");
        camion.PesoMaximo = int.Parse(Console.ReadLine());
    }
    estacionamiento.AgregarVehiculo(vehiculo);
}