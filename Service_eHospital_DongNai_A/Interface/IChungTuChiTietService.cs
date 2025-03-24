namespace Service_eHospital_DongNai_A.Interface
{
    public interface IChungTuChiTietService : IBaseService<ChungTuChiTiet>
    {
        Task<List<ChungTuChiTiet>> GetByListIDToListAsync(List<int?> ListID);
    }
}

