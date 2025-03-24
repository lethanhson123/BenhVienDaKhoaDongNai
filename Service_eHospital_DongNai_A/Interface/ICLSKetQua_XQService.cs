namespace Service_eHospital_DongNai_A.Interface
{
    public interface ICLSKetQua_XQService : IBaseService<CLSKetQua_XQ>
    {
        Task<List<CLSKetQua_XQ>> GetByListIDToListAsync(List<int?> ListID);
    }
}

