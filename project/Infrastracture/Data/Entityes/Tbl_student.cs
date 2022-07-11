using System.ComponentModel.DataAnnotations;

public class Tbl_student
{
    [Key]
 public int Id { get; set; } 
 public string Name { get; set; }
 public string Family { get; set; }
 
}