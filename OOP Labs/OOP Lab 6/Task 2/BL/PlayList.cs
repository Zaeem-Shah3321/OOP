using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6.BL
{
    internal class PlayList
    {
        private string Name;
        private List<Songs> songs = new List<Songs>();
        public PlayList(string name)
        {
            Name = name;
        }
        public void AddSong(Songs song)
        {
            songs.Add(song);
        }
        public void ShowPlaylist()
        {
            Console.WriteLine("Playlist: " + Name);
            foreach (Songs song in songs)
            {
                Console.WriteLine(song.getTitle());
            }
        }
    }
}
