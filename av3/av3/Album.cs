using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace av3
{
    internal class Album
    {
        public string Name { get; set; }
        public int YearOfIssue { get; set; }
        public List<Song> Songs { get; set; }

        public Album(string name, int yearOfIssue)
        {
            Name = name;
            YearOfIssue = yearOfIssue;
            Songs = new List<Song>();
        }

        public void addSong(Song song)
        {
            foreach(Song s in Songs)
            {
                if (s.Name.Equals(song.Name))
                {
                    return;
                }
            }
            Songs.Add(song);
        }



        
        public Song findSong(Song song)
        {
            int indx = Songs.FindIndex(s => s.Equals(song));

            foreach(Song s in Songs)
            {
                if (s.Equals(song))
                {
                    return s;
                }
            }
            throw new SongNotFoundException();
        }

        public override bool Equals(object? obj)
        {
            return obj is Album album &&
                   Name == album.Name &&
                   YearOfIssue == album.YearOfIssue &&
                   EqualityComparer<List<Song>>.Default.Equals(Songs, album.Songs);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Album name: {Name} Issue Year: {YearOfIssue} Number of songs {Songs.Count} ");

            return sb.ToString();
        }
    }
}
