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

// void AddOneToPersonsAge(Person person)
// {
//   ++person.Age;
// }

Person AddOneToPersonsAge(Person person) => new Person { Name = person.Name, Age = person.Age + 1 };

public class Person
{
  public string Name { get; init; }
  public int Age { get; init; }
}