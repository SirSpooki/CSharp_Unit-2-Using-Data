using System;
using static System.Console;
class MakeChange
{
   static void Main()
   {
     WriteLine("Enter Amount:");
     int money = Convert.ToInt32(ReadLine());

     int twenties = money/20;
     int tens = (money%20)/10;
     int fives =((money%20)%10)/5 ;
     int ones = ((money%20)%10)%5;

     WriteLine($"twenties: {twenties} tens: {tens} fives: {fives} ones: {ones}");
   }
}
