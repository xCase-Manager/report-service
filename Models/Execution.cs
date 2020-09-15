using System.ComponentModel.DataAnnotations;
public class Execution
{
    [Key]
    public long Id { get; set; }

    public string TestcaseId { get; set; }
    
    public string Status { get; set; }
}