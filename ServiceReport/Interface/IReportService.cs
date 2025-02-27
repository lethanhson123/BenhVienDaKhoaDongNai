namespace ServiceReport.Interface
{
    public interface IReportService : IBaseService<Report>
    {
        Task<List<Report>> ReportDictionary0001ToListAsync();
        Task<List<Report>> ReportDictionary0002ToListAsync();
        Task<List<Report>> ReportDictionary0003ToListAsync(int Year);
    }
}

