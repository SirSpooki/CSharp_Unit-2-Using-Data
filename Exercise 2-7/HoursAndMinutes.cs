using System;
using static System.Console;
class HoursAndMinutes
{
   static void Main()
   {
     int minutes = 197;

     int hours = minutes/60;
     int leftoverMinutes = minutes%60;

     WriteLine($"{minutes} minutes is {hours} hours and {leftoverMinutes} minutes.");
   }
}
