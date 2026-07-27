using System.ComponentModel.DataAnnotations;

namespace BookShelf.Data.Models
{
    public class Author
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string? Country { get; set; }
        public virtual ICollection<Book> Books { get; set; } = null!;
    }
}
