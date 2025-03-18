namespace Service_eHospital_DongNai_A.Interface
{
    public interface ICLSYeuCauService : IBaseService<CLSYeuCau>
    {
        Task<List<CLSYeuCau>> ReportACLSYeuCau0004ToListAsync(int NhomDichVu_Id, int PhongBan_Id, int Year, int Month, int Day);
    }
}

