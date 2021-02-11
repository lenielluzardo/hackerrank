using System;

namespace Exercises
{
  public class DayOne_DataTypes
  {
    public static void Exe()
    {
      int i = 4;
      double d = 4.0;
      string s = "HackerRank ";

      // Declare second integer, double, and String variables.
      int ii;
      double dd;
      string ss;

      //Read and save an integer, double, and String to your variables."
      
      Console.WriteLine("Write a Integer Number");
      ii = int.Parse(Console.ReadLine());

      Console.WriteLine("Write a Floating Point Number");
      var doubleString = Console.ReadLine();
      dd = double.Parse(doubleString, System.Globalization.CultureInfo.InvariantCulture);

      Console.WriteLine("Write Some Text");
      ss = Console.ReadLine();
      
      // Print the sum of both integer variables on a new line.
      Console.WriteLine(i + ii);
      
      // Print the sum of the double variables on a new line.
      Console.WriteLine("{0:N}", d + dd);
      
      // Concatenate and print the String variables on a new line
      // The 's' variable above should be printed first.
      Console.WriteLine("{0}",s+ss);
    }
  }
}
