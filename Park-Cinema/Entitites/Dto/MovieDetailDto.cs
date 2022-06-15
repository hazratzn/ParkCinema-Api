using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class MovieDetailDto
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Trailer { get; set; }
        public string Actor { get; set; }
        public string Duration { get; set; }
    }
}
