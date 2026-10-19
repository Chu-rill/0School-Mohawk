using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Book : Media, IEncryptable
    {
        public string Author { get; protected set; }
        public string Summary { get; protected set; }

        /// <summary>
        /// Creating a Book.
        /// </summary>
        /// <param name="title">Title of the book</param>
        /// <param name="year">Year of publication</param>
        /// <param name="author">Author of the book</param>
        /// <param name="summary">ROT13 encrypted summary gotten from Data.txt</param>
        public Book(string title, int year, string author, string summary): base(title, year)
        {
            Author = author;
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
        /// Returns a formatted table row for List All Books
        /// name, Title, Year and the Author.
        /// </summary>
        public override string ToString()
        {
            return $"{"Book",-7}{Title,-60}{Year,-6}Author: {Author}";
        }
    }
}
