namespace Podiumcars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menu = "||------PODIUM CARS ------||" + "\n" + "1. Gestionar Usuario" + "\n" + "2. Gestionar Vehiculos de Segunda" + "\n" +
                  "3. Gestionar Vehiculos importacion" + "\n";

            bool continuar = true;


            do
            {
                Console.Write(menu);
                string entrada = Console.ReadLine();

                switch (entrada)
                {
                    case "1":
                        UIUsuarios.GestionarUsuario();
                        break;

                    case "2":
                        UIVehiculoSegunda.GestionarVehiculosSegunda();
                        break;

                    case "3":
                        UIVehiculoImportacion.GestionarVehiculosImportacion();
                        break;

                    case "4":
                        Console.WriteLine("Cerrando Podium Cars.");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opcion invalida.");
                        Console.ReadKey();
                        break;
                }

            }
            while (continuar);

        }
    }

}
    

