using static System.Console;
class InchesToCentimeters
{
   static void Main()
   {
     const double centimetersInInch = 2.54;
     int inches = 3;
     double centimeters = centimetersInInch * inches;

     WriteLine($"{inches} inches is {centimeters} centimeters");
   }
}
