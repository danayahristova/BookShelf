using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShelf.Data.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        public int Year { get; set; }
        [ForeignKey(nameof(AuthorId))]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; } = null!;
    }
}
