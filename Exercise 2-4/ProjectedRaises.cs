using System;
using static System.Console;
using System.Globalization;
class ProjectedRaises
{
   static void Main()
   {
      double employee1 = 25000;
      double employee2 = 38000;
      double employee3 = 51000;
      const double percentRaise = 0.04;

      double mathStuff1 =((employee1*percentRaise)+employee1); 
      double mathStuff2 = ((employee2*percentRaise)+employee2);
      double mathStuff3 = ((employee3*percentRaise)+employee3);

      WriteLine(" Next year's salary for the first employee will be: {0}", mathStuff1.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine(" Next year's salary for the second employee will be: {0}", mathStuff2.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine(" Next year's salary for the third employee will be: {0}", mathStuff3.ToString("C", CultureInfo.GetCultureInfo("en-US")));





      




   }
}
