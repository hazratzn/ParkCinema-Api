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
    public class Rules:IEntity
    {
        public int Id { get; set; }
        public string MainTitle { get; set; }
        public string MainDescription { get; set; }
        public string SubTitle { get; set; }
        public string SubDescription { get; set; }
        public string Image { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
