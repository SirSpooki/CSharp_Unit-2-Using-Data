using System;
using static System.Console;
using System.Globalization;
class GreenvilleRevenue
{
   static void Main()
   {
     const double ENTRANCE_FEE = 25; 
     int lastYearC, currentYearC;
     double revenue;
     
     WriteLine("Enter number of contestants last year");
     lastYearC = Convert.ToInt32(ReadLine());
     WriteLine("Enter number of contestants this year");
     currentYearC = Convert.ToInt32(ReadLine());

     bool moreLess = currentYearC > lastYearC;
     revenue = (double)currentYearC*ENTRANCE_FEE;

     WriteLine($"Last year's competition had {lastYearC} contestants, and this year's has {currentYearC} contestants");
     WriteLine("Revenue expected this year is ${0}",revenue.ToString("C", CultureInfo.GetCultureInfo("en-US")));
     WriteLine($"It is {moreLess} that this year's competition is bigger than last year's.");

   }
}
