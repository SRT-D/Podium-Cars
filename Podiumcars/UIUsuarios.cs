using System;
using System.Collections.Generic;
using System.Text;

namespace Podiumcars;

public static class UIUsuarios
{
    public static List<Usuario> listaUsuarios = new List<Usuario>();

    public static void GestionarUsuario()
    {
        bool continuar = true;
        do
        {
            Console.WriteLine("\n---GESTION DE USUARIOS---" + "\n" + "1. Registrar Usuario" + "\n" + "2. Listar Usuarios" + "\n" + 
                "3. Salir" + "\n");
          
    
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Registrar();
            }
            else if (opcion == "2")
            {
                Listar();
            }
            
            else if (opcion == "3")
            {
                continuar = false; 
            }
            else
            {
                Console.WriteLine("Opcion invalida.");
            }

        } while (continuar);
    }

    private static void Registrar()
    {
        Console.Write("Nombre Completo: ");
        string nombre = Console.ReadLine();

        Console.Write("Telefono: ");
        string telefono = Console.ReadLine();

        Console.Write("Cedula: ");
        long cedula = long.Parse(Console.ReadLine());

        Console.WriteLine("--Datos del Vehiculo del usuario--");
        VehiculoSegunda vehiculo = new VehiculoSegunda();
        Console.Write("Marca del auto: ");
        vehiculo.Marca = Console.ReadLine();
        Console.Write("Modelo del auto: ");
        vehiculo.Modelo = Console.ReadLine();

        Usuario nuevo = new Usuario(nombre, telefono, cedula, vehiculo);
        listaUsuarios.Add(nuevo);
    }

    private static void Listar()
    {
        if (listaUsuarios.Count == 0)
        {
            Console.WriteLine("\nNo hay usuarios registrados ");
        }
        else
        {
            Console.WriteLine("---LISTA DE USUARIOS---");
            int contador = 1;

            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                Usuario usuarios = listaUsuarios[i];

                Console.WriteLine(contador + " Usuario:" + usuarios.NombreCompleto + " | " +
                    "Vende:" + usuarios.VehiculoVenta.Marca +" " + usuarios.VehiculoVenta.Modelo);
                contador++;
            }
        }


    }




}

