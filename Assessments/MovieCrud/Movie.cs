using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessments.MovieCrud
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public double TicketCost { get; set; }
        public string ProducerName { get; set; }

        public override string ToString()
        {
            return $"Movie Id:{MovieId}, Movie Name:{MovieName}, Ticket Cost:{TicketCost}, Producer Name:{ProducerName}";
        }
    }
}
