using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bar_Rating.Data.Entities
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Bar))]
        public int BarId { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public virtual Bar? Bar { get; set; }

        public virtual User? User { get; set; }

        public string Comment { get; set; } 
    }
}
