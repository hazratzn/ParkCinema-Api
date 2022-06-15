using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Hall:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AcusticSystem { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public ICollection<BranchHall> BranchHalls { get; set; }
    }
}
