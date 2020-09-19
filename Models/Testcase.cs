using System.ComponentModel.DataAnnotations;
public class Testcase
{
    [Key]
    public string Id { get; set; }

    public string name { get; set; }

    public string projectId { get; set; } 
}