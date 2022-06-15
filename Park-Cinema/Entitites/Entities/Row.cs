using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Row:IEntity
    {
        public int Id { get; set; }
        public int NumberRow { get; set; }
        public int HallId { get; set; }
        public Hall Hall { get; set; }
    }
}
