using Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Movie:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClaimerAge { get; set; }
        public string Image { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int MovieDetailId { get; set; }
        public MovieDetail MovieDetail { get; set; }
        //public ICollection<MovieFormat> MovieFormats { get; set; }
        //public ICollection<Session> Sessions { get; set; }

    }
}
