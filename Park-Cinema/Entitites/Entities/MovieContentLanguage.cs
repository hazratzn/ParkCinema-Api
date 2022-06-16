namespace Entity.Entities
{
    public class MovieContentLanguage
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public int MovieId { get; set; }
        public Language Language { get; set; }
        public Movie Movie { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public string Actor { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Languages { get; set; }
    }
}