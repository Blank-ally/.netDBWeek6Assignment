public class Video : Media
{
    public Video(string id, string title, string year, string format)
    {
        Id = id;
        Title = title;
        Year = year;
        Format = format;

    }
  
    public string Id { get; set; }
    public string Title { get; set; }
    public string Year { get; set; }
    public string Format { get; set; }

      public override string ToString()
    {
        return $"Title: {Title}, Year: {Year}, Format: {Format}";
    }
}