string userInput = Console.ReadLine();
if (userInput == "Print person")
{
  Person person = new Person() { Name = "Shivay", Age = 37 };
  System.Console.WriteLine($"{person.Name} is {person.Age} years old.");
}

GC.Collect();

Console.ReadKey();

public class Person
{
  public string Name { get; init; }
  public int Age { get; init; }
}