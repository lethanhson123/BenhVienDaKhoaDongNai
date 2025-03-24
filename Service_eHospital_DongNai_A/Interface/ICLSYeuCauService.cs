namespace Service_eHospital_DongNai_A.Interface
{
    public interface ICLSYeuCauService : IBaseService<CLSYeuCau>
    {
        Task<List<CLSYeuCau>> ReportACLSYeuCau0004ToListAsync(string ListCLSYeuCau_Id, int Year, int Month, int Day);
        Task<List<CLSYeuCau>> GetByBenhNhan_Id_Year_Month_DayToListAsync(int BenhNhan_Id, int Year, int Month, int Day);
    }
}

