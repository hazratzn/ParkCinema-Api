using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Branch:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public string WorkingHours { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
