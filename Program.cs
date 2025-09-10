const string filePath = @"C:\Users\aerma\Downloads\sampleData.csv";
var data = new CsvReader().Read(filePath);

Console.ReadKey();

public class CsvReader
{
  public CsvData Read(string filePath)
  {
    var streamReader = new StreamReader(filePath);

    const string Separator = ",";
    var columns = streamReader.ReadLine().Split(Separator);

    var rows = new List<string[]>();
    while (!streamReader.EndOfStream)
    {
      var cellData = streamReader.ReadLine().Split(Separator);
      rows.Add(cellData);
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