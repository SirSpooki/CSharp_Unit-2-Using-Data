// This program tells the user the values of the integers that are
// one more and one less than the entered integer
using System;
using static System.Console;
class DebugTwo4
{
   static void Main()
   {
    
      int enteredInteger , entry, more, less;
      WriteLine("Enter an integer >> ");
      entry = Convert.ToInt32(ReadLine());
      WriteLine("You entered {0}", entry);
      enteredInteger = Convert.ToInt32(entry);
      more = enteredInteger+ 1;
      less = enteredInteger- 1;
      WriteLine("One more than {0} is {1} and one less than {2} is {3}",
	 enteredInteger, more,enteredInteger, less);
   }
}
