using System.ComponentModel.DataAnnotations;
public class Project
{
    [Key]
    public string Id { get; set; }

    public string Name { get; set; }
}