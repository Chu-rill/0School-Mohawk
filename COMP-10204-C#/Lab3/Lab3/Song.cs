using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Song: Media
    {
        public string Album { get; protected set; }  
        public string Artist { get; protected set; } 

        /// <summary>
        /// Creating a Song.
        /// </summary>
        /// <param name="title">Title of the song</param>
        /// <param name="year">Year of release</param>
        /// <param name="album">Album name</param>
        /// <param name="artist">Performing artist</param>
        /// <param name="genre">Music genre</param>
        public Song(string title, int year, string album, string artist) : base(title, year)
        {
            Album = album;
            Artist = artist;
        }

        /// <summary>
        /// Returns a formatted table row for List All Songs
        /// name, Title, Year, Artist and the Album.
        /// </summary>
        public override string ToString()
        {
            return $"{"Song",-7}{Title,-60}{Year,-6}Artist: {Artist}, Album: {Album}";
        }
    }
}
