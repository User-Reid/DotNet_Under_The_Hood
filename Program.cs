
Console.ReadKey();

public class CsvReader
{
  public string[] Columns { get; }
  public IEnumerable<string[]> Rows { get; }

  public CsvData CvsReader(string[] columns, IEnumerable<string[]> rows)
  {
    Columns = columns;
    Rows = rows;
  }
}