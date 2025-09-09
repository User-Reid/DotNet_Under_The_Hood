for (var i = 0; i < 5; i++)
{
  var person = new Person { Name = "Shivay", Age = 37 };
}

GC.Collect();
System.Console.WriteLine("Ready to close.");

Console.ReadKey();

class Person
{
  public string Name { get; init; }
  public int Age { get; init; }

  ~Person()
  {
    System.Console.WriteLine($"Person called {Name} is being destructed.🔫");
  }

  // protected override void Finalize()
  // {
  //   System.Console.WriteLine($"Person called {Name} is being destructed.🔫");
  // }
}
// going over the dispose method - introduction.