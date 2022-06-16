using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;
using Microsoft.AspNetCore.Http;

namespace Entity.Entities
{
    public class Branch : IEntity
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string WorkingHours { get; set; }
        public int HallCount { get; set; }
        public string AcusticSystem { get; set; }
        public string HallFormatType { get; set; }
        public string BarsChoose { get; set; }
        public string Projects { get; set; }
        [NotMapped] 
        public IFormFile ImageFile { get; set; }
        public string Image { get; set; }
        public IList<Photo> Photos { get; set; }
        public ICollection<Hall> Halls { get; set; }
        public ICollection<BranchLanguage> BranchLanguages { get; set; }
    }
}
