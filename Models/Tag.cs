using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace blog.Models;

[Table("Tag")]
public class Tag{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
}
