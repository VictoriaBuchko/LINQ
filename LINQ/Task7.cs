using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Magazine
    {
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public int PageCount { get; set; }
        public DateTime PublicationDate { get; set; }

        public Magazine(){}
        public Magazine(string title, string genre, int pageCount, DateTime publicationDate)
        {
            Title = title;
            Genre = genre;
            PageCount = pageCount;
            PublicationDate = publicationDate;
        }
    }
}
