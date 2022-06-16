namespace Entity.Entities
{
    public class BranchLanguage
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int BranchId { get; set; }
        public Language Language { get; set; }
        public Branch Branch { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
    }
}