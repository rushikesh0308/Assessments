using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.BookLibrary
{
    public class Book
    {
        public int BookId { get; set; }

        public string BookName { get; set; }

        public string BookAuthor { get; set; }

        public double BookPrice { get; set; }

        public override string ToString()
        {
            return $"BookId={BookId},BookName={BookName},BookPrice={BookPrice}";
        }
    }
}
