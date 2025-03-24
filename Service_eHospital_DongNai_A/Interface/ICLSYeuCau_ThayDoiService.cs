namespace Service_eHospital_DongNai_A.Interface
{
    public interface ICLSYeuCau_ThayDoiService : IBaseService<CLSYeuCau_ThayDoi>
    {
        Task<List<CLSYeuCau_ThayDoi>> GetByListIDToListAsync(List<int?> ListID);
    }
}

