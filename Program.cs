int number = 5;

AddOneToNumber(ref number);

System.Console.WriteLine(number);

MethodWithOutParamater(out int otherNumber);
System.Console.WriteLine($"Other number is {otherNumber}");

var list = new List<int> { 1, 2, 3 };
AddOneToList(ref list);
System.Console.WriteLine(string.Join(", ", list));

Console.ReadKey();

void AddOneToList(ref List<int> numbers)
{
  numbers = null;
}

void MethodWithOutParamater(out int number)
{
  number = 10;
}

void AddOneToNumber(ref int number)
{
  ++number;
}
