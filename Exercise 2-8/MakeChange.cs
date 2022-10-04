using System;
using static System.Console;
class MakeChange
{
   static void Main()
   {
     int chicken1 = 30;
     int chicken2 = 30;
     int chicken3 = 60;
     int chicken4 = 7;

     int sumEggs = chicken1 + chicken2 + chicken3 + chicken4;
     int dozen = sumEggs/12;
     int remainderEggs = sumEggs%12;

     WriteLine($" {sumEggs} eggs is {dozen} dozen and {remainderEggs} eggs");
   }
}
