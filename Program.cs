bool flag = true;
Person person = new Person();
if (flag)
{
  string textInsideIf = "aaa";
  person.Name = "Tom";
}

string text = "bbb";

Console.ReadKey();

public class Person
{
  public string Name { get; init; }
  public int Age { get; init; }
}