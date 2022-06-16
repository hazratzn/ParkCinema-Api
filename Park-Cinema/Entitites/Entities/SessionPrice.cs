using System.ComponentModel.DataAnnotations.Schema;
using Entity.Enums;

namespace Entity.Entities
{
    public class SessionPrice
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public Session SessionTime { get; set; }
        public SessionPriceType PriceType { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }
    }
}
