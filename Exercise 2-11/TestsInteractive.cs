using System;
using static System.Console;
class TestsInteractive
{
   static void Main()
   {
     WriteLine("Enter test score 1 ");
     double score1 = Convert.ToDouble(ReadLine());
     WriteLine("Enter test score 2 ");
     double score2 = Convert.ToDouble(ReadLine());
     WriteLine("Enter test score 3 ");
     double score3 = Convert.ToDouble(ReadLine());
     WriteLine("Enter test score 4 ");
     double score4 = Convert.ToDouble(ReadLine());
     WriteLine("Enter test score 5 ");
     double score5 = Convert.ToDouble(ReadLine());
     WriteLine("Enter test score 6 ");
     double score6 = Convert.ToDouble(ReadLine());
     WriteLine("Enter test score 7 ");
     double score7 = Convert.ToDouble(ReadLine());
     WriteLine("Enter test score 8 ");
     double score8 = Convert.ToDouble(ReadLine());

     double sum = (score1 +score2 +score3 +score4 +score5 +score6 +score7 +score8);
     double average = sum/(double)8;
     WriteLine("The average test score is: {0}", average.ToString("#0.00"));
   }
}
