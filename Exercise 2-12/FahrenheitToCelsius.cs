using System;
using static System.Console;
class FahrenheitToCelsius
{
   static void Main()
   {
      WriteLine("Enter Temperature in Fahrenheit: ");
      double Fahrenheit = Convert.ToDouble(ReadLine());

      double math = (double)5.0/9.0;

      double toCelsius = (double)(Fahrenheit - 32) * math;

      WriteLine("{0} F is {1} C", Fahrenheit.ToString("F1"), toCelsius.ToString("F1"));


      

   }
}
