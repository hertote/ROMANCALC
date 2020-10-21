using System;
using System.Collections.Generic;
using System.Text;

namespace RomanCalc
{
    class ControllersUtils
    {
        public static int ReadIntegerInput(String Message)
        {
            while (true)
            {
               
                try
                {
                    System.Console.WriteLine(Message);
                    string number = System.Console.ReadLine();
                    int convertedInteger = System.Convert.ToInt32(number);
                    return convertedInteger;
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine("La entrada es incorrecta");
                }






            }





        }
    }
}
