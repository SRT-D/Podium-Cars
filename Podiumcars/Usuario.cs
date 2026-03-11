using System;
using System.Collections.Generic;
using System.Text;

namespace Podiumcars;

public class Usuario
{
    public string NombreCompleto { get; set; }
    public string Telefono { get; set; }
    public long Cedula { get; set; } 
    public VehiculoSegunda VehiculoVenta { get; set; }

    public Usuario(string nombre, string tel, long id, VehiculoSegunda auto)
    {
        NombreCompleto = nombre;
        Telefono = tel;
        Cedula = id;
        VehiculoVenta = auto;
    }
}

