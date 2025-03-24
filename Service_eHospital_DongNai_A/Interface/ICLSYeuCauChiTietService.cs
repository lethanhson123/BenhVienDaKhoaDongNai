namespace Service_eHospital_DongNai_A.Interface
{
    public interface ICLSYeuCauChiTietService : IBaseService<CLSYeuCauChiTiet>
    {
        Task<List<CLSYeuCauChiTiet>> GetByListIDToListAsync(List<int?> ListID);
    }
}

