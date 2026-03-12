using Podiumcars;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Podiumcarsñ

    public class VehiculoImportacion : Vehiculo
{
    public DateTime FechaLlegada { get; set; }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"[Importación] {Marca} {Modelo}");
        Console.WriteLine($" > Fecha estimada de llegada: {FechaLlegada.ToShortDateString()}");
    }
}

