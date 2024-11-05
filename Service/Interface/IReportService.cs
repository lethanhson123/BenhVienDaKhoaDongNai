namespace Service.Interface
{
    public interface IReportService : IBaseService<Report>
    {
        Task<List<Report>> Report0001ToListAsync(long ID);
        Task<List<Report>> Report0002ToListAsync(long ID);
        Task<List<Report>> Report0003ToListAsync(long ID);
        Task<Report> Report0004ToAsync(long ThanhVienID);
    }
}

