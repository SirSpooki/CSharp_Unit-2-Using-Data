using System;
using static System.Console;
using System.Globalization;
class ProjectedRaisesInteractive
{
   static void Main()
   {
      WriteLine("Enter Salary For Employee 1: ");
      double salary1 = Convert.ToDouble(ReadLine());

      WriteLine("Enter Salary For Employee 2: ");
      double salary2 = Convert.ToDouble(ReadLine());

      WriteLine("Enter Salary For Employee 3: ");
      double salary3 = Convert.ToDouble(ReadLine());

      const double RAISE = 0.04;
    
      WriteLine("Next year's salary for the first employee will be {0}", (salary1 + salary1 * RAISE).ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Next year's salary for the second employee will be {0}", (salary2 + salary2 * RAISE).ToString("C", CultureInfo.GetCultureInfo("en-US")));  
      WriteLine("Next year's salary for the third employee will be {0}", (salary3 + salary3 * RAISE).ToString("C", CultureInfo.GetCultureInfo("en-US")));     
   }
}
