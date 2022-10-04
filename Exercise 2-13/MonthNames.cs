using System;
using static System.Console;
class MonthNames
{
  enum Month
  {
    JANUARY = 1, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, 
    AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
  }
   static void Main()
   {
     WriteLine("Enter month number: ");
     int chosMonth = Convert.ToInt32(ReadLine());

     WriteLine(Enum.GetName(typeof(Month), chosMonth));

   }
}
