using System;
using static System.Console;
class Eggs
{
   static void Main()
   {
     WriteLine("Number of Eggs From Chicken 1: ");
     int chicken1 = Convert.ToInt32(ReadLine());
     WriteLine("Number of Eggs From Chicken 2: ");
     int chicken2 = Convert.ToInt32(ReadLine());
     WriteLine("Number of Eggs From Chicken 3: ");
     int chicken3 = Convert.ToInt32(ReadLine());
     WriteLine("Number of Eggs From Chicken 4: ");
     int chicken4 = Convert.ToInt32(ReadLine());

     int sumEggs = chicken1 + chicken2 + chicken3 + chicken4;
     int dozen = sumEggs/12;
     int remainderEggs = sumEggs%12;

     WriteLine($"{sumEggs} eggs is {dozen} dozen and {remainderEggs} eggs.");
   }
}
