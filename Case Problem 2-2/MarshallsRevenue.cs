using System;
using static System.Console;
using System.Globalization;
class MarshallsRevenue
{
   static void Main()
   {
     const double INTERIOR_MURAL = 500;
     const double EXTERIOR_MURAL = 750;

     int intMuralSched, extMuralSched;
     double revenue, totalInt, totalExt;
     
     WriteLine("Enter number of interior murals scheduled");
     intMuralSched = Convert.ToInt32(ReadLine());
     WriteLine("Enter number of exteriot murals scheduled");
     extMuralSched = Convert.ToInt32(ReadLine());

     totalInt = intMuralSched*INTERIOR_MURAL;
     totalExt = extMuralSched*EXTERIOR_MURAL;
     revenue = totalExt+totalInt;
     bool intVsExt = intMuralSched>extMuralSched;

     WriteLine("{0} interior murals are scheduled at {1} each for a total of {2}",intMuralSched, INTERIOR_MURAL.ToString("C", CultureInfo.GetCultureInfo("en-US")), totalInt.ToString("C", CultureInfo.GetCultureInfo("en-US")));
     WriteLine("{0} exterior murals are scheduled at {1} each for a total of {2}",extMuralSched, EXTERIOR_MURAL.ToString("C", CultureInfo.GetCultureInfo("en-US")), totalExt.ToString("C", CultureInfo.GetCultureInfo("en-US")));
     WriteLine("Total revenue expected is {0}", revenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
     WriteLine($"It is {intVsExt} that there are more interior murals scheduled than exterior ones.");



   }
}
