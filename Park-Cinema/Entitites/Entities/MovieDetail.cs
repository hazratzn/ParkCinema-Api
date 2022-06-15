using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class MovieDetail:IEntity
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public string Trailer { get; set; }
        public string Actor { get; set; }
        public string VideoUrl { get; set; }
        public string Duration { get; set; }
        [ForeignKey("Movie")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
