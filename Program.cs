const string filePath = "file.txt";
var writer = new FileWriter(filePath);
writer.Write("Some text");
writer.Write("Some other text");

var reader = new SpecificLineFromTextFileReader(filePath);
var third = reader.ReadLineNumber(3);
var fourth = reader.ReadLineNumber(4);

System.Console.WriteLine($"Third line is: {third}");
System.Console.WriteLine($"Fourth line is: {fourth}");

System.Console.WriteLine("Press any key to close.");
Console.ReadKey();

public class FileWriter
{
  private readonly StreamWriter _streamWriter;
  public FileWriter(string filePath)
  {
    _streamWriter = new StreamWriter(filePath, true);
  }
  public void Write(string text)
  {
    _streamWriter.WriteLine(text);
    _streamWriter.Flush();
  }
}

public class SpecificLineFromTextFileReader
{
  private readonly StreamReader _streamReader;
  public SpecificLineFromTextFileReader(string filePath)
  {
    _streamReader = new StreamReader(filePath);
  }

  public string ReadLineNumber(int lineNumber)
  {
    _streamReader.DiscardBufferedData();
    _streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

    for (var i = 0; i < lineNumber - 1; i++)
    {
      _streamReader.ReadLine();
    }

    return _streamReader.ReadLine();
  }
}