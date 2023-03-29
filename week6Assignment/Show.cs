public class Show : Media
{
  
     public Show(string id,string title,string year,string network)
    {
        Id = id;
        Title =  title;
        Year =  year;
        Network = network;

    }
     
       public string Id { get; set; }
    public string Title { get; set; }
    public string Year { get; set; }
      public string Network { get; set; }
  

  public override string ToString()
    {
        return $"Title: {Title}, Year: {Year}, Network: {Network}";
    }

    }