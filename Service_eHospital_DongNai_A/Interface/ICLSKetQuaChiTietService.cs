namespace Service_eHospital_DongNai_A.Interface
{
    public interface ICLSKetQuaChiTietService : IBaseService<CLSKetQuaChiTiet>
    {
        Task<List<CLSKetQuaChiTiet>> GetByListIDToListAsync(List<int?> ListID);
    }
}

