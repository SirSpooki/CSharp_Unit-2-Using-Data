// This program computes net weekly pay
// based on hours worked, rate per hour,
// and 15% withholding
using System;
using static System.Console;
using System.Globalization;
class DebugTwo3
{
   static void Main()
   {
      const double WITHHOLDING_RATE = .15;
  
      double hours, rate, gross, withholding, net;
      WriteLine("Enter the number of hours you worked this week >> ");
      hours = Convert.ToDouble(ReadLine());
      WriteLine("Enter your hourly rate >> ");
      rate = Convert.ToDouble(ReadLine());
      gross = hours * rate;
      withholding = gross * WITHHOLDING_RATE;
      net = gross - withholding;
      WriteLine("You worked {0} hours at {1} per hour",
	 hours, rate.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Gross pay is {0}", gross.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Withholding is {0}", withholding.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Net pay is {0}", net.ToString("C", CultureInfo.GetCultureInfo("en-US"))); 
   }
}
