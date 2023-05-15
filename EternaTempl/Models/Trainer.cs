namespace EternaTempl.Models
{
    public class Trainer:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string? TwitterUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? LinkedinUrl { get; set; }
        public string? FacebookUrl { get; set; }
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
