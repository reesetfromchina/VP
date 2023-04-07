namespace Aud_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Song s = new Song();

            s.Name = "ive";

            Song s1 = new Song("Turks", 2.0, 2, "nav.com");
            Song s2 = new Song("Vicodin", 5.0, 3, "nav.com");
            Song s3 = new Song("Tap", 100.0, 4, "nav.com");
            Song s4 = new Song("Bad Habits", 5.01, 2, "nav.com");

            Album album = new Album();

            album.Name = "Bad Habits";
            album.Year = 2018;
            Console.WriteLine(album);
            album.addSong(s1);
            Console.WriteLine("------------------");
            Console.WriteLine(album);
            album.addSong(s2);
            album.addSong(s3);
            album.addSong(s4);

            Console.WriteLine(album);
            
            album.fingSong("Vicodin");
        }
    }
}