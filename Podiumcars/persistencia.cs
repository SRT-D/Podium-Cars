using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Podiumcars;

public static class Persistencia
{
    //Parte hecha con IA, la t implica no invocar varias veces las clases para guardar.
    private static string pathUsuarios = "usuarios.csv";
    private static string pathSegunda = "vehiculos_segunda.csv";
    private static string pathImportados = "vehiculos_importados.csv";

    
    public static void GuardarTodo()
    {
        Guardar(UIUsuarios.listaUsuarios, pathUsuarios);
        Guardar(UIVehiculoSegunda.inventarioSegunda, pathSegunda);
        Guardar(UIVehiculoImportacion.listaImportados, pathImportados);
    }

    private static void Guardar<T>(List<T> lista, string path)
    {
        using (var writer = new StreamWriter(path))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(lista);
        }
    }

  
    public static void CargarTodo()
    {
        UIUsuarios.listaUsuarios = Cargar<Usuario>(pathUsuarios);
        UIVehiculoSegunda.inventarioSegunda = Cargar<VehiculoSegunda>(pathSegunda);
        UIVehiculoImportacion.listaImportados = Cargar<VehiculoImportacion>(pathImportados);
    }

    private static List<T> Cargar<T>(string path)
    {
        if (!File.Exists(path)) return new List<T>();

        using (var reader = new StreamReader(path))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            return csv.GetRecords<T>().ToList();
        }
    }
}

