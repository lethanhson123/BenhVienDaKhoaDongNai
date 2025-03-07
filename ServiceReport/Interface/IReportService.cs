namespace ServiceReport.Interface
{
    public interface IReportService : IBaseService<Report>
    {
        Task<List<Report>> ReportDictionary0001ToListAsync();
        Task<List<Report>> ReportDictionary0002ToListAsync();
        Task<List<Report>> ReportDictionary0003ToListAsync(int Year);

        Task<List<Report>> ReportA0001ToListAsync(int Year, int Month, int Day, int PhongBanID);
        Task<List<Report>> ReportNSTLA0001ToListAsync();
        Task<List<Report>> ReportNSTLA0002ToListAsync();
    }
}

