namespace Service_eHospital_DongNai_A.Interface
{
    public interface ICLSKetQua_DienCoService : IBaseService<CLSKetQua_DienCo>
    {
        Task<List<CLSKetQua_DienCo>> GetByListIDToListAsync(List<int?> ListID);
    }
}

