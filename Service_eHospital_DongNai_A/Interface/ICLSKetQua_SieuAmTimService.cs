namespace Service_eHospital_DongNai_A.Interface
{
    public interface ICLSKetQua_SieuAmTimService : IBaseService<CLSKetQua_SieuAmTim>
    {
        Task<List<CLSKetQua_SieuAmTim>> GetByListIDToListAsync(List<int?> ListID);
    }
}

