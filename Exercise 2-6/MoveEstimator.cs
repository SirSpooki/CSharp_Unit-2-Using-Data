using System;
using static System.Console;
using System.Globalization;
class MoveEstimator
{
   static void Main()
   {
     WriteLine("Enter Estimated Hours for Job: ");
     double estHours = Convert.ToDouble(ReadLine());

     WriteLine("Enter miles involved: ");
     double estMiles = Convert.ToDouble(ReadLine());

     double moveCost = (150 * estHours) + (2 * estMiles) + 200;

     WriteLine("For a move taking {0} hours and going {1} the estimate is {2}", estHours, estMiles, moveCost.ToString("C", CultureInfo.GetCultureInfo("en-US")));


   }
}
