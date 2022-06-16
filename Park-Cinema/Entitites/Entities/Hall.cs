using Core.Entities;

namespace Entity.Entities
{
    public class Hall:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AcusticSystem { get; set; }
        public int SeatNumbers { get; set; }
        public string BarsChoose { get; set; }
        public string FilmProject { get; set; }
        public string  HallFormatD { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}
