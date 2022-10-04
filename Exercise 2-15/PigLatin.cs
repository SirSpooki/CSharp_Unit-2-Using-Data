using static System.Console;
class PigLatin
{
   static void Main()
   {
      WriteLine("Enter A Word");
      string userWord = ReadLine();

      string firstLetter = userWord.Substring(0,1);
      userWord = userWord.Substring(1);

      string latin = userWord+firstLetter +"ay";
      WriteLine(latin);


   }
}
