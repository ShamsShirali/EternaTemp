namespace EternaTempl.Models
{
    public class Feature:BaseEntity
    {
        public string Icon { get; set; }
        public string Description { get; set; }
        public int? RandmId { get; set; }

        public Randm? Randm { get; set; }
    }
}
