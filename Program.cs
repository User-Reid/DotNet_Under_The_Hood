int number = 5;
var john = new Person { Name = "John", Age = 34 };

AddOneToNumber(number);
AddOneToPersonsAge(john);

System.Console.WriteLine($"{number}, {john.Age}");


Console.ReadKey();

void AddOneToNumber(int number)
{
  ++number;
}

void AddOneToPersonsAge(Person person)
{
  ++person.Age;
}

public class Person
{
  public string Name { get; set; }
  public int Age { get; set; }
}