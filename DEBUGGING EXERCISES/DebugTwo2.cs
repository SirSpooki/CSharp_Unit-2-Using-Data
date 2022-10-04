// This program greets the user
// and multiplies two entered values
using System;
using static System.Console;
class DebugTwo2
{
   static void Main()
   {
      string name;
      int first, second, product;
      WriteLine("Enter your name >> ");
      name = ReadLine();
      WriteLine("Hello, {0}! Enter an integer >> ", name);
      first = Convert.ToInt32(ReadLine());
      WriteLine("Enter another integer >> ");
      second = Convert.ToInt32(ReadLine());
      product = first * second;
      WriteLine("Thank you, {0}. The product of {1} and {2} is {3}",
	 name, first, second, product);
   }
}
