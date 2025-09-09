// const string filePath = "file.txt";
// using var writer = new FileWriter(filePath);
// writer.Write("Some text");
// writer.Write("Some other text");
// writer.Dispose();

// using var reader = new SpecificLineFromTextFileReader(filePath);
// var third = reader.ReadLineNumber(3);
// var fourth = reader.ReadLineNumber(4);
// reader.Dispose();

// System.Console.WriteLine($"Third line is: {third}");
// System.Console.WriteLine($"Fourth line is: {fourth}");

// System.Console.WriteLine("Press any key to close.");
// Console.ReadKey();

// public class FileWriter : IDisposable
// {
//   private readonly StreamWriter _streamWriter;
//   public FileWriter(string filePath)
//   {
//     _streamWriter = new StreamWriter(filePath, true);
//   }
//   public void Write(string text)
//   {
//     _streamWriter.WriteLine(text);
//     _streamWriter.Flush();
//   }

//   public void Dispose()
//   {
//     _streamWriter.Dispose();
//   }
// }

// public class SpecificLineFromTextFileReader : IDisposable
// {
//   private readonly StreamReader _streamReader;
//   public SpecificLineFromTextFileReader(string filePath)
//   {
//     _streamReader = new StreamReader(filePath);
//   }

//   public string ReadLineNumber(int lineNumber)
//   {
//     _streamReader.DiscardBufferedData();
//     _streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

//     for (var i = 0; i < lineNumber - 1; i++)
//     {
//       _streamReader.ReadLine();
//     }

//     return _streamReader.ReadLine();
//   }

//   public void Dispose()
//   {
//     _streamReader.Dispose();
//   }
// }

Console.ReadKey();

public class AllLinesFromTextFileReader : IDisposable
{
  private readonly StreamReader _streamReader;

  public AllLinesFromTextFileReader(string filePath)
  {
    _streamReader = new StreamReader(filePath);
  }

  public List<string> ReadAllLines()
  {
    var result = new List<string>();
    while (!_streamReader.EndOfStream)
    {
      result.Add(_streamReader.ReadLine());
    }

    return result;
  }

  public void Dispose()
  {
    _streamReader.Dispose();
  }
}