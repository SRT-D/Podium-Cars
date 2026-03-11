using System;
using System.Collections.Generic;
using System.Text;

namespace Podiumcars;

public abstract class Vehiculo : IVehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public abstract void MostrarDetalles();
}

