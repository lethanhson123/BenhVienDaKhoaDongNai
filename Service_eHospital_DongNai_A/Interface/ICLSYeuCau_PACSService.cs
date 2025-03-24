namespace Service_eHospital_DongNai_A.Interface
{
    public interface ICLSYeuCau_PACSService : IBaseService<CLSYeuCau_PACS>
    {
        Task<List<CLSYeuCau_PACS>> GetByListIDToListAsync(List<int?> ListID);
    }
}

