namespace sdc1_knowledge_check_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Vinyl>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var vinyl = new Vinyl();

                Console.WriteLine("Enter the name of the album: ");
                vinyl.AlbumTitle = Console.ReadLine();

                Console.WriteLine("Enter the name of the artist: ");
                vinyl.Artist = Console.ReadLine();

                Console.WriteLine("Enter the number of records in the album: ");
                vinyl.NumberOfVinyl = Console.ReadLine();



                recordList.Add(vinyl);
            }

            // Print out the list of records using Console.WriteLine()
            foreach (Vinyl vinyl in recordList)
                Console.WriteLine($"The album:{vinyl.AlbumTitle} made by; {vinyl.Artist} has {vinyl.NumberOfVinyl} records");


        }
    }
}