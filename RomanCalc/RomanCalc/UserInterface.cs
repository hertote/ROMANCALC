using System;
using System.Collections.Generic;
using System.Text;

namespace RomanCalc
{
    class UserInterface
    {

        public static void PrintMainMenu()
        {
            System.Console.WriteLine("Calculadora Román");
            System.Console.WriteLine("-----------------");
            System.Console.WriteLine("1) Sumar una serie de numeros.");
            System.Console.WriteLine("2) Restar una serie de numeros.");
            System.Console.WriteLine("3) Multiplicar una serie de numeros.");
            System.Console.WriteLine("4) Dividir una serie de numeros.");
            System.Console.WriteLine("5) Realizar ecuación de primer grado.");
            System.Console.WriteLine("6) Realizar ecuación de segundo grado.");
            System.Console.WriteLine("7) Realizar Raíz cuadrada.");
            System.Console.WriteLine("8) Realizar secuencia fibonacci.");
            System.Console.WriteLine("9) Realizar Sumario.");
            System.Console.WriteLine("0) Salir.");

        }

        public static void PrintSubtractionMenu()
        {

        }
        public static void PrintSubtractionSubmenu()
        {
            System.Console.WriteLine(" 0) Volver al menú princupal");
            System.Console.WriteLine(" 1) Seguir Restando");
            System.Console.WriteLine(" 2) Reiniciar la Resta");
        }
        public static void PrintAdditionMenu()
        {

        }


        public static void PrintAdditionSubmenu()
        {
            System.Console.WriteLine(" 0) Volver al menú princupal");
            System.Console.WriteLine(" 1) Seguir sumando");
            System.Console.WriteLine(" 2) Reiniciar la suma");
        }


        public static int ReadMenuOption()
        {
            string option = System.Console.ReadLine();
            try
            {
                int result = System.Int32.Parse(option);      // ===>   int result = int.Parse(option);
                return result;
            }
            catch (System.Exception e)
            {
                return -1;
            }
        }

        public static int ReadMenuOption(int MinOptionValue, int MaxOptionValue)
        {
            while (true)
            {
                int option = ReadMenuOption();
                if (option >= MinOptionValue && option <= MaxOptionValue)
                    return option;
                else
                    System.Console.WriteLine("Opcion no valida, introduce una opcion entre" + MinOptionValue + " y " + MaxOptionValue);

            }
        }

        
    }
}
