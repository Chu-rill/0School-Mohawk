using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Movie: Media, IEncryptable
    {
        public string Director { get; protected set; } 
        public string Summary { get; protected set; }

        /// <summary>
        /// Creating a Movie.
        /// </summary>
        /// <param name="title">Title of the movie</param>
        /// <param name="year">Year of release</param>
        /// <param name="director">Director of the movie</param>
        /// <param name="summary">ROT13 encrypted summary gotten from Data.txt</param>
        public Movie(string title, int year, string director, string summary) : base(title, year)
        {
            Director = director;
            Summary = summary;
        }

        /// <summary>
        /// Returns the encrypted summary. The summary is already stored
        /// encrypted, so no encyption is needed we just return the summary.
        /// it is never used.
        /// </summary>
        public string Encrypt()
        {
            return Summary;
        }

        /// <summary>
        /// Returns the decrypted summary.
        /// </summary>
        public string Decrypt()
        {
            return Rot13.Transform(Summary);
        }

        /// <summary>
        /// Returns a formatted table row for List All Movies
        /// name, Title, Year and the Director.
        /// </summary>
        public override string ToString()
        {
            return $"{"Movie",-7}{Title,-60}{Year,-6}Director: {Director}";
        }
    }
}
