using System.ComponentModel.DataAnnotations;
public class Execution
{
    [Key]
    public long Id { get; set; }
    public bool IsComplete { get; set; }
}