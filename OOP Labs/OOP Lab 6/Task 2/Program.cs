using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab6.BL;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs song1 = new Songs("Song1");
            Songs song2 = new Songs("Song2");
            Songs song3 = new Songs("Song3");
            Songs song4 = new Songs("Song4");
            PlayList playlist = new PlayList("Anime Ops");
            playlist.AddSong(song1);
            playlist.AddSong(song2);
    	    playlist.AddSong(song3);
	    playlist.AddSong(song4);
            playlist.ShowPlaylist();
            Console.ReadKey();
        }
    }
}
