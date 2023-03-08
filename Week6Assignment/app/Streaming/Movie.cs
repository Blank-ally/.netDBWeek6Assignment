public class Movie : Media
{
    public Movie(string id,string title,string year,string theater)
    {
        Id = id;
        Title =  title;
        Year =  year;
        theater = theater;
    }
     public Movie(string id,string title,string year)
    {
        Id = id;
        Title =  title;
        Year =  year;
       
    }

    public string Id { get; set; }
    public string Title { get; set; }
    public string Year { get; set; }
    public string Theater { get; set; }
 
   
    public override string ToString()
    {
        return $"Title: {Title}, Year: {Year}, Theater: {Theater}";
    }
}