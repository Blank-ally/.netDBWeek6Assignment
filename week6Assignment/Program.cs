class Program
{
    static void Main(string[] args)
    {
        string input;

        FileService fileService = new FileService();


      

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

            }
            else if (input == "2")
            {
                fileService.Write();

            }
        } while (input == "1" || input == "2");

    }
}