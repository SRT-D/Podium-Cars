using System;
using System.Collections.Generic;
using System.Text;

namespace Podiumcars;

public class VehiculoSegunda : Vehiculo
{
    public int Año { get; set; }
    public double Kilometraje { get; set; }

    public Modificacion Extras { get; set; }

    public VehiculoSegunda()
    {
        Extras = new Modificacion(); 
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine("Marca: " + Marca + " " + Modelo + "|" + " Año:" + Año + "|" + " KM:" + Kilometraje);
        Console.WriteLine("Mods Internas:" + (Extras.Internas ? "Sí" : "No"));
        Console.WriteLine("Mods Externas:" + (Extras.Externas ? "Sí" : "No"));
    }
}
