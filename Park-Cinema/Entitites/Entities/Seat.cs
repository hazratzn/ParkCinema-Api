using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class Seat:IEntity
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public bool isBusy { get; set; }
        public int RowId { get; set; }
        public Row Row { get; set; }
    }
}
