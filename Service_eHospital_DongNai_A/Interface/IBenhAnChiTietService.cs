namespace Service_eHospital_DongNai_A.Interface
{
    public interface IBenhAnChiTietService : IBaseService<BenhAnChiTiet>
    {
        Task<List<BenhAnChiTiet>> GetByListIDToListAsync(List<int?> ListID);
    }
}

