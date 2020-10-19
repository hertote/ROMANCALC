using System;
//Este es el controlador principal
namespace RomanCalc
{
    class Program
    {
        public static void LaunchMainMenu()
        {
            while (true) //es un bucle continuo para que la app no cierre
            {
                
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadOption();
                if (option == 0);
                {
                    break;
                }
                if (option == -1)
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Opción no válida");
                }



            }
        }
        static void Main(string[] args)
        {
            LaunchMainMenu();



        }
    }
}
