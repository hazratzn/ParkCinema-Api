using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Footer:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
