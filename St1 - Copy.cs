using System;

public class Example
{
   public static void Main()
   {
      decimal[] values = {12.6m, 12.1m, 9.5m, 8.16m, .1m, -.1m,  -1.1m,
                          -1.9m, -3.9m};
      Console.WriteLine("{0,-8} {1,10} {2,10}\n",
                        "Value", "Ceiling", "Floor");
      foreach (decimal value in values)
      Console.WriteLine("{0,-8} {1,10} {2,10}", value,
                        Decimal.Ceiling(value), Decimal.Floor(value));
   }
}