using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aud_2
{
    class Album
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public List<Song> pesni { get; set; }
        
        public Album()
        {
            pesni = new List<Song>();
        }

        public Album(string name, int year, List<Song> pesni)
        {
            Name = name;
            Year = year;
            foreach (Song pesna in pesni)
            {
                this.pesni.Add(pesna);
            }
        }

        public void addSong(Song s)
        {
            pesni.Add(s);
        }

        public Song fingSong(string find)
        {
            foreach (Song s in pesni)
            {
                if (s.Name.Equals(find, StringComparison.OrdinalIgnoreCase))
                {
                    return s;
                }
                    
            }
            throw new SongNotFoundException("The song " + find + " is not found in the album!");
        }

        public void removeSong(String name)
        {
            for(int i = 0; i < pesni.Count; i++)
            {
                if (pesni[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    pesni.RemoveAt(i);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            // xD
            sb.Append("Name of album: " + Name + "\n");
            sb.Append("Year: "+ Year + "\n");
            sb.Append("Songs:\n");
            foreach(Song s in pesni)
            {
                sb.Append(s.ToString());
            }

            return sb.ToString();
        }
    }
}
