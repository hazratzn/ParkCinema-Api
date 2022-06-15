using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class MovieDetail:IEntity
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public DateTime Year { get; set; }
        public string Genre { get; set; }
        public string Trailer { get; set; }
        public string Actor { get; set; }
        public DateTime Duration { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
