using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entity.Entities
{
    public class Session : IEntity
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int HallId { get; set; }
        public Hall Hall { get; set; }
        public ICollection<SessionPrice> SessionPrices { get; set; }
    }
}
