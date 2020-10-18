namespace XCaseManager.ReportService.Models
{
    public class DBSettings : IDBSettings
    {
        public string ProjectCollectionName { get; set; }
        public string TestcaseCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IDBSettings
    {
        string ProjectCollectionName { get; set; }
        string TestcaseCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}