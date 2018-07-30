using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core
{
    public class User
    {
        [Required]
        [Key]
        [MaxLength(20)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [EmailAddress]
        [MaxLength(80)]
        public string email { get; set; }
        
    }
}
