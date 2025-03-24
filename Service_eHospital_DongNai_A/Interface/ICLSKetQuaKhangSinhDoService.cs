namespace Service_eHospital_DongNai_A.Interface
{
    public interface ICLSKetQuaKhangSinhDoService : IBaseService<CLSKetQuaKhangSinhDo>
    {
        Task<List<CLSKetQuaKhangSinhDo>> GetByListIDToListAsync(List<int?> ListID);
    }
}

