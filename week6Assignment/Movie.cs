public class Movie : Media
{
    public Movie(string id,string title, Array genres)
    {
        ID = id;
        Title =  title;
        Genres = genres;
        
    }
    
    public string ID { get; set; }
    public string Title { get; set; }
    public Array Genres { get; set; }
   
    public override string ToString()
    {
        return $"ID: {ID}\nTitle: {Title}\nGenres: {string.Join('|', Genres)}";
    }
}