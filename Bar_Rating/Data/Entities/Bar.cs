using System.ComponentModel.DataAnnotations;

namespace Bar_Rating.Data.Entities
{
    public class Bar
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }

        public virtual List<Rating>? Ratings { get; set; }
    }
}
