public class Video : Media
{
    public Video(string id, string title, string format,string length Array regions)
    {
        Id = id;
        Title = title;
        Format = format;
        Length = length;
        Regions = regions;


    }
  
    public string Id { get; set; }
    public string Title { get; set; }
    public string Format { get; set; }
    public string Length { get; set; }
    public Array Regions { get; set; }

      public override string ToString()
    {
        return $"Title: {Title},Format: {Format},Length: {Length,}, Regions: {string.Join('|', Regions)}";

    }
}