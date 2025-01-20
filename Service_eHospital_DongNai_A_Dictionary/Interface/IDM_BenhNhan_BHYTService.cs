namespace Service_eHospital_DongNai_A_Dictionary.Interface
{
    public interface IDM_BenhNhan_BHYTService : IBaseService<DM_BenhNhan_BHYT>
    {
        Task<List<DM_BenhNhan_BHYT>> GetByBenhNhan_IdToListAsync(int BenhNhan_Id);
        Task<List<DM_BenhNhan_BHYT>> GetByBenhNhan_IdAndEmptyToListAsync(int BenhNhan_Id);
    }
}

