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
    public class VIP:IEntity
    {
        public int Id { get; set; }
        public string CoverImage { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
