using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace blog.Models;

[Table("User")]
public class User{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MinLength(4)]
    [MaxLength(80)]
    [Column("Name", TypeName ="NVARCHAR")]
    public string Name { get; set; }
    [Required]
    [MinLength(4)]
    [MaxLength(80)]
    [Column("Email", TypeName ="NVARCHAR")]
    public string Email { get; set; }


    public string PasswordHash { get; set; }
    public string Bio { get; set; }
    public string Image { get; set; }
    public string Slug { get; set; }
}
