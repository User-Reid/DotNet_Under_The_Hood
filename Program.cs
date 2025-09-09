const string path = @"C:\Users\aerma\Downloads\sampleData.csv";
var data = new CsvReader().Read(path);



Console.ReadKey();

public class CsvReader
{
  public CsvData Read(string path)
  {
    using var streamReader = new StreamReader(path);

    const string Seperator = ",";
    var columns = streamReader.ReadLine().Split(Seperator);

    var rows = new List<string[]>();

    while (!streamReader.EndOfStream)
    {
      var cellsInRow = streamReader.ReadLine().Split(Seperator);
      rows.Add(cellsInRow);
    }

    return new CsvData(columns, rows);
  }
}

public class CsvData
{
  public string[] Columns { get; }
  public IEnumerable<string[]> Rows { get; }
  public CsvData(string[] columns, IEnumerable<string[]> rows)
  {
    Columns = columns;
    Rows = rows;
  }
}