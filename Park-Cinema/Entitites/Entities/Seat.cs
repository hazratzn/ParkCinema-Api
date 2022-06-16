using Core.Entities;

namespace Entity.Entities
{
    public class Seat : IEntity
    {
        public int Id { get; set; }
        public bool IsBusy { get; set; }
        public bool IsVip { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public int SessionId { get; set; }
        public Session Session { get; set; }
    }
}