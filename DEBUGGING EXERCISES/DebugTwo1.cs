// Program compares your name to the name of your boss
using System;
using static System.Console;
class DebugTwo1
{
   static void Main()
   {
      string name, bossName;
      bool areNamesTheSame;
      Write("Enter your name >> ");
      name = ReadLine();
      Write("Hello {0}! Enter the name of your boss >> ", name);
      bossName = ReadLine();
      areNamesTheSame = String.Equals(name, bossName);
      WriteLine("It is {0} that you are your own boss", areNamesTheSame);
   }
}
