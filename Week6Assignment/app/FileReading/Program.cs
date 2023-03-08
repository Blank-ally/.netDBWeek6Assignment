// See https://aka.ms/new-console-template for more information
 
  string input;

        var file = "movies.csv";
        var Lines = new List<string>();
        FileService fileService = new FileService();


        var check = new checker();

 do
        {
            Console.WriteLine("1) Read data from file.");
            Console.WriteLine("2) Create file from data.");
            Console.WriteLine("Enter any other key to exit.");
              // stored user  input 
            input = Console.ReadLine();


            if (input == "1")
            {
                fileService.Read();

            } else if (input == "2")
            {
 
 
            }
 } while (input == "1" || input == "2");