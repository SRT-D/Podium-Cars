using Podiumcars;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Podiumcars;

public class VehiculoImportacion : Vehiculo
{
    public DateTime FechaActual { get; set; }

    public override void MostrarDetalles()
    {
        Console.WriteLine("Importacion:" + Marca + " " + Modelo);
        Console.WriteLine("Fecha estimada de llegada: " +  FechaActual.ToShortDateString());
        
    }

}


    
