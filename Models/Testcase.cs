using System.ComponentModel.DataAnnotations;
public class Testcase
{
    [Key]
    public string Id { get; set; }

    public string Name { get; set; }

    public string ProjectId { get; set; } 
}