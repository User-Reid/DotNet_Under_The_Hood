// int number = 5;

// AddOneToNumber(ref number);

// System.Console.WriteLine(number);

// MethodWithOutParamater(out int otherNumber);
// System.Console.WriteLine($"Other number is {otherNumber}");

// Console.ReadKey();

// void MethodWithOutParamater(out int number)
// {
//   number = 10;
// }

// void AddOneToNumber(ref int number)
// {
//   ++number;
// }
DateTime taco = new DateTime(2024, 08, 14);
DateTime banana = new DateTime(2024, 08, 14);

RefModifierFastForwardToSummerExercise.FastForwardToSummer(ref taco);

System.Console.WriteLine(taco);

Console.ReadKey();

public static class RefModifierFastForwardToSummerExercise
{
  public static void FastForwardToSummer(ref DateTime x)
  {
    DateTime firstDayOfSummer = new DateTime(x.Year, 06, 21);
    if (x > firstDayOfSummer)
    {
      System.Console.WriteLine("Neat");
    }
    else if (x < firstDayOfSummer)
    {
      x = firstDayOfSummer;
    }
  }
}