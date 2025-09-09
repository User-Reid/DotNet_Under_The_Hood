int number = 5;

AddOneToNumber(ref number);

System.Console.WriteLine(number);

MethodWithOutParamater(out int otherNumber);
System.Console.WriteLine($"Other number is {otherNumber}");

Console.ReadKey();

void MethodWithOutParamater(out int number)
{
  number = 10;
}

void AddOneToNumber(ref int number)
{
  ++number;
}
