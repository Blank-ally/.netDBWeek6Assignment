using Microsoft.Extensions.Logging;

public class FileService : AbstractFileServices
{
   

 private string file = "Media.txt";


  
    private List<string> Lines = new List<string>();
    private List<Media> mediaList = new List<Media>();
    private Validate check = new Validate();


    public FileService()
    {
        string[] mediaFiles = { "movies.csv","shows.csv","video.csv" };

        for (var i = 0; i < mediaFiles.Length; i++)

        {
          
            
            if (File.Exists(mediaFiles[i]))
            {

                var sr = new StreamReader(mediaFiles[i]);
                try
                {
                    sr.ReadLine();


                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                     
                        Lines.Add(check.validateMovie(line));

                    }
                }

                catch (Exception ex)
                {
                }
                finally
                {
                    sr.Close();
                }

                var sw = new StreamWriter(file, true);
                foreach(string line in Lines)
                {
                    sw.WriteLine(line);
                }
                sw.Close();


            }
        }
    }


    public override void Read()

    {

       
        Console.WriteLine("*** I am reading");

        if (File.Exists(file))
        {

            var sr = new StreamReader(file);
            try
            {
                sr.ReadLine();


                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    Lines.Add(check.validateMovie(line));

                }
            }

            catch (Exception ex)
            {
            }
            finally
            {
                sr.Close();
            }


            for (var i = 0; i < Lines.Count; i++)
            {
                Console.WriteLine(Lines[i]);
              
            }


          

        }

    }



    public override void Write()
    {
      

        var sw = new StreamWriter(file, true);

        Console.WriteLine("What kind of Media would you like to make \n1.Movie\n2.Show\n3.Video");
        var mediaType = Console.ReadLine();

        switch (mediaType)
        {
            case "1":

                Console.WriteLine("Movie Id");
                var id = Console.ReadLine();



                Console.WriteLine("Title");
                var title = Console.ReadLine();

                Console.WriteLine("how many genres");
                var genre = Convert.ToInt32(Console.ReadLine());

                // a string array with the size of watchers variable i can add to in my loop 
                var genres = new string[genre];
                // for loop to store the names the user enters followed by a pipe so i don't have to edit the way the file reads 
                for (var i = 0; i < genre; i++)
                {
                    Console.WriteLine("what's the genre");
                    genres[i] = Console.ReadLine();
                }



                sw.WriteLine($"ID: {id}\nTitle: {title}\nGenres: {string.Join(',', genres)}");
                Lines.Add($"ID: {id}\nTitle: {title}\nGenres: {string.Join(',', genres)}");
                sw.Close();

                break;
            case "2":
                Console.WriteLine("Show Id");
                 id = Console.ReadLine();

                Console.WriteLine("Title");
                title = Console.ReadLine();

                Console.WriteLine("Season");
                var season = Console.ReadLine();

                Console.WriteLine("Episode");
                var episode = Console.ReadLine();

                Console.WriteLine("how many writers");
                 var writer = Convert.ToInt32(Console.ReadLine());

                // a string array with the size of watchers variable i can add to in my loop 
                var writers  = new string[writer];
                // for loop to store the names the user enters followed by a pipe so i don't have to edit the way the file reads 
                for (var i = 0; i < writer; i++)
                {
                    Console.WriteLine("who is the writer");
                    writers[i] = Console.ReadLine();
                }



                sw.WriteLine($"ID: {id}\nTitle: {title}\nSeason: {season}\nEpisode: {episode}\nWriters: {string.Join(',', writers)}");
                Lines.Add($"ID: {id}\nTitle: {title}\nSeason: {season}\nEpisode: {episode}\nWriters: {string.Join(',', writers)}");

                sw.Close();

                break;
            case "3":
                Console.WriteLine("Video Id");
                id = Console.ReadLine();

                Console.WriteLine("Title");
                title = Console.ReadLine();

                Console.WriteLine("Format");
                var format = Console.ReadLine();

                Console.WriteLine("Length");
                var length = Console.ReadLine();

                Console.WriteLine("how many regions");
                var region = Convert.ToInt32(Console.ReadLine());

            
                var regions = new string[region];
            
                for (var i = 0; i < region; i++)
                {
                    Console.WriteLine("what's the region");
                    regions[i] = Console.ReadLine();
                }



                sw.WriteLine($"ID: {id}\nTitle: {title}\nFormat: {format}\nLength: {length}\nRegions: {string.Join(',', regions)}");
                Lines.Add($"ID: {id}\nTitle: {title}\nFormat: {format}\nLength: {length}\nRegions: {string.Join(',', regions)}");

                sw.Close();
                break;
            default:
                Console.WriteLine("Sorry your input was not valid only 1-3 Is valid input");
                sw.Close();
                break;

        }

    }

}
    