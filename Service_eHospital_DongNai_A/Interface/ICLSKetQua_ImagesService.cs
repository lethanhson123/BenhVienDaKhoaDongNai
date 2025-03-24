namespace Service_eHospital_DongNai_A.Interface
{
    public interface ICLSKetQua_ImagesService : IBaseService<CLSKetQua_Images>
    {
        Task<List<CLSKetQua_Images>> GetByListIDToListAsync(List<int?> ListID);
    }
}

