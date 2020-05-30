using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySqlReadersApp.Domain.Entities
{
    public class Reader
    {
        [Required]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }

    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string EmailAddress { get; set; }
        public bool IsActive { get; set; }
    }
}