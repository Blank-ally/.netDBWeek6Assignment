public class Show : Media
{
  
     public Show(string id,string title,string season,string episode,Array writer)
    {
        ID = id;
        Title =  title;
        Season = season ;
        Episode = episode ;
        Writer = writer ;
        

    }
     
       public string ID { get; set; }
    public string Title { get; set; }
    public string Season { get; set; }
    public string Episode { get; set; }
    public Array Writer { get; set; }
  

  public override string ToString()
    {
        return $"Title: {Title}, Season: {Season}, Episode: {Episode}, {string.Join('|', Writers)}";
    }

    }