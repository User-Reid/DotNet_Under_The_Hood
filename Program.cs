using System.Collections;

int number = 5;
var person = new Person { Name = "Ted", Age = 19 };
object boxedNumber = number;

var numbers1 = new List<int> { 1, 2, 3, 4, 5 };
var numbers2 = new ArrayList {1,2,3,4,5};

var variousObjects = new List<object> {
  1,
  1.5m,
  new DateTime(2024, 6, 1),
  "hello",
  new Person {Name = "Anna", Age = 61}
};

foreach (var item in variousObjects)
{
  System.Console.WriteLine(item.GetType().Name);
  System.Console.WriteLine(item);
}

Console.ReadKey();

class Person
{
  public string Name { get; init; }
  public int Age { get; init; }
}