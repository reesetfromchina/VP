namespace av3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Song s1 = new Song("Turks", 3, (decimal)3.8);
            Console.WriteLine(s1.ToString());


            Song s2 = new Song("Amazing", 3, (decimal)8.0);
            Song s3 = new Song("Vicodin", 2, (decimal)10.0);

            Album album = new Album("Bad Habits", 2018);


            album.addSong(s2);
            album.addSong(s3);


            Console.WriteLine(album);



        }
    }
}