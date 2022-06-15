using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class SeatDto
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public bool Buyed { get; set; }
        public int RowId { get; set; }
    }
}
