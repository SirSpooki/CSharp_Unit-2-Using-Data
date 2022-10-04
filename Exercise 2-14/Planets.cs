using System;
using static System.Console;
class Planets
{
  enum Planet
  {
    MERCURY=1, VENUS, EARTH, MARS, JUPITER, SATURN, URANUS, NEPTUNE
  }
   static void Main()
   {
      WriteLine("Numeric Position of Planet:");
      int name = Convert.ToInt32(ReadLine());
  

      WriteLine("{0} is {1} planet(s) from the sun", Enum.GetName(typeof(Planet), name), name);
   }
}
