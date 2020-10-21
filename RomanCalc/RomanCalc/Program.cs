using System;
using System.Diagnostics;
//Este es el controlador principal
namespace RomanCalc
{
    class Program
    {

        public static void LaunchSubadditionMenu(int Accumuled)
        {
            while (true)
            {
                UserInterface.PrintAdditionMenu();
                int number = ControllersUtils.ReadIntegerInput("Dime el numero acumulado:");
                Accumuled += number;
                System.Console.WriteLine("El numero acumulado es " + Accumuled);
                UserInterface.PrintAdditionSubmenu();
            }



        }

        public static void SubtractionMenu()
        {
            while (true)
            { 
                UserInterface.PrintSubtractionMenu();
                int number1 = ControllersUtils.ReadIntegerInput("Dime el primero:");
                int number2 = ControllersUtils.ReadIntegerInput("Dmie el segundo:");
                int result = number1 - number2;
                System.Console.WriteLine("La resta es." + result);
                UserInterface.PrintSubtractionSubmenu();
                int option = UserInterface.ReadMenuOption(0, 2);
                switch (option)
                {
                    case 0:
                        System.Console.Clear();
                        return;
                    case 1:
                        LaunchSubadditionMenu(result);
                        break;
                    case 2:
                        System.Console.Clear();
                        break;
            
                    default:
                        break;

                }
            }   
        }

        //Addition finction controller
        //this function manages the addition menu loop, and their options
        public static void LaunchAdditionMenu()
        {
            while (true)
            {
                UserInterface.PrintAdditionMenu();
                int number1 = ControllersUtils.ReadIntegerInput("Dime el primero:");
                int number2 = ControllersUtils.ReadIntegerInput("Dime el segundo:");
                int result = number1 + number2;
                System.Console.WriteLine("La suma es: " + result);
                UserInterface.PrintAdditionSubmenu();
                int option = UserInterface.ReadMenuOption(0, 2);
                switch (option)
                {
                    case 0:
                        System.Console.Clear();
                        return;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                    default:
                        break;
                }
            }
        }

        public static void LaunchMainMenu()
        {
            while (true) //es un bucle continuo para que la app no cierre
            {
                
                UserInterface.PrintMainMenu();
                //ControllersUtils.ReadIntergerInput();
                int option = UserInterface.ReadMenuOption();
                System.Console.Clear();
                {
                    if (option == 0)
                        break;
                    else if (option == -1)
                        System.Console.WriteLine("Opción no válida");
                    else if (option > 9 || option < 0)
                        System.Console.WriteLine("Opción no válida, introduce un numero entre el 0 y el 9");
                    else if (option == 1)
                        LaunchAdditionMenu();

                    else if (option == 2)
                        SubtractionMenu();




                }

            }
        }
        static void Main(string[] args)
        {
            LaunchMainMenu();



        }
    }
}
